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
    public partial class TaskSum : Form
    {
        public TaskSum()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //int FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            //int SecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            //int result = FirstNumber + SecondNumber;
            //txtResult .Text= result.ToString();
            txtResult.Text = (Convert.ToInt32(txtFirstNumber.Text) + Convert.ToInt32(txtSecondNumber.Text)).ToString();
            txtResult.BackColor = Color.Coral;
            int result = Convert.ToInt32(txtResult.Text);
            if (result >= 100 &&result<200 )
            {
                txtResult.BackColor = Color.Red;
            }
            else if ( result>= 200)
            {
                txtResult.BackColor = Color.Green;
            }
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
