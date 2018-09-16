using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_calcul
{
    class Opérations
    {
        

        double operandeGauche { get; set; }
        double operandeDroite { get; set; }
        int operateur { get; set; }

        public Opérations(double x,double y)
        {
            this.operandeGauche = x;
            this.operandeDroite = y;
            this.operateur = Choix();
            
            // Console.WriteLine(Convert.ToString(operateur));

            double resultat=Calcul(operandeGauche, operandeDroite, operateur);
            Console.WriteLine(resultat + "\n");
            
        }

        

        private int Choix()
        {
           ConsoleKeyInfo info = Console.ReadKey(false);         
            do
            {
            Console.WriteLine("Quelle opération voulez-vous réaliser ?");
            Console.WriteLine("1- Addition");
            Console.WriteLine("2- Soustraction");
            Console.WriteLine("3- Multiplication");
            Console.WriteLine("4- Division");
            info = Console.ReadKey(false);
            }
            while (info.Key != ConsoleKey.D1 && info.Key != ConsoleKey.D2 && info.Key != ConsoleKey.D3 && info.Key != ConsoleKey.D4);
            return info.KeyChar;
        }

        private double Calcul(double x,double y,int op)
        {
            switch (op-48)
            {
                    
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
