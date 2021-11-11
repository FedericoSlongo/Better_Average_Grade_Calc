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
            int ciclo = 0;
            double voto, voto_temp = 0, voto_finale;
            bool error = false;
            do
            {
                Console.WriteLine("Insert the grade ");
                do
                {
                    if (error)
                    {
                        Console.WriteLine("The grade you inserted isn't valid");
                    }
                } while (error = !double.TryParse(Console.ReadLine(), out voto));
                voto_temp = voto_temp + voto;
                if (voto == 0)
                {
                    Console.Clear();
                    voto_finale = voto_temp / ciclo;
                    Console.WriteLine($"The final grade is {voto_finale}");
                }
                ciclo++;
            } while (!(voto == 0));
            Console.ReadKey();
        }
    }
}
