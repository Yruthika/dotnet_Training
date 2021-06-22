using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormProject
{
    public partial class form4 : Form
    {
        string[] names = new string[10];
        public form4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\Hp\Desktop\Testdata\TestFile.txt","-"+txtSave.Text);
            txtSave.Clear();
            MessageBox.Show("Saved!!");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtRead.Text = File.ReadAllText(@"C:\Users\Hp\Desktop\Testdata\TestFile.txt");
        }

        private void txtSave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
