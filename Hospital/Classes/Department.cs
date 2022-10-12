using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //[ForeignKey("Manager")]

        //public Nullable<int> DoctorManageId { get; set; }


        public virtual ICollection<Room>Rooms { get; set; }
        [Required]

        public virtual Doctor Manager { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }



    }
}
