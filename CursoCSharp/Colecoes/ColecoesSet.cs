﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);
            
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8 Temporada de Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10),
            };

            carrinho.UnionWith(combo); // AddRange foi trocado por UnionWith
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine("Index: " + carrinho.LastIndexOf(livro));
        }
    }
}
