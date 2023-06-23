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
    public partial class FormFirstTime : Form
    {
        public static string Cellnumber, PhnHome, Age, Id, NextOfkin, fulName,lastName;
        public FormFirstTime()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin F = new FormLogin();
            F.Show();
            Hide();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Have you entered correct details?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
            {
                txtBxCellNumber.Text = "";
                txtBxPhnHome.Text = "";
                txtBxiDNo.Text = "";
                txtBxNextOfKin.Text = "";
                txtBxFormFisrtTimeFullNames.Text = "";
                txtBxlastName.Text = "";


            }
           else if (Result == DialogResult.Yes)
            {
                Cellnumber = txtBxCellNumber.Text;
                PhnHome = txtBxPhnHome.Text;
                Id = txtBxiDNo.Text;
                NextOfkin = txtBxNextOfKin.Text;
                fulName = txtBxFormFisrtTimeFullNames.Text;
                lastName = txtBxlastName.Text;

                FormBookAppointment1 F = new FormBookAppointment1();
                F.Show();
                Hide();
            }
          
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            Hide();
        }
    }
}
