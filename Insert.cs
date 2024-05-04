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
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-SL7MU42\\SQLEXPRESS; Initial Catalog=mydb; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string query = @"CREATE TABLE info (
                       Sno int primary key,
                       Name varchar(50),
                       Age int);
                    ";
                try
                {
                    SqlCommand cmd = new SqlCommand(query,conn);
                    int row_efected = cmd.ExecuteNonQuery();
                    label1.Text = row_efected.ToString();
                }catch(Exception ex)
                {
                    label1.Text = ex.Message;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            int sno = int.Parse(textBox1.Text);
            string Name = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string cs = "Data Source=DESKTOP-SL7MU42\\SQLEXPRESS; Initial Catalog=mydb; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                string query = "INSERT INTO info (Sno,Name,Age) VALUES (@Sno,@Name,@Age)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Sno", sno);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Age", age);
                int row_eff = cmd.ExecuteNonQuery();
                if (row_eff > 0)
                {
                    label1.Text = "Data inserted. "+row_eff;
                }
                else
                {
                    label1.Text = "Data not inserted.";
                }
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
