using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
            DateTime RsDay = dtpDate.Value.Date + dtpHour.Value.TimeOfDay;
            
            var db = new CabinContext();
            var citizens = db.Citizens.ToList();
            var exist = citizens.Where(c => c.Dui == txtDui.Text).ToList();
            var appointmentOnes = db.AppointmentOnes.ToList();
            var appointments = appointmentOnes
                .Where(a =>  a.Id == a.CitizenId)
                .OrderBy(a => a.CitizenId).ToList();
            
            AppointmentOne res = (from vare in db.AppointmentOnes
                where vare.Citizen.Dui == txtDui.Text
                select vare).First();
            if (exist.Count() > 0 && appointmentOnes.Count() > 0)
            {
                var NewAppointment = new List<AppointmentTwoo>
                {
                    new AppointmentTwoo()
                    {
                        DateAppointment = RsDay,
                        EmployeeId = employee.Id,
                        Place = txtPlace.Text,
                        CitizenId = res.CitizenId
                    }
                };
                NewAppointment.ForEach(a => db.Add(a));
                db.SaveChanges();

                var SavedAppointments = db.AppointmentTwoos
                    .OrderBy(a => a.Id)
                    .ToList();

                MessageBox.Show("Cita registrada con éxito.","Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
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
                            MessageBox.Show($"El ciudadano esta listo para agendar su segunda dosis!", "seguimiento de citas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El cuidadano no posee una cita registrada", "seguimiento de citas",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
        }
    }
}