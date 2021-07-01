using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Citizenxdisease
    {
        public int Id { get; set; }
        public int? CitizenId { get; set; }
        public int? DiseaseId { get; set; }

        public virtual Citizen Citizen { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
