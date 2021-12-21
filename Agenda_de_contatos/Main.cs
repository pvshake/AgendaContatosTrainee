using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_de_contatos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            login l = new login();
            l.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newContact();
        }
        private void newContact()
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void removerContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exclude();
        }
        private void exclude()
        {
            Excluir e = new Excluir();
            e.Show();
        }

        private void atualizarContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterar();
        }
        private void alterar()
        {
            Atualizar atualizar = new Atualizar();
            atualizar.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
        }
    }
}
