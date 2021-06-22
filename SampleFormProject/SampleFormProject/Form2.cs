using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "WELCOME!!!!";
            this.BackColor = Color.Beige;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
            btnSubmit.BackColor = Color.Yellow;
            this.BackColor = Color.Aquamarine;
            lbSuccessfull.Text = txtName.Text + " " + "Registration Successfull!!!!";

        }

        
    }
}
