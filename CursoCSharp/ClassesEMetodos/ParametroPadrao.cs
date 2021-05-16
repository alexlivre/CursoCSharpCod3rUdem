﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 2)
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10, 20));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
