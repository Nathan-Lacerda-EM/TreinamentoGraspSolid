using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP
{
    class Program
    {
        public static void Main(string[] args)
        {
            AtualizarSaldoDiario atualizarSaldoDiario = new AtualizarSaldoDiario();
            atualizarSaldoDiario.BaixarEstoque();

            SaldoFinanceiro saldoFinanceiro = new SaldoFinanceiro();
            saldoFinanceiro.Atualizar();

            Resolucao.SaldoDiario saldoDiarioResolucao = new Resolucao.SaldoDiario();
            saldoDiarioResolucao.BaixarEstoque();

            Resolucao.SaldoFinanceiro saldoFinanceiroResolucao = new Resolucao.SaldoFinanceiro();
            saldoFinanceiroResolucao.Atualizar();

            Console.ReadKey();
        }
    }
}
