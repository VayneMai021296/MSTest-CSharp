using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Utilities;

namespace TestProject1.Validator
{
    [TestClass]
    public class EmailValidatorTest : TestBase
    {
        [TestInitialize]
        public void TestInit()
        {
            _emailValidator = new EmailValidator();
        }
        [TestMethod]
        [Owner("Mai Trung Kien")]
            

        public void TestEmailValidator()
        {
            var result = _emailValidator.IsValid("maitrungkien1296@gmail.com");
            Assert.IsTrue(result);
        }
    }
}
