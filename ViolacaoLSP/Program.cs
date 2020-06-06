using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViolacaoLSP.Resolucao;

namespace ViolacaoLSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo
            {
                Altura = 5,
                Largura = 2
            };

            Quadrado quadrado = new Quadrado
            {
                Altura = 5,
                Largura = 2
            };

            Console.WriteLine(
                "VIOLAÇÃO: " +
                "\nÁrea do retângulo: " + retangulo.GetArea() +
                "\nÁrea do quadrado: " + quadrado.GetArea());

            RodeComResolucao();

            Console.ReadKey();
        }

        public static void RodeComResolucao()
        {
            Resolucao.Retangulo retanguloResolucao = new Resolucao.Retangulo(5, 2);
            Resolucao.Quadrado quadradoResolucao = new Resolucao.Quadrado(5);

            Console.WriteLine("\nResolução: " +
                "\nÁrea do retângulo: " + retanguloResolucao.GetArea() +
                "\nÁrea do quadrado: " + quadradoResolucao.GetArea());
        }
    }
}
