using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfBeds { get; set; }

        public string Type { get; set; }
        public Department Department { get; set; }
        [Required]
        public virtual Nurse Manager { get; set; }

        public virtual ICollection<Nurse> Nurses { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

    }
}

