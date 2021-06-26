using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Disease
    {
        public int Id { get; set; }
        public string DiseaseaName { get; set; }
        public int? CitizenId { get; set; }

        public virtual Citizen Citizen { get; set; }
    }
}
