using System;
using System.Linq;

namespace CsharpCourse.Sections
{
    public class SectionFive
    {
        public class Patient
        {
            public virtual void Examine()
            {
                Console.WriteLine("Patient has been examined...");
            }
            
        }

        public class Adult : Patient
        {
            public override void Examine()
            {
                Console.WriteLine("Adult has been examined...");
            }
        }

        public class ExtensionMethod
        {
            public void Example()
            {
                string x = "Hello";
                string y = "hello";
                
                Console.WriteLine(x + " is cap? " + x.IsCap());
                Console.WriteLine(y + " is cap? " + y.IsCap());
            }
        }
    }
    
    public static class StringCap
    {
        // Extending the string type and adding IsCap to it
        public static bool IsCap(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s.First());
        }
    }
}