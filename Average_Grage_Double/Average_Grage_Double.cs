using System;

namespace Fogli
{
    internal static class Average_Grage_Double
    {
        private static void Main()
        {
            int ciclo = 0, max = 0, min = 0;
            double voto, votoTemp = 0;
            var error = false;
            do
            {
                Console.WriteLine("Inserire il voto ");
                do
                {
                    if (error) Console.WriteLine("Il tuo voto non è valido reinserire un voto valido");
                    error = !double.TryParse(Console.ReadLine(), out voto);
                    if (voto < 0)
                    {
                        Console.WriteLine("Il voto è minore di zero");
                        error = true;
                    }

                    if (voto > 10)
                    {
                        Console.WriteLine("Il voto è più grande di dieci");
                        error = true;
                    }
                } while (error);

                if (voto >= 6) max++;
                if (voto < 6 && voto > 0) min++;
                votoTemp += voto;
                if (voto == 0)
                {
                    Console.Clear();
                    double votoFinale = votoTemp / ciclo;
                    Console.WriteLine($"Hai inserito {ciclo} voti");
                    Console.WriteLine($"La media è {votoFinale}, hai presso {min} insufficenti e {max} sufficenti");
                    if (votoFinale >= 6) Console.WriteLine($"{votoFinale} è sufficente :D");
                    if (votoFinale < 6 && votoFinale > 0)
                    {
                        Console.Write($"{votoFinale} è insufficente :/, per recuperare devi prendere ");
                        double x = 6 * (ciclo + 1) - votoFinale;
                        Console.WriteLine(x);
                    }
                }

                ciclo++;
            } while (voto != 0);

            Console.ReadKey();
        }
    }
}
