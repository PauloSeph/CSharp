using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios {
    class Conversao {
        static void Main(string[] args) {
            double a; float b;
            a = 5.1; b = (float)a;
            Console.WriteLine(b);

            double c; int d;
            a = 5.1; d = (int)a;
            Console.WriteLine(d);

            int e = 5; int f = 2;
            double resultado = (double)e / f;
            Console.WriteLine(resultado);

        }
        }
    }
