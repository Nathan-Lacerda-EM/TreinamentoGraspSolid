using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoOCP.Resolucao
{
    public class ArquivoTxt : IArquivo
    {
        public void Gere() => Console.WriteLine("Arquivo TXT gerado com sucesso.");
    }
}
