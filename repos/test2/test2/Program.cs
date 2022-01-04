using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {


            data _data = new data { 
                Id = 1,
                SSN = 2,
                Message = "A Message"
            };

            string jsonString = JsonSerializer.Serialize(_data);

            Console.WriteLine(jsonString);


        }
    }
}
