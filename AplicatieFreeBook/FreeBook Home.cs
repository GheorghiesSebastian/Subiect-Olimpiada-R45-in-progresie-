using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook
{
    public partial class FreeBookHome : Form
    {
        public FreeBookHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FreeBookHome_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inregistrare InregistrareZ = new Inregistrare();
            InregistrareZ.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogareFreeBook Logare = new LogareFreeBook();
            Logare.Show();
            this.Hide();
        }
    }
}
