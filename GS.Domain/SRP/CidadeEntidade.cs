using GS.Domain.SRP;

namespace GS.Domain
{
    public class CidadeEntidade
    {
        public int Identificador { get; set; }
        public int CodigoIBGE { get; set; }
        public string Descricao { get; set; }
        public EstadoEntidade EstadoEntidade { get; set; }
    }
}