using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1    /// Esta clase contiene métodos para 
                    /// la conversión de min a seg y viceversa
    {
        public static double Seconds2Minutes (double s)
        {
            return s == 0 ? 0 : s / 60; /// si seg no es 0 se div en 60 para pasarlo a minutos
        }

        public static double Minutes2Seconds (double m)
        {
            return m == 0 ? 0: m * 60; /// si min no es 0 se mult por 60 para pasarlo a seg
        }

        public static double Hours2Minutes (double h)
        {
            return h == 0 ? 0: h * 60; /// si hours no es 0, lo mult por 60 para pasarlo a min
        }
    }
}
