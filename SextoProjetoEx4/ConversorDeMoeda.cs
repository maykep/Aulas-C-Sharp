using System;
using System.Collections.Generic;
using System.Text;

namespace SextoProjetoEx4
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double DolarParaReal( double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF;
        }
    }
}
