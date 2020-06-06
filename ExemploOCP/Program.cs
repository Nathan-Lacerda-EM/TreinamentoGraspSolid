using System;
using System.Collections.Generic;

namespace ViolacaoOCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arquivos = new List<Arquivo>();

            var arquivoWord = new ArquivoWord();
            arquivos.Add(arquivoWord);

            var arquivoPdf = new ArquivoPdf();
            arquivos.Add(arquivoPdf);

            var arquivoTxt = new ArquivoTxt();
            arquivos.Add(arquivoTxt);

            var geradorDeArquivo = new GeradorDeArquivos();
            geradorDeArquivo.GereArquivos(arquivos);

            RodeComResolucao();

            Console.ReadKey();
        }

        public static void RodeComResolucao()
        {
            var arquivos = new List<Resolucao.IArquivo>();

            var arquivoWord = new Resolucao.ArquivoWord();
            arquivos.Add(arquivoWord);

            var arquivoPdf = new Resolucao.ArquivoPdf();
            arquivos.Add(arquivoPdf);

            var arquivoTxt = new Resolucao.ArquivoTxt();
            arquivos.Add(arquivoTxt);

            var geradorDeArquivo = new Resolucao.GeradorDeArquivos();
            geradorDeArquivo.GereArquivos(arquivos);
        }
    }
}
