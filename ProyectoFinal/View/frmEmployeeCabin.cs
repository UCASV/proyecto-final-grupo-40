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
    }
}