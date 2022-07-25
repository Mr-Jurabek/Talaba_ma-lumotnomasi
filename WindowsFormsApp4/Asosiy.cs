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
    public partial class Asosiy : Form
    {
        
        //DataTable dt;
        int ID = 0;
        
        public Asosiy()
        {
            InitializeComponent();
        }

        private void Asosiy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "talabaDataSet.talaba". При необходимости она может быть перемещена или удалена.
            this.talabaTableAdapter.Fill(this.talabaDataSet.talaba);

            display();

        }

        public void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\talaba.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand com = new SqlCommand();
            SqlDataAdapter adapt = new SqlDataAdapter();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from talaba", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Qoshish oyna_2 = new Qoshish();
            oyna_2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Qoshish oyna_2 = new Qoshish();
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            oyna_2.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            oyna_2.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            oyna_2.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            oyna_2.comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            oyna_2.maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            oyna_2.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            oyna_2.maskedTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            oyna_2.textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\talaba.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand com = new SqlCommand();
                SqlDataAdapter adapt = new SqlDataAdapter();
                com = new SqlCommand("delete talaba where ID=@id", con);
                con.Open();
                com.Parameters.AddWithValue("@id", ID);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("O'chirildi");

                display();
            }
            else
            {
                MessageBox.Show("iltimos tanlang!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
