using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UTS___Sewa_Iphone
{
    public partial class Form1Login : Form
    {
        TampilanUtama tampilanUtama = new TampilanUtama();
        public Form1Login()
        {
            InitializeComponent();
        }

        private void Form1Login_Load(object sender, EventArgs e)
        {
            this.Hide();
            tampilanUtama.ShowDialog();
            this.Close();
        }


        private void LogoIphoneLogin_Click(object sender, EventArgs e)
        {
            // Membuka form tujuan
            Form2 formTujuan = new Form2();
            formTujuan.Show();

            // Menyembunyikan form saat ini
            this.Hide();
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
