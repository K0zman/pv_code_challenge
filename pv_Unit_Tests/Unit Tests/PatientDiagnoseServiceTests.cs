using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using pv_BI.Services;

namespace pv_Tests.Unit_Tests
{
    public class PatientDiagnoseServiceTests
    {
        private Mock<PatientDiagnoseService> _mockPatientDiagnoseService;

        [SetUp]
        public void Setup()
        {
            _mockPatientDiagnoseService = new Mock<PatientDiagnoseService>();

        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "Diagnose")]
        [TestCase(7, ExpectedResult = "Patient")]
        [TestCase(14, ExpectedResult = "Diagnose Patient")]
        public string ReplaceTests(int input)
        {
            var inputList = new List<int>() { input };
            return _mockPatientDiagnoseService.Object.Replace(inputList).FirstOrDefault();
        }
    }
}
