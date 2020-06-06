using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoISP
{
    public interface ISaldo
    {
        #region Public Methods

        void Atualizar();

        void BaixarEstoque();

        #endregion Public Methods
    }
}
