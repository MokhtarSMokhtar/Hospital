using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class Nurse
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public int Age { get; set; }

        public Gender gender { get; set; }
        public  ICollection<MedicineTime> medicineTimes { get; set; }
        public Room Room { get; set; }



    }
}
