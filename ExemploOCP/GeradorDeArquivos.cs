using System.Collections.Generic;

namespace ViolacaoOCP
{
    public class GeradorDeArquivos
    {
        public void GereArquivos(List<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                if (arquivo is ArquivoWord)
                    ((ArquivoWord)arquivo).GereDocx();
                else if (arquivo is ArquivoPdf)
                    ((ArquivoPdf)arquivo).GerePdf();
                else if (arquivo is ArquivoTxt)
                    ((ArquivoTxt)arquivo).GereTxt();
            }
        }
    }
}
