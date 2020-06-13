namespace HelpDesk
{
    partial class CadastroTicket
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxPessoas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxServicos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUrgencia = new System.Windows.Forms.ComboBox();
            this.txt_Mensagem = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Assunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Anexar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePrevisao = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 10000);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(217, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 269);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // comboBoxPessoas
            // 
            this.comboBoxPessoas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPessoas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPessoas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxPessoas.FormattingEnabled = true;
            this.comboBoxPessoas.Location = new System.Drawing.Point(13, 31);
            this.comboBoxPessoas.Name = "comboBoxPessoas";
            this.comboBoxPessoas.Size = new System.Drawing.Size(178, 28);
            this.comboBoxPessoas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pessoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Responsável:";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(13, 94);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(178, 28);
            this.comboBoxUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(13, 160);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(178, 28);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serviços:";
            // 
            // comboBoxServicos
            // 
            this.comboBoxServicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxServicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServicos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxServicos.FormattingEnabled = true;
            this.comboBoxServicos.Location = new System.Drawing.Point(13, 222);
            this.comboBoxServicos.Name = "comboBoxServicos";
            this.comboBoxServicos.Size = new System.Drawing.Size(178, 28);
            this.comboBoxServicos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Urgência:";
            // 
            // comboBoxUrgencia
            // 
            this.comboBoxUrgencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUrgencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUrgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUrgencia.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxUrgencia.FormattingEnabled = true;
            this.comboBoxUrgencia.Location = new System.Drawing.Point(13, 285);
            this.comboBoxUrgencia.Name = "comboBoxUrgencia";
            this.comboBoxUrgencia.Size = new System.Drawing.Size(178, 28);
            this.comboBoxUrgencia.TabIndex = 9;
            // 
            // txt_Mensagem
            // 
            this.txt_Mensagem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Mensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Mensagem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mensagem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Mensagem.Location = new System.Drawing.Point(217, 91);
            this.txt_Mensagem.Name = "txt_Mensagem";
            this.txt_Mensagem.Size = new System.Drawing.Size(526, 86);
            this.txt_Mensagem.TabIndex = 11;
            this.txt_Mensagem.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Assunto:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_Assunto
            // 
            this.txt_Assunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Assunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Assunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Assunto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Assunto.Location = new System.Drawing.Point(217, 32);
            this.txt_Assunto.MinimumSize = new System.Drawing.Size(2, 28);
            this.txt_Assunto.Name = "txt_Assunto";
            this.txt_Assunto.Size = new System.Drawing.Size(526, 27);
            this.txt_Assunto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ação:";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(656, 183);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 33);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Anexar
            // 
            this.btn_Anexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anexar.Location = new System.Drawing.Point(563, 183);
            this.btn_Anexar.Name = "btn_Anexar";
            this.btn_Anexar.Size = new System.Drawing.Size(87, 33);
            this.btn_Anexar.TabIndex = 16;
            this.btn_Anexar.Text = "Anexar";
            this.btn_Anexar.UseVisualStyleBackColor = true;
            this.btn_Anexar.Click += new System.EventHandler(this.btn_Anexar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salvar.Location = new System.Drawing.Point(657, 504);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(87, 33);
            this.btn_Salvar.TabIndex = 17;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Previsão da Solução:";
            // 
            // dateTimePrevisao
            // 
            this.dateTimePrevisao.CalendarForeColor = System.Drawing.SystemColors.InfoText;
            this.dateTimePrevisao.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dateTimePrevisao.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePrevisao.CalendarTitleForeColor = System.Drawing.SystemColors.MenuText;
            this.dateTimePrevisao.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePrevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePrevisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePrevisao.Location = new System.Drawing.Point(13, 348);
            this.dateTimePrevisao.Name = "dateTimePrevisao";
            this.dateTimePrevisao.Size = new System.Drawing.Size(178, 27);
            this.dateTimePrevisao.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CadastroTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(763, 549);
            this.Controls.Add(this.dateTimePrevisao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Anexar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Assunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Mensagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxUrgencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxServicos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPessoas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroTicket";
            this.Text = "Cadastro de Ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroTicket_FormClosing);
            this.Load += new System.EventHandler(this.CadastroTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxPessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxServicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUrgencia;
        private System.Windows.Forms.RichTextBox txt_Mensagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Assunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Anexar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePrevisao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}