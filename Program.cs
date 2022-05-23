using System;

namespace ConsoleApp3
{
    public enum tempos
    {
        Noturno,
        Diurno,
    }

    public class FlagsEnumExample
    {
        public static void Main()
        {
           
            DateTime numero = DateTime.Now;

            if (numero.Hour >= 05.55 && numero.Hour < 6.10)
            {                
                Console.WriteLine(tempos.Noturno);
            }
            else if (numero.Hour >= 6.10 && numero.Hour < 16.50)
            {
                Console.WriteLine(tempos.Diurno);
            }
            else if (numero.Hour >= 16.50)
            {
                Console.WriteLine(tempos.Noturno);
            }
            else if (numero.Hour < 6.10)
            {
                Console.WriteLine(tempos.Noturno);
            }
        }
    }

}
