using System;
using System.IO;

namespace CsharpCourse.Sections
{
    public class SectionThree
    {
        // Fields defined here are called Instance fields
        private string _test = String.Empty;
        
        // public property exposes _test field safely
        public string Test
        {
            get => _test;
            set
            {
                if (value.Contains("kit"))
                {
                    _test = value;
                }
                else
                {
                    throw new InvalidDataException();
                }
            }
        }
        
        public Employee GetEmployee()
        {
            Employee employee = new Employee()
            {
                FirstName = "Kit",
                LastName = "Thornton",
                Seniority = 1
            };
            
            return employee;
        }
        
        // Here we'll explore briefly value and reference types
        // Here the seniority of test will be returned as 2. Learn.
        public int GetSeniority()
        {
            Employee test = GetEmployee();
            Employee test2 = test;
            test2.Seniority = 2;
            
            return test.Seniority;
        }
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