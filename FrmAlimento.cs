using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_MarcoHenrique
{
    public partial class FrmAlimento : Form
    {
        public FrmAlimento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prefeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito(); //Indico qual form será aberto
            this.Hide(); //fechar atual
            frm.ShowDialog(); //Abrir novo form
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja(); //Indico qual form será aberto
            this.Hide(); //fechar atual
            frm.ShowDialog(); //Abrir novo form
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento(); //Indico qual form será aberto
            this.Hide(); //fechar atual
            frm.ShowDialog(); //Abrir novo form
        }
    }
}
