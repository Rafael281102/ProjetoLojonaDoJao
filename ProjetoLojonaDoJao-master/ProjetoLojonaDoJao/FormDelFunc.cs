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
    public partial class FormDelFunc : Form
    {
        public FormDelFunc()
        {
            InitializeComponent();
        }

        private void limparForm()
        {
            Id2.Clear();
            SenhaMaster1.Clear();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            bool bEmpty = false;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.lojonadojaoConnectionString);
            SqlCommand comm = new SqlCommand("DELETE FROM tabela_funcio WHERE Nome = @Nome", conn);
            SqlCommand check = new SqlCommand("SELECT Nome, Email, Senha FROM tabela_funcio WHERE Nome = @Nome AND Email = @Email AND Senha = @Senha", conn);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = Id2.Text;

            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = SenhaMaster1.Text;

            comm.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            //comm.Parameters["@Senha"].Value = txSenha.Text;

            check.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            check.Parameters["@Nome"].Value = Id2.Text;

            check.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            check.Parameters["@Email"].Value = SenhaMaster1.Text;

            check.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            check.Parameters["@Senha"].Value = SenhaMaster1.Text;

            if(Id2.Text == "")
            {
                bEmpty = true;
            }

            if (SenhaMaster1.Text == "")
            {
                bEmpty = true;
            }

            if (SenhaMaster1.Text == "")
            {
                bEmpty = true;
            }

            if(bEmpty)
            {
                MessageBox.Show("Por favor, insira as credenciais!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        SqlDataReader dr = check.ExecuteReader();


                        if (dr.HasRows)
                        {
                            DialogResult diaRes = MessageBox.Show("Você quer REALMENTE remover a sua conta?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (diaRes == DialogResult.Yes)
                            {
                                dr.Close();
                                comm.ExecuteNonQuery();
                                MessageBox.Show("Conta Removida com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.None);             
                            }
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Esse usuario não foi encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        limparForm();
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }

            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparForm();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
