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
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfBeds { get; set; }
        [ForeignKey("Manager")]
        public int ManagerID { get; set; }
        public string Type { get; set; }    
        public Department Department  { get; set; }
        [InverseProperty("manage")]
        public virtual Nurse Manager { get; set; }

        [InverseProperty("Room")]
        public virtual ICollection<Nurse> Nurses { get; set; }



    }
}
