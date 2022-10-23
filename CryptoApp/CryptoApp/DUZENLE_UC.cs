using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApp
{
    public partial class DUZENLE_UC : UserControl
    {
        public DUZENLE_UC()
        {
            InitializeComponent();
        }

        private void txtI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void kaydet()
        {
            Settings1.Default.a = txta.Text;
            Settings1.Default.b = txtb.Text;
            Settings1.Default.c = txtc.Text;
            Settings1.Default.d = txtd.Text;
            Settings1.Default.e = txte.Text;
            Settings1.Default.f = txtf.Text;
            Settings1.Default.g = txtg.Text;
            Settings1.Default.h = txth.Text;
            Settings1.Default.i = txti.Text;
            Settings1.Default.j = txtj.Text;
            Settings1.Default.k = txtk.Text;
            Settings1.Default.l = txtl.Text;
            Settings1.Default.m = txtm.Text;
            Settings1.Default.n = txtn.Text;
            Settings1.Default.o = txto.Text;
            Settings1.Default.p = txtp.Text;
            Settings1.Default.q = txtq.Text;
            Settings1.Default.r = txtr.Text;
            Settings1.Default.s = txts.Text;
            Settings1.Default.t = txtt.Text;
            Settings1.Default.u = txtu.Text;
            Settings1.Default.v = txtv.Text;
            Settings1.Default.w = txtw.Text;
            Settings1.Default.x = txtx.Text;
            Settings1.Default.y = txty.Text;
            Settings1.Default.z = txtz.Text;
            Settings1.Default.Space = txtSpace.Text;
            Settings1.Default.HARF1 = txt1.Text;
            Settings1.Default.HARF2 = txt2.Text;
            Settings1.Default.HARF3 = txt3.Text;
            Settings1.Default.HARF4 = txt4.Text;
            Settings1.Default.HARF5 = txt5.Text;
            Settings1.Default.HARF6 = txt6.Text;
            Settings1.Default.Save();
            MessageBox.Show("Bilgiler Kaydedildi.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void getir()
        {
            txta.Text = Settings1.Default.a;
            txtb.Text = Settings1.Default.b;
            txtc.Text = Settings1.Default.c;
            txtd.Text = Settings1.Default.d;
            txte.Text = Settings1.Default.e;
            txtf.Text = Settings1.Default.f;
            txtg.Text = Settings1.Default.g;
            txth.Text = Settings1.Default.h;
            txti.Text = Settings1.Default.i;
            txtj.Text = Settings1.Default.j;
            txtk.Text = Settings1.Default.k;
            txtl.Text = Settings1.Default.l;
            txtm.Text = Settings1.Default.m;
            txtn.Text = Settings1.Default.n;
            txto.Text = Settings1.Default.o;
            txtp.Text = Settings1.Default.p;
            txtq.Text = Settings1.Default.q;
            txtr.Text = Settings1.Default.r;
            txts.Text = Settings1.Default.s;
            txtt.Text = Settings1.Default.t;
            txtu.Text = Settings1.Default.u;
            txtv.Text = Settings1.Default.v;
            txtw.Text = Settings1.Default.w;
            txtx.Text = Settings1.Default.x;
            txty.Text = Settings1.Default.y;
            txtz.Text = Settings1.Default.z;
            txtSpace.Text = Settings1.Default.Space;
            txt1.Text = Settings1.Default.HARF1;
            txt2.Text = Settings1.Default.HARF2;
            txt3.Text = Settings1.Default.HARF3;
            txt4.Text = Settings1.Default.HARF4;
            txt5.Text = Settings1.Default.HARF5;
            txt6.Text = Settings1.Default.HARF6;         
        }
        private void btnKAYDET_Click(object sender, EventArgs e)
        {
             kaydet();           
        }

        private void DUZENLE_UC_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void txtSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
