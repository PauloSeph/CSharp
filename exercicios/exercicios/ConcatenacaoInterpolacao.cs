using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios {
    class ConcatenacaoInterpolacao {
        static void Main(string[] args) {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            // PlaceHolder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concat
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}



