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
    public partial class FormVender : Form
    {
        public FormVender()
        {
            InitializeComponent();
        }

        void limparForm()
        {
            txCodigo.Clear();
            txNomeCliente.Clear();
            txQuantia.Clear();
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            bool bEveryEmpty = false;
            int iQuantiaVendida = 0;
            int iQuantia = 0;
            int iOffset = 0;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.lojonadojaoConnectionString);
            SqlCommand comm = new SqlCommand("SELECT Codigo, Quantia FROM tabela_produto WHERE Codigo = @Codigo", conn);
            SqlDataReader dr;
            SqlCommand remover = new SqlCommand("DELETE FROM tabela_produto WHERE Codigo = @Codigo", conn);
            

            if (txCodigo.Text == "")
            {
                bEveryEmpty = true;
            }

            if (txQuantia.Text == "")
            {
                bEveryEmpty = true;
            }

            if(txNomeCliente.Text == "")
            {
                bEveryEmpty = true;
            }


            // Detectar se ha numeros na caixa de Codigo
            bool bNumeros = false;
            string sCodigos = txCodigo.Text;
            bool bNumerosCodigos = false;
            for (int i = 0; i < sCodigos.Length; i++)
            {
                if (!(sCodigos[i] >= '0' && sCodigos[i] <= '9'))
                {
                    bNumeros = true;
                    bNumerosCodigos = true;
                }

            }

            // Detectar se ha numeros na caixa de Quantidade
            bool bNumerosQuantia = false;
            string sQuantidade = txQuantia.Text;
            for (int i = 0; i < sQuantidade.Length; i++)
            {
                if (!(sQuantidade[i] >= '0' && sQuantidade[i] <= '9'))
                {
                    bNumeros = true;
                    bNumerosQuantia = true;
                }
            }

            if(bEveryEmpty)
            {
                MessageBox.Show("Há campos não preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bNumeros)
                {
                    if (bNumerosCodigos)
                    {
                        MessageBox.Show("Você inseriu não inseriu um numero na caixa do codigo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txCodigo.Clear();
                    }
                    if (bNumerosQuantia)
                    {
                        MessageBox.Show("Você inseriu não inseriu um numero na caixa da quantidade!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txQuantia.Clear();
                    }
                }
                else
                {
                    comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    comm.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);

                    remover.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    remover.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);


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
                            // Tentar, antes, checar se o usuario ja existe, e fazer Query com o banco de dados
                            dr = comm.ExecuteReader();
                            if (dr.Read())
                            {
                                iQuantia = Convert.ToInt32(dr["Quantia"].ToString());
                                iQuantiaVendida = Convert.ToInt32(txQuantia.Text);
                            }
                            dr.Close();

                            if (iQuantiaVendida == iQuantia)
                            {
                                DialogResult diaRes = MessageBox.Show("Você quer vender TODOS os produtos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (diaRes == DialogResult.Yes)
                                {
                                    remover.ExecuteNonQuery();
                                    MessageBox.Show("Todos os produtos dessa categoria foram vendidos com sucesso para " + txNomeCliente.Text + "!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limparForm();
                                }
                            }

                            if(iQuantiaVendida > iQuantia)
                            {
                                MessageBox.Show("Não exite produtos suficientes para a venda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            if(iQuantiaVendida < iQuantia)
                            {
                                iOffset = iQuantia - iQuantiaVendida;
                                SqlCommand atualizar = new SqlCommand("UPDATE tabela_produto SET Quantia = " + iOffset + "WHERE Codigo = @Codigo", conn);

                                atualizar.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                                atualizar.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);

                                atualizar.ExecuteNonQuery();
                                MessageBox.Show("Produto(s) vendido com sucesso para" + txNomeCliente.Text + "!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limparForm();
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
                        // Fechar a conexão com o Banco de Dados e mostrar o resultado de sucesso na tela.
                        conn.Close();
                    }
                }
            }  
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
