using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class InstitutionalId
    {
        public int Id { get; set; }
        public string Identificator { get; set; }
        public int? CitizenId { get; set; }

        public virtual Citizen Citizen { get; set; }
    }
}
