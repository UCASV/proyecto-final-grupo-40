using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.View
{
    public partial class frmEmployeeLogin : Form
    {
        public frmEmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            var db = new CabinContext();
            var listEmployees = db.Employees
                .OrderBy(c => c.Id)
                .ToList();
            var Result = listEmployees.Where(
                u => u.EmployeeUser.Equals(txtUserEmployee.Text) && u.EmployeePassword.Equals(txtPasswordEmployee.Text)
            ).ToList();

            if (Result.Count == 0)
                MessageBox.Show("El usuario no existe", "Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("Inicio de sesion exitoso!", "Cabina de vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmEmployeeCabin window = new frmEmployeeCabin(Result[0]);
                this.Hide();
                window.Show();
            }
        }


        private void frmEmployeeLogin_Load(object sender, EventArgs e)
        {
            var db = new CabinContext();
            List<Cabin> cabins = db.Cabins
                .ToList();
            cmbCabin.DataSource = cabins;
            cmbCabin.DisplayMember = "Direction";
            cmbCabin.ValueMember = "Id";
        }
    }
}