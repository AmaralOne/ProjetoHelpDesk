namespace HelpDesk
{
    partial class CadastroSimples
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCadastro = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Location = new System.Drawing.Point(93, 315);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(174, 315);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(255, 315);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 2;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(336, 315);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(12, 315);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 4;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(19, 27);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(76, 20);
            this.txt_Id.TabIndex = 7;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(19, 66);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(299, 20);
            this.txt_Nome.TabIndex = 8;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(31, 142);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(299, 20);
            this.txt_pesquisa.TabIndex = 10;
            this.txt_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisa_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pesquisa:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 106);
            this.panel1.TabIndex = 11;
            // 
            // dataGridCadastro
            // 
            this.dataGridCadastro.AllowUserToAddRows = false;
            this.dataGridCadastro.AllowUserToDeleteRows = false;
            this.dataGridCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCadastro.Location = new System.Drawing.Point(13, 168);
            this.dataGridCadastro.Name = "dataGridCadastro";
            this.dataGridCadastro.ReadOnly = true;
            this.dataGridCadastro.Size = new System.Drawing.Size(412, 130);
            this.dataGridCadastro.TabIndex = 12;
            // 
            // CadastroSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 350);
            this.Controls.Add(this.dataGridCadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroSimples";
            this.Text = "CadastroSimples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroSimples_FormClosing);
            this.Load += new System.EventHandler(this.CadastroSimples_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCadastro;
    }
}