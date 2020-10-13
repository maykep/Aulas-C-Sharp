using System;
using System.Collections.Generic;
using System.Text;

namespace SextoProjeto
{
    class Retangulo
    {
        public double Largura, Altura;
        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
