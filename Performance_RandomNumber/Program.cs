using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller();
        }

        static void Controller()
        {
            int id = 0;
            Random random = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                id++;

                int randomValue = random.Next(0, 9999);

                using (StreamWriter sw = File.AppendText(@"C:\Users\zbc23jkst\Desktop\SQLServerProfiler\RandomValue.txt"))
                {
                    Console.WriteLine($"{id}");
                    if (id == 1)
                    {
                        sw.WriteLine("ID, RandomValue");
                    }
                    sw.WriteLine($"{id}, {randomValue}");
                }
            }
        }
    }
}
