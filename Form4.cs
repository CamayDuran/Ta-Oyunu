using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace YazilimSinama1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            taslar = new List<Taslar>();
            InitializeComponent();
        }
        Image resim;
        List<Taslar> taslar; //Taslari tytacak olan dizi

        private void Form4_Load(object sender, EventArgs e)
        {
            resim = Image.FromFile(@"C:\Users\Lenovo\Desktop\Oyun\ggg.png");//resmin uzantısını çağırdık
            TaslariOlustur();//Taşları olustur fonk 
        }

        public void TaslariOlustur()
        {
            Bitmap bmp_res = new Bitmap(resim);
            int genislik = 72;
            int yukseklik = 99;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Taslar yeni_tas = new Taslar();
                    yeni_tas.resmi = bmp_res.Clone(new Rectangle(x * genislik, y * yukseklik, genislik, yukseklik), resim.PixelFormat);
                    taslar.Add(yeni_tas);
                }
            }
        }

        private void baslabtn_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();//rasgele nereye yerlesecegi
            int sayi1 = rastgele.Next(1, 64);
            int sayi2 = rastgele.Next(1, 64);
            int sayi3 = rastgele.Next(1, 64);
            int sayi4 = rastgele.Next(1, 64);
            int sayi5 = rastgele.Next(1, 64);
            int sayi6 = rastgele.Next(1, 64);
            int sayi7 = rastgele.Next(1, 64);

            int[] konum = { sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7 };
            int sayi;
            int[] sayilar = new int[7];
            for (int j = 0; j < 7; j++)
            {
                Random rast = new Random();//rasgele hangi sayının gelecegi
                sayi = rast.Next(0, 10);
                sayilar[j] = sayi;
            }

            for (int i = 0; i < 7; i++)
            {
                switch (konum[i])
                {
                    case 0:
                        A0.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 1:
                        A1.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 2:
                        A2.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 3:
                        A3.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 4:
                        A4.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 5:
                        A5.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 6:
                        A6.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 7:
                        A7.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 8:
                        B0.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 9:
                        B1.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 10:
                        B2.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 11:
                        B3.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 12:
                        B4.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 13:
                        B5.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 15:
                        B7.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 16:
                        C0.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 17:
                        C1.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 19:
                        C3.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 20:
                        C4.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 21:
                        C5.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 22:
                        C6.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 23:
                        C7.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 24:
                        D0.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 25:
                        D1.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 26:
                        D2.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 27:
                        D3.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 29:
                        D5.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 30:
                        D6.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 31:
                        D7.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 32:
                        E0.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 33:
                        E1.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 34:
                        E2.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 35:
                        E3.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 36:
                        E4.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 37:
                        E5.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 38:
                        E6.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 39:
                        E7.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 40:
                        F0.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 41:
                        F1.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 42:
                        F2.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 44:
                        F4.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 45:
                        F5.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 46:
                        F6.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 47:
                        F7.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 48:
                        G0.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 49:
                        G1.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 50:
                        G2.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 51:
                        G3.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 52:
                        G4.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 53:
                        G5.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 54:
                        G6.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 55:
                        G7.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 56:
                        H0.Image = taslar[sayilar[3]].resmi;
                        break;
                    case 57:
                        H1.Image = taslar[sayilar[4]].resmi;
                        break;
                    case 58:
                        H2.Image = taslar[sayilar[5]].resmi;
                        break;
                    case 59:
                        H3.Image = taslar[sayilar[6]].resmi;
                        break;
                    case 60:
                        H4.Image = taslar[sayilar[0]].resmi;
                        break;
                    case 61:
                        H5.Image = taslar[sayilar[1]].resmi;
                        break;
                    case 62:
                        H6.Image = taslar[sayilar[2]].resmi;
                        break;
                    case 63:
                        F2.Image = taslar[sayilar[3]].resmi;
                        break;

                }

            }
        }

        private void EngelKoy(object sender, MouseEventArgs e)
        {
            PictureBox dosya = (PictureBox)sender;
            dosya.BackColor = Color.Brown;
        }
    }
}
