using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class PatientVisitors
    {
        public DateTime Date { get; set; }
        [Key,ForeignKey("Patient") , Column(Order = 1)]
        public int PatientId { get; set; }
        [Key,ForeignKey("Visits") , Column(Order =21)]
        public int VisitorId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Visits Visits { get; set; }  

    }
}
