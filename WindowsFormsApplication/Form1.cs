using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //MessageBox.Show("Inicializando o formulário pelo construtor");
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Nicollas esse é o seu primeiro programa! - " + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }
        
        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void abrirLerArquivo_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Abrir Ler Arquivo", abrirLerArquivo_Click));
            contextMenu.MenuItems.Add(new MenuItem("Abrir cadastro", abrirCadastro_Click));
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));

            notifyIcon.ContextMenu = contextMenu;


            atualizaHora();

            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione...]";

            dataGridView.DataSource = Estado.Lista();

            /* ou 
             cboEstados.Items.Clear();
             foreach (Estado estado in Estado.Lista())
             {
                 cboEstados.Items.Add(estado);
             }*/



        }

        private void atualizaHora()
        {
            lblHoraAtual.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTexto = new FrmTexto();

            frmTexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no icone");
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Dois cliques no ícone");
        }

        private void btnNotificao_Click(object sender, EventArgs e)
        {
            // notifyIcon.ShowBalloonTip(10,"Notificação", txtResultado.Text, ToolTipIcon.Warning);
            notifyIcon.ShowBalloonTip(10, "Notificação", "Valide os campos\nNome, Telefone", ToolTipIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }
    }
}
