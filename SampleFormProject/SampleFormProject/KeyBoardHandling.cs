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
    public partial class KeyBoardHandling : Form
    {
        public KeyBoardHandling()
        {
            InitializeComponent();
        }

        private void KeyBoardHandling_Load(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.R)
            {
                this.BackColor = Color.Red;
            }

        }

        private void KeyBoardHandling_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void KeyBoardHandling_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void KeyBoardHandling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                this.BackColor = Color.Red;
        }
    }
}
