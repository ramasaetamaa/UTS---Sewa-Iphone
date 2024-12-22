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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InisialisasiListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("No.", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Iphone", 91, HorizontalAlignment.Center);
            listView1.Columns.Add("Tipe", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Warna", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Paket", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Penyewa", 114, HorizontalAlignment.Center);
        }
    }
}
