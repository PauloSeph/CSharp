using System;

namespace exercicios {
    class OpComparativo {
        static void Main(string[] args) {
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("--------------");
            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;
            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }

    }
}
}