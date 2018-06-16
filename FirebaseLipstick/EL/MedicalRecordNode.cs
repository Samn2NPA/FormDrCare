using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseLipstick.EL
{
    class MedicalRecordNode
    {
        public String MedRecKey { get; set; }

        public MedicalRecord medicalRecord { get; set; }

        public MedicalRecordNode(String key, MedicalRecord record)
        {
            this.MedRecKey = key;
            this.medicalRecord = record;
        }
    }
}
