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

using System.IO;
using System.Windows.Forms;

namespace OyunKH
{
    public class Oyuncu
    {

        private string ad;
        private int puan;
        private int asamaNo;
        private int index;
        public string Ad { get => ad; set => ad = value; }
        public int Puan { get => puan; set => puan = value; }
        public int AsamaNo { get => asamaNo; set => asamaNo = value; }
        public int Index { get => index; set => index = value; }

        public Oyuncu()
        {
        }



    }
}
