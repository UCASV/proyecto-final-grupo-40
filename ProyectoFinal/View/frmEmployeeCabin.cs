using System;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmEmployeeCabin : Form
    {
        public Employee employee { get; set; }
        public frmEmployeeCabin(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void frmEmployeeCabin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLogin window2 = new frmLogin(employee);
            window2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmAppointmentTracking check = new frmAppointmentTracking(employee);
            check.Show();
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            frmVaccination windows = new frmVaccination(employee);
            windows.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWaitingRoom waitingRoom = new frmWaitingRoom(employee);
            waitingRoom.Show();
        }
    }
}