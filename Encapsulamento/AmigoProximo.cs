using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine("public: " + amiga.InfoPublica);
            //Console.WriteLine("protected: " + amiga.CorDoOlho);
            Console.WriteLine("internal: " + amiga.NumeroCelular);
            Console.WriteLine("protected internal: " + amiga.JeitoDeFalar);
            //Console.WriteLine("private protected: " + amiga.SegredoFamilia);
            //Console.WriteLine("private: " + amiga.UsaMuitoPhotoshop);
        }
    }
}
