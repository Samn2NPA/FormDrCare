using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseLipstick.EL
{
    class MedicalRecord
    {
        public String Key { get; set; }

        public int Stt { get; set; }

        ///for STATUS of Medical Record -- DOCTOR
        public int isTaken { get; set; }

        public String DoctorKey { get; set; }
        public String PatientKey { get; set; }

        public String DoctorName { get; set; }
        public String PatientName { get; set; }

        public String DiseaseName { get; set; }
        public String DayCreated { get; set; }
        public String medRecNote { get; set; }
    }
}
