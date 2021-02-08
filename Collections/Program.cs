using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            string b = "Hello";
            float c = 2.32f;
            char d = 'd';
            bool e = true;
            int[] f = new int[6] { 1, 2, 3, 4, 5, 6 };
            ArrayList Array1 = new ArrayList();
            ArrayList Array2 = new ArrayList()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            Array1.Add(a);
            Array1.Add(b);
            Array1.Add(c);
            Array1.Add(d);
            Array1.Add(e);
            Array1.Add(f);
            Array1.Add("bcd");

            var dcd = Array1[6];//Just for the sake of explicit typecasting
            
            Array1.Insert(0, a * 2);//inserting value a*2 at 0 index 
            //by inserting every value will be pushed forward to the next location.

            Array1.AddRange(Array2);//adding another array list at the end of the first array list 

            for( int i = 0; i < Array1.Count; i++)
            {
                Console.WriteLine("Value from {0} index ", i);
                Console.WriteLine(Array1[i]);
            }
            Console.WriteLine("\n Ended The array List Now moving towards next Collection \n\n\n")


        }
    }
}
