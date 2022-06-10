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
    public partial class FormPrincipal : Form
    {
        protected Form1 frmPrim;
        public FormPrincipal(Form1 _form1)
        {
            InitializeComponent();
            frmPrim = _form1;
        }

        bool bAllEmptyString = false;
        private void limparForm()
        {
            txCodigo.Clear();
            txNomeProduto.Clear();
            txQuantiaProduto.Clear();
            txPreco.Clear();
            txTipo.Clear();
            dtCadastro.Value = DateTime.Now;
            bAllEmptyString = false;

        }


        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            bool bOK = true;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.lojonadojaoConnectionString);
            SqlCommand comm = new SqlCommand("INSERT INTO tabela_produto (Codigo, Nome, Quantia, Preco, Tipo, DataCadastro) VALUES (@Codigo, @Nome, @Quantia, @Preco, @Tipo, @DataCadastro)", conn);
            SqlCommand check = new SqlCommand("SELECT Codigo FROM tabela_produto WHERE Codigo = @Codigo", conn);

            string sPreco = txPreco.Text;
            bool bNumeros = false;
            bool bNumerosPreco = false;
            for (int i = 0; i < sPreco.Length; i++)
            {
                if (!(sPreco[i] >= '0' && sPreco[i] <= '9'))
                {
                    bNumeros = true;
                    bNumerosPreco = true;
                }

            }

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

            string sQuant = txQuantiaProduto.Text;
            bool bNumerosQuant = false;
            for (int i = 0; i < sQuant.Length; i++)
            {
                if (!(sQuant[i] >= '0' && sQuant[i] <= '9'))
                {
                    bNumeros = true;
                    bNumerosQuant = true;
                }

            }

            if (bNumeros)
            {
                if (bNumerosCodigos)
                {
                    MessageBox.Show("O campo do Codigo não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCodigo.Clear();
                }

                if (bNumerosPreco)
                {
                    MessageBox.Show("O campo do Preco não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txPreco.Clear();
                }

                if (bNumerosQuant)
                {
                    MessageBox.Show("O campo da Quantidade não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txQuantiaProduto.Clear();
                }

            }
            else
            {
                comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                comm.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);

                check.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                check.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);

                comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Nome"].Value = txNomeProduto.Text;

                comm.Parameters.Add("@Quantia", System.Data.SqlDbType.Int);
                comm.Parameters["@Quantia"].Value = Convert.ToInt32(txQuantiaProduto.Text);

                comm.Parameters.Add("@Preco", System.Data.SqlDbType.Int);
                comm.Parameters["@Preco"].Value = Convert.ToInt32(txPreco.Text);

                comm.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Tipo"].Value = txTipo.Text;

                comm.Parameters.Add("@DataCadastro", System.Data.SqlDbType.Date);
                comm.Parameters["@DataCadastro"].Value = dtCadastro.Value;

                // Entenda, o operador || não funciona para booleanas e strings
                if (txCodigo.Text == "")
                {
                    bAllEmptyString = true;
                }

                if (txNomeProduto.Text == "")
                {
                    bAllEmptyString = true;
                }

                if (txQuantiaProduto.Text == "")
                {
                    bAllEmptyString = true;
                }

                if (txTipo.Text == "")
                {
                    bAllEmptyString = true;
                }

                if (bAllEmptyString)
                {
                    MessageBox.Show("Os campos não estão preenchidos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                        SqlDataReader dr = check.ExecuteReader();
                        if (dr.HasRows)
                        {
                            MessageBox.Show("Esse Produto já Existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dr.Close();
                            bOK = false;
                        }
                        else
                        {
                            dr.Close();
                            comm.ExecuteNonQuery();
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
                    if (bOK == true)
                    {
                        MessageBox.Show("Produto Cadastrado com Sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparForm();
                    }
                }
            }
            
        }

        private void btConsultarProduto_Click(object sender, EventArgs e)
        {
            bool bNumeros = false;
            bool bCodigoEmpty = false;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.lojonadojaoConnectionString);
            SqlCommand comm = new SqlCommand("SELECT Codigo, Nome, Quantia, Preco, Tipo, DataCadastro FROM tabela_produto WHERE Codigo = @Codigo", conn);
            SqlDataReader dr;

            if(txCodigo.Text == "")
            {
                bCodigoEmpty = true;
            }

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

            if(bCodigoEmpty)
            {
                MessageBox.Show("A caixa de Codigo não está preenchida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                if (bNumerosCodigos)
                {
                    MessageBox.Show("O campo do Codigo não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCodigo.Clear();
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
                            // Tentar, antes, checar se o usuario ja existe, e fazer Query com o banco de dados
                            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                            comm.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);
                            dr = comm.ExecuteReader();
                            if (dr.Read())
                            {
                                txNomeProduto.Text = dr["Nome"].ToString();
                                txQuantiaProduto.Text = dr["Quantia"].ToString();
                                txPreco.Text = dr["Preco"].ToString();
                                txTipo.Text = dr["Tipo"].ToString();
                                dtCadastro.Value = Convert.ToDateTime(dr["DataCadastro"]);
                            }
                            dr.Close();
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

        

        private void btVenderProduto_Click(object sender, EventArgs e)
        {
            //FormVender fv = new FormVender();
            //fv.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Deseja REALMENTE sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(diaRes == DialogResult.Yes)
            {
                this.Hide();
                frmPrim.Show();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojonadojaoDataSet1.tabela_produto' table. You can move, or remove it, as needed.
            //this.tabela_produtoTableAdapter.Fill(this.lojonadojaoDataSet1.tabela_produto);
            // TODO: This line of code loads data into the 'lojonadojaoDataSet1.tabela_funcio' table. You can move, or remove it, as needed.
            //this.tabela_funcioTableAdapter.Fill(this.lojonadojaoDataSet1.tabela_funcio);

        }


        private void atualizar_RegistrosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tabela_produtoTableAdapter.Atualizar_Registros(this.lojonadojaoDataSet1.tabela_produto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btAtualizarProduto_Click(object sender, EventArgs e)
        {
            bool bOK = true;
            bool bEveryEmpty = false;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.lojonadojaoConnectionString);
            SqlCommand comm = new SqlCommand("UPDATE tabela_produto SET Nome = @Nome, Quantia = @Quantia, Preco = @Preco, Tipo = @Tipo, DataCadastro = @DataCadastro WHERE Codigo = @Codigo", conn);
            SqlCommand check = new SqlCommand("SELECT Codigo FROM tabela_produto WHERE Codigo = @Codigo", conn);

            if(txCodigo.Text == "")
            {
                bEveryEmpty = true;
            }

            if (txNomeProduto.Text == "")
            {
                bEveryEmpty = true;
            }

            if (txPreco.Text == "")
            {
                bEveryEmpty = true;
            }

            if (txQuantiaProduto.Text == "")
            {
                bEveryEmpty = true;
            }

            if (txTipo.Text == "")
            {
                bEveryEmpty = true;
            }

            string sPreco = txPreco.Text;
            bool bNumeros = false;
            bool bNumerosPreco = false;
            for (int i = 0; i < sPreco.Length; i++)
            {
                if (!(sPreco[i] >= '0' && sPreco[i] <= '9'))
                {
                    bNumeros = true;
                    bNumerosPreco = true;
                }

            }

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

            string sQuant = txQuantiaProduto.Text;
            bool bNumerosQuant = false;
            for (int i = 0; i < sQuant.Length; i++)
            {
                if (!(sQuant[i] >= '0' && sQuant[i] <= '9'))
                {
                    bNumeros = true;
                    bNumerosQuant = true;
                }

            }

            if(bEveryEmpty)
            {
                MessageBox.Show("Há campos não preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bNumeros)
                {
                    if (bNumerosCodigos)
                    {
                        MessageBox.Show("O campo do Codigo não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txCodigo.Clear();
                    }

                    if (bNumerosPreco)
                    {
                        MessageBox.Show("O campo do Preco não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txPreco.Clear();
                    }

                    if (bNumerosQuant)
                    {
                        MessageBox.Show("O campo da Quantidade não possui numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txQuantiaProduto.Clear();
                    }

                }
                else
                {
                    comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    comm.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);

                    check.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                    check.Parameters["@Codigo"].Value = Convert.ToInt32(txCodigo.Text);

                    comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Nome"].Value = txNomeProduto.Text;

                    comm.Parameters.Add("@Quantia", System.Data.SqlDbType.Int);
                    comm.Parameters["@Quantia"].Value = Convert.ToInt32(txQuantiaProduto.Text);

                    comm.Parameters.Add("@Preco", System.Data.SqlDbType.Int);
                    comm.Parameters["@Preco"].Value = Convert.ToInt32(txPreco.Text);

                    comm.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Tipo"].Value = txTipo.Text;

                    comm.Parameters.Add("@DataCadastro", System.Data.SqlDbType.Date);
                    comm.Parameters["@DataCadastro"].Value = dtCadastro.Value;

                    // Entenda, o operador || não funciona para booleanas e strings
                    if (txCodigo.Text == "")
                    {
                        bAllEmptyString = true;
                    }

                    if (txNomeProduto.Text == "")
                    {
                        bAllEmptyString = true;
                    }

                    if (txQuantiaProduto.Text == "")
                    {
                        bAllEmptyString = true;
                    }

                    if (txTipo.Text == "")
                    {
                        bAllEmptyString = true;
                    }

                    if (bAllEmptyString)
                    {
                        MessageBox.Show("Os campos não estão preenchidos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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
                            SqlDataReader dr = check.ExecuteReader();
                            if (dr.HasRows)
                            {
                                dr.Close();
                                comm.ExecuteNonQuery();

                            }
                            else
                            {
                                MessageBox.Show("Esse Produto não Existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dr.Close();
                                bOK = false;
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
                        if (bOK == true)
                        {
                            MessageBox.Show("Produto Ataulizado com Sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limparForm();
                        }
                    }
                }
            }
                
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Deseja REALMENTE sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                this.Hide();
                frmPrim.Show();
            }
        }

        private void btLimparPainel_Click(object sender, EventArgs e)
        {
            limparForm();
        }
    }
}


