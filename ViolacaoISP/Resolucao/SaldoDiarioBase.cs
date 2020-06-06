using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP.Resolucao
{
    public abstract class SaldoDiarioBase : ISaldo
    {
        public abstract void Atualizar();
        public abstract void BaixarEstoque();
    }
}
