using System;
using System.Threading.Tasks;

namespace AsyncAwait
{ 
    internal class HashBrown { }

    internal class Latte { }

    internal class Juice { } 

    class Program
    {
        static async Task Main(string[] args)
        {
            Latte latte = CupOfLatte();
            Console.WriteLine("coffee is ready");

            var hashBrownTask = FryHashBrownsAsync(3);

            while (!hashBrownTask.IsCompleted)
            {
                Console.WriteLine("Doing other things while waiting for hash browns...");
                await Task.Delay(1000); // Simulate doing other work
            }
            Console.WriteLine("hash browns are ready");

            Juice juicer = PourOJ();
            Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        private static Latte CupOfLatte()
        {
            Console.WriteLine("Pouring latte");
            return new Latte();
        }
        private static async Task<HashBrown> FryHashBrownsAsync(int patties)
        {
            Console.WriteLine($"putting {patties} hash brown patties in the pan");
            Console.WriteLine("cooking first side of hash browns...");
            Task.Delay(3000).Wait();
            for (int patty = 0; patty < patties; patty++)
            {
                Console.WriteLine("flipping a hash brown patty");
            }
            Console.WriteLine("cooking the second side of hash browns...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put hash browns on plate");

            return new HashBrown();
        }
        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            Juice oj = new Juice();
            
            return new Juice();
        }
    }
}
