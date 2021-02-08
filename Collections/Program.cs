using System;
using System.Collections;
using System.Collections.Generic;
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
            Console.WriteLine("\n Ended The array List Now moving towards next Collection \n\n\n");
            



            //Code for Sorted List (Non generic)
            Console.WriteLine("From Sorted List Nongeneric");
            int j = 0;
            SortedList myNames = new SortedList();
            myNames.Add(j,a);
            j++;
            myNames.Add(j, b);
            j++;
            myNames.Add(j, c);
            j++;
            myNames.Add(j, d);
            j++;
            myNames.Add(j, e);
            j++;
            myNames.Add(j, f);
            j++;

            Console.WriteLine("Before removing an element");
            foreach (DictionaryEntry variable in myNames)
            {
                Console.WriteLine("{0} {1}", variable.Key, variable.Value);
            }

            myNames.RemoveAt(0);
            Console.WriteLine("After removing an element");
            foreach (DictionaryEntry variable in myNames)
            {
                Console.WriteLine("{0} {1}",variable.Key , variable.Value) ;
            }
            




            //Code for Sorted List (Generic)
            Console.WriteLine("\n\n\n From Sorted List Generic");
            j = 0;
            SortedList<int, string> myNames1 = new SortedList<int, string>();
            myNames1.Add(j, "a");
            j++;
            myNames1.Add(j, "b");
            j++;
            myNames1.Add(j, "c");
            j++;
            myNames1.Add(j, "d");
            j++;
            myNames1.Add(j, "e");
            j++;
            myNames1.Add(j, "f");
            j++;

            myNames1.Remove(1);
            foreach (var variable in myNames1)
            {
                Console.WriteLine("The value against key {0} is {1}",variable.Key, variable.Value);
            }

            Console.WriteLine("\n\n\n Using KeyValuePair Property");

            foreach (KeyValuePair<int, string> obj in myNames1)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
            string result;
            if (myNames1.TryGetValue(2, out result))
            {
                Console.WriteLine("true {0}", result);
            }
            //Console.WriteLine(myNames1[0]);

            //Code for Dictionary implementation starts here
            Console.WriteLine("\n\n\n From Dictionary");

            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict.Add('a', "Ali");
            dict.Add('b', "Batman");
            dict.Add('c', "Cat");
            dict.Add('d', "Dog");
            dict.Add('e', "Elephant");
            dict.Add('f', "Frog");
            foreach(Object obj in dict)
            {
                Console.WriteLine(obj);
            }
            
            dict.Add('g', "Goose");
            dict.Remove('a');

            Console.WriteLine("\n\n From Dictionary Generic Printing Count of objects");
            Console.WriteLine(dict.Count);

            Console.WriteLine("\n\n\n From Dictionary Generic using Object");
            foreach (Object obj in dict)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\n\n\n From Dictionary Generic using KeyValuePair");
            foreach (KeyValuePair<char,string> obj in dict)
            {
                Console.WriteLine("{0} {1}",obj.Key , obj.Value);
            }



            //Code for Hashset implementation starts here
            Console.WriteLine("\n\n\n From Hashtable");

            Hashtable hash = new Hashtable();
            hash.Add(1,a);
            hash.Add('a', b);
            hash.Add('b', b);
            hash.Add('d', b);
            foreach(DictionaryEntry obj in hash)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);

            }


            //Code for List implementation starts here
            Console.WriteLine("\n\n\n From List generic");

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(21);
            myList.Add(2);
            myList.Add(0);
            myList.Sort();
            for(int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            myList.RemoveAt(0);
            myList.Insert(0,20);
            myList.Sort();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }


            List<ArrayList> myCollector = new List<ArrayList>();
            myCollector.Add(Array1);
            myCollector.Add(Array2);
            Console.WriteLine("\n\n"+myCollector[0].ToArray().Length);






            //Code for Stack implementation starts here


        }
    }
}
