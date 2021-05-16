using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executoutrabalho1 = true;
            var executoutrabalho2 = true;

            bool comprouTv50 = executoutrabalho1 && executoutrabalho2;
            Console.WriteLine("Comprou Tv 50? {0}", comprouTv50);

            bool comprouSorvete = executoutrabalho1 || executoutrabalho2;
            Console.WriteLine("Comprou soverte? {0}", comprouSorvete);

            bool comprouTv32 = executoutrabalho1 ^ executoutrabalho2;
            Console.WriteLine("Comprou Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
