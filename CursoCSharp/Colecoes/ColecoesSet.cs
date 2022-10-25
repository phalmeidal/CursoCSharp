﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("got", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa",29.9),
                new Produto("8 temporada",99.9),
                new Produto("poster",10),
            };
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach(var item in carrinho) {
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
