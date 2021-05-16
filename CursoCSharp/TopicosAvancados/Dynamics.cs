using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Maria Júlia";
            aluno.Nota = 8.9;
            aluno.Idade = 24;

            Console.WriteLine("{0} {1} {2}", aluno.Nome, aluno.Nota, aluno.Idade );
        }
    }
}
