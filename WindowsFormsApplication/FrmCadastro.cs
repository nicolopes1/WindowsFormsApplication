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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;

            try
            {
                int numero = int.Parse(txtNumero.Text);            //ou Convert.ToInt16();
                numero += 100;

                throw new ErroDeProposito("Erro de propósito");

                MessageBox.Show("Olá " + nome + ", o valor do número mais 100 é de: " + numero);
            }
            catch(FormatException erroo)
            {
                MessageBox.Show("Olá, você digitou letra no lugar de número!" + erroo.Message);
                txtNumero.Focus();
            }

            catch (ErroDeProposito erroProposito)
            {
                MessageBox.Show("Erro de propósito! " + erroProposito.StackTrace);

            }

            catch (Exception erro)
            {
                MessageBox.Show("Olá, você digitou letra no lugar de número!" + erro.Message);
   
            }

            finally
            {
                MessageBox.Show("Todas as minhas exceções tratadas !");
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estou buscando no banco de dados com o termo :" + txtBuscaTool.Text);
        }
    }


    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro):base(erro)
        {

        }
    }
}
