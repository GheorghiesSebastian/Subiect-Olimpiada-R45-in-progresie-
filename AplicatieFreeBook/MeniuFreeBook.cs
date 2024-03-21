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
    public partial class MeniuFreeBook : Form
    {
        public MeniuFreeBook()
        {
            InitializeComponent();
        }

        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {
            label1.Text = LogareFreeBook.textBox1.Text;
        }
    }
}
