using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public string Case { get; set; }
        public Gender gender { get; set; }

        public ICollection<Doctor> Doctors { get; set; }

        public virtual ICollection<DrageTime> medicineTimes { get; set; }

        public virtual ICollection<PatientVisitors> Visitors { get; set; }



    }
}
