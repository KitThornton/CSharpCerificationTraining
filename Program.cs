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
            
            // Create a collection that is a list of strings
            var dogs = new List<string> {"Sausage", "Aussie Shepherd"};
            dogs.ForEach(Console.WriteLine);
            
            // Create an array
            int[] a1 = new[] { 1, 3, 5, 7, 9, 11 };
            foreach (int i in a1)
            {
                Console.WriteLine(i);
            }
        }
    }
}