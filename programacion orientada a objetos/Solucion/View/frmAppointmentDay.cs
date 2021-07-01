using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

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
            var bd = new CabinContext();
            var SavedAppointments = bd.AppointmentOnes
                .OrderBy(a => a.Id)
                .ToList();

            int size = SavedAppointments.Count() - 1;
            int appointmentid = SavedAppointments[size].Id;
            string appointmentdate = SavedAppointments[size].DateAppointment.ToString();


            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    Document document = new Document(PageSize.A4);
                    PdfWriter pdf = PdfWriter.GetInstance(document, file);
                    document.Open();
                    document.Add(new Paragraph("Detalles de cita"));
                    document.Add(Chunk.NEWLINE);
                    document.Add(new Paragraph("DUI: " + Convert.ToString(citizen.Dui)));
                    document.Add(new Paragraph("Nombre: " + citizen.CitizenName));
                    document.Add(new Paragraph("Fecha y hora: " + appointmentdate));
                    document.Add(new Paragraph("Lugar de vacunación: " + txtPlace.Text));
                    document.Close();
                    pdf.Close();
                }
            }
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
