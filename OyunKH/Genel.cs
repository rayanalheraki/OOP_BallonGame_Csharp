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
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OyunKH
{
    public class Genel 
    {

        // ----------------variables & properties-------------------
        #region Değişkenler
        private Okcu _okcu;
        private Ok _ok;
        private YesilBalon _yBalon;
        private SariBalon _sBalon;
        private KirmiziBalon _kBalon;
        private Panel _okcuPanel;
        private Panel _balonPanel;
        private Timer _genelTimer;
        private Timer _hareketTimer; 
        private Timer _balonOlusturmaTimer;
        private TimeSpan _gecenSure;
        private readonly List<Ok> _oklar = new List<Ok>();
        private readonly List<YesilBalon> _yBalonlar = new List<YesilBalon>();
        private readonly List<SariBalon> _sBalonlar = new List<SariBalon>();
        private readonly List<KirmiziBalon> _kBalonlar = new List<KirmiziBalon>();
        public bool CalisiyorMu;
        public int okSayisi;
        public int yBalonSayisi;
        public int sBalonSayisi;
        public int kBalonSayisi;
        public int OyuncuAsamasi;
        public string OyuncuAdi;
        public int OyuncuPuani;
        public int satirIndex;
        private Image okcuResmi;
        private Image okResmi;
        private Image kBalonResmi;
        private Image yBalonResmi;
        private Image sBalonResmi;
        string path = @"demo.txt";
        #endregion

        //--------------Events------------------

        public event EventHandler GenelTimerDegisti;
        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;
                GenelTimerDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        //---------------constructor---------------------
        public Genel(Panel okcuPaneli,Panel BalonPanel,Oyuncu _oyuncu)
        {
            
            OyuncuPuani = 0;
            OyuncuAsamasi = _oyuncu.AsamaNo;
            OyuncuAdi = _oyuncu.Ad;
            OyuncuPuani += _oyuncu.Puan;
            satirIndex = _oyuncu.Index;
            _genelTimer = new Timer { Interval = 1000 };
            _hareketTimer = new Timer { Interval = 100 };
            _balonOlusturmaTimer = new Timer { Interval = 2000 };
            //aşamaya göre hızı ayarlar
            if (OyuncuAsamasi==2)
            {
                _balonOlusturmaTimer = new Timer { Interval = 1400 };
            }
            else if(OyuncuAsamasi==3)
            {
                _balonOlusturmaTimer = new Timer { Interval = 1100 };
            }
            _okcuPanel = okcuPaneli;
            _balonPanel = BalonPanel;
            _genelTimer.Tick += _genelTimer_Tick;
            _hareketTimer.Tick += _hareketTimer_Tick;
            _balonOlusturmaTimer.Tick += _balonlarTimer_Tick;
            
            okSayisi = 0;
            yBalonSayisi = 0;
            kBalonSayisi = 0;
            sBalonSayisi = 0;
        }

        //-----------------Methods-----------------------
     
        #region zamanlayıcılar
        private void _genelTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }
        private void _hareketTimer_Tick(object sender, EventArgs e)
        {
            OkHareketleri();
            YBalonHareketleri();
            KBalonHareketleri();
            SBalonHareketleri();
            YBalonSil();
            SBalonSil();
            KBalonSil();
            // Aşama bitirme Koşullerı
            // 1.Aşamada eğer 20 yeşil balon vuruldu ise başarlacak
            if (yBalonSayisi == 20 && OyuncuAsamasi == 1)
            {

                OyunuBitir();
                MessageBox.Show(OyuncuAsamasi.ToString() + ".Aşamasi başar ile bitirdiniz \nsonraki asamaya gitmek için ENTER bas.");
                OyuncuAsamasi = 2;
                return;
            }
            // 2.Aşamada eğer 20  yeşil balon ve 6 sarı balon vuruldu ise başarlacak
            else if (yBalonSayisi + sBalonSayisi == 26 && OyuncuAsamasi == 2)
            {
                OyunuBitir();
                MessageBox.Show(OyuncuAsamasi.ToString() + ".Aşamasi başar ile bitirdiniz \nsonraki asamaya gitmek için ENTER bas. ");
                OyuncuAsamasi = 3;
                return;
            }
            // 3.Aşamada eğer 20  yeşil balon, 4 sarı balon ve 4 sarı balon vuruldu ise başarlacak
            else if (yBalonSayisi + kBalonSayisi + sBalonSayisi == 28 && OyuncuAsamasi == 3)
            {
                OyunuBitir();

                MessageBox.Show("Tebrikler Oyunu başar ile bitirdiniz");
                return;
            }
        }

        private void _balonlarTimer_Tick(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            //aşama numarasına göre işlem yapar
            switch (OyuncuAsamasi)
            {
                case 1:
                    YesilBalonOlustur();
                    break;
                case 2:
                    // random bir sayi kullanarak 1 - 2 arasında bir nomara seçip ona göre balonun renkini seçer, balon sayıları sınırlı olacak
                    while(true)
                    { 
                        int rastgeleSec = rnd.Next(0, 4);
                        if (rastgeleSec == 1 && yBalonSayisi<20)
                        {
                            YesilBalonOlustur();
                            break;
                        }else if(rastgeleSec==2 && sBalonSayisi < 6)
                        {
                            SariBalonOlustur();
                            break;
                        }
                    }
                    break;
                case 3:
                    // random bir sayi kullanarak 1 - 3 arasında bir nomara seçip ona göre balonun renkini seçer, balon sayıları sınırlı olacak
                    while (true)
                    {
                        int rastgeleSec = rnd.Next(0, 5);
                        if (rastgeleSec == 1 && sBalonSayisi < 20)
                        {
                            YesilBalonOlustur();
                            break;
                        }
                        else if (rastgeleSec == 2 && sBalonSayisi < 4)
                        {
                            SariBalonOlustur();
                            break;
                        }
                        else if (rastgeleSec == 3 && kBalonSayisi < 4)
                        {
                            KirmiziBalonOlustur();
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
            
        }
        #endregion

        public void OyunuBaslat()
        {
            // eger oyunu calismiyorsa oyunu calistiracak
            if (!CalisiyorMu)
            {
                //_okcuPanel.Controls.Remove(_okcu);
                CalisiyorMu = true;
                _genelTimer.Start();
                _hareketTimer.Start();
                _balonOlusturmaTimer.Start();
                OkcuOlustur();
            }
            else return;
        }
        private void OyunuBitir()
        {
            if (CalisiyorMu)
            {
                CalisiyorMu = false;
                _genelTimer.Stop();
                _hareketTimer.Stop();
                _balonOlusturmaTimer.Stop();
                yBalonSayisi = 0;
                sBalonSayisi = 0;
                kBalonSayisi = 0;
                okSayisi = 0;
            }
            else return;
        }
        public  void AtesEt()
        {

            if (CalisiyorMu)
            {
                OkOlustur();
            }
            else return;

        }
   
        #region resimler_değiştirme_fonksiyonlaru
        public void OkcuResimDegistir(Image s)
        {
            s = new Bitmap(s, 135, 135);
            okcuResmi = s;
        }
        public void OkResimDegistir(Image s)
        {
            s = new Bitmap(s, 25, 88);
            okResmi = s;
        }
        public void kBalonResimDegistir(Image s)
        {
            s = new Bitmap(s, 80, 100);
            kBalonResmi = s;
        }
        public void yBalonResimDegistir(Image s)
        {
            s = new Bitmap(s, 80, 100);
            yBalonResmi = s;
        }
        public void sBalonResimDegistir(Image s)
        {
            s = new Bitmap(s, 80, 100);
            sBalonResmi = s;
        }
        #endregion

        #region nesne_oluşturma_fonksiyonleri
        private void OkcuOlustur()
        {
            _okcu = new Okcu(_okcuPanel.Height, _okcuPanel.Size);
            if(okcuResmi!=null)
            _okcu.Image=okcuResmi;
            _okcuPanel.Controls.Add(_okcu);
        }
        public  void OkOlustur()
        {
            Size x = new Size(50, 0);
            _ok = new Ok(_balonPanel.Size+ x, _okcu.Middle);
            if (okResmi != null)
                _ok.Image = okResmi;
            _oklar.Add(_ok);
            _balonPanel.Controls.Add(_ok);
            okSayisi++;
            if(okSayisi==50 && OyuncuAsamasi==3 )
            {
                OyunuBitir();
            }
            
        }
        private void YesilBalonOlustur()
        {
            _yBalon = new YesilBalon(_balonPanel.Size);
            if (yBalonResmi != null)
                _yBalon.Image = yBalonResmi;
            _yBalonlar.Add(_yBalon);
            _balonPanel.Controls.Add(_yBalon);
            
        }
        private void SariBalonOlustur()
        {
            _sBalon = new SariBalon(_balonPanel.Size);
            if (sBalonResmi != null)
                _sBalon.Image =sBalonResmi;
            _sBalonlar.Add(_sBalon);
            _balonPanel.Controls.Add(_sBalon);
            sBalonSayisi++;
        }
        private void KirmiziBalonOlustur()
        {
            Size x = new Size(0, 150);
            _kBalon = new KirmiziBalon(_balonPanel.Size+ x);
            if (kBalonResmi != null)
                _kBalon.Image = kBalonResmi;
            _kBalonlar.Add(_kBalon);
            _balonPanel.Controls.Add(_kBalon);
            kBalonSayisi++;
        }
        #endregion

        #region nesne_hareketleme_fonksiyonleri
        public void OkcuHareketleri(Yon yon)
        {
            if (CalisiyorMu)
                _okcu.HareketEttir(yon);
        }
        private void OkHareketleri()
        {
            for (int i = _oklar.Count - 1; i >= 0; i--)
            {
                var ok = _oklar[i];
                var carptiMi = ok.HareketEttir(Yon.saga);
                if (carptiMi)
                {
                    _oklar.Remove(ok);
                    _balonPanel.Controls.Remove(ok);
                }
            }
        }
        private void YBalonHareketleri()
        {
            foreach (var ybalon in _yBalonlar)
            {
                var carpiMi = ybalon.HareketEttir(Yon.asagi);
                if (!carpiMi) continue;

                OyunuBitir();
                break;
            }
        }
        private void SBalonHareketleri()
        {
            foreach (var sbalon in _sBalonlar)
            {
                var carpiMi = sbalon.HareketEttir(Yon.asagi);
                if (!carpiMi) continue;

                OyunuBitir();
                break;
            }
        }
        private void KBalonHareketleri()
        {
            foreach (var kbalon in _kBalonlar)
            {
                var carpiMi = kbalon.HareketEttir(Yon.asagi);
                if (carpiMi)
                {
                }
                //_kBalonlar.Remove(kbalon);
                //_balonPanel.Controls.Remove(kbalon);
                //OyunuBitir();
                //break;
            }
        }
        #endregion

        #region silme_fonksiyonleri
        private void YBalonSil()
        {
            for (int i = _yBalonlar.Count - 1; i >= 0; i--)
            {
                var yBalon = _yBalonlar[i];

                var vuranBalon = yBalon.VurulduMu(_oklar);
                if (vuranBalon is null) continue;

                _yBalonlar.Remove(yBalon);
                _oklar.Remove(vuranBalon);
                _balonPanel.Controls.Remove(yBalon);
                _balonPanel.Controls.Remove(vuranBalon);
                OyuncuPuani += 5;
                yBalonSayisi++;
            }

        }
        private void SBalonSil()
        {
            for (int i = _sBalonlar.Count - 1; i >= 0; i--)
            {
                var sBalon = _sBalonlar[i];

                var vuranBalon = sBalon.VurulduMu(_oklar);
                if (vuranBalon is null) continue;

                _sBalonlar.Remove(sBalon);
                _oklar.Remove(vuranBalon);
                _balonPanel.Controls.Remove(sBalon);
                _balonPanel.Controls.Remove(vuranBalon);
                OyuncuPuani += 15;
            }
        }
        private void KBalonSil()
        {
            for (int i = _kBalonlar.Count - 1; i >= 0; i--)
            {
                var kBalon = _kBalonlar[i];

                var vuranBalon = kBalon.VurulduMu(_oklar);
                if (vuranBalon is null) continue;
                _kBalonlar.Remove(kBalon);
                _oklar.Remove(vuranBalon);
                _balonPanel.Controls.Remove(kBalon);
                _balonPanel.Controls.Remove(vuranBalon);
                OyuncuPuani = 0;
            }
        }
        #endregion
    }
}
