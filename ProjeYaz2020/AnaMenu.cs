/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**			 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				  NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Rayan Alheraki
**				ÖĞRENCİ NUMARASI.......: G171210556
****************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using OyunKH;

namespace ProjeYaz2020
{
    public partial class AnaMenu : Form
    {

        private string path = @"demo.txt";
        private List<Oyuncu> _oyuncular = new List<Oyuncu>();
        Oyuncu _oyuncu;
        int oyuncuIndex = 0;

        public AnaMenu()
        {
            InitializeComponent();
            OkuListele();

        }
        public void OkuListele()
        {
            //_oyuncular.Clear();
            OyuncuListe.Items.Clear();
            // Dosyadan Okuma ve combobox'te listeleme işlemleri
            using (StreamReader sr = File.OpenText(path))
            {
                OyuncuListe.Items.Clear();
                _oyuncular.Clear();
                string stir = "";
                while ((stir = sr.ReadLine()) != null)
                {
                    String[] liste = stir.Split(',');
                    _oyuncu = new Oyuncu()
                    {
                        Ad = liste[0],
                        Puan = Convert.ToInt16(liste[1]),
                        AsamaNo = Convert.ToInt16(liste[2]),
                        Index = oyuncuIndex
                    };
                    _oyuncular.Add(_oyuncu);
                    oyuncuIndex++;
                }
            }
            //kayıtlı oyuncular listbox'a ekleme yapıyor 
            foreach (var _oyuncu in _oyuncular)
            {
                OyuncuListe.Items.Add(_oyuncu.Ad);

            }
        }

        //yeni kayit işlemleri 
        private void button1_Click(object sender, EventArgs e)
        {
            //eğer ad alanı boş ise işlem yapmayacak 
            if (GirilenAd.Text.ToString() == "")
            {
                MessageBox.Show("Oyuncu adi giriniz.");
                return;
            }
            //dosyaya son satira yazma
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(GirilenAd.Text.ToString() + "," + 0 + "," + 1);  
            }
            OkuListele();
            label5.Text = "Eklendi :)";
        }

        //Eski oyuncu seçeme butonu 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //listbox´tan seçelen eleman indeksini kullanarak listten oyuncu seçer
                _oyuncu = _oyuncular[Convert.ToInt32(OyuncuListe.SelectedIndex)];
                Oyun oyunFormu = new Oyun(_oyuncu,this);
                oyunFormu.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("bir Oyuncu seciniz" );
            }
        }
        #region gereksiz
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
        #endregion

        //l
        private void OyuncuListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox´te seçelen eleman degiştiriliyorsa Oyuncu puanı ve asama numarası değiştirecek
            _oyuncu = _oyuncular[Convert.ToInt32(OyuncuListe.SelectedIndex)];
            PuanBox.Text = _oyuncu.Puan.ToString();
            AsamaBox.Text = _oyuncu.AsamaNo.ToString();
        }
        
        
    }
}
