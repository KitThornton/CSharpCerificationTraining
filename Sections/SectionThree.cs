using System;

namespace CsharpCourse.Sections
{
    public class SectionThree
    {
        
    }


    public class Employee
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Seniority { get; set; }

        public string Promote()
        {
            return "Employee has been promoted";
        }

        public string AnnualReview()
        {
            return "Annual review done...";
        }
    }
}