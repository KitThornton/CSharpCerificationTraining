using System;

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
    }
}