using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            // ou File.WriteAllLines("c:\\", "texto.txt");
            File.WriteAllText(@"c:\arquivos\texto_" + DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss") +".txt", txtTexto.Text);
            MessageBox.Show("Arquivo salvo!");
            txtTexto.Text = "";
        }
         
        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }
    }
}
