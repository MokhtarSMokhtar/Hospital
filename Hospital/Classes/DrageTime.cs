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
        [Key ,ForeignKey("patient"), Column(Order = 1)]
        public int PatientId { get; set; }
        public DateTime Time { get; set; }
        [Key, ForeignKey("Nurse"), Column(Order = 2)]
        public int NurseId { get; set; }
        public string DrageName { get; set; }
        public virtual Patient patient { get; set; }
        public virtual  Nurse Nurse { get; set; }

    }
}
