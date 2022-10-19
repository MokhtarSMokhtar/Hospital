using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class DrageTime
    {
        [Key]   
        public int ID { get; set; } 
        [ForeignKey("patient")]
        public int PatientId { get; set; }
        public DateTime Time { get; set; }
        [ ForeignKey("Nurse")]

        public int NurseId { get; set; }
        public string DrageName { get; set; }
        public Shift Shift { get; set; }
        public virtual Patient patient { get; set; }
        public virtual Nurse Nurse { get; set; }

    }
}
