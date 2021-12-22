using System;
using System.Collections.Generic;
using CsharpCourse.Sections;

namespace CsharpCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region SectionThree
            // SectionThree sectionThree = new SectionThree();
            // int test = sectionThree.GetSeniority();
            // Console.WriteLine(test);
            #endregion

            #region SectionFour
            /*SectionFour.Person person = new SectionFour.Person {Age = 19, Weight = 23};
            Console.WriteLine("Age: " + person.Age);
            
            SectionFour.AddConstructor addConstructor = new SectionFour.AddConstructor();
            
            SectionFour.StructExample structExample2 = new SectionFour.StructExample(6, 7);
            SectionFour.StructExample structExample;
            structExample.x = 6;
            structExample.y = 7;
            structExample.DoThis();*/

            SectionFour.GenericTypes genericTypes = new SectionFour.GenericTypes();
            genericTypes.GenericTypesExample();
            
            #endregion
        }
    }
}