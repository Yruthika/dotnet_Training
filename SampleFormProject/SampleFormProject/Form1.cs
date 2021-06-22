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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Load";
            this.BackColor = Color.Red;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            btnOk.BackColor = Color.Yellow;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Text = "Hai" + " "+txtName.Text + "You are" + txtAge.Text + " "+"years Old";
        }
    }
}
