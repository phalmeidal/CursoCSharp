﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area + 1000);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade = "+ idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols = " + saldoDeGols);


            short salario = short.MinValue;
            Console.WriteLine("Salario = "+ salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int = " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira = "+ populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long = " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial = " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço computador = " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas = " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra = " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);
        }
    }
}
