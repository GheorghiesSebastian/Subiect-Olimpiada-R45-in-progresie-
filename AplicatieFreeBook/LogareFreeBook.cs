using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AplicatieFreeBook
{
    public partial class LogareFreeBook : Form
    {
        SqlConnection oli = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sebi\\source\\repos\\AplicatieFreeBook\\Database1.mdf;Integrated Security=True");
        public LogareFreeBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int Islogin = 0;

            SqlDataAdapter OliAdapter = new SqlDataAdapter();
            SqlDataAdapter OliAdapter2 = new SqlDataAdapter();
            DataSet Oliset = new DataSet();
            DataSet Oliset2 = new DataSet();

            string olimpiada = "select email from utilizatori where email='"+ textBox1.Text +"'";
            string olimpiada2 = "select parola from utilizatori where parola='" + textBox2.Text + "'";

            using (SqlCommand comanda = new SqlCommand(olimpiada, oli))
            {
                OliAdapter.SelectCommand = comanda;
                oli.Open();
                OliAdapter.Fill(Oliset, "email");
                using (SqlDataReader OliReader = comanda.ExecuteReader())
                {
                    if (OliReader.HasRows)
                    {
                        ++Islogin;
                    }
                }
                oli.Close();
            }

            using (SqlCommand comanda2 = new SqlCommand(olimpiada2, oli))
            {
                OliAdapter2.SelectCommand = comanda2;
                oli.Open();
                OliAdapter2.Fill(Oliset2, "parola");
                using (SqlDataReader OliReader2 = comanda2.ExecuteReader())
                {
                    if (OliReader2.HasRows)
                    {
                        ++Islogin;
                    }
                }
                oli.Close();
            }

            if (Islogin == 2)
            {

                MeniuFreeBook MFB = new MeniuFreeBook();
                MFB.Show();
                this.Hide();
            }
        }

    }
}
