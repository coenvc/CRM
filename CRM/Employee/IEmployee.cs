using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{ 
    /// <summary>
    /// De IEmpoyee interface zorgt ervoor dat er gemakkeijk zowel vrijwilligers 
    /// als betaalde werknemers toegevoegd kunnen worden  
    /// TODO: Over mij toevoegen 
    /// </summary>
    public  interface IEmployee
    { 
         string FirstName { get; } 
         string SirName { get; }  
         string Department { get; } 
         string Profilepath { get; } 
        string AboutMe { get;}
    }
}
