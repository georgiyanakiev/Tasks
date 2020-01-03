using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
   public static class Program8
    {
       public static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 1000; x++)
                {
                    Console.WriteLine(x);
                }
            });
            t.Wait();
            Console.WriteLine();
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();
        }
    }
}
