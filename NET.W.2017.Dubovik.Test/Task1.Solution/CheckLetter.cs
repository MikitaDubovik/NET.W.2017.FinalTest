using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class CheckLetter : IChecker
    {
        public Tuple<bool, string> VerifyPassword(string password)
        {
            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
