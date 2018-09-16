using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_calcul
{
    class Program
    {
        private static int x;
        private static int y;
        private static bool onContinue = true;
        private static string reponse;

        public static int op { get; private set; }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Operande gauche ?");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Operande droite ?");
                y = int.Parse(Console.ReadLine());
                Opérations calcul = new Opérations(x, y);
                Console.WriteLine("Voulez-vous continuer ?");
                reponse = Console.ReadLine();
                if (reponse != "o" && reponse != "O")
                        onContinue = false;
                
            }
            while (onContinue);



        }
    }
}
