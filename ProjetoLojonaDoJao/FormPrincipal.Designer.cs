
namespace ProjetoLojonaDoJao
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.btConsultarProduto = new System.Windows.Forms.Button();
            this.btVenderProduto = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNomeProduto = new System.Windows.Forms.TextBox();
            this.txQuantiaProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lojonadojaoDataSet1 = new ProjetoLojonaDoJao.lojonadojaoDataSet();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.lojonadojaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojonadojaoDataSet = new ProjetoLojonaDoJao.lojonadojaoDataSet();
            this.tabelafuncioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabela_funcioTableAdapter = new ProjetoLojonaDoJao.lojonadojaoDataSetTableAdapters.tabela_funcioTableAdapter();
            this.tabelaprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabela_produtoTableAdapter = new ProjetoLojonaDoJao.lojonadojaoDataSetTableAdapters.tabela_produtoTableAdapter();
            this.atualizar_RegistrosToolStrip = new System.Windows.Forms.ToolStrip();
            this.atualizar_RegistrosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btLimparPainel = new System.Windows.Forms.Button();
            this.btAtualizarProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaprodutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojonadojaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojonadojaoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojonadojaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelafuncioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaprodutoBindingSource)).BeginInit();
            this.atualizar_RegistrosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.BackColor = System.Drawing.Color.White;
            this.btAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarProduto.Image")));
            this.btAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdicionarProduto.Location = new System.Drawing.Point(12, 28);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(221, 64);
            this.btAdicionarProduto.TabIndex = 24;
            this.btAdicionarProduto.Text = "Adicionar Produto";
            this.btAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdicionarProduto.UseVisualStyleBackColor = false;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // btConsultarProduto
            // 
            this.btConsultarProduto.BackColor = System.Drawing.Color.White;
            this.btConsultarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btConsultarProduto.Image")));
            this.btConsultarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultarProduto.Location = new System.Drawing.Point(493, 28);
            this.btConsultarProduto.Name = "btConsultarProduto";
            this.btConsultarProduto.Size = new System.Drawing.Size(221, 64);
            this.btConsultarProduto.TabIndex = 26;
            this.btConsultarProduto.Text = "Consultar Produto";
            this.btConsultarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConsultarProduto.UseVisualStyleBackColor = false;
            this.btConsultarProduto.Click += new System.EventHandler(this.btConsultarProduto_Click);
            // 
            // btVenderProduto
            // 
            this.btVenderProduto.BackColor = System.Drawing.Color.White;
            this.btVenderProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenderProduto.Image = ((System.Drawing.Image)(resources.GetObject("btVenderProduto.Image")));
            this.btVenderProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVenderProduto.Location = new System.Drawing.Point(731, 28);
            this.btVenderProduto.Name = "btVenderProduto";
            this.btVenderProduto.Size = new System.Drawing.Size(221, 64);
            this.btVenderProduto.TabIndex = 27;
            this.btVenderProduto.Text = "Vender Produto";
            this.btVenderProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVenderProduto.UseVisualStyleBackColor = false;
            this.btVenderProduto.Click += new System.EventHandler(this.btVenderProduto_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.White;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(12, 326);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(97, 42);
            this.btSair.TabIndex = 35;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo de Barras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome do Produto:";
            // 
            // txNomeProduto
            // 
            this.txNomeProduto.Location = new System.Drawing.Point(167, 148);
            this.txNomeProduto.Name = "txNomeProduto";
            this.txNomeProduto.Size = new System.Drawing.Size(130, 20);
            this.txNomeProduto.TabIndex = 29;
            // 
            // txQuantiaProduto
            // 
            this.txQuantiaProduto.Location = new System.Drawing.Point(493, 109);
            this.txQuantiaProduto.Name = "txQuantiaProduto";
            this.txQuantiaProduto.Size = new System.Drawing.Size(66, 20);
            this.txQuantiaProduto.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quantia do Produto:";
            // 
            // txPreco
            // 
            this.txPreco.Location = new System.Drawing.Point(493, 149);
            this.txPreco.Name = "txPreco";
            this.txPreco.Size = new System.Drawing.Size(66, 20);
            this.txPreco.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Preço:";
            // 
            // txTipo
            // 
            this.txTipo.Location = new System.Drawing.Point(818, 114);
            this.txTipo.Name = "txTipo";
            this.txTipo.Size = new System.Drawing.Size(130, 20);
            this.txTipo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data de Cadastro:";
            // 
            // dtCadastro
            // 
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(818, 146);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(83, 20);
            this.dtCadastro.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantiaDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaprodutoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(231, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 41;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 45;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 103;
            // 
            // quantiaDataGridViewTextBoxColumn
            // 
            this.quantiaDataGridViewTextBoxColumn.DataPropertyName = "Quantia";
            this.quantiaDataGridViewTextBoxColumn.FillWeight = 50F;
            this.quantiaDataGridViewTextBoxColumn.HeaderText = "Quantia";
            this.quantiaDataGridViewTextBoxColumn.Name = "quantiaDataGridViewTextBoxColumn";
            this.quantiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantiaDataGridViewTextBoxColumn.Width = 50;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 75;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Width = 80;
            // 
            // tabelaprodutoBindingSource1
            // 
            this.tabelaprodutoBindingSource1.DataMember = "tabela_produto";
            this.tabelaprodutoBindingSource1.DataSource = this.lojonadojaoDataSet1;
            // 
            // lojonadojaoDataSet1
            // 
            this.lojonadojaoDataSet1.DataSetName = "lojonadojaoDataSet";
            this.lojonadojaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(167, 111);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(66, 20);
            this.txCodigo.TabIndex = 28;
            // 
            // lojonadojaoDataSetBindingSource
            // 
            this.lojonadojaoDataSetBindingSource.DataSource = this.lojonadojaoDataSet;
            this.lojonadojaoDataSetBindingSource.Position = 0;
            // 
            // lojonadojaoDataSet
            // 
            this.lojonadojaoDataSet.DataSetName = "lojonadojaoDataSet";
            this.lojonadojaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelafuncioBindingSource
            // 
            this.tabelafuncioBindingSource.DataMember = "tabela_funcio";
            this.tabelafuncioBindingSource.DataSource = this.lojonadojaoDataSet1;
            // 
            // tabela_funcioTableAdapter
            // 
            this.tabela_funcioTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaprodutoBindingSource
            // 
            this.tabelaprodutoBindingSource.DataMember = "tabela_produto";
            this.tabelaprodutoBindingSource.DataSource = this.lojonadojaoDataSet1;
            // 
            // tabela_produtoTableAdapter
            // 
            this.tabela_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // atualizar_RegistrosToolStrip
            // 
            this.atualizar_RegistrosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizar_RegistrosToolStripButton});
            this.atualizar_RegistrosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.atualizar_RegistrosToolStrip.Name = "atualizar_RegistrosToolStrip";
            this.atualizar_RegistrosToolStrip.Size = new System.Drawing.Size(965, 25);
            this.atualizar_RegistrosToolStrip.TabIndex = 43;
            this.atualizar_RegistrosToolStrip.Text = "atualizar_RegistrosToolStrip";
            // 
            // atualizar_RegistrosToolStripButton
            // 
            this.atualizar_RegistrosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.atualizar_RegistrosToolStripButton.Name = "atualizar_RegistrosToolStripButton";
            this.atualizar_RegistrosToolStripButton.Size = new System.Drawing.Size(110, 22);
            this.atualizar_RegistrosToolStripButton.Text = "Atualizar_Registros";
            this.atualizar_RegistrosToolStripButton.Click += new System.EventHandler(this.atualizar_RegistrosToolStripButton_Click);
            // 
            // btLimparPainel
            // 
            this.btLimparPainel.BackColor = System.Drawing.Color.White;
            this.btLimparPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparPainel.Image = ((System.Drawing.Image)(resources.GetObject("btLimparPainel.Image")));
            this.btLimparPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimparPainel.Location = new System.Drawing.Point(12, 218);
            this.btLimparPainel.Name = "btLimparPainel";
            this.btLimparPainel.Size = new System.Drawing.Size(192, 56);
            this.btLimparPainel.TabIndex = 34;
            this.btLimparPainel.Text = "Limpar Painel";
            this.btLimparPainel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimparPainel.UseVisualStyleBackColor = false;
            this.btLimparPainel.Click += new System.EventHandler(this.btLimparPainel_Click);
            // 
            // btAtualizarProduto
            // 
            this.btAtualizarProduto.BackColor = System.Drawing.Color.White;
            this.btAtualizarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizarProduto.Image")));
            this.btAtualizarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizarProduto.Location = new System.Drawing.Point(255, 28);
            this.btAtualizarProduto.Name = "btAtualizarProduto";
            this.btAtualizarProduto.Size = new System.Drawing.Size(221, 64);
            this.btAtualizarProduto.TabIndex = 25;
            this.btAtualizarProduto.Text = "Atualizar Produto";
            this.btAtualizarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarProduto.UseVisualStyleBackColor = false;
            this.btAtualizarProduto.Click += new System.EventHandler(this.btAtualizarProduto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Copyright: Lojona do Jão Inc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(812, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Ver: 1.48";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(763, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Todos os direitos reservados.";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(965, 380);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btAtualizarProduto);
            this.Controls.Add(this.btLimparPainel);
            this.Controls.Add(this.atualizar_RegistrosToolStrip);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txQuantiaProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btVenderProduto);
            this.Controls.Add(this.btConsultarProduto);
            this.Controls.Add(this.btAdicionarProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Painel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaprodutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojonadojaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojonadojaoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojonadojaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelafuncioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaprodutoBindingSource)).EndInit();
            this.atualizar_RegistrosToolStrip.ResumeLayout(false);
            this.atualizar_RegistrosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.Button btConsultarProduto;
        private System.Windows.Forms.Button btVenderProduto;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNomeProduto;
        private System.Windows.Forms.TextBox txQuantiaProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.BindingSource lojonadojaoDataSetBindingSource;
        private lojonadojaoDataSet lojonadojaoDataSet;
        private lojonadojaoDataSet lojonadojaoDataSet1;
        private System.Windows.Forms.BindingSource tabelafuncioBindingSource;
        private lojonadojaoDataSetTableAdapters.tabela_funcioTableAdapter tabela_funcioTableAdapter;
        private System.Windows.Forms.BindingSource tabelaprodutoBindingSource;
        private lojonadojaoDataSetTableAdapters.tabela_produtoTableAdapter tabela_produtoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tabelaprodutoBindingSource1;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.ToolStrip atualizar_RegistrosToolStrip;
        private System.Windows.Forms.ToolStripButton atualizar_RegistrosToolStripButton;
        private System.Windows.Forms.Button btLimparPainel;
        private System.Windows.Forms.Button btAtualizarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}