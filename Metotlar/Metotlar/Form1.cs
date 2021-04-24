using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uyariver();
            Topla(12, 23);
            decimal ttr = KdvHesapla((decimal)100);
            int toplam = Toplam();
            decimal ttr2 = KdvHesapla(100, (decimal)0.18);
            decimal tpl = KdvHesapla((double)0.15);
        }
        void Uyariver()
        {
            MessageBox.Show("Test");
        }
        void Topla(int s1, int s2)
        {
            int topla = s1 + s2;

        }
        decimal KdvHesapla(decimal fiyat)
        {
            decimal tutar = fiyat + (fiyat * (decimal)0.18);
            return tutar;
        }
        decimal KdvHesapla(decimal fiyat,decimal KdvOrani)
        {
            decimal tutar = fiyat + fiyat * KdvOrani;
            return tutar;
        }
        decimal KdvHesapla(double KdvOrani)
        {
            decimal tutar = Convert.ToDecimal( 200 + (200 * KdvOrani));
            return tutar;
        }
        int Toplam()
        {
            return 19 + 23;
        }
        

    }
}
