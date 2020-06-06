
namespace ViolacaoLSP.Resolucao
{
    public class Retangulo
    {
        public int Altura { get; set; }

        public int Largura { get; set; }
        
        public Retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public int GetArea()
        {
            return Largura * Altura;
        }
    }
}
