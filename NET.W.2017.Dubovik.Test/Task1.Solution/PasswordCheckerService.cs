using System;
using System.Linq;
using Task1.Solution;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        public Tuple<bool, string> CreateUser(string password, IRepository repo, params IChecker[] checkers)
        {
            Tuple<bool, string> flag=null;

            foreach (var checker in checkers)
            {
                flag = checker.VerifyPassword(password);
                if (!flag.Item1)
                    return flag;
            }

            repository = repo;
            repository.Create(password);
            return flag ?? new Tuple<bool, string>(false, "Unexpected exception");
        }
    }
}
