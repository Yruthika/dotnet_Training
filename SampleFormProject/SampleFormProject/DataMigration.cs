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
    public partial class DataMigration : Form
    {
        public DataMigration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\Hp\Desktop\DataMigration\MydData8.txt", "  " + txtSave.Text);
            txtSave.Clear();
            MessageBox.Show("Saved!!");

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtRead.Text = File.ReadAllText(@"C:\Users\Hp\Desktop\DataMigration\MydData8.txt");
            txtRead.BackColor = Color.AntiqueWhite
                ;
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            string SourceFile= @"C:\Users\Hp\Desktop\DataMigration\MydData8.txt";
            string DestinatonFile = @"C:\Users\Hp\Desktop\DataMigration\MydData9.txt";
            if (File.Exists(@"C:\Users\Hp\Desktop\DataMigration\MydData1.txt"))
            {

                File.Copy(SourceFile, DestinatonFile);
            }
            txtMigrate.Text = File.ReadAllText(@"C:\Users\Hp\Desktop\DataMigration\MydData9.txt");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string ReverseString = txtMigrate.Text;
            char[] Chararray = ReverseString.ToCharArray();
            Array.Reverse(Chararray);
            string Txt = string.Empty;
            for (int i = 0; i <= Chararray.Length - 1; i++)
            {
                Txt += Chararray.GetValue(i);
            }
            txtReverse.Text = Txt.ToString();
;        }
    }
}
