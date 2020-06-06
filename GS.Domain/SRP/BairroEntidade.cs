namespace GS.Domain
{
    public class BairroEntidade
    {
        public int Identificador { get; set; }
        public int Descricao { get; set; }
        public CidadeEntidade Cidade { get; set; }
    }
}