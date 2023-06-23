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
    public partial class FormEmergency : Form
    {
        public static string ID, contactPhn, location, HomeContactPhn,AddedItem,commonIllness,FirstName,LastName;

    public FormEmergency()
        {
            InitializeComponent();


            listBxEmergency.Items.Add("Bleeding");
            listBxEmergency.Items.Add("Breathing difficulties");
            listBxEmergency.Items.Add("Severe Pain");
            listBxEmergency.Items.Add("Accident");
            listBxEmergency.Items.Add("A Stroke");
            listBxEmergency.Items.Add("Heart Attack");
            listBxEmergency.Items.Add("Drowning");
            listBxEmergency.Items.Add("Food Poisoning");
            listBxEmergency.Items.Add("Drug Overdose");
            listBxEmergency.Items.Add("Seizure");


        }

        private void btnHome4_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin F = new FormLogin();
            F.Show();
            Hide();
        }

        private void listBxEmergency_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Have you entered correct details?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

         if (Result == DialogResult.No)
            {
                txtBxFormEmergencyIdNo.Text = "";
                txtBxContactPhn.Text = "";
                txtBxEmergencyHomePhn.Text = "";
                txtBxLocation.Text = "";
                txtBxFrstName.Text = "";
                txtBxLastName.Text = "";
                txtBxSpecify.Text = "";
               

            }
            else if(Result == DialogResult.Yes)
            {
                ID = txtBxFormEmergencyIdNo.Text;
                contactPhn = txtBxContactPhn.Text;
                HomeContactPhn = txtBxEmergencyHomePhn.Text;
                location = txtBxLocation.Text;
                commonIllness = listBxEmergency.SelectedItem.ToString();
                FirstName = txtBxFrstName.Text;
                LastName = txtBxLastName.Text;



                FormBookAppointment1 F = new FormBookAppointment1();
                F.Show();
                Hide();
            }









        }
    }
}
