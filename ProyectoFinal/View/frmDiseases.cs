using System.Windows.Forms;
using System;

namespace ProyectoFinal.View
{
    public partial class frmDiseases : Form
    {
        public Citizen citizen { get; set; }
        public frmDiseases(Citizen citizen)
        {
            InitializeComponent();
            this.citizen = citizen;
        }
    }
}