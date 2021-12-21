using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda_de_contatos
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {

            txtNome.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            this.Close();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            mostraTudo();
        }

        private void mostraTudo()
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDataSet.Contato'. Você pode movê-la ou removê-la conforme necessário.
            this.contatoTableAdapter.Fill(this.agendaDataSet.Contato);
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
            con.Open();

            string Query = "SELECT * FROM Contato";

            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
            con.Open();

            string Query = "SELECT * FROM Contato WHERE nome like '%" +txtNome.Text+ "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clean();
        }
        private void clean()
        {
            txtNome.Text = string.Empty;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            back();
        }
        private void back()
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostraTudo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
