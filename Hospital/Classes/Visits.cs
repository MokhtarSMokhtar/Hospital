using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class Visits
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }

        public DateTime Date { get; set; }
       public virtual ICollection<Patient> patients { get; set; }


    }
}
