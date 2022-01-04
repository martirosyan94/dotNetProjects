using System;
using System.Collections.Generic;
using System.Linq;

namespace serviceTitan
{
    class Program
    {
        private static object watch;

        public static void Main(string[] args)
        {
            //List<int> counts = new List<int> { 2,1,1,2,1 };
            List<int> counts = new List<int> { 2, 2, 2, 2 };
            //List<int> counts = new List<int> { 1, 1, 1 };
            //List<int> counts = new List<int> { 3, 3, 3, 3, 3, 1, 3 };
            SocialGraph(counts);

            //List<int> arr = new List<int> { 30, 20, 10 };
            List<int> arr1 = new List<int> { 30, 10, 20 };
            mincost(arr1);
            //List<int> arr2 = new List<int> { 10, 95, 37, 33, 19, 92, 94, 16, 2, 18, 50 };
            var watch = new System.Diagnostics.Stopwatch();
            for (int i = 1; i <= 10; i++)
            {
                watch.Start();
                mincost2(arr1);
                //mincost2(arr2);
                watch.Start();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                //graf(counts);
            }
            Console.WriteLine("_______________________________");
            for (int i = 1; i <= 10; i++)
            {
                watch.Start();
                //mincost(arr1);
                //mincost(arr2);
                watch.Start();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                //graf(counts);
            }
        }

        private static void SocialGraph(List<int> counts)
        {
            Console.WriteLine("Me");
            List<List<int>> graph = new List<List<int>>();
            
            for (int i = 0; i < counts.Count; i++)
            {
                bool isGroupExist = false;
                for (int j = 0; j < graph.Count; j++)
                {

                        if (counts[i] == graph[j][0]) { isGroupExist = true; }
                }

                if (isGroupExist) { continue; }

                graph.Add(new List<int> { counts[i], 0 });
                for (int j = i; j < counts.Count; j++)
                {
                    if (counts[j] == graph[graph.Count-1][0])
                    {
                        ++graph[graph.Count - 1][1];
                        graph[graph.Count - 1].Add(j);
                    }
                }
            }

            foreach (var currentGraphEl in graph)
            {
                int j = 0;
                for (int i = 2; i < currentGraphEl.Count; i++)
                {
                    if (j++ < currentGraphEl[0])
                    {
                        Console.Write(currentGraphEl[i]);
                        if (j != currentGraphEl[0]) { Console.Write(" "); }
                        continue;
                    }
                    else
                    {
                        j = 1;
                        Console.Write("\n" + currentGraphEl[i] + " ");
                    }
                }
                Console.WriteLine();
            }

        }

        // MINIMUM COST
        private static void mincost(List<int> arr) 
        {
            int minCost = 0;
            arr.Sort();
            bool isInserted = false;
            while (arr.Count > 1)
            {
                int tmpCost = arr[0] + arr[1];
                minCost += tmpCost;
                arr.RemoveRange(0, 2);
                for (int i = 0; i < arr.Count; i++)
                {
                    if (tmpCost < arr[i])
                    {
                        arr.Insert(i, tmpCost);
                        isInserted = true;
                        break;
                    }
                
                }
                if (!isInserted)
                {
                    arr.Add(tmpCost);
                }
                isInserted = false;
            }

            Console.WriteLine(minCost);
        }

        private static void graf(List<int> counts)
        {
            Console.WriteLine("Ruben");

            var users = Enumerable.Range(0, counts.Count()).ToList();
            foreach (var item in counts)
            {
                var group = new List<int>();
                var currents = users.Where(e => counts[e] == item).ToList();
                if (currents.Any())
                {

                    for (int i = 0; i < item; i++)
                    {
                        group.Add(currents.First());
                        users.RemoveAt(users.FindIndex(e => e == currents[0]));
                        currents.RemoveAt(0);
                    }
                    Console.WriteLine(String.Join(" ", group));
                }

            }



        }

        private static void mincost2(List<int> arr)
        {
            int minCost = 0;

            while (arr.Count > 1)
            {
                arr.Sort();
                minCost += arr[0] + arr[1];
                arr[0] += arr[1];
                //  if (arr[0] > 100)
                //  { arr[0] = 100; }
                arr.RemoveAt(1);
            }

            Console.WriteLine(minCost);
        }

    }
}
