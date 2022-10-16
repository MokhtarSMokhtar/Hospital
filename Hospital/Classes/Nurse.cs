using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public enum Shift
    {
        Am ,
        Pm
    }
  
    public class Nurse
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }
        public Shift shift { get; set; }

        public int Age { get; set; }
        [ForeignKey("Room")]

        public int? RoomId { get; set; }
        [ForeignKey("ManagerRoom")]

        public int? RoomManageId { get; set; }
        
        public Gender gender { get; set; }
        public ICollection<DrageTime> medicineTimes { get; set; }

        [InverseProperty("Manager")]
        public virtual Room ManagerRoom { get; set; }

        [InverseProperty("Nurses")]
        public virtual Room Room { get; set; }

    }
}