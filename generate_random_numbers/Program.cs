using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generate_random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                List<Double> numbers = new List<Double>();
                Random rng = new Random();
                double max = 999999999;
                double min = 0;
                if (args.Length > 2)
                {
                    min = Convert.ToDouble(args[2]);
                }
                if (args.Length > 3)
                {
                    max = Convert.ToDouble(args[3]);
                }

                for (int i = 0; i < int.Parse(args[1]); i++)
                {
                    numbers.Add(Math.Floor(rng.NextDouble() * (max - min + 1) + min));
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(args[0]))
                {
                    foreach (double number in numbers)
                    {
                        file.WriteLine(number.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("name file and say how many numbers you want");
                Console.ReadKey();
            }
           
        }
    }
}
