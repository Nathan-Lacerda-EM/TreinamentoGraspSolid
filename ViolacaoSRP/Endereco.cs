using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Domain
{
    public class Endereco
    {
        public int Identificador { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Complemento { get; set; }
        public BairroEntidade Bairro { get; set; }
    }
}
