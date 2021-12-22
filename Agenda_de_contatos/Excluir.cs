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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {            
            txtNome.Text = String.Empty;
            txtID.Text = String.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
            con.Open();

            string Query = "SELECT * FROM Contato WHERE nome like '%" + txtNome.Text + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Excluir_Load(object sender, EventArgs e)
        {
            mostraTudo();
        }
        private void mostraTudo()
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDataSetExcluir.Contato'. Você pode movê-la ou removê-la conforme necessário.
            this.contatoTableAdapter1.Fill(this.agendaDataSetExcluir.Contato);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("microsoft sans serif", 9);

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
            con.Open();

            string Query = "SELECT * FROM Contato";

            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mostraTudo();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente deletar permanentemente este contato?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
                con.Open();

                string Query = "DELETE FROM Contato WHERE id_contato = '" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Contato Deletado com Sucesso!");
                mostraTudo();
                limpar();
            }
            else
            {
                mostraTudo();
            }

            

        }
    }
}
