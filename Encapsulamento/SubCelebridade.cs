﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDoOlho = "Verde";

        // Mesmo projeto (assmbly)
        internal ulong NumeroCelular = 5511999999;

        // Herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma class ou herança no mesmo projeto (c# > 7.2)
        private protected string SegredoFamilia = "Bla bla";

        // Private é o padrão
        private bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine("public: " + InfoPublica);
            Console.WriteLine("protected: " + CorDoOlho);
            Console.WriteLine("internal: " + NumeroCelular);
            Console.WriteLine("protected internal: " + JeitoDeFalar);
            Console.WriteLine("private protected: " + SegredoFamilia);
            Console.WriteLine("private: " + UsaMuitoPhotoshop);
        }
    }
}
