using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS___Sewa_Iphone
{
    public partial class Form3 : Form
    {
        Form4 form4 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
