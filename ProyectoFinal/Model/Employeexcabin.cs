using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Employeexcabin
    {
        public int Id { get; set; }
        public int? CabinId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }

        public virtual Cabin Cabin { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
