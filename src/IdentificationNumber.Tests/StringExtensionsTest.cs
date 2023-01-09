using IdentificationNumber.Models;
using IdentificationNumber.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificationNumber.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        [DataRow("194106279161")]
        [DataRow("195003072260")]
        public void ToIdentificationNumber_ConvertStringToPersonIdentificationNumber_ReturnsTrue(string value)
        {
            var pin = value.ToIdentificationNumber<PersonIdentificationNumber>();

            Assert.IsTrue(pin.IsValid);
        }

        [TestMethod]
        [DataRow("2120000142")]
        [DataRow("212000-0142")]
        public void ToIdentificationNumber_ConvertStringToBusinessIdentificationNumber_ReturnsTrue(string value)
        {
            var pin = value.ToIdentificationNumber<BusinessRegistrationNumber>();

            Assert.IsTrue(pin.IsValid);
        }

        [TestMethod]
        [DataRow("194106279161")]
        [DataRow("556703-7485")]
        public void ToIdentificationNumber_ConvertStringToIIdentificationNumber_IsValid(string value)
        {
            var pin = value.ToIdentificationNumber();

            Assert.IsTrue(pin.IsValid);
        }

    }
}
