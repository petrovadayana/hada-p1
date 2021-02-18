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
                isActive = value == 'q' ? false : true;
            }
            get
            {
                return line;
            }
        }
        static double getValue(char line, double valor)
        {
            switch (line)
            {
                case 'm':
                    return HadaP1.Minutes2Seconds(valor);
                case 's':
                    return HadaP1.Seconds2Minutes(valor);
                default:
                    return -1;
            }
        }

        static char getType()
        {
            Console.Write("Valor a introducir: 's' (segundos) o 'm' (minutos) / q Quit: ");
            return Console.ReadLine()[0];
        }

        static void Main(string[] args)
        {
            do
            {
                Line = getType();
                if (isActive)
                {
                    Console.Write("Introduce valor a convertir: ");
                    string valueInput = Console.ReadLine();
                    double value = double.Parse(valueInput);

                    double result = getValue(line, value);

                    if (result != -1)
                    {
                        Console.WriteLine("Result: " + result);
                    }
                }
            } while (isActive);
        }
    }
}