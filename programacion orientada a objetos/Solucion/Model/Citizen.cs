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
            Citizenxdiseases = new HashSet<Citizenxdisease>();
            InstitutionalIds = new HashSet<InstitutionalId>();
        }

        public int Id { get; set; }
        public string Dui { get; set; }
        public string CitizenName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? Age { get; set; }
        public string InstitutionalId { get; set; }
        public string Mail { get; set; }
        public int? CabinId { get; set; }

        public virtual Cabin Cabin { get; set; }
        public virtual ICollection<AppointmentOne> AppointmentOnes { get; set; }
        public virtual ICollection<AppointmentTwoo> AppointmentTwoos { get; set; }
        public virtual ICollection<Citizenxdisease> Citizenxdiseases { get; set; }
        public virtual ICollection<InstitutionalId> InstitutionalIds { get; set; }
    }
}
