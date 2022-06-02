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

namespace ProjetoLojonaDoJao
{
    public partial class FormMenuFunc : Form
    {

        public Form1 frmPrim;
        public FormMenuFunc(Form1 _form1)
        {
            InitializeComponent();
            frmPrim = _form1;

        }

        //Ok, tem MT coisa pra checar aqui.

        private void limparForm()
        {
            //txNome.Clear();
            //txSenha.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenuFunc_Load(object sender, EventArgs e)
        {

        }

        /*private void btEntrar_Click(object sender, EventArgs e)
        {
            bool bEmpty = false;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.lojonadojaoConnectionString);
            SqlCommand comm = new SqlCommand("SELECT Nome, Senha FROM tabela_funcio WHERE Nome = @Nome AND Senha = @Senha", conn);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Senha"].Value = txSenha.Text;

            if (txNome.Text == "")
            {
                bEmpty = true;
            }
            if (txSenha.Text == "")
            {
                bEmpty = true;
            }

            if (bEmpty)
            {
                MessageBox.Show("Por Favor, insira as credenciais!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    try
                    {
                        // Tentar conectar com o bando de dados
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Erro ao conectar-se com o Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        // Tentar fazer Query com o banco de dados
                        SqlDataReader dr = comm.ExecuteReader();

                        // Checar se há colunas ativas que correspondem
                        if (dr.HasRows)
                        {

                            //MessageBox.Show("Deu Certo", "INSERT", MessageBoxButtons.OK);                 
                            MessageBox.Show("Login efetuado com sucesso!", "Seja Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dr.Close();
                            //Abrir Form para abrir o registro de produtos
                            FormPrincipal formPrinc = new FormPrincipal(frmPrim);
                            this.Hide();
                            formPrinc.Show();
                            frmPrim.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario Invalido! Tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Erro ao tentar fazer uma consulta com o Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    // Checar se a conexão com o Banco de Dados esta aberta, e depois fechar e mostrar o resultado de sucesso na tela.
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
                           
            }
        }*/

        /*private void btCancelar_Click(object sender, EventArgs e)
        {
            bool bFull = false;

            if (!(txNome.Text == ""))
            {
                bFull = true;
            }
            if (!(txSenha.Text == ""))
            {
                bFull = true;
            }

            if (bFull)
            {
                DialogResult diaRes = MessageBox.Show("Você Deseja sair mesmo? Há credenciais preenchidas!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(diaRes == DialogResult.Yes)
                {
                    limparForm();
                    this.Hide();
                }
            }
            else
            {
                this.Hide();
            }
           
        }*/
    }
}