using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Employee
    {
        public Employee()
        {
            AppointmentOnes = new HashSet<AppointmentOne>();
            AppointmentTwoos = new HashSet<AppointmentTwoo>();
            Employeexcabins = new HashSet<Employeexcabin>();
        }

        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string InstitutionalMail { get; set; }
        public string Direction { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeUser { get; set; }
        public string EmployeePassword { get; set; }

        public virtual ICollection<AppointmentOne> AppointmentOnes { get; set; }
        public virtual ICollection<AppointmentTwoo> AppointmentTwoos { get; set; }
        public virtual ICollection<Employeexcabin> Employeexcabins { get; set; }
    }
}
