using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace UTS___Sewa_Iphone
{
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();

        public Form2()
        {
            InitializeComponent();

            // Tambahkan item ke ComboBox
            ComboBox1Tipe.Items.Add("iPhone 13");
            ComboBox1Tipe.Items.Add("iPhone 14");
            ComboBox1Tipe.Items.Add("iPhone 15");
            ComboBox1Tipe.Items.Add("iPhone 16");

            ComboBoxPaket.Items.Add("Paket Standar");
            ComboBoxPaket.Items.Add("Paket Premium");
            ComboBoxPaket.Items.Add("Paket Eksklusif");

            ComboBoxWarna.Items.Add("Hitam");
            ComboBoxWarna.Items.Add("Putih");
            ComboBoxWarna.Items.Add("Merah");
            ComboBoxWarna.Items.Add("Hijau");

            // Atur nilai default
            ComboBox1Tipe.SelectedIndex = 0; // Default ke "iPhone 13"
            ComboBoxPaket.SelectedIndex = 1; // Default ke "Paket Premium"
            ComboBoxWarna.SelectedIndex = 0; // Default ke "Hitam"

            // Set ListView menjadi mode detail
            listView1.View = View.Details;

            // Tambahkan kolom ke ListView
            listView1.Columns.Add("No", 50); // Kolom 1: Nomor
            listView1.Columns.Add("Tipe", 100); // Kolom 2: Tipe
            listView1.Columns.Add("Warna", 100); // Kolom 3: Warna
            listView1.Columns.Add("Paket", 120); // Kolom 4: Paket
            listView1.Columns.Add("Tanggal/Waktu", 150); // Kolom 5: Tanggal/Waktu
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSewa16_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void ComboBox1Tipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxPaket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxWarna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSewa_Click(object sender, EventArgs e)
        {
            // Validasi pilihan sebelum memproses
            if (ComboBox1Tipe.SelectedItem == null || ComboBoxWarna.SelectedItem == null || ComboBoxPaket.SelectedItem == null)
            {
                MessageBox.Show("Pastikan semua pilihan telah diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari ComboBox
            string tipe = ComboBox1Tipe.SelectedItem.ToString();
            string warna = ComboBoxWarna.SelectedItem.ToString();
            string paket = ComboBoxPaket.SelectedItem.ToString();
            string waktu = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"); // Tanggal dan waktu sekarang

            // Tampilkan pesan konfirmasi
            MessageBox.Show($"Menyewa {tipe} dengan warna {warna} dan paket {paket}.", "Info Sewa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tambahkan data ke ListView
            int noUrut = listView1.Items.Count + 1; // Nomor urut
            ListViewItem item = new ListViewItem(noUrut.ToString()); // Kolom 1: Nomor
            item.SubItems.Add(tipe);                                 // Kolom 2: Tipe
            item.SubItems.Add(warna);                                // Kolom 3: Warna
            item.SubItems.Add(paket);                                // Kolom 4: Paket
            item.SubItems.Add(waktu);                                // Kolom 5: Tanggal/Waktu

            listView1.Items.Add(item); // Tambahkan item ke ListView
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // Reset ComboBox ke nilai default
            ComboBox1Tipe.SelectedIndex = 0;
            ComboBoxPaket.SelectedIndex = 1;
            ComboBoxWarna.SelectedIndex = 0;

            // Opsional: Hapus semua data di ListView (jika perlu)
            // listView1.Items.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Buat instance dari Form3
            Form3 form3 = new Form3();

            // Tampilkan Form3
            form3.Show();

            // (Opsional) Sembunyikan form saat ini
            this.Hide();
        }
    }
}

