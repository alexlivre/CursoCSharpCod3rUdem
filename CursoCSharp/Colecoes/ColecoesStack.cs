using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pinha = new Stack();
            pinha.Push(3);
            pinha.Push("a");
            pinha.Push(true);
            pinha.Push(3.14f);

            foreach(var item in pinha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pinha.Pop()}");

            foreach(var item in pinha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pinha.Peek()}");
            Console.WriteLine(pinha.Count);
        }
    }
}
