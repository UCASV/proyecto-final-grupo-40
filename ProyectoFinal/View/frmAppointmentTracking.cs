using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoFinal.View
{
    public partial class frmAppointmentTracking : Form
    {
        public Employee employee { get; set; }
        public Citizen citizen { get; set; }

        public frmAppointmentTracking(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.citizen = citizen;
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            frmLogin window = new frmLogin(employee);
            this.Close();
            window.Show();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            var db = new CabinContext();
            var citizens = db.Citizens.ToList();
            var exist = citizens.Where(c => c.Dui == txtDui.Text).ToList();
            var appointmentOnes = db.AppointmentOnes.ToList();
            var appointments = appointmentOnes
                .Where(a => a.DateAppointment == DateTime.Today && a.Citizen.Dui == txtDui.Text)
                .OrderBy(a => a.DateAppointment).ToList();
            if (exist.Count() > 0 && appointmentOnes.Count() > 0)
            {
                exist.ForEach(ex => txtDui.Text = ex.Dui.ToString());
                MessageBox.Show($"El ciudadano tiene una cita registrada", "seguimiento de citas",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El cuidadano no posee una cita registrada", "seguimiento de citas",
                    MessageBoxButtons.OK);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmEmployeeCabin Continue = new frmEmployeeCabin(employee);
            Continue.Show();
        }

        private void btnPdf2_Click(object sender, EventArgs e)
        {
            
        }
    }
}