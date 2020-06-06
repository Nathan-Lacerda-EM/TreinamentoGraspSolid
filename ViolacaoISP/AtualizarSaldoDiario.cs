using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP
{
    public class AtualizarSaldoDiario : ISaldo
    {
        #region Public Methods

        public void Atualizar()
        {
            Console.WriteLine("O saldo DIARIO foi atualizado.");
        }

        public void BaixarEstoque()
        {
            Console.WriteLine("O estoque foi baixado em 10 itens");
            Atualizar();
        }

        #endregion Public Methods
    }
}
