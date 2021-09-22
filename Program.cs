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
            
            SectionFour.Person person = new SectionFour.Person();
            person.Age = 19;
            person.Weight = 23;
            
            Console.WriteLine("Age: " + person.Age);

        }
    }
}