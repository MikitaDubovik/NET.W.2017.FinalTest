using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class CheckTest
    {
        private readonly Mock<PasswordCheckerService> passwordChecker = new Mock<PasswordCheckerService>();
        private readonly Mock<IRepository> repository = new Mock<IRepository>();

        [Test]
        public void CheckLengthTest()
        {
            var checkLength = new Mock<CheckLength>();
            Tuple<bool,string> temp=passwordChecker.Object.CreateUser("pass", repository.Object, checkLength.Object);
            Assert.AreEqual(Tuple.Create(false, $"pass length too short"), temp);
        }

        [Test]
        public void CheckLetterTest()
        {
            var checkLength = new Mock<CheckLetter>();
            Tuple<bool, string> temp = passwordChecker.Object.CreateUser("password", repository.Object, checkLength.Object);
            Assert.AreEqual(Tuple.Create(true, "Password is Ok. User was created"), temp);
        }

        [Test]
        public void CheckNullEmptyTest()
        {
            var checkLength = new Mock<CheckNullEmpty>();
            Tuple<bool, string> temp = passwordChecker.Object.CreateUser(string.Empty, repository.Object, checkLength.Object);
            Assert.AreEqual(Tuple.Create(false, "Password is empty"), temp);
        }

        [Test]
        public void CheckNumberTest()
        {
            var checkLength = new Mock<CheckNumber>();
            Tuple<bool, string> temp = passwordChecker.Object.CreateUser("no digit", repository.Object, checkLength.Object);
            Assert.AreEqual(Tuple.Create(false, "no digit hasn't digits"), temp);
        }
    }
}
