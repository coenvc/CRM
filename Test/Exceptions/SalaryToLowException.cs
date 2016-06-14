using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{ 
    /// <summary>
    /// Deze exceptie wordt meegegeven als het salaris van een werknemer 0 is  
    /// Hietdoor wordt hij omgekast naar een vrijwilliger in de Import methode
    /// </summary>
    class SalaryToLowException : Exception
    {
        public string Message = "Het salaris van de opgegeven betaalde werkenemer is te laag";

       
    }
}
