using GManager.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lbProductVersion.Text = "Versão " + Application.ProductVersion;
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock form = new FrmStock();
            form.MdiParent = this;
            form.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutBox form = new FrmAboutBox();
            form.ShowDialog();
        }
    }
}
