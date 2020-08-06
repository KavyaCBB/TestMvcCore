using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TestMvcCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            Console.WriteLine("enter numbers");
            int[] val = new int[5];
            for (int i = 0; i < val.Length; i++)
            {
                val[i] = int.Parse(Console.ReadLine());
            }

            // int intTemp = Convert.ToInt32(Console.ReadLine());
            int small = PrintSmallestLargest(val);

            Console.WriteLine(small);
        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        static int PrintSmallestLargest(int[] arr)
        {
            if (arr.Length > 0)
            {
                int small = arr[0];
                int large = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (large < arr[i])
                    {
                        int tmp = large;
                        large = arr[i];
                        arr[i] = large;
                    }
                    if (small > arr[i])
                    {
                        int tmp = small;
                        small = arr[i];
                        arr[i] = small;
                    }
                }
                Console.WriteLine("Smallest is {0}", small);
               // Console.WriteLine("Largest is {0}", large);
                return small;
            }

            return 0;
        }
    }
}
