using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using pv_BI.Interfaces;
using pv_BI.Services;

namespace pv_Tests.Tests
{
    public class PatientRegisterServiceTests
    {

        private Mock<PatientRegistrationService> _mockPatientRegistrationService;

        [SetUp]
        public void Setup()
        {
            _mockPatientRegistrationService = new Mock<PatientRegistrationService>();

        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "Register")]
        [TestCase(5, ExpectedResult = "Patient")]
        [TestCase(15, ExpectedResult = "Register Patient")]
        public string ReplaceTests(int input)
        {
            var inputList = new List<int>(){input};
            return _mockPatientRegistrationService.Object.Replace(inputList).FirstOrDefault();
        }
    }
}
