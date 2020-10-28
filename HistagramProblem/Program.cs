using System;
using System.Collections.Generic;
using System.Linq;

namespace HistagramProblem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // from console input single input 
            /* var stringList = Console.ReadLine().Split(',').ToList();
             var bucketSize = int.Parse(Console.ReadLine());*/

            string line;
            int bucketSize = 0;
            List<string> stringList = new List<string>();
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\vitripathi\source\repos\HistagramProblem\Histogram.txt");
            while ((line = file.ReadLine()) != null)
            {
                stringList.Clear();
                stringList.AddRange(line.Split(',').ToList());
                bucketSize = int.Parse(file.ReadLine());
                List<int> intList = stringList.ConvertAll(int.Parse);
                Utility.ConvertToBucket(intList, bucketSize);
                 Console.WriteLine("-----------------------------------------------------");
            }
            file.Close();
            Console.ReadKey();
        }

       
    }
}
