using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pv_BI.Interfaces
{
    public interface IPatientDiagnoseService
    {
        IEnumerable<string> Replace(IEnumerable<int> values);
    }
}
