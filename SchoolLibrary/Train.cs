using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibrary
{
    public partial class Train : Form
    {
        Form1 frm = new Form1();
        public Train()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbYas.SelectedIndex == -1 || cmbKategori.SelectedIndex == -1 || txtKitapAdi.Text == null || txtKitapAdi.Text == " ")
            {
                MessageBox.Show("Lütfen tüm seçenekleri doğru şekilde doldurunuz.");
            }
            else
            {
                if (cmbYas.SelectedIndex == 0 && cmbKategori.SelectedIndex == 0)
                {
                    frm.cocukMacera.Add(txtKitapAdi.Text);
                    MessageBox.Show("Ekleme işlemi başarılı");
                }
                else if (cmbYas.SelectedIndex == 0 && cmbKategori.SelectedIndex == 1)
                {
                    frm.cocukOgretici.Add(txtKitapAdi.Text);
                    MessageBox.Show("Ekleme işlemi başarılı");
                }
                else if (cmbYas.SelectedIndex == 1 && cmbKategori.SelectedIndex == 0)
                {
                    frm.gencMacera.Add(txtKitapAdi.Text);
                    MessageBox.Show("Ekleme işlemi başarılı");
                }
                else if (cmbYas.SelectedIndex == 1 && cmbKategori.SelectedIndex == 1)
                {
                    frm.gencFantastik.Add(txtKitapAdi.Text);
                    MessageBox.Show("Ekleme işlemi başarılı");
                }
                else if (cmbYas.SelectedIndex == 2 && cmbKategori.SelectedIndex == 0)
                {
                    frm.ortaSiyasi.Add(txtKitapAdi.Text);
                    MessageBox.Show("Ekleme işlemi başarılı");
                }
                else if (cmbYas.SelectedIndex == 2 && cmbKategori.SelectedIndex == 1)
                {
                    frm.ortaBiyografi.Add(txtKitapAdi.Text);
                    MessageBox.Show("Ekleme işlemi başarılı");
                }
                else
                    MessageBox.Show("Bir sorun var");
            }
            
        }

        private void cmbYas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbYas.SelectedIndex == 0)
            {
                cmbKategori.Items.Clear();
                cmbKategori.Items.Add("Macera");
                cmbKategori.Items.Add("Öğretici");
            }
            else if (cmbYas.SelectedIndex == 1)
            {
                cmbKategori.Items.Clear();
                cmbKategori.Items.Add("Macera");
                cmbKategori.Items.Add("Fantastik");
            }
            else if (cmbYas.SelectedIndex == 2)
            {
                cmbKategori.Items.Clear();
                cmbKategori.Items.Add("Siyasi");
                cmbKategori.Items.Add("Biyografi");
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frm.Show();
        }
    }
}
