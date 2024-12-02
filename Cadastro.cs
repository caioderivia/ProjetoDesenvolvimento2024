using System;
using System.Windows.Forms;

namespace AgendaProSolutions
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs   
 e)
        {
            // Código para limpar os campos do formulário
            textBoxID.Text = "";
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefone.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Código para confirmar o cadastro
            // Aqui você implementaria a lógica para salvar os dados em um banco de dados ou em um arquivo, por exemplo.
            string id = textBoxID.Text;
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = textBoxTelefone.Text;

            MessageBox.Show("Cadastro realizado com sucesso!");
        }
    }
}
