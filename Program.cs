using System;
using System.Collections.Generic;
using CsharpCourse.Sections;

namespace CsharpCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SectionThree sectionThree = new SectionThree();
            int test = sectionThree.GetSeniority();
            Console.WriteLine(test);

            Person person = new Person {Age = 19, Weight = 23};
            Console.WriteLine("Age: " + person.Age);

            AddConstructor addConstructor = new AddConstructor();

            StructExample structExample2 = new StructExample(6, 7);
            StructExample structExample;
            structExample.x = 6;
            structExample.y = 7;
            structExample.DoThis();
        }
    }
}