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
            txtCEP.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtComp.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtData.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtPais.Text = String.Empty;
            txtRG.Text = String.Empty;
            txtRua.Text = String.Empty;
            txtTel1.Text = String.Empty;
            txtTel2.Text = String.Empty;
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
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");

            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string rg = txtRG.Text;
            string dataNasc = txtData.Text;
            string email = txtEmail.Text;
            string tel1 = txtTel1.Text;
            string tel2 = txtTel2.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string comp = txtComp.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;

            string Query = "INSERT INTO Contato (nome, cpf, rg, data_de_nascimento, email, telefone1, telefone2, rua, numero, complemento, cep, cidade, estado, pais) VALUES ('" + nome + "', '" + cpf + "', '" + rg + "', '" + dataNasc + "', '" + email + "', '" + tel1 + "', '" + tel2 + "', '" + rua + "', '" + numero + "', '" + comp + "', '" + cep + "', '" + cidade + "', '" + estado + "', '" + pais + "')";
            SqlCommand cmd = new SqlCommand(Query, con);

            if(MessageBox.Show("Deseja realmente alterar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Dados Alterados com Sucesso!");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
