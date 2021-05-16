using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    class Encapsulamento
    {
        public class FilhoNaoReconhecido : SubCelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("FilhoNaoReconhecido...");

                Console.WriteLine("public: " + InfoPublica);
                Console.WriteLine("protected: " + CorDoOlho);
                //Console.WriteLine("internal: " + NumeroCelular);
                Console.WriteLine("protected internal: " + JeitoDeFalar);
                //Console.WriteLine("private protected: " + SegredoFamilia);
                //Console.WriteLine("private: " + UsaMuitoPhotoshop);
            }
        }

        public class AmigoDistante
        {
            public readonly SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos()
            {
                Console.WriteLine("AmigoDistante...");

                Console.WriteLine("public: " + amiga.InfoPublica);
                //Console.WriteLine("protected: " + amiga.CorDoOlho);
                //Console.WriteLine("internal: " + amiga.NumeroCelular);
                //Console.WriteLine("protected internal: " + amiga.JeitoDeFalar);
                //Console.WriteLine("private protected: " + amiga.SegredoFamilia);
                //Console.WriteLine("private: " + amiga.UsaMuitoPhotoshop);

            }
        }

        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            Console.WriteLine();
            new FilhoReconhecido().MeusAcessos();
            Console.WriteLine();
            new AmigoProximo().MeusAcessos();
            Console.WriteLine();
            new AmigoDistante().MeusAcessos();


        }
    }
}
