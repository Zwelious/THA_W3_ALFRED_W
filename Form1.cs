using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Alfred_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            char inputAge = Convert.ToChar(age.Text);
            int umur = -1;
            bool invalid = false;
            if (Char.IsNumber(inputAge))
            {
                umur = Convert.ToInt32(inputAge);
            }
            else
            {
                invalid = true;
                MessageBox.Show("Age must be a number.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string ageMessage = "";
            if(umur > 18){
                ageMessage = "You are an adult";
            }
            else if(umur < 18 && umur >= 0)
            {
                ageMessage = "You are a minor";
            }
            
            if(invalid == false){
                string message = "Name: " + name.Text + " Email: " + email.Text + " Phone Number: " + phone.Text + ". " + ageMessage;
                MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            age.Text = "";
            email.Text = "";
            phone.Text = "";
        }
    }
}
