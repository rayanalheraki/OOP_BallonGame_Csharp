using OyunKH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjeYaz2020
{
    public partial class Kaydet : Form
    {
        private Genel oyuncu;
        private Oyun oyunFormu;
        private AnaMenu anaMenu;

        private string path = @"demo.txt";

        private string yeniSatir;
        public Kaydet(Genel _oyuncu,Oyun _oyunFormu,AnaMenu _anaMenu)
        {
            InitializeComponent();
            oyuncu = _oyuncu;
            anaMenu = _anaMenu;
            oyunFormu = _oyunFormu;
        }

        // satrın numarası kullanarak satır değiştirme fonksiyonu
        private void satirDegistir(string yeniSatir, int satirNo)
        {
            string[] Satirlar = File.ReadAllLines(path);
            Satirlar[satirNo] = yeniSatir;
            File.WriteAllLines(path, Satirlar);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // text dosyasinda anı oyuncu satrı üzerinde düzenleme yapar
            yeniSatir = oyuncu.OyuncuAdi + "," + oyuncu.OyuncuPuani + "," + oyuncu.OyuncuAsamasi;
            satirDegistir(yeniSatir, oyuncu.satirIndex);
            KayitEdildi.Text = "kayit edildi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // text dosyasinda oyuncu puanı ve asaması sıfırlanıyor 
            yeniSatir = oyuncu.OyuncuAdi + "," + 0 + "," + 1 ;
            satirDegistir(yeniSatir, oyuncu.satirIndex);
            KayitEdildi.Text = "Sıfırlandı";
            oyunFormu.Close();
            anaMenu.OkuListele();
        }

        private void Kaydet_Load(object sender, EventArgs e)
        {

        }
    }
}
