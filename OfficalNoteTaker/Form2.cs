using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficalNoteTaker
{
    public partial class Form2 : Form
    {
        string password;
        string Username;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Local_but_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            reset_lbl.Visible = false;
        }

        private void Reset_but_Click(object sender, EventArgs e)
        {
            if (password.Equals(txt_Password.Text) == true && Username.Equals(txt_User.Text) == true)
            {
                reset_lbl.Visible = true;

                txt_User.Clear();
                txt_Password.Clear();
                Set_but.Visible = true;

            }
        }

        private void Set_but_Click(object sender, EventArgs e)
        {
            password = txt_Password.Text;
            Username = txt_User.Text;

            txt_User.Clear();
            txt_Password.Clear();

            reset_lbl.Visible = false;
            Set_but.Visible = false;
        }

        private void Login_but_Click(object sender, EventArgs e)
        {
            if (password.Equals(txt_Password.Text) == true && Username.Equals(txt_User.Text) == true)
            {
                new Form1().Show();
                this.Hide();
            }

            else 
            {
                txt_User.Clear();
                txt_Password.Clear();
            }
        }
    }
}
