using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Citizen
    {
        public Citizen()
        {
            AppointmentOnes = new HashSet<AppointmentOne>();
            AppointmentTwoos = new HashSet<AppointmentTwoo>();
            Diseases = new HashSet<Disease>();
            InstitutionalIds = new HashSet<InstitutionalId>();
        }

        public int Id { get; set; }
        public string Dui { get; set; }
        public string CitizenName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? Age { get; set; }
        public int? InstitutionalId { get; set; }
        public string Mail { get; set; }
        public int? CabinId { get; set; }

        public virtual Cabin Cabin { get; set; }
        public virtual ICollection<AppointmentOne> AppointmentOnes { get; set; }
        public virtual ICollection<AppointmentTwoo> AppointmentTwoos { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
        public virtual ICollection<InstitutionalId> InstitutionalIds { get; set; }
    }
}
