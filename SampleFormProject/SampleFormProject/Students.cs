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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            string[] students = File.ReadAllLines(@"C:\Users\Hp\Desktop\StudentsFolder\StudentsDetails.txt");
            
            //txtName.Text = students[0];

            StudentRegister studRegister = new StudentRegister();
            studRegister.StudentName = students[0];
            studRegister.PhoneNumber = students[1];
            studRegister.Place = students[2];
            studRegister.Email = students[3];

            txtName.Text = studRegister.StudentName;
            txtPhoneNumber.Text = studRegister.PhoneNumber;
            txtPlace.Text = studRegister.Place;
            txtEmail.Text = studRegister.Email;
        }
    }
}
