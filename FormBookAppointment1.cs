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
    public partial class FormBookAppointment1 : Form
    {
        public static string reasonofAppointment,title,age,timeOfAppointment,DateOfAppointment;

    private void FormBookAppointment1_Load(object sender, EventArgs e)
    {

    }

    public FormBookAppointment1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            Hide();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(txtBxtimeOfAppointment.Text == "10:00 AM" || txtBxtimeOfAppointment.Text == "12:00 PM" || txtBxtimeOfAppointment.Text == "16:00 PM")
            {
                MessageBox.Show("We cannot make it For  " +   txtBxtimeOfAppointment.Text  + "  ,enter a different time","Appointments Full",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {

                reasonofAppointment = txtReasonForAppointMent.Text;
                title = txtBxTitle.Text;
                age = txtBxAge.Text;
                timeOfAppointment = txtBxtimeOfAppointment.Text;
                DateOfAppointment = dateTimePicker.Value.ToLongDateString();
                MessageBox.Show("Appointment Successfully Booked For\n" + timeOfAppointment + "\n" + DateOfAppointment, "Appointment Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }












        }
    }
}
