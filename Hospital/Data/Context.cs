﻿using Hospital.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Context : DbContext
    {

        public Context() : base(@"Data source =.; initial catalog =Hospital; integrated security = true;")
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet <Nurse> Nurses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Visits>  Visits { get; set; }
        public DbSet<PatientVisitors> PatientVisitors { get; set; }
        public DbSet<DrageTime> DrageTimes { get; set; }

    }
}
