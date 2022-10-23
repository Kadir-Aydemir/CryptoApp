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
    public partial class CryptoApp : Form
    {
        public CryptoApp()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            PanelContainer.Controls.Add(uc);
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DUZENLE_UC dc = new DUZENLE_UC();
            addUserControl(dc);
        }

        private void btnCeviri_Click(object sender, EventArgs e)
        {
            CEVIRI_UC cc = new CEVIRI_UC();
            addUserControl(cc);
        }

        private void CryptoApp_Load(object sender, EventArgs e)
        {
            CEVIRI_UC cc = new CEVIRI_UC();
            addUserControl(cc);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
