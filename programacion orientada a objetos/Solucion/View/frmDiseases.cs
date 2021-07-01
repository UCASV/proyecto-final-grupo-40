using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal.View
{
    public partial class frmDiseases : Form
    {
        public Citizen citizen { get; set; }
        public Employee employee { get; set; }
        public frmDiseases(Citizen citizen, Employee employee) 
        {
            InitializeComponent();
            this.citizen = citizen;
            this.employee = employee;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
                    bool a = chkDisease.Checked;
                    bool b = checkBox3.Checked;
                    bool c = checkBox1.Checked;
                    bool d = checkBox5.Checked;
                    bool f = checkBox4.Checked;
                    bool g = checkBox6.Checked;
                    bool h = checkBox2.Checked;
                    bool i = checkBox7.Checked;
            
                    bool[] arrayresult = new bool[8] { a, b, c, d, f, g, h, i };
            
                    int count = 0;
            
                        for (int l = 0; l < 8; l++)
                    {
                        if (arrayresult[l] == true)
                        {
                            count++;
                        }
                    }
            
                    int[] arrayid = new int[count];
                    int cont = 0;
            
                        for (int m = 0; m < 8; m++)
                    {
                        if (arrayresult[m] == true)
                        {
                            arrayid[cont] = m + 1;
                            cont++;
                        }
                    }

                    var db = new CabinContext();        
            
                    int cnt = 0;
                    List<Citizenxdisease> Diseases = new List<Citizenxdisease>();
                    
                    for (int p = 0; p < arrayid.Length; p++)
                    {
                        Citizenxdisease disease = new Citizenxdisease()
                        {
                            DiseaseId = arrayid[cnt],
                            CitizenId = citizen.Id
                        };
                        cnt++;
                        Diseases.Add(disease);
                    }
                    Diseases.ForEach(dxc => db.Add(dxc));
                    db.SaveChanges();
                    var savedDiseases = db.Citizenxdiseases
                        .OrderBy(dxc => dxc.CitizenId)
                        .ToList();
                    
                    frmAppointmentDay window = new frmAppointmentDay(citizen,employee);
                    this.Hide();
                    window.Show();
        }
    }
}