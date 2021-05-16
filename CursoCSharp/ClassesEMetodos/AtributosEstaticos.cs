using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {
        public class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto;

            public Produto(string nome, double preco, double desconto)
            {
                this.Nome = nome;
                this.Preco = preco;
                //this.Desconto = desconto;
            }

            public Produto()
            {
                // Construtor padrão
            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }

        public static void Executar()
        {
            var produto1 = new Produto("Canete", 3.2, 0.1);

            var produto2 = new Produto()
            {

                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.5
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço do produto com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço do produto com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço do produto com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço do produto com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
