namespace ViolacaoLSP
{
    public class Quadrado : Retangulo
    {
        public override int Altura 
        {
            set 
            { 
                _altura = value;
                _largura = value;
            } 
        }

        public override int Largura
        {
            set
            {
                _altura = value;
                _largura = value;
            }
        }
    }
}
