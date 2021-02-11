using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

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

            for (int i = 0; i < Array1.Count; i++)
            {
                Console.WriteLine("Value from {0} index ", i);
                Console.WriteLine(Array1[i]);
            }
            Console.WriteLine("\n Ended The array List Now moving towards next Collection \n\n\n");


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Code for Sorted List (Non generic)
            Console.WriteLine("From Sorted List Nongeneric");
            int j = 0;
            SortedList myNames = new SortedList();
            myNames.Add(j, a);
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
                Console.WriteLine("{0} {1}", variable.Key, variable.Value);
            }




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                Console.WriteLine("The value against key {0} is {1}", variable.Key, variable.Value);
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




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Code for Dictionary implementation starts here
            Console.WriteLine("\n\n\n From Dictionary");

            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict.Add('a', "Ali");
            dict.Add('b', "Batman");
            dict.Add('c', "Cat");
            dict.Add('d', "Dog");
            dict.Add('e', "Elephant");
            dict.Add('f', "Frog");
            foreach (Object obj in dict)
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
            foreach (KeyValuePair<char, string> obj in dict)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }



            //Code for HashTable implementation starts here
            Console.WriteLine("\n\n\n From Hashtable");

            Hashtable hash = new Hashtable();
            hash.Add(1, a);
            hash.Add('a', b);
            hash.Add('b', b);
            hash.Add('d', b);
            foreach (DictionaryEntry obj in hash)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Code for List implementation starts here
            Console.WriteLine("\n\n\n From List generic");

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(21);
            myList.Add(2);
            myList.Add(0);
            myList.Sort();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            myList.RemoveAt(0);
            myList.Insert(0, 20);
            myList.Sort();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }


            List<ArrayList> myCollector = new List<ArrayList>();
            myCollector.Add(Array1);
            myCollector.Add(Array2);
            Console.WriteLine("\n\n" + myCollector[0].ToArray().Length);


            //Adding dummy student data into the list of students


            int age;
            float cgpa;
            string name;
            string email;
            string address;
            string contactNumber;
            List<StudentInfo> myClass = new List<StudentInfo>();
            StudentInfo bacs = new StudentInfo();
            myClass.Add(bacs);
            myClass.Add(bacs);
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine("Write the age of {0} student", i + 1);
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the cgpa of {0} student", i + 1);
                cgpa = float.Parse(Console.ReadLine());
                Console.WriteLine("Write the name of {0} student", i + 1);
                name = Console.ReadLine();
                Console.WriteLine("Write the email of {0} student", i + 1);
                email = Console.ReadLine();
                Console.WriteLine("Write the address of {0} student", i + 1);
                address = Console.ReadLine();
                Console.WriteLine("Write the contactNumber of {0} student", i + 1);
                contactNumber = Console.ReadLine();

                myClass.Add(new StudentInfo(age, cgpa, name, email, address, contactNumber));
            }
            foreach (StudentInfo s in myClass)
                if (s.AGE >= 18)
                {
                    Console.WriteLine("The student details are as follow");
                    Console.WriteLine("The Name of the student is {0}", s.NAME);
                    Console.WriteLine("The Age of the student is {0}", s.AGE);
                    Console.WriteLine("The Cgpa of the student is {0}", s.CGPA);
                    Console.WriteLine("The Email of the student is {0}", s.EMAIL);
                    Console.WriteLine("The Address of the student is {0}", s.ADDRESS);
                    Console.WriteLine("The Contact Number of the student is {0}", s.CONTACTNUMBER);

                }
            var results = from StudentInfo in myClass
                          where StudentInfo.AGE >= 12
                          select StudentInfo;
            Console.WriteLine("Student with age greater then 12 are as follow");
            
            foreach( StudentInfo s in results)
            {
                Console.WriteLine(s.AGE);
            }
            /*
            myClass.Select(x=>new object { name=x.Total})

            var results = from s in myClass
                          select s;

               foreach(StudentInfo info in myClass)
                {
            Console.WriteLine(results[0]);*/


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            //Code for Stack implementation starts here
            Console.WriteLine("\n\n\n Implementation of Stack starts from here \n");
            Stack<int> myStack = new Stack<int>(f);
            
            
            Console.WriteLine("\nStack after entering values using array \n");
            foreach (int variable in myStack)
            {
                Console.Write(variable + ",");
            }
            Console.WriteLine();
            
            
            Console.WriteLine("\nStack after entering Value using push \n");
            myStack.Push(20);
            foreach (int variable in myStack)
            {
                Console.Write(variable + ",");
            }


            Console.WriteLine("\nStack after Peeking from it \n");
            Console.WriteLine(myStack.Peek());
            foreach (int variable in myStack)
            {
                Console.Write(variable + ",");
            }
            
            
            Console.WriteLine("\nStack after popping element from it \n");
            Console.WriteLine(myStack.Pop());
            foreach (int variable in myStack)
            {
                Console.Write(variable + ",");
            }
            Console.WriteLine();
            int check=24;
            if (myStack.Contains(check))
            {
                Console.WriteLine("true the stack contains the value {0}", check);
            }
            else
            {
                Console.WriteLine("False the stack doesnot contains the value {0}", check);

            }


            //Iplementation of queue starts from here
            Queue<int> myQueue = new Queue<int>(f);
            Console.WriteLine("\nQueue after entering values from array");
            foreach (int variable in myQueue)
            {
                Console.Write(variable + ",");
            }

            myQueue.Enqueue(20);
            Console.WriteLine("\n\nQueue after using enqueue");
            foreach (int variable in myQueue)
            {
                Console.Write(variable + ",");
            }



            Console.WriteLine("\n\nQueue after Dequeue method");
            Console.WriteLine("The value returned from the dequeue method is "+ myQueue.Dequeue());
            foreach (int variable in myQueue)
            {
                Console.Write(variable + ",");
            }


            Console.WriteLine("\n\nPrinting the count of elements in the queue \n"+ myQueue.Count());
            
            Console.WriteLine("\nQueue after Peeking from it");
            Console.WriteLine("Value returned from peek method is "+myQueue.Peek());
            foreach (int variable in myQueue)
            {
                Console.Write(variable + ",");
            }

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            //File Hanlding
            string path1 = @"C:\Users\Lenovo\source\repos\Collections\Collections\bin\Debug\netcoreapp3.1/DummyData1.txt";
            string path2 = @"C:\Users\Lenovo\source\repos\Collections\Collections\bin\Debug\netcoreapp3.1/DummyData2.txt";
            string path3 = @"C:\Users\Lenovo\source\repos\Collections\Collections\bin\Debug\netcoreapp3.1/DummyData3.txt";

            string Abc = "Hello from the file1";
            string Abcd = "Hello from the file2";
            
            /*File.WriteAllText(path1,Abc);
            File.WriteAllText(path2, Abcd);
            */
            string DataRead =File.ReadAllText(path1);
            Console.WriteLine(DataRead);

            //This block is used to to auto close the file after the use
            //the file will open at the start of the using block and
            //At the end of the block the file is automatically closed.
            
            /*using (StreamWriter sw = File.AppendText(path1))
            {
                sw.WriteLine("\nHello once again using Stream Writer");
            }

            using (StreamReader sr = File.OpenText(path2))
            {
                string readed = "";
                while ((readed = sr.ReadLine()) != null)
                {
                    Console.WriteLine(readed);
                }
            } */

            DataRead = File.ReadAllText(path1);
            Console.WriteLine("\n\n"+DataRead+"\n\n");
            
            DataRead = File.ReadAllText(path2);
            Console.WriteLine("\n\n" + DataRead + "\n\n");


            /*FileStream file = new FileStream(path3, FileMode.OpenOrCreate , FileAccess.ReadWrite);
            //file.Write("Hello")
            file.WriteByte(66); 
            file.Close();
*/
            using (FileStream file1 = new FileStream(path3, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(file1,Encoding.UTF8))
                {
                    int[] arrays = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    foreach(int num in arrays)
                    {
                        sw.Write(num + " ");
                    }

                    sw.WriteLine("\nHelpppp");
                }
            }


            using (FileStream file1 = new FileStream(path3, FileMode.Open, FileAccess.Read ))
            {
                using (StreamReader sr = new StreamReader(file1))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }

                }
            }



            //Exception Handling Code
            int[] except = new int[3] { 1, 2, 3 };
            try
            {
                Console.WriteLine(except[10]);
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("The try catch Block has ended");
            }

            /*using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {
                using(StreamWriter stw = new StreamWriter(fs))
                {

                }

                using(StreamReader str = new StreamReader(fs))
                {

                }

            }*/

            //Manipulating the tuples in the form of an array
            Tuple<int,float,double ,char,string>[] studentTuples = new Tuple< int, float, double, char, string>[2];
            for(int i = 0; i < 2; i++)
            {
                studentTuples[i] = new Tuple<int, float, double, char, string>(1, 2.2f, 3.3, 'a', "abcd");
            }


            foreach(Tuple<int, float, double, char, string> tp in studentTuples)
            {
                Console.Write(tp.Item1 +" , ");
                Console.Write(tp.Item2 + " , ");
                Console.Write(tp.Item3 + " , ");
                Console.Write(tp.Item4 + " , ");
                Console.WriteLine(tp.Item5);

            }

        }
    }
}
