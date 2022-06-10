namespace ProjetoLojonaDoJao
{
    partial class FormTabelaCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inConnectedDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inConnectedDBDataSet = new ProjetoLojonaDoJao.InConnectedDBDataSet();
            this.ID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTableAdapter = new ProjetoLojonaDoJao.InConnectedDBDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inConnectedDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inConnectedDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDFuncionarioDataGridViewTextBoxColumn,
            this.iDCidadeDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.telefoneClienteDataGridViewTextBoxColumn,
            this.dataNascimentoClienteDataGridViewTextBoxColumn,
            this.cPFClienteDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clienteBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(744, 426);
            this.dgvClientes.TabIndex = 11;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDFuncionarioDataGridViewTextBoxColumn
            // 
            this.iDFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Funcionario";
            this.iDFuncionarioDataGridViewTextBoxColumn.HeaderText = "ID_Funcionario";
            this.iDFuncionarioDataGridViewTextBoxColumn.Name = "iDFuncionarioDataGridViewTextBoxColumn";
            this.iDFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCidadeDataGridViewTextBoxColumn
            // 
            this.iDCidadeDataGridViewTextBoxColumn.DataPropertyName = "ID_Cidade";
            this.iDCidadeDataGridViewTextBoxColumn.HeaderText = "ID_Cidade";
            this.iDCidadeDataGridViewTextBoxColumn.Name = "iDCidadeDataGridViewTextBoxColumn";
            this.iDCidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneClienteDataGridViewTextBoxColumn
            // 
            this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "Telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
            this.telefoneClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoClienteDataGridViewTextBoxColumn
            // 
            this.dataNascimentoClienteDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento_Cliente";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.HeaderText = "DataNascimento_Cliente";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.Name = "dataNascimentoClienteDataGridViewTextBoxColumn";
            this.dataNascimentoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFClienteDataGridViewTextBoxColumn
            // 
            this.cPFClienteDataGridViewTextBoxColumn.DataPropertyName = "CPF_Cliente";
            this.cPFClienteDataGridViewTextBoxColumn.HeaderText = "CPF_Cliente";
            this.cPFClienteDataGridViewTextBoxColumn.Name = "cPFClienteDataGridViewTextBoxColumn";
            this.cPFClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.inConnectedDBDataSetBindingSource;
            // 
            // inConnectedDBDataSetBindingSource
            // 
            this.inConnectedDBDataSetBindingSource.DataSource = this.inConnectedDBDataSet;
            this.inConnectedDBDataSetBindingSource.Position = 0;
            // 
            // inConnectedDBDataSet
            // 
            this.inConnectedDBDataSet.DataSetName = "InConnectedDBDataSet";
            this.inConnectedDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Produto
            // 
            this.ID_Produto.HeaderText = "ID_Produto";
            this.ID_Produto.Name = "ID_Produto";
            this.ID_Produto.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 300;
            // 
            // PrecoUnit
            // 
            this.PrecoUnit.HeaderText = "PrecoUnit";
            this.PrecoUnit.Name = "PrecoUnit";
            this.PrecoUnit.ReadOnly = true;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 30;
            // 
            // PrecoParcial
            // 
            this.PrecoParcial.HeaderText = "PrecoParcial";
            this.PrecoParcial.Name = "PrecoParcial";
            this.PrecoParcial.ReadOnly = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormTabelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FormTabelaCliente";
            this.Text = "FormTabelaCliente";
            this.Load += new System.EventHandler(this.FormTabelaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inConnectedDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inConnectedDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoParcial;
        private System.Windows.Forms.BindingSource inConnectedDBDataSetBindingSource;
        private InConnectedDBDataSet inConnectedDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private InConnectedDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFClienteDataGridViewTextBoxColumn;
    }
}