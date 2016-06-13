using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Paid : Employee, IEmployee, IComparable<Paid>
    { 
        public string SirName { get; private set; } 
        public string FirstName { get; private set; } 
        public string Department { get; private set; } 
        public decimal Salary { get; private set; } 
        public string Profilepath { get; private set; } 
        public string AboutMe { get; private set; }

        public Paid(string firstname, string sirname, string department, decimal salary,string profilepath,string aboutme):base(firstname,sirname,department,profilepath,aboutme)
        {
            this.FirstName = firstname;
            this.SirName = sirname;
            this.Department = department;
            this.Salary = salary; 
            this.Profilepath = profilepath;
            this.AboutMe = aboutme;
        }

        public int CompareTo(Paid other)
        {
            if (this.Salary == other.Salary)
            {
                if (this.SirName == other.SirName)
                {
                    return this.FirstName.CompareTo(other.FirstName);
                }


            } 
            if (this.Salary < other.Salary)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {SirName} Department: {Department} Salary: {Salary} Euro";
        }
    }
}
