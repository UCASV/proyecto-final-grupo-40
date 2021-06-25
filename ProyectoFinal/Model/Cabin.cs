using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Cabin
    {
        public Cabin()
        {
            Citizens = new HashSet<Citizen>();
            Employeexcabins = new HashSet<Employeexcabin>();
        }

        public int Id { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }
        public string ManagerName { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Employeexcabin> Employeexcabins { get; set; }
    }
}
