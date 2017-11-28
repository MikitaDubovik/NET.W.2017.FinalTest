using System;
using System.Linq;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        public Tuple<bool, string> CreateUser(string password, IRepository repo)
        {
            Tuple<bool, string> flag = VerifyPassword(password);

            if (flag.Item1)
            {
                repository = repo;
                repository.Create(password);
                return flag;
            }

            return flag;
        }

        private Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
