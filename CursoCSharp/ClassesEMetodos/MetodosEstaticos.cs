﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de classe
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 5);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();

            Console.WriteLine(calc.Somar(2, 5));
            // Vai dar erro porque Multiplicar é um método de claase
            //Console.WriteLine(calc.Multiplicar(2, 9)); 
        }
    }
}
