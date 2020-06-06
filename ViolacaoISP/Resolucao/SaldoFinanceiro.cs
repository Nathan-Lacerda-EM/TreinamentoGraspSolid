using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP.Resolucao
{
    public class SaldoFinanceiro : ISaldo
    {
        public void Atualizar()
        {
            Console.WriteLine("O saldo financeiro foi atualizado.");
        }
    }
}
