using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pv_BI.Interfaces;

namespace pv_BI.Services
{
    public class PatientRegistrationService : IPatientRegistrationService
    {
        public IEnumerable<string> Replace(IEnumerable<int> values)
        {
            var valueList = values.ToList();
            return valueList.Select(x =>
            {
                string formatedString = string.Empty;

                if (x%3 == 0 || x%5 == 0)
                {
                    if (x%3 == 0)
                    {
                        formatedString = "Register";
                    }
                    if (x%5 == 0)
                    {
                        formatedString += formatedString == string.Empty ? "Patient" : " Patient";
                    }
                    return formatedString;
                }
                return x.ToString();
            });
        }
    }
}
