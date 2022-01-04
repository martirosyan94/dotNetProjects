using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Reflaction
    {
        public int GetNumberOfMethods(MethodInfo[] mi, string letter)
        {
            if (letter.Count() > 1)
            {
                // ի՞նչ էքսեփշն կարելի ա գցել
                throw new Exception("The argument should be single letter");
            }

            return mi.Where(m => m.Name.StartsWith(letter)).Count();
        }
        public int SumLettersNumber(MethodInfo[] mi, string letter)
        {
            return mi.Where(m => m.Name.StartsWith(letter)).Select(m => (int)m.Name[1] % 32).Distinct().Sum();
        }
    }
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("Running");
        }
        public void Run1()
        {
            Console.WriteLine("Running1");
        }
        public void Ran()
        {
            Console.WriteLine("Ranning1");
        }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public void StartEngine()
        {
            Console.WriteLine("The engine is starting..");
        }

        public void PtartEngine()
        {
            Console.WriteLine("The engine is ptarting..");
        }
    }
}
