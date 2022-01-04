using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace multitreding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(()=>Task1(), ()=> Task2()) ; // գրելաձևը հասկանալ
            Parallel.Invoke(() => Task1());
            Parallel.Invoke(() => Task2());
            /*var items = Enumerable.Range(0, 10).ToArray(); //փոքրատառո՞վ
            Parallel.For(0, items.Length, i =>
            {
                WorkOnItem(i);
            }); */

            /*    Thread thread = new Thread(() =>
                {
                    Console.WriteLine("Hello from the thread");
                    Thread.Sleep(1000);
                });

                thread.Start();
                Console.WriteLine("Press a key to end.");
            */
            //    Console.WriteLine(Factorial(-5));

            List<string> pangram = new List<string> { "abc", "qwejuihiUUUUrtyuioplkjhgfdsazxcvbnm" };
            //Console.WriteLine(isPangram(pangram));
            Console.WriteLine(volleyball(3, 25));
        }
        public static int volleyball(int A, int B)
        {
            var localA = 0;
            var localB = 0;
            return 0;
        }
        public static string isPangram(List<string> pangram)
        {
            string result = "";
            foreach (var currentStr in pangram)
            {
                if (currentStr.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            return result;
        }

        static void Task1() // ինչո՞ւ ստատիկ
        {
            Console.WriteLine("Task1 start");
            Thread.Sleep(2000);
            Console.WriteLine("Task1 end");
        }
        static void Task2()
        {
            Console.WriteLine("Task2 start");
            Thread.Sleep(2000);
            Console.WriteLine("Task2 end");
        }

        static void WorkOnItem(object item)
        {
            Console.WriteLine("object is printing..." + item);
            Thread.Sleep(2000);
        }

        public int Factorial(int n)
        {
           if (n < 0)
             throw new Exception("The negative number does not have factorial");

            int p = 1;
            while (n != 0)
                p *= n--;
            return p;      
        }
        
    }
}
