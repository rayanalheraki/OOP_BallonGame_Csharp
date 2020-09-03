/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**			 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				  NESNEYE DAYALI PROGRAMLAMA DERSİ
**					   2019-2020 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Rayan Alheraki
**				ÖĞRENCİ NUMARASI.......: G171210556
****************************************************************************/
using System.Drawing;
using System.Windows.Forms;

namespace OyunKH
{
    class Ok : OrtakOzellik
    {
        
        public Ok(Size hareketAlaniBoyutlari, int Ortada) :base(hareketAlaniBoyutlari)
        {
            Image = Image.FromFile(@"img\Ok.png");
            HareketMesafesi = (int)(Width * 1.2);
            Left = 0;
            Middle = Ortada;
        }
        
    }
}
