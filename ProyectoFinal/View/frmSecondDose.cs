using System;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmSecondDose : Form
    {
        public Employee employee { get; set; }
        public frmSecondDose(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
        }
    }
}