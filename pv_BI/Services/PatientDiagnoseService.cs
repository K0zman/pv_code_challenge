using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pv_BI.Interfaces;

namespace pv_BI.Services
{
    public class PatientDiagnoseService : IPatientDiagnoseService
    {
        public IEnumerable<string> Replace(IEnumerable<int> values)
        {
            return values.Select(x =>
            {
                string formatedString = string.Empty;

                if (x % 2 == 0 || x % 7 == 0)
                {
                    if (x % 2 == 0)
                    {
                        formatedString = "Diagnose";
                    }
                    if (x % 7 == 0)
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
