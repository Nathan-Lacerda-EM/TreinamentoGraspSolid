using System.Collections.Generic;

namespace ViolacaoOCP.Resolucao
{
    public class GeradorDeArquivos
    {
        public void GereArquivos(List<IArquivo> arquivos) => arquivos.ForEach(arquivo => arquivo.Gere());
    }
}
