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
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable Table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RKQ0H6O\SQLEXPRESS;Initial Catalog=Notes1_1;Integrated Security=True");
        private void Name_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void New_but_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Notes_Data", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            int row = dataGridView1.CurrentCell.RowIndex;

            if (row >= 0)
            {
                txt_title.Text = dt.Rows[row].ItemArray[0].ToString();
                txt_msg.Text = dt.Rows[row].ItemArray[1].ToString();
            }

            con.Open();
            string query = "DELETE FROM Notes_Data WHERE Title = '" + this.txt_title.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void Open_but_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Notes_Data", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            txt_title.Clear();
            txt_msg.Clear();
        }

        private void Save_but_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Notes_Data (Title, Message) VALUES ('" + txt_title.Text + "','" + txt_msg.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            txt_title.Clear();
            txt_msg.Clear();
        }

        private void Del_but_Click(object sender, EventArgs e)
        {
            string id = txt_Id.Text;
            con.Open();
            string query = "DELETE FROM Notes_Data WHERE Title = '" + this.txt_Id.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
