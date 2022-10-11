﻿using System;
using System.Collections.Generic;
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
        [ForeignKey("Manager")]

        public int ManagerId { get; set; }
        [InverseProperty("manage")]

        public virtual Doctor Manager { get; set; }

        [InverseProperty("WorkDepartment")]
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Room>Rooms { get; set; } 




    }
}
