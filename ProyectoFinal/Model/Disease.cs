using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Disease
    {
        public Disease()
        {
            Citizenxdiseases = new HashSet<Citizenxdisease>();
        }

        public int Id { get; set; }
        public string DiseaseaName { get; set; }

        public virtual ICollection<Citizenxdisease> Citizenxdiseases { get; set; }
    }
}
