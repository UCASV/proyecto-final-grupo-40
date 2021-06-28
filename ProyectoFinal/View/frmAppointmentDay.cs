using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal.View
{
    public partial class frmAppointmentDay : Form
    {
        public Citizen citizen { get; set; }
        public Employee employee { get; set; }

        public frmAppointmentDay(Citizen citizen, Employee employee)
        {
            InitializeComponent();
            this.citizen = citizen;
            this.employee = employee;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            DateTime RsDay = dtpDate.Value.Date + dtpHour.Value.TimeOfDay;
            
             var db = new CabinContext();
             var NewAppointment = new List<AppointmentOne>
             {
                 new AppointmentOne()
                     {
                        DateAppointment = RsDay,
                        Place = txtPlace.Text,
                        EmployeeId = employee.Id,
                        CitizenId = citizen.Id,
                     }
             };
             NewAppointment.ForEach(a => db.Add(a));
             db.SaveChanges();
             
             var SavedAppointments = db.AppointmentOnes
                 .OrderBy(a => a.Id)
                 .ToList();
             
             MessageBox.Show("Cita registrada con éxito.",
                 "Cabina de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToString("yyyy-mm-dd");

        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
