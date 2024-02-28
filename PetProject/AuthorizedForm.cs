using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetProject
{
    public partial class AuthorizedForm : Form
    {
        public AuthorizedForm()
        {
            InitializeComponent();
        }

        private void gunaGoogleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(gunaGoogleSwitch1.Checked)
            {
                guna2TextBox1.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox1.UseSystemPasswordChar= true;
            }
        }
    }
}
