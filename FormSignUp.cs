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
    public partial class FormSignUp : Form
    {
        

        public FormSignUp()
        {
            InitializeComponent();

            lblPatient.Visible = false;
            
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            groupBoxPatientInfo.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBxPatientI.Text == "")
            {
                MessageBox.Show("ID Required", "ID Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

          else  if (txtBxPatientI.Text == FormFirstTime.Id)
           {
                

                groupBoxPatientInfo.Visible = true;
                lblPatient.Visible = true;
              

                lblPatient.Text = "First time Patient";
                lblFName.Text = FormFirstTime.fulName;
                lbllastName.Text = FormFirstTime.lastName;
                lblIDNo.Text = FormFirstTime.Id;
                lblCellNumber.Text = FormFirstTime.Cellnumber;
                lblAge.Text = FormFirstTime.Age;
                lblPhnHome.Text = FormFirstTime.PhnHome;
                lblNextKin.Text = FormFirstTime.NextOfkin;
                lblBloodPressure.Text = "Low";
                lblMedication.Text = "Tablets";
                lbllastTreatMent.Text = "N/A";
                lblReasonOfAppointment.Text = FormBookAppointment1.reasonofAppointment;
                lblSuffersFrom.Text = FormBookAppointment1.reasonofAppointment;
                lblTitle.Text = FormBookAppointment1.title;
                lblAge.Text = FormBookAppointment1.age;
                labelTimeOfAppointment.Text = FormBookAppointment1.timeOfAppointment;
                labelDateOfAppointment.Text = FormBookAppointment1.DateOfAppointment;

                lblLocation.Visible = false;
                lbllocate.Visible = false;



            }
            else if (txtBxPatientI.Text == FormRegular.IdentityNo)
            {
                groupBoxPatientInfo.Visible = true;
                lblPatient.Visible = true;
               






                lblPatient.Text = "Regular Patient";
                labelNames.Text = "Title";
                lblFName.Text = FormBookAppointment1.title;
                labelLastName.Text = "Age";
                lbllastName.Text = lblAge.Text = FormBookAppointment1.age;
                labelTitle.Visible = false;
                lblTitle.Visible = false;
                labelAge.Visible = false;
                lblAge.Visible = false;
                lbllocate.Visible = false;
                lblLocation.Visible = false;
                lblpHome.Visible = false;
                lblPhnHome.Visible = false;
                lblCellNumber.Visible = false;
                lblCel.Visible = false;
                lblnx.Visible = false;
                lblNextKin.Visible = false;
                lbllastTreatMent.Text = FormRegular.lastCheckUp;
                lblIDNo.Text = FormRegular.IdentityNo;
                lbllastTreatMent.Text = FormRegular.lastCheckUp;
                lblSuffersFrom.Text = FormRegular.ApplicablicableIllness;
                lblBloodPressure.Text = "Normal";
                lblMedication.Text = "injection";
                lblReasonOfAppointment.Text = FormBookAppointment1.reasonofAppointment;
                labelTimeOfAppointment.Text = FormBookAppointment1.timeOfAppointment;
                labelDateOfAppointment.Text = FormBookAppointment1.DateOfAppointment;




            }
            else if (txtBxPatientI.Text == FormEmergency.ID)
            {
                groupBoxPatientInfo.Visible = true;
                lblPatient.Visible = true;
            
            
                lblPatient.Text = "Emergency Patient";
                lblIDNo.Text = FormEmergency.ID;
                lblCellNumber.Text = FormEmergency.contactPhn;
                lbllastTreatMent.Text = "N/A";
                lblPhnHome.Text = FormEmergency.HomeContactPhn;
                lblSuffersFrom.Text = FormEmergency.commonIllness;
                lblLocation.Text = FormEmergency.location;
                lblFName.Text = FormEmergency.FirstName;
                lbllastName.Text = FormEmergency.LastName;
                lblBloodPressure.Text = "High";
                lblMedication.Text = "liquid";
                lblReasonOfAppointment.Text = FormBookAppointment1.reasonofAppointment;
                lblTitle.Text = FormBookAppointment1.title;
                lblAge.Text = FormBookAppointment1.age;
                labelTimeOfAppointment.Text = FormBookAppointment1.timeOfAppointment;
                labelDateOfAppointment.Text = FormBookAppointment1.DateOfAppointment;


                lblNextKin.Visible = false;
                lblnx.Visible = false;

            }
            else
            {
                MessageBox.Show(" ID not recognised,Patient did book for an appointment","Denied",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
              
           
           
           
          
            
            
           
           
            

           
            
        }

        private void btnEmergencyWard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Successfuly Send to  Emergency Ward", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXray_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Successfuly Send to  Xray Ward", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMaternityWard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Successfuly Send to  Maternity Ward", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCasualtyWard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Successfuly Send to Casualty Ward", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
