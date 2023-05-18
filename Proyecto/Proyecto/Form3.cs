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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Proyecto
{
    public partial class Form3 : Form
    {
        string server = "Data Source=(localdb)\\NICOUNI;Initial Catalog=IdealSize;Integrated Security=True";
        SqlConnection cn = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form5();
            form.Show();

            cn.ConnectionString = server;
            cn.Open();
            SqlCommand cmd = new SqlCommand("ingreso", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            
           
            cmd.Parameters.AddWithValue("Correo_Electronico", textBox1.Text);
            cmd.Parameters.AddWithValue("Contraseña", textBox2.Text);
     

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            cn.Close(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form1();
            form.Show();

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
