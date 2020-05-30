using System;
using System.Collections;
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
    

    public partial class Form1 : Form
    {
        public ArrayList cocukMacera = new ArrayList();
        public ArrayList cocukOgretici = new ArrayList();
        public ArrayList gencMacera = new ArrayList();
        public ArrayList gencFantastik = new ArrayList();
        public ArrayList ortaSiyasi = new ArrayList();
        public ArrayList ortaBiyografi = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        public void Doldur()
        {
            cocukMacera.Add( "Küçük Prens");
            cocukMacera.Add( "Macera Geçidi");
            cocukOgretici.Add( "Çocuk Kalbi");
            cocukOgretici.Add( "Kaşağı");

            gencMacera.Add("Başlangıç/Dan Brown");
            gencMacera.Add("Mahşer/Stephen King");
            gencMacera.Add("Kargalar Meclisi/Leigh Bardugo");
            gencFantastik.Add("Dönüşüm/Franz Kafka");
            gencFantastik.Add("Hayaletin Çırağı/Joseph Delaney");
            gencFantastik.Add("Mahşer İzleri/Ali Kerem");

            ortaSiyasi.Add("Kara Kutu/Soner Yalçın");
            ortaSiyasi.Add("Şaki/Murat Ağırel");
            ortaSiyasi.Add("Beyaz Zambaklar/Grigory Petrov");
            ortaBiyografi.Add("Bir Şizofrenin Yaşamı/Elyn R. Saks");
            ortaBiyografi.Add("Hitler Problemi/John Lukacs");
            ortaBiyografi.Add("Adı Aylin/Ayşe Kulin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void rdnBtnCocuk_CheckedChanged(object sender, EventArgs e)
        {
            rdnBtn1.Text = "Macera";
            rdnBtn2.Text = "Öğretici";
        }

        private void rdnBtnGenc_CheckedChanged(object sender, EventArgs e)
        {
            rdnBtn1.Text = "Macera";
            rdnBtn2.Text = "Fantastik";
        }

        private void rdnBtnOrta_CheckedChanged(object sender, EventArgs e)
        {
            rdnBtn1.Text = "Siyasi";
            rdnBtn2.Text = "Biyografi";
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int no;

            if (rdnBtnCocuk.Checked == true && rdnBtn1.Checked == true)
            {
                no = random.Next(0, cocukMacera.Count);
                lblTavsiye.Text = "Okumanız gereken kitap -> " + cocukMacera[no].ToString();
            }
            else if (rdnBtnCocuk.Checked == true && rdnBtn2.Checked == true)
            {
                no = random.Next(0, cocukOgretici.Count);
                lblTavsiye.Text = "Okumanız gereken kitap -> " + cocukOgretici[no].ToString();
            }

            else if (rdnBtnGenc.Checked == true && rdnBtn1.Checked == true)
            {
                no = random.Next(0, gencMacera.Count);
                lblTavsiye.Text = "Okumanız gereken kitap -> " + gencMacera[no].ToString();
            }

            else if (rdnBtnGenc.Checked == true && rdnBtn2.Checked == true)
            {
                no = random.Next(0, gencFantastik.Count);
                lblTavsiye.Text = "Okumanız gereken kitap -> " + gencFantastik[no].ToString();
            }

            else if (rdnBtnOrta.Checked == true && rdnBtn1.Checked == true)
            {
                no = random.Next(0, ortaSiyasi.Count);
                lblTavsiye.Text = "Okumanız gereken kitap -> " + ortaSiyasi[no].ToString();
            }

            else if (rdnBtnOrta.Checked == true && rdnBtn2.Checked == true)
            {
                no = random.Next(0, ortaBiyografi.Count);
                lblTavsiye.Text = "Okumanız gereken kitap -> " + ortaBiyografi[no].ToString();
            }

            else
                MessageBox.Show("Yanlış birşey var");
        }
    }
}
