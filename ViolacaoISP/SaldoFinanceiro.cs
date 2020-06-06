using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP
{
    public class SaldoFinanceiro : ISaldo
    {
        #region Public Methods

        public void Atualizar()
        {
            Console.WriteLine("O saldo financeiro foi atualizado.");
        }

        public void BaixarEstoque()
        {
            throw new Exception("OPS! Eu não sei o que fazer aqui. Não sou uma classe de saldo de estoques");
        }

        #endregion Public Methods
    }
}
