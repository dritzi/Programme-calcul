using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_calcul
{
    class Opérations
    {
        

        int operandeGauche { get; set; }
        int operandeDroite { get; set; }
        int operateur { get; set; }

        public Opérations(int x,int y)
        {
            this.operandeGauche = x;
            this.operandeDroite = y;
            this.operateur = Choix();
            
            Console.WriteLine(Convert.ToString(operateur));

            int resultat=Calcul(operandeGauche, operandeDroite, operateur);
            Console.WriteLine(resultat + "\n");
            
        }

        

        private int Choix()
        {
           ConsoleKeyInfo info = Console.ReadKey(true);         
            do
            {
            Console.WriteLine("Quelle opération voulez-vous réaliser ?");
            Console.WriteLine("1- Addition");
            Console.WriteLine("2- Soustraction");
            Console.WriteLine("3- Multiplication");
            Console.WriteLine("4- Division");
            info = Console.ReadKey(true);
            }
            while (info.Key != ConsoleKey.D1 && info.Key != ConsoleKey.D2 && info.Key != ConsoleKey.D3 && info.Key != ConsoleKey.D4);
            return info.KeyChar;
        }

        private int Calcul(int x,int y,int op)
        {
            switch (op-48)
            {
                case 0:
                    return 0;
                    
                case 1:
                    return x + y;               
                case 2:
                    return x - y;
                case 3:
                    return x * y;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Opération impossible");
                        return 0;
                    }
                    return x / y;
                
                default:
                    return 0;
                    
   
            }
        }

    }
}
