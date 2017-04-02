using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.EntityLayer
{
    public class Diagnosis
    {
        public string PatientId { get; set; }
        public string Symptoms { get; set; }
        public string DiagnosisProvided { get; set; }
        public string AdministeredBy { get; set; }
        public string DateOfDiagnosis { get; set; }
        public char FollowUp { get; set; }
        public string DateOfFollowUp { get; set; }

    }
}
