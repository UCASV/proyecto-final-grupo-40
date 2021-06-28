using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.View
{
    public partial class frmLogin : Form
    {
        public Employee employee { get; set; }
        public frmLogin(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
               {
                   
                   var db = new CabinContext();
                 
                   Citizen newCitizen = new Citizen
                   {
                       Dui = txtDui.Text,
                       CitizenName = txtName.Text,
                       Address = txtDirection.Text,
                       Phone = txtPhoneNumber.Text,
                       Age = Int32.Parse(txtAge.Text),
                       InstitutionalId = txtInsti.Text ,
                       Mail = txtEmail.Text
                   };
                   
                   db.Add(newCitizen);
                   db.SaveChanges();
                       
                   MessageBox.Show("Usuario creado existosamente", "Cabina de vacunacion",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                   var listCitizen = db.Citizens
                       .OrderBy(c => c.Id)
                       .ToList();
                   var Result = listCitizen.Where(
                       u => u.CitizenName.Equals(txtName.Text) && u.Dui.Equals(txtDui.Text)
                   ).ToList();
                   
                   frmDiseases window = new frmDiseases(Result[0], employee);
                   this.Hide();
                   window.Show();
               }

        
    }
}