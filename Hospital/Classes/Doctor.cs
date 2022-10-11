using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{

   
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string Spacial { get; set; }
        public int Phone { get; set; }

        public int Age { get; set; }

        public Gender gender { get; set; }

        [ForeignKey ("WorkDepartment")]
        public int DepartmentId { get; set; }
        [ForeignKey("manage")]

        public int MangeDepartment { get; set; }
        public virtual ICollection<Patient> patients { get; set; }
        [InverseProperty("Doctors")]

        public virtual Department WorkDepartment { get; set; }
        [InverseProperty("Manager")]

        public virtual Department manage { get; set; }



    }
}
