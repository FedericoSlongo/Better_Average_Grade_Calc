using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grage_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ciclo = 0, max = 0, min = 0;
            double voto, voto_temp = 0, voto_finale, x;
            string voto_;
            bool error = false;
            do
            {
                Ri_Lettura:
                Console.WriteLine("Inserire il voto ");
                do
                {
                    if (error)
                    {
                        Console.WriteLine("Il tuo voto non è valido reinserire un voto valido");
                    }
                    //Lettura del voto
                    voto_ = Console.ReadLine().ToLower();

                    //Controllo se vuole eliminare il numero precedente
                    if (voto_ == "prec" || voto_ == "precedente")   {
                        if (ciclo == 0)
                        {
                            Console.WriteLine("Non hai ancora inserito numeri");
                            goto Ri_Lettura;
                        }
                        Console.WriteLine("Cancellazione del numero precedente completata!");
                        ciclo--;
                        goto Ri_Lettura;
                    }

                    //Controllo se il voto è un numero valido corretto
                    error = !double.TryParse(voto_, out voto);
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
                //Controllo se il voto è sufficente
                if (voto >= 6)
                {
                    max++;
                }
                //Controllo se il voto è insufficente
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
                        x = 6 * (ciclo + 1) - voto_finale;
                        Console.WriteLine(x);
                    }
                }
                ciclo++;
            } while (!(voto == 0));
            Console.ReadKey();
        }
    }
}
