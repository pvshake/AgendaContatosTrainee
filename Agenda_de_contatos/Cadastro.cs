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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            txtID.Text = String.Empty;
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cadastrar esse contato?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                cadastrar();
            else
                limpar();
                
        }

        private void cadastrar()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
            con.Open();

            string id = txtID.Text;
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

            string Query = "INSERT INTO Contato (id_contato, nome, cpf, rg, data_de_nascimento, email, telefone1, telefone2, rua, numero, complemento, cep, cidade, estado, pais) VALUES ('" + id + "', '" + nome + "', '" + cpf + "', '" + rg + "', '" + dataNasc + "', '" + email + "', '" + tel1 + "', '" + tel2 + "', '" + rua + "', '" + numero + "', '" + comp + "', '" + cep + "', '" + cidade + "', '" + estado + "', '" + pais + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("CONTATO SALVO COM SUCESSO!");
            limpar();
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
