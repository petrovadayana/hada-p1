using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        private static bool isActive = false;
        private static char line;
        public static char Line
        {
            set
            {
                line = value;
                isActive = value == 'q' ? false : true; /// comprobracion de si es o no 'q'
            }
            get
            {
                return line;
            }
        }
        static double getValue(char line, double valor) /// recibimos 'm'/'s'/'h' y valor a convertir
        {
            switch (line)
            {
                case 'm':
                    return HadaP1.Minutes2Seconds(valor);   /// si es m: de min a seg
                case 's':
                    return HadaP1.Seconds2Minutes(valor);  /// si es s: de seg a min
                case 'h':
                    return HadaP1.Hours2Minutes(valor);    /// si es h: de horas a min
                default:
                    return -1;
            }
        }

        static char getType()   /// mensaje de inicio programa y dato: tipo conversion 
        {
            Console.Write("Tipo de unidad: 's' (segundos) |'m' (minutos) | 'h' (horas) | 'q' Quit: ");
            return Console.ReadLine()[0];
        }

        static void Main(string[] args)
        {
            do
            {
                Line = getType();
                if (isActive)
                {
                    Console.Write("Introduce valor a convertir: "); /// valor a convertir
                    string valueInput = Console.ReadLine();
                    double value = double.Parse(valueInput);    /// de string a double

                    double result = getValue(line, value);  /// llamamos a metodo que procesa datos

                    if (result != -1)
                    {
                        Console.WriteLine("Resultado: " + result); /// devolvemos resultado
                    }
                }
            } while (isActive); /// mientras sea true (y no es por tanto 'q')
        }
    }
}