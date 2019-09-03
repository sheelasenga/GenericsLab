using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[10];
            count[0] = 2;
            count[1] = 3;
            count[2] = 7;

            int[,,] threeD = new int[10, 10, 10];
            threeD[1, 1, 1] = 20;
            threeD[5, 5, 5] = 47;
            for (int x = 0; x < threeD.GetLength(0); x++)
            {

                for (int y = 0; y < threeD.GetLength(1); y++)
                {
                    for (int z = 0; z < threeD.GetLength(2); z++)
                    {
                        Console.WriteLine("The value of count three is:" + threeD[x, y, z]);

                    }
                    Console.ReadLine();
                }
            }
            //dictionary

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("One", "India");
            myDictionary.Add("two", "Britain");
            myDictionary.Add("three", "Africa");
            myDictionary.Add("four", "Dubai");
            myDictionary.Add("five", "America");
            //Console.WriteLine(myDictionary["One"]);
            myDictionary.ToList().ForEach(x => Console.WriteLine(x.Value));



            //Queue
            Queue<double> qd = new Queue<double>();

            foreach (Object obj in qd)
            {
                Console.WriteLine(obj);
            }
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
                
                //  Console.WriteLine(i);
            }

            Console.WriteLine("The number of elements in the Queue " + qd.Count);
           // qd.Dequeue();
            Console.ReadLine();
        }
    }
}
