using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grage_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ciclo = 0, max = 0, min = 0;
            double voto, voto_temp = 0, voto_finale, x;
            bool error = false;
            do
            {
                Console.WriteLine("Inserire il voto ");
                do
                {
                    if (error)
                    {
                        Console.WriteLine("Il tuo voto non è valido");
                    }
                } while (error = !double.TryParse(Console.ReadLine(), out voto));
                if (voto >= 6)
                {
                    max++;
                }
                if (voto < 6 && voto > 0)
                {
                    min++;
                }
                voto_temp = voto_temp + voto;
                if (voto == 0)
                {
                    Console.Clear();
                    voto_finale = voto_temp / ciclo;
                    Console.WriteLine($"Hai inserito {ciclo} voti");
                    Console.WriteLine($"La media è {voto_finale}, hai presso {min} insufficenti e {max} sufficenti");
                    if (voto_finale >= 6)
                    {
                        Console.WriteLine($"{voto_finale} è sufficente :D");
                    }
                    if (voto_finale < 6 && voto_finale > 0)
                    {
                        Console.Write($"{voto_finale} è insufficente :/, per recuperare devi prendere ");
                        x = 6*(ciclo + 1) - voto_finale;
                        Console.WriteLine(x);
                    }
                }
                ciclo++;
            } while (!(voto == 0));
            Console.ReadKey();
        }
    }
}
