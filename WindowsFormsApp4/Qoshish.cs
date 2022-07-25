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

namespace WindowsFormsApp4
{
    public partial class Qoshish : Form
    {
        Asosiy oynaa = new Asosiy();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\talaba.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        //SqlDataAdapter adapt = new SqlDataAdapter();
        
        public Qoshish()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("INSERT INTO talaba (familiya, ism, sharif, jinsi, tugilgan_kuni, email, tel_nomer, yashash_manzili) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox4.Text + "','" + maskedTextBox2.Text + "','" + textBox5.Text + "')", con);

            com.ExecuteNonQuery();
            oynaa.display();
            MessageBox.Show("Saqlandi!");
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Qoshish_Load(object sender, EventArgs e)
        {

        }
    }
}
