﻿using System;
using System.Collections.Generic;
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
        public string Type { get; set; }    
        public Department Department  { get; set; }
        public Nurse Manager { get; set; }
       public virtual ICollection<Nurse> Nurses { get; set; }



    }
}