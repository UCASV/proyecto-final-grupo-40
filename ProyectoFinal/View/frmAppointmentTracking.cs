using System;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmAppointmentTracking : Form
    {
        public Employee employee { get; set; }
        public frmAppointmentTracking(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            frmLogin window = new frmLogin(employee);
            this.Close();
            window.Show();
        }
    }
}