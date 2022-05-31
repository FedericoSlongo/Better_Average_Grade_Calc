using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grade_Duble_clstr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string voto_temp = "";
            int ciclo = 0;
            double voto = 0, media = 0;
            double[] voto_finale = new double[100];

            //Aggiunta dei numeri
            do
            {
                Console.Write("Inserisci il voto: ");
                voto_temp = Console.ReadLine().ToLower();
                if (voto_temp == "0")
                {
                    break;
                }
                if (voto_temp == "prec" || voto_temp == "precedente")
                {
                    Console.WriteLine("Il numero precedente è stato eliminato");
                    ciclo -= 2;
                } else if (!double.TryParse(voto_temp, out voto))
                {
                    Console.WriteLine("Numero inserito non valido");
                    ciclo--;
                }
                else
                {
                    voto_finale[ciclo] = voto;
                }
                ciclo++;
            } while (true);

            //Calcolo media temporale
            for (int i = 0; i < 100; i++)
            {
                media += voto_finale[i];
            }
            //Pulisco la console
            Console.Clear();
            //Stampa media con calcolo finale
            Console.WriteLine($"La media è {media / ciclo}");

            Console.ReadKey();
        }
    }
}
