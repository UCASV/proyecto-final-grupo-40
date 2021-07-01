using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.View
{
    public partial class frmWaitingRoom : Form
    {
        public Employee employee { get; set; }
        public frmWaitingRoom(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            DateTime RsDay = dtpDate.Value.Date + dtpHours.Value.TimeOfDay;
            
            var bd = new CabinContext();
            var citizens = bd.Citizens.ToList();
            var exist = citizens.Where(c => c.Dui == txtDui.Text).ToList();
            var appointmentOnes = bd.AppointmentOnes.ToList();
            var appointments = appointmentOnes
                .Where(a =>  a.Id == a.CitizenId)
                .OrderBy(a => a.CitizenId).ToList();
            
            if (exist.Count() > 0 && appointmentOnes.Count() > 0)
            {
                AppointmentOne res = (from vare in bd.AppointmentOnes
                    where vare.Citizen.Dui == txtDui.Text
                    select vare).First();

                res.VaccinationDate = RsDay;
                bd.SaveChanges();

                MessageBox.Show("Llego tu momento para vacunarte!", "Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmVaccination vaccination = new frmVaccination(employee);
                this.Close();
                vaccination.Show();
            }
            else 
                MessageBox.Show("No se encuentra el dui!", "Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}