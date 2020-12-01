using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RKQ0H6O\SQLEXPRESS;Initial Catalog=Notes1_1;Integrated Security=True");
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
            Reset2_but.Visible = false;
            reset_lbl.Visible = false;
        }

        private void Reset_but_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Security2 Where Username= '" +txt_User.Text + "' and Password = '"+ txt_Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                string query = "DELETE FROM Security2 WHERE Username = '" + txt_User.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

                Reset2_but.Visible = true;
                reset_lbl.Visible = true;
            }

            else
            {
                txt_User.Clear();
                txt_Password.Clear();
            }
        }

        private void Set_but_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Security2 (Username, Password) VALUES ('" + txt_User.Text + "','" + txt_Password.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            txt_User.Clear();
            txt_Password.Clear();

            reset_lbl.Visible = false;
            Set_but.Visible = false;
        }

        private void Login_but_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Security2 Where Username= '" + txt_User.Text + "' and Password = '" + txt_Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
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

        private void Reset2_but_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Security2 (Username, Password) VALUES ('" + txt_User.Text + "','" + txt_Password.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            txt_User.Clear();
            txt_Password.Clear();

            Reset2_but.Visible = false;
            reset_lbl.Visible = false;
        }
    }
}
