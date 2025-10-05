using System;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static async Task<string> FetchDataAsync()
        {
            Console.WriteLine("Fetching data...");

            await Task.Delay(3000); // 3 seconds delay

            return "Data fetched successfully!";
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Program started.");

            string result = await FetchDataAsync();

            Console.WriteLine(result);
            Console.WriteLine("Program ended.");
        }
    }
}
