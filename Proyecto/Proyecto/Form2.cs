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

namespace Proyecto
{
    public partial class Form2 : Form
    {
        string server = "Data Source=(localdb)\\NICOUNI;Initial Catalog=IdealSize;Integrated Security=True";
        SqlConnection cn = new SqlConnection();
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form1();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form5();
            form.Show();

            cn.ConnectionString = server;
                cn.Open();
                SqlCommand cmd = new SqlCommand("registro",cn);
            
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre", textBox1.Text);
                cmd.Parameters.AddWithValue("Apellido", textBox2.Text);
                cmd.Parameters.AddWithValue("Correo_Electronico", textBox3.Text);
                cmd.Parameters.AddWithValue("Contraseña", textBox4.Text);
                cmd.Parameters.AddWithValue("Confirmar_Contraseña",textBox5.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.ToString());
                    
                }
                
            

        }
    }
}
