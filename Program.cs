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

            var t = Math.Round(35.4);

            AddConstructor addConstructor = new AddConstructor();
        }
    }
}