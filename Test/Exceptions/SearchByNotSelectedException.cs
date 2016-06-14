using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exceptions
{
    public  class SearchByNotSelectedException:Exception
    { 
        /// <summary>
        /// This exception is thrown when a user doesn't specify 
        /// if he wants to search a user by first or last name 
        /// </summary>
        public  string Message = "Er is niet geselcteerd of er op voor of achternaam gezocht moet worden";
    }
}
