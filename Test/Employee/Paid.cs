using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Paid : Employee, IEmployee, IComparable<Paid>
    { 
        public string Lastname { get; private set; } 
        public string Firstname { get; private set; } 
        public string Department { get; private set; } 
        public decimal Salary { get; private set; } 
        public string Profilepath { get; private set; } 
        public string AboutMe { get; private set; }

        public Paid(string firstname, string sirname, string department, decimal salary,string profilepath,string aboutme):base(firstname,sirname,department,profilepath,aboutme)
        {
            this.Firstname = firstname;
            this.Lastname = sirname;
            this.Department = department;
            this.Salary = salary; 
            this.Profilepath = profilepath;
            this.AboutMe = aboutme;
        }

        public int CompareTo(Paid other)
        {
            if (this.Salary == other.Salary)
            {
                if (this.Firstname == other.Lastname)
                {
                    return this.Firstname.CompareTo(other.Firstname);
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
            return $"Name: {Firstname} {Lastname} Department: {Department} Salary: {Salary} Euro";
        }
    }
}
