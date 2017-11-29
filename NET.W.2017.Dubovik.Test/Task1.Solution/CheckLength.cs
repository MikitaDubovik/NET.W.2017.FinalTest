﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class CheckLength : IChecker
    {
        public Tuple<bool, string> VerifyPassword(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
