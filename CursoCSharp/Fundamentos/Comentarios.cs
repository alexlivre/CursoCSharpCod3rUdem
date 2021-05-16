using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos


{
    class Comentarios
    {
        public static void Executar()
        {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            /// O C#
            /// tem o
            /// XML Comments
            /// 
            Console.WriteLine("O C# tem o XML Comments!");

            /*
             * Esse é um comentário
             * de
             * múltiplas lina
             */

            Console.WriteLine("Teclas de CTRL + K + C comenta, CTRL + K + U descomenta.");
        }
    }
}
