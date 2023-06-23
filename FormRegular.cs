using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safeprojectname
{
    public partial class FormRegular : Form
    {
        public static string lastCheckUp, IdentityNo,ApplicablicableIllness,OtherSpecifiedIllness,fullname;
        public FormRegular()
        {
            InitializeComponent();

            

            listBox1.Items.Add("Allergies");
            listBox1.Items.Add("Colds and Flu");
            listBox1.Items.Add("Diarrhea");
            listBox1.Items.Add("Headache");
            listBox1.Items.Add("Stomach Aches");
            listBox1.Items.Add("High Blood");
            listBox1.Items.Add("Diabetes");
            listBox1.Items.Add("TB ");
            listBox1.Items.Add("Hiv Aids");
            listBox1.Items.Add("Asthma");
           
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
       
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            DialogResult Result = MessageBox.Show("Have you entered correct details?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.No)
            {
               
                txtBxOtherIllnesses.Text = "";
                ttxBxidnum.Text = "";
            }
           else if (Result == DialogResult.Yes)
            {
                lastCheckUp = dateTimePicker1.Value.ToLongDateString();
                ApplicablicableIllness = listBox1.SelectedItem.ToString();
                OtherSpecifiedIllness = txtBxOtherIllnesses.Text;
                IdentityNo = ttxBxidnum.Text;

           
            }

           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormLogin F = new FormLogin();
            F.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
