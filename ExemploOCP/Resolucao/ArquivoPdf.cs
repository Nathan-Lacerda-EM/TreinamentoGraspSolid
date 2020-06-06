using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoOCP.Resolucao
{
    public class ArquivoPdf : IArquivo
    {
        public void Gere() => Console.WriteLine("Arquivo PDF gerado com sucesso.");
    }
}
