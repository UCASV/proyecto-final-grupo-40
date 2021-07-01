using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal.View
{
    public partial class frmVaccination : Form
    {
        public Employee employee { get; set; }
        public frmVaccination(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var bd = new CabinContext();
            var citizens = bd.Citizens.ToList();
            var exist = citizens.Where(c => c.Dui == txtDui.Text).ToList();
            var appointmentOnes = bd.AppointmentOnes.ToList();
            var appointments = appointmentOnes
                .Where(a =>  a.Id == a.CitizenId)
                .OrderBy(a => a.CitizenId).ToList();
            
            if (exist.Count() > 0 && appointmentOnes.Count() > 0)
            {
                
                MessageBox.Show("Vacunacion exitosa!", "Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSecondDose secondDose = new frmSecondDose(employee);
                this.Close();
                secondDose.Show();
            }
            else 
                MessageBox.Show("No se encuentra el dui!", "Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}