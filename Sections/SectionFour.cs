using System;
using System.Collections;
using System.Collections.Generic;

namespace CsharpCourse.Sections
{
    public class SectionFour
    {

        public class Person
        {
            // private field
            private int _age;
            private int _weight;

            // properties
            public int Weight
            {
                get => _weight;
                set => _weight = value;
            }

            public int Age
            {
                get => _age;
                set
                {
                    if (value > 0 && value < 65)
                    {
                        _age = value;
                    }
                    else
                    {
                        throw new Exception("Age cannot be over 65 ...");
                    }
                }
            }
        }

        public class AddConstructor
        {
            // Same name, this is the constructor
            public AddConstructor()
            {
                Console.WriteLine("The constructor has been called");
                DoThat();
            }

            public void DoThat()
            {
                Console.WriteLine("DoThat has been called");
            }
        }

        public struct StructExample
        {
            public int x;
            public int y;

            // Cannot use a default constructor, must have params
            public StructExample(int a, int b)
            {
                x = a;
                y = b;
            }

            public void DoThis()
            {
                Console.WriteLine(x+y);
            }

        }

        public class GenericTypes
        {
            public void GenericTypesExample()
            {
                // Non-generic list
                ArrayList list1 = new ArrayList();
                list1.Add(1);
                list1.Add(3);
                list1.Add(5);

                foreach (int x in list1)
                {
                    Console.WriteLine(x);
                }
                
                // Generic list
                List<int> list2 = new List<int>();
                list2.Add(2);
                list2.Add(4);
                list2.Add(6);

                foreach (int x in list2)
                {
                    Console.WriteLine(x);
                }
            }
        }

        /// <summary>
        /// This is for the Indexers chapter
        /// </summary>
        public class Car
        {
            string[] car = new string[40];

            public string this[int carNum]
            {
                get
                {
                    if (carNum >= 0 && carNum < car.Length)
                    {
                        return car[carNum];
                    }

                    return "Out of index range...";
                }

                set
                {
                    if (carNum >= 0 && carNum < car.Length)
                    {
                        car[carNum] = value;
                    }
                }
            }
        }
    }
}