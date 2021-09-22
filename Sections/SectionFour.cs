using System;

namespace CsharpCourse.Sections
{
    public class SectionFour
    {
        
    }

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
}