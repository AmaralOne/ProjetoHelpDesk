namespace HelpDesk
{
    partial class CadastroPessoas
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
            this.dataGridCadastro = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxEquipe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.checkBoxUsuario = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCadastro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCadastro
            // 
            this.dataGridCadastro.AllowUserToAddRows = false;
            this.dataGridCadastro.AllowUserToDeleteRows = false;
            this.dataGridCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCadastro.Location = new System.Drawing.Point(15, 237);
            this.dataGridCadastro.Name = "dataGridCadastro";
            this.dataGridCadastro.ReadOnly = true;
            this.dataGridCadastro.Size = new System.Drawing.Size(622, 130);
            this.dataGridCadastro.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxEquipe);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.checkBoxUsuario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_Endereco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_telefone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_CPF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 160);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Equipe:";
            // 
            // comboBoxEquipe
            // 
            this.comboBoxEquipe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEquipe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEquipe.Enabled = false;
            this.comboBoxEquipe.FormattingEnabled = true;
            this.comboBoxEquipe.Location = new System.Drawing.Point(19, 115);
            this.comboBoxEquipe.Name = "comboBoxEquipe";
            this.comboBoxEquipe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipe.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Enabled = false;
            this.txt_Senha.Location = new System.Drawing.Point(146, 115);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(76, 20);
            this.txt_Senha.TabIndex = 20;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Enabled = false;
            this.checkBoxUsuario.Location = new System.Drawing.Point(245, 115);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(62, 17);
            this.checkBoxUsuario.TabIndex = 18;
            this.checkBoxUsuario.Text = "Usuário";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            this.checkBoxUsuario.TextChanged += new System.EventHandler(this.checkBoxUsuario_TextChanged);
            this.checkBoxUsuario.Click += new System.EventHandler(this.checkBoxUsuario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Endereço:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Enabled = false;
            this.txt_Endereco.Location = new System.Drawing.Point(315, 70);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(299, 20);
            this.txt_Endereco.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Location = new System.Drawing.Point(19, 70);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(288, 20);
            this.txt_Email.TabIndex = 15;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Location = new System.Drawing.Point(514, 27);
            this.txt_telefone.Mask = "(99) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefone:";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Enabled = false;
            this.txt_CPF.Location = new System.Drawing.Point(408, 27);
            this.txt_CPF.Mask = "000.000.000.00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(100, 20);
            this.txt_CPF.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
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
            this.label2.Location = new System.Drawing.Point(100, 11);
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
            this.txt_Nome.Location = new System.Drawing.Point(103, 27);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(299, 20);
            this.txt_Nome.TabIndex = 8;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(34, 198);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(299, 20);
            this.txt_pesquisa.TabIndex = 19;
            this.txt_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisa_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pesquisa:";
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Location = new System.Drawing.Point(238, 382);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 17;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(562, 382);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(481, 382);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 15;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Location = new System.Drawing.Point(400, 382);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 14;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Location = new System.Drawing.Point(319, 382);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 13;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 411);
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
            this.Name = "CadastroPessoas";
            this.Text = "Cadastro de Pessoas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPessoas_FormClosed);
            this.Load += new System.EventHandler(this.CadastroPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCadastro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.CheckBox checkBoxUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEquipe;
    }
}