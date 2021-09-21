using System;
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
        }
    }
}