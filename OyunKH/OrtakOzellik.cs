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
using System.Windows.Forms;
using System.Drawing;

namespace OyunKH
{
    public enum Yon
    {
        yukari,
        sola,
        saga,
        asagi
    }
    internal abstract class OrtakOzellik : PictureBox 
    {
        public OrtakOzellik(Size hareketAlaniBoyutlari)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            BackColor = Color.Transparent;
        }

        public Size HareketAlaniBoyutlari { get; }
        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }
        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }
        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }
        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        public bool HareketEttir(Yon yon)
        {
            if(yon==Yon.yukari)
            {
                return YukariHareketEttir();
            }else if(yon == Yon.asagi)
            {
                return asagiHareketEttir();
            }
            else if (yon == Yon.sola)
            {
                return SolaHareketEttir();
            }
            else if (yon == Yon.saga)
            {
                return SagaHareketEttir();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }
        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;
            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;
            //nesnenin hareket alanin sağ sonuna ulaştiysa fonksiyondan çıkacak
            Right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;
            return Right == HareketAlaniBoyutlari.Width;
        }
        private bool SolaHareketEttir()
        {
            if (Left == 0) return true;
            var yeniLeft = Left - HareketMesafesi;
            var tasacakMi = yeniLeft < 0;
            //nesnenin hareket alanin sol sonuna ulaştiysa fonksiyondan çıkacak
            Left = tasacakMi ? 0 : yeniLeft;
            return Left == 0;
        }
        private bool asagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;
            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;
            //nesnenin hareket alanin aşaği sonuna ulaştiysa fonksiyondan çıkacak
            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;
            return Bottom == HareketAlaniBoyutlari.Height;
        }
        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;
            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            //nesnenin hareket alanin Yukari sonuna ulaştiysa fonksiyondan çıkacak
            Top = tasacakMi ? 0 : yeniTop;
            return Top == 0;
        }

    }
}
