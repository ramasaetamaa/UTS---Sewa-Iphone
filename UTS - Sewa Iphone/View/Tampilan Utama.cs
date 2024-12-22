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
    public partial class TampilanUtama : Form
    {
        public TampilanUtama()
        {
            InitializeComponent();

        }

        Form2 form2 = new Form2();


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            // Membuka form tujuan (misalnya Form2)
            Form2 formTujuan = new Form2();
            formTujuan.Show();

            // Menyembunyikan form saat ini
            this.Hide();
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
        }
    }
}
