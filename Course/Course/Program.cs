using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string n7 = "Maria Zin";
            object n8 = "Alfred";
            object n9 = 20;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);

            // Funcoes MIn e Max
            int no1 = int.MinValue;
            int no2 = int.MaxValue;
            sbyte no3 = sbyte.MinValue;
            decimal no4 = decimal.MaxValue;
            Console.WriteLine(no1);
            Console.WriteLine(no2);
            Console.WriteLine(no3);
            Console.WriteLine(no4);

            // Write e WriteLine
            Console.Write("Bom dia!");
            Console.WriteLine("Boa noite");

            // Outros
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(idade); 
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); 
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", 
                              nome, idade, saldo);
            Console.WriteLine
            ($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine
            (nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString
            ("F2", CultureInfo.InvariantCulture) + " reais");

            int a = 5;
            int b = 2;
            double resultado = (double)a / b;

              Console.WriteLine(resultado);



            string frase = Console.ReadLine();
            Console.WriteLine(frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string ase = vet[0];
            string ase2 = vet[1];
            string ase3 = vet[2];
            Console.WriteLine("Voce digitou: ");
         

            Console.WriteLine($"{ase} e {ase2} e {ase3} ");


            // 
            int no10 = int.Parse(Console.ReadLine());
            Console.WriteLine(no10);

            double n20 = double.Parse(Console.ReadLine(),
                            CultureInfo.InvariantCulture);
            Console.WriteLine(n20.ToString("F2", 
                            CultureInfo.InvariantCulture));



        }
    }
}
