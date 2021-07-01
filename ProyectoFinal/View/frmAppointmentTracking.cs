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
            this.Close();
        }

        private void btnPdf2_Click(object sender, EventArgs e)
        {
            
            var bd = new CabinContext();
            
            var citizens = bd.Citizens.ToList();
            var exist = citizens.Where(c => c.Dui == txtDui.Text).ToList();
            var appointmentOnes = bd.AppointmentOnes.ToList();
            var appointments = appointmentOnes
                .Where(a =>  a.Citizen.Dui == txtDui.Text)
                .OrderBy(a => a.CitizenId).ToList();
            
            int size = appointments.Count() - 1;
            
            string appointmentname = appointments[size].Citizen.CitizenName;
            string appointmentdui = appointments[size].Citizen.Dui;
            string appointmentdate = appointments[size].DateAppointment.ToString();
            string appointmentplace = appointments[size].Place;


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
                    document.Add(new Paragraph("DUI: " + appointmentdui));
                    document.Add(new Paragraph("Nombre: " + appointmentname));
                    document.Add(new Paragraph("Fecha y hora: " + appointmentdate));
                    document.Add(new Paragraph("Lugar de vacunación: " + appointmentplace));
                    document.Close();
                    pdf.Close();
                }
            }
        }
    }
}