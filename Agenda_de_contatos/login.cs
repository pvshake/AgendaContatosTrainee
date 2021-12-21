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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            group1();
        }

        private void group1()
        {
            groupBox1.Enabled = true;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-INEFT7UP;Initial Catalog=Agenda;Integrated Security=True");
            con.Open();

            string Query = "SELECT * FROM Login WHERE username = '" + txtUser.Text + "' AND senha = '" + txtSenha.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtSenha.Text = "";
                txtUser.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            this.Close();
        }
    }        
}
