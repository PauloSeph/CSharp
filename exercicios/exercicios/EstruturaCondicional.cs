using System;

namespace Course {
    class EstruturaCondicional {
        static void Main(string[] args) {
            Console.WriteLine("Entre com um n�mero inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) { 
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Impar");
            }

            // Ex2
            Console.WriteLine("Qual a hora atual?"); 
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) { 
                Console.WriteLine("Bom dia!"); 
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            } 
            else {
                Console.WriteLine("Boa noite!");
            }


        }

    }
}
