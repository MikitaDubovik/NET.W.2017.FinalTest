using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repo=new SqlRepository();

            var checkers = new IChecker[] {new CheckLength(), new CheckLetter(), new CheckNullEmpty()};

            PasswordCheckerService passwordChecker = new PasswordCheckerService();

            System.Console.WriteLine(passwordChecker.CreateUser("kjhadfkjaskj", repo, checkers));

            System.Console.ReadKey();

        }
    }
}
