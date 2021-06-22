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

    public partial class PeopleForm : Form
    {
        string[] people = File.ReadAllLines(@"C:\Users\Hp\Desktop\StudentsFolder\PeopleDetails.txt");

        public PeopleForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //List<string> PeopleList = new List<string>();
    
            if (txtSearchingName.Text == ("Ansa Sebastian").ToLower())
            {
                txtSearchingName.Clear();
                    People register1 = new People();
                    register1.Name = people[0];
                    register1.PhoneNumber = people[1];
                    register1.Email = people[2];
                    double marks = Convert.ToDouble(people[3]);
                    double markPerc = ((marks / 80) * 100);
                    register1.Marks = markPerc + "%".ToString();
                    register1.Place = people[4];

                    txtName.Text = register1.Name;
                    txtPhoneNumber.Text = register1.PhoneNumber;
                    txtEmail.Text = register1.Email;
                    txtMarks.Text = register1.Marks;
                    txtPlace.Text = register1.Place;
            }
             else if(txtSearchingName.Text==("Sinu Sebastian").ToLower())
            {
                txtSearchingName.Clear();
                People register2 = new People();
                register2.Name = people[5];
                register2.PhoneNumber = people[6];
                register2.Email = people[7];
                double marks2 = Convert.ToDouble(people[8]);
                double markPerc2 = ((marks2 / 80) * 100);
                register2.Marks = markPerc2 + "%".ToString();
                register2.Place = people[9];

                txtName.Text = register2.Name;
                txtPhoneNumber.Text = register2.PhoneNumber;
                txtEmail.Text = register2.Email;
                txtMarks.Text = register2.Marks;
                txtPlace.Text = register2.Place;
            }

           else if (txtSearchingName.Text == ("Manju Manohar").ToLower())
            {
                txtSearchingName.Clear();
                People register3 = new People();
                register3.Name = people[10];
                register3.PhoneNumber = people[11];
                register3.Email = people[12];
                double marks2 = Convert.ToDouble(people[13]);
                double markPerc2 = ((marks2 / 80) * 100);
                register3.Marks = markPerc2 + "%".ToString();
                register3.Place = people[14];

                txtName.Text = register3.Name;
                txtPhoneNumber.Text = register3.PhoneNumber;
                txtEmail.Text = register3.Email;
                txtMarks.Text = register3.Marks;
                txtPlace.Text = register3.Place;
            }
            else { MessageBox.Show("The Name does not Existing In this file!!");}
        }
    }
}
