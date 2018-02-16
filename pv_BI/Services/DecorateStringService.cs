using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pv_BI.Interfaces;

namespace pv_BI.Services
{
    public class DecorateStringService : IDecorateStringService
    {
        private readonly IPatientRegistrationService _patientRegistrationService;
        public DecorateStringService(IPatientRegistrationService patientRegistrationService)
        {
            _patientRegistrationService = patientRegistrationService;
        }
        public string Formater(IEnumerable<string> elements)
        {
            return String.Join(System.Environment.NewLine, elements);
        }
    }
}
