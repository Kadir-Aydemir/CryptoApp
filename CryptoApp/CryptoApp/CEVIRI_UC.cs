using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CryptoApp
{
    public partial class CEVIRI_UC : UserControl
    {
        public CEVIRI_UC()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (panelNormal.Visible == true)
            {
                panelNormal.Visible = false;
                panelSIFRELI.Visible = true;
                panelSIFRELI.BringToFront();
                btnChange.BringToFront();
                btnCevir.Visible = false;
                btnCevir2.Visible = true;
                btnCevir2.BringToFront();
            }
            else
            {
                panelSIFRELI.Visible = false;
                panelNormal.Visible = true;
                panelNormal.BringToFront();
                btnChange.BringToFront();
                btnCevir.Visible = true;
                btnCevir2.Visible = false;
                btnCevir.BringToFront();
            }
        }
        string sonuc;
        void harfuret()
        {
            Refresh();
            Refresh();
            string[] harf = new string[6];
            for (int i = 0; i < 6; i++)
            {
                string s = "HARF" + (i + 1);
                harf[i] = Settings1.Default[s].ToString();
            }
            Random rd = new Random();
            sonuc = harf[rd.Next(6)];//harf[r];
        }
        private void btnCevir_Click(object sender, EventArgs e)
        {
            try
            {
                string metin = txtNORMAL.Text.Trim();
                string ceviri = "";
                string bul;
                int sayac = 0;

                for (int i = 0; i < metin.Length; i++)
                {  
                    sayac++;
                    if (metin.Length % 2 == 0)
                    {                      
                        if (sayac == 1)
                        {
                            if (metin[i].ToString() != " ")
                            {
                                harfuret();
                                bul = metin[i].ToString();
                                ceviri = ceviri + sonuc + Settings1.Default[bul];
                            }
                            else
                            {
                                harfuret();
                                ceviri = ceviri + sonuc + Settings1.Default.Space;
                            }
                        }
                        if (sayac == 2)
                        {
                            if (metin[i].ToString() != " ")
                            {
                                harfuret();
                                bul = metin[i].ToString();
                                ceviri = ceviri + Settings1.Default[bul] + sonuc + " ";
                                sayac = 0;
                            }
                            else
                            {
                                harfuret();
                                ceviri = ceviri + Settings1.Default.Space + sonuc + " ";
                                sayac = 0;
                            }
                        }
                    }
                    else
                    {
                        if (i != metin.Length - 1)
                        {
                            if (sayac == 1)
                            {
                                if (metin[i].ToString() != " ")
                                {
                                    harfuret();
                                    bul = metin[i].ToString();
                                    ceviri = ceviri + sonuc + Settings1.Default[bul];
                                }
                                else
                                {
                                    harfuret();
                                    ceviri = ceviri + sonuc + Settings1.Default.Space;
                                }
                            }
                            if (sayac == 2)
                            {
                                if (metin[i].ToString() != " ")
                                {
                                    harfuret();
                                    bul = metin[i].ToString();
                                    ceviri = ceviri + Settings1.Default[bul] + sonuc + " ";
                                    sayac = 0;
                                }
                                else
                                {
                                    harfuret();
                                    ceviri = ceviri + Settings1.Default.Space + sonuc + " ";
                                    sayac = 0;
                                }
                            }
                        }
                        else
                        {
                            if (metin[i].ToString() != " ")
                            {
                                harfuret();
                                bul = metin[i].ToString();
                                ceviri = ceviri + sonuc;
                                harfuret();
                                ceviri = ceviri + sonuc;
                                ceviri = ceviri + Settings1.Default[bul];
                                harfuret();
                                ceviri = ceviri + sonuc;
                                harfuret();
                                ceviri = ceviri + sonuc;
                            }
                            else
                            {
                                harfuret();
                                ceviri = ceviri + sonuc;
                                harfuret();
                                ceviri = ceviri + sonuc;
                                ceviri = ceviri + Settings1.Default.Space;
                                harfuret();
                                ceviri = ceviri + sonuc;
                                harfuret();
                                ceviri = ceviri + sonuc;
                            }
                        }
                    }
                }
                txtSIFRELI.Text = ceviri;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin, sadece küçük harf kullanın,rakam veya özel karakter kullanmayın!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void txtNORMAL_TextChanged(object sender, EventArgs e)
        {
            txtNORMAL.Text = txtNORMAL.Text.ToLower();
            txtNORMAL.SelectionStart = txtNORMAL.Text.Length;
            lblnormalkarakter.Text = txtNORMAL.TextLength.ToString();
        }

        private void txtSIFRELI2_TextChanged(object sender, EventArgs e)
        {
            txtSIFRELI2.Text = txtSIFRELI2.Text.ToLower();
            txtSIFRELI2.SelectionStart = txtSIFRELI2.Text.Length;
            lblsifrelikarakter.Text = txtSIFRELI2.TextLength.ToString();
        }

        private void btnCevir2_Click(object sender, EventArgs ea)
        {
            try
            {
                string cevir = "";
                string str = txtSIFRELI2.Text.Trim();
                string[] sayilar = Regex.Split(str, @"\D+");
                foreach (string ss in sayilar)
                {
                    int sayi;
                    string syi = "";
                    if (int.TryParse(ss, out sayi))
                    {
                        List<string> Grup = new List<string>();
                        for (int j = 0; j < ss.Length; j++)
                        {
                            if (j % 2 == 0)
                                Grup.Add(ss.Substring(j, 2));
                        }
                        for (int k = 0; k < Grup.Count; k++)
                        {
                            syi = Grup[k];
                            if (syi == Settings1.Default.a)
                            {
                                cevir = cevir + "a";
                            }
                            if (syi == Settings1.Default.b)
                            {
                                cevir = cevir + "b";
                            }
                            if (syi == Settings1.Default.c)
                            {
                                cevir = cevir + "c";
                            }
                            if (syi == Settings1.Default.d)
                            {
                                cevir = cevir + "d";
                            }
                            if (syi == Settings1.Default.e)
                            {
                                cevir = cevir + "e";
                            }
                            if (syi == Settings1.Default.f)
                            {
                                cevir = cevir + "f";
                            }
                            if (syi == Settings1.Default.g)
                            {
                                cevir = cevir + "g";
                            }
                            if (syi == Settings1.Default.h)
                            {
                                cevir = cevir + "h";
                            }
                            if (syi == Settings1.Default.i)
                            {
                                cevir = cevir + "i";
                            }
                            if (syi == Settings1.Default.j)
                            {
                                cevir = cevir + "j";
                            }
                            if (syi == Settings1.Default.k)
                            {
                                cevir = cevir + "k";
                            }
                            if (syi == Settings1.Default.l)
                            {
                                cevir = cevir + "l";
                            }
                            if (syi == Settings1.Default.m)
                            {
                                cevir = cevir + "m";
                            }
                            if (syi == Settings1.Default.n)
                            {
                                cevir = cevir + "n";
                            }
                            if (syi == Settings1.Default.o)
                            {
                                cevir = cevir + "o";
                            }
                            if (syi == Settings1.Default.p)
                            {
                                cevir = cevir + "p";
                            }
                            if (syi == Settings1.Default.q)
                            {
                                cevir = cevir + "q";
                            }
                            if (syi == Settings1.Default.r)
                            {
                                cevir = cevir + "r";
                            }
                            if (syi == Settings1.Default.s)
                            {
                                cevir = cevir + "s";
                            }
                            if (syi == Settings1.Default.t)
                            {
                                cevir = cevir + "t";
                            }
                            if (syi == Settings1.Default.u)
                            {
                                cevir = cevir + "u";
                            }
                            if (syi == Settings1.Default.v)
                            {
                                cevir = cevir + "v";
                            }
                            if (syi == Settings1.Default.w)
                            {
                                cevir = cevir + "w";
                            }
                            if (syi == Settings1.Default.x)
                            {
                                cevir = cevir + "x";
                            }
                            if (syi == Settings1.Default.y)
                            {
                                cevir = cevir + "y";
                            }
                            if (syi == Settings1.Default.z)
                            {
                                cevir = cevir + "z";
                            }
                            if (syi == Settings1.Default.Space)
                            {
                                cevir = cevir + " ";
                            }
                        }
                    }
                }
                txtNORMAL2.Text = cevir;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
