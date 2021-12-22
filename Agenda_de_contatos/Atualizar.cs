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
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtEmail.Text = String.Empty;
            txtTel1.Text = String.Empty;
            txtTel2.Text = String.Empty;
            txtID.Text = String.Empty;
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
            alterar();
        }
        private void alterar()
        {
            string email = txtEmail.Text;
            string tel1 = txtTel1.Text;
            string tel2 = txtTel2.Text;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Atualizar_Load(object sender, EventArgs e)
        {
            mostrarTudo();
        }
        private void mostrarTudo()
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDataSet1.Contato'. Você pode movê-la ou removê-la conforme necessário.
            this.contatoTableAdapter.Fill(this.agendaDataSet1.Contato);
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
            mostrarTudo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente os dados deste contato?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
                con.Open();

                string Query = "UPDATE Contato SET telefone1 = '" + txtTel1.Text + "', telefone2 = '" + txtTel2.Text + "', email = '" + txtEmail.Text + "' WHERE id_contato = '" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Dados Alterados com Sucesso!");
                mostrarTudo();
                limpar();
            }
            else
                mostrarTudo();                
        }
    }
}
