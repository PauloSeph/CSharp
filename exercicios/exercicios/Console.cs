﻿using System;
using System.Globalization;

namespace exercicios {
    class Console {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); 
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
