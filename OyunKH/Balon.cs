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
using System;
using System.Collections.Generic;

namespace OyunKH
{
    class Balon : OrtakOzellik
    {
        private static Random rastgele = new Random();
        public Balon(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * 0.2);
            Left = Width + rastgele.Next(hareketAlaniBoyutlari.Width - 2*Width + 1);
        }
        public Ok VurulduMu(List<Ok> oklar)
        {
            foreach (var ok in oklar)
            {
                var vuruldumu =  ok.Right > Left && ok.Left < Right && ok.Top < Bottom && ok.Bottom>Top;
                if (vuruldumu) return ok;
            }
            return null;
        }
    }
}
