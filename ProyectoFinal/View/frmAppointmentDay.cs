using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmAppointmentDay : Form
    {
        public Citizen citizen { get; set; }
        public frmAppointmentDay(Citizen citizen)
        {
            InitializeComponent();
            this.citizen = citizen;
        }
    }
}