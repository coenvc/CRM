using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Charity:Employee, IEmployee
    {
        public string SirName { get; private set; }
        public string FirstName { get; private set; }
        public string Department { get; private set; } 
        public string Profilepath { get; private set; } 
        public string AboutMe { get; private set; }

        public Charity(string firstname, string sirname, string department,string profilepath,string aboutme):base(firstname,sirname,department,profilepath,aboutme)
        {
            this.FirstName = firstname;
            this.SirName = sirname;
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
