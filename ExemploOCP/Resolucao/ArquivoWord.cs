using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoOCP.Resolucao
{
    public class ArquivoWord : IArquivo
    {
        public void Gere() => Console.WriteLine("Arquivo Word gerado com sucesso.");
    }
}
