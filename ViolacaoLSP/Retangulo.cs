using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolacaoLSP
{
    public class Retangulo
    {
        protected int _altura;
        protected int _largura;

        public virtual int Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                _altura = value;
            }
        }

        public virtual int Largura
        {
            get
            {
                return _largura;
            }
            set
            {
                _largura = value;
            }
        }

        public int GetArea()
        {
            return Largura * Altura;
        }
    }
}
