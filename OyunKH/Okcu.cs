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
using System.Windows.Forms;
using System.Drawing;

namespace OyunKH
{
    class Okcu : OrtakOzellik
    {
        public Okcu(int panelBoyu, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"img\{GetType().Name}.png");
            Middle = panelBoyu /2 ;
            HareketMesafesi = 50;
        }
    }
}
