using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Employee
    {
        public string FirstName { get; private set; }
        public string SirName { get; private set; }
        public string Department { get; private set; } 
        public string Profilepath { get; private set; } 
        public string AboutMe { get; private set; }

        public Employee(string firstName, string sirName, string department,string profilepath,string aboutme)
        {
            this.FirstName = firstName;
            this.SirName = sirName; 
            this.Department = department;
            this.Profilepath = profilepath;
            this.AboutMe = aboutme;
        }

        public override string ToString()
        {
            return $"Name : {FirstName} {SirName} Department : {Department}";
        }  

    }
}
