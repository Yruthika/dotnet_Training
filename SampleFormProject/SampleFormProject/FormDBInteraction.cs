using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormProject
{
    public partial class FormDBInteraction : Form
    {
        public FormDBInteraction()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-ELFPKHG\SQLEXPRESS;Database=DBInteraction;Trusted_Connection=True;");
            connection.Open();
            MessageBox.Show("Connection Ok!!");

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PersonSave";
            cmd.Parameters.AddWithValue ("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Place", txtPlace.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully");
        }
    }
}
