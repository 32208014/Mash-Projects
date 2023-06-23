using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public static string form1fulname,form1lastname;
        public Form1()
        {
            
            InitializeComponent();

            btnLogin.Visible = false;
            BtnSignUp.Visible = false;

            txtBxForm1Fullnames.Visible = false;
            txtBxForm1LastName.Visible = false;

            lblfullNames.Visible = false;
            lbllastName.Visible = false;
           

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            FormFirstTime.Id = "";
            FormRegular.IdentityNo = "";
            FormEmergency.ID = "";

            lblfullNames.Visible = true;
            lbllastName.Visible = true;

            txtBxForm1Fullnames.Visible = true;
            txtBxForm1LastName.Visible = true;

            BtnAdmission.Visible = false;
            btnLogin.Visible = true;
        }

        private void BtnAdmission_Click(object sender, EventArgs e)
        {
            
            btnPatient.Visible = false;
            BtnSignUp.Visible = true;


            txtBxForm1LastName.Visible = false;
            lbllastName.Visible = false;

            txtBxForm1Fullnames.Visible = true;

            lblfullNames.Visible = true;
            lblfullNames.Text = "Employee ID";
           
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if(txtBxForm1Fullnames.Text == "")
            {
                MessageBox.Show("Employee ID required", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                FormSignUp F = new FormSignUp();
                F.Show();
                Hide();
            }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBxForm1Fullnames.Text == "" || txtBxForm1LastName.Text == "")
            {
                MessageBox.Show("Please enter details", "full name and Last Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                FormLogin F = new FormLogin();
                F.Show();
                Hide();
            }
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
