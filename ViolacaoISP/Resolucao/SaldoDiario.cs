using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP.Resolucao
{
    public class SaldoDiario : SaldoDiarioBase
    {
        public override void Atualizar()
        {
            Console.WriteLine("O saldo DIARIO foi atualizado.");
        }

        public override void BaixarEstoque()
        {
            Console.WriteLine("O estoque foi baixado em 10 itens");
            Atualizar();
        }
    }
}
