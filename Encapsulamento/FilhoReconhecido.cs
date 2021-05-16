using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine("public: " + InfoPublica);
            Console.WriteLine("protected: " + CorDoOlho);
            Console.WriteLine("internal: " + NumeroCelular);
            Console.WriteLine("protected internal: " + JeitoDeFalar);
            Console.WriteLine("private protected: " + SegredoFamilia);
            //Console.WriteLine("private: " + UsaMuitoPhotoshop);
        }
    }
}
