
namespace ProjetoLojonaDoJao
{
    partial class FormDelFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelFunc));
            this.SenhaMaster1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoConfrma1 = new System.Windows.Forms.Button();
            this.BotaoCancela1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenhaMaster1
            // 
            this.SenhaMaster1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaMaster1.Location = new System.Drawing.Point(132, 119);
            this.SenhaMaster1.Name = "SenhaMaster1";
            this.SenhaMaster1.Size = new System.Drawing.Size(162, 23);
            this.SenhaMaster1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "SENHA MASTER:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // Id2
            // 
            this.Id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id2.Location = new System.Drawing.Point(132, 69);
            this.Id2.Name = "Id2";
            this.Id2.Size = new System.Drawing.Size(162, 23);
            this.Id2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Deletar Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotaoConfrma1
            // 
            this.BotaoConfrma1.AutoSize = true;
            this.BotaoConfrma1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.BotaoConfrma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoConfrma1.Location = new System.Drawing.Point(177, 180);
            this.BotaoConfrma1.Name = "BotaoConfrma1";
            this.BotaoConfrma1.Size = new System.Drawing.Size(149, 32);
            this.BotaoConfrma1.TabIndex = 22;
            this.BotaoConfrma1.Text = "CONFIRMA";
            this.BotaoConfrma1.UseVisualStyleBackColor = false;
            this.BotaoConfrma1.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // BotaoCancela1
            // 
            this.BotaoCancela1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.BotaoCancela1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCancela1.Location = new System.Drawing.Point(16, 180);
            this.BotaoCancela1.Name = "BotaoCancela1";
            this.BotaoCancela1.Size = new System.Drawing.Size(149, 32);
            this.BotaoCancela1.TabIndex = 21;
            this.BotaoCancela1.Text = "CANCELA";
            this.BotaoCancela1.UseVisualStyleBackColor = false;
            this.BotaoCancela1.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormDelFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(341, 229);
            this.Controls.Add(this.BotaoCancela1);
            this.Controls.Add(this.BotaoConfrma1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SenhaMaster1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDelFunc";
            this.Text = "Remover Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SenhaMaster1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoConfrma1;
        private System.Windows.Forms.Button BotaoCancela1;
    }
}