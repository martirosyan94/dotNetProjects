using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MysqlTest
{
    class Program
    {
        //nuget - mysql.data
        static void Main(string[] args)
        {

            var cs = "server=127.0.0.1;uid=root;pwd=Dark(h0colate;database=test";
            Console.WriteLine("Hello World!");
            @"Data Source=(localdb)\ProjectsV13;Initial Catalog=aaaa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            using (var connection = new MySqlConnection(cs))
            {
                connection.Open();
                var cmd = new MySqlCommand($"Select * from Student where id = {1}", connection);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetString(1));
                    Console.WriteLine($"{reader.GetInt32(0)} {reader.GetString(1)}");
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
