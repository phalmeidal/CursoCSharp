using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "galdiador");
            filmes.Add(2002, "homemaranga");
            filmes.Add(2004, "incriveis");
            filmes.Add(2006, "truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                
            }

            foreach(var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            foreach (KeyValuePair<int, string>filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

        }
    }
}
