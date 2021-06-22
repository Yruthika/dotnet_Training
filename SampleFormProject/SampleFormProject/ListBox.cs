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
    public partial class ListBox : Form
    {
        List<string> names = new List<string>();
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            names.Add(txtAdd.Text);
            lstNames.Items.Add(txtAdd.Text);
            MessageBox.Show("data Added");
            txtAdd.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            names.RemoveAt(0);
            txtRemove.Text = lstNames.Text;
        }
    }
}
