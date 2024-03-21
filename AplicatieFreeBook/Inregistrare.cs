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
using System.Data.SqlTypes;

namespace AplicatieFreeBook
{
    public partial class Inregistrare : Form
    {
        SqlConnection oli = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sebi\\source\\repos\\AplicatieFreeBook\\Database1.mdf;Integrated Security=True");

        public Inregistrare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int MAXT;

            if (textBox4.Text == textBox5.Text)
            {
                oli.Open();
                SqlCommand comand = new SqlCommand("INSERT INTO utilizatori(email,parola,nume,prenume)values('" + textBox1.Text + "','" + textBox4 + "','" + textBox2.Text + "','" + textBox3.Text + "')", oli);
                comand.ExecuteNonQuery();
                comand.Dispose();
                oli.Close();
            }
            else
            {
                MessageBox.Show("Parolele introduse nu sunt identice");
            }

            oli.Open();
            SqlCommand max = new SqlCommand("select max (id) as max_id from utilizatori");
            max.Connection = oli;
            MAXT = Convert.ToInt32(max.ExecuteScalar());
            max.Dispose();
            oli.Close();

            oli.Open();
            SqlCommand email = new SqlCommand("select email from utilizatori where email = '"+ textBox1.Text +"'");
            textBox1.Text = textBox1.Text;
            email.Connection = oli;
            email.Dispose();
            oli.Close();

        }

    }
}