using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class AppointmentOne
    {
        public int Id { get; set; }
        public DateTime? DateAppointment { get; set; }
        public string Place { get; set; }
        public DateTime? RowDate { get; set; }
        public DateTime? VaccinationDate { get; set; }
        public TimeSpan? SideEffectTime { get; set; }
        public int? EmployeeId { get; set; }
        public int? CitizenId { get; set; }

        public virtual Citizen Citizen { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
