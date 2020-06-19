namespace HelpDesk
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.btn_Alterar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.btn_Pessoas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridTicket = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrevisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.btn_Alterar,
            this.btn_Excluir,
            this.btn_Imprimir,
            this.btn_Pessoas,
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 22);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(40, 19);
            this.toolStripButton6.Text = "Novo";
            this.toolStripButton6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click_1);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Image")));
            this.btn_Alterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(46, 19);
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Image")));
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(46, 19);
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_Excluir.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imprimir.Image")));
            this.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(57, 19);
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Pessoas
            // 
            this.btn_Pessoas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Pessoas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pessoas.Image")));
            this.btn_Pessoas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Pessoas.Name = "btn_Pessoas";
            this.btn_Pessoas.Size = new System.Drawing.Size(52, 19);
            this.btn_Pessoas.Text = "Pessoas";
            this.btn_Pessoas.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 19);
            this.toolStripButton1.Text = "Equipes";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(43, 19);
            this.toolStripButton4.Text = "Status";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(63, 19);
            this.toolStripButton5.Text = "Urgências";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 19);
            this.toolStripButton2.Text = "Serviços";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridTicket
            // 
            this.dataGridTicket.AllowUserToAddRows = false;
            this.dataGridTicket.AllowUserToDeleteRows = false;
            this.dataGridTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pessoa,
            this.Assunto,
            this.Responsavel,
            this.Servico,
            this.Status,
            this.Urgencia,
            this.Equipe,
            this.DataInicio,
            this.DataAlteracao,
            this.DataPrevisao,
            this.CodigoPessoa});
            this.dataGridTicket.Location = new System.Drawing.Point(12, 25);
            this.dataGridTicket.Name = "dataGridTicket";
            this.dataGridTicket.ReadOnly = true;
            this.dataGridTicket.Size = new System.Drawing.Size(776, 365);
            this.dataGridTicket.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Pessoa
            // 
            this.Pessoa.DataPropertyName = "NomePessoa";
            this.Pessoa.HeaderText = "Pessoa";
            this.Pessoa.Name = "Pessoa";
            this.Pessoa.ReadOnly = true;
            this.Pessoa.Width = 200;
            // 
            // Assunto
            // 
            this.Assunto.DataPropertyName = "Assunto";
            this.Assunto.HeaderText = "Assunto";
            this.Assunto.Name = "Assunto";
            this.Assunto.ReadOnly = true;
            this.Assunto.Width = 200;
            // 
            // Responsavel
            // 
            this.Responsavel.DataPropertyName = "NomeResponsavel";
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            this.Responsavel.Width = 150;
            // 
            // Servico
            // 
            this.Servico.DataPropertyName = "NomeServico";
            this.Servico.HeaderText = "Serviços";
            this.Servico.Name = "Servico";
            this.Servico.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "NomeStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Urgencia
            // 
            this.Urgencia.DataPropertyName = "NomeUrgencia";
            this.Urgencia.HeaderText = "Urgência";
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.ReadOnly = true;
            // 
            // Equipe
            // 
            this.Equipe.DataPropertyName = "NomeEquipe";
            this.Equipe.HeaderText = "Equipe";
            this.Equipe.Name = "Equipe";
            this.Equipe.ReadOnly = true;
            // 
            // DataInicio
            // 
            this.DataInicio.DataPropertyName = "DataInicio";
            this.DataInicio.HeaderText = "Data Criação";
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.ReadOnly = true;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.DataPropertyName = "DataAlteracao";
            this.DataAlteracao.HeaderText = "Data Alteração";
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.ReadOnly = true;
            // 
            // DataPrevisao
            // 
            this.DataPrevisao.DataPropertyName = "PrevisaoTermico";
            this.DataPrevisao.HeaderText = "Data Previsão";
            this.DataPrevisao.Name = "DataPrevisao";
            this.DataPrevisao.ReadOnly = true;
            // 
            // CodigoPessoa
            // 
            this.CodigoPessoa.DataPropertyName = "CodigoPessoa";
            this.CodigoPessoa.HeaderText = "CodigoPessoa";
            this.CodigoPessoa.Name = "CodigoPessoa";
            this.CodigoPessoa.ReadOnly = true;
            this.CodigoPessoa.Visible = false;
            // 
            // dt_Final
            // 
            this.dt_Final.CalendarForeColor = System.Drawing.SystemColors.InfoText;
            this.dt_Final.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dt_Final.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dt_Final.CalendarTitleForeColor = System.Drawing.SystemColors.MenuText;
            this.dt_Final.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dt_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(596, 416);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(178, 27);
            this.dt_Final.TabIndex = 21;
            this.dt_Final.ValueChanged += new System.EventHandler(this.dt_Final_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data Final:";
            // 
            // dt_Inicio
            // 
            this.dt_Inicio.CalendarForeColor = System.Drawing.SystemColors.InfoText;
            this.dt_Inicio.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dt_Inicio.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dt_Inicio.CalendarTitleForeColor = System.Drawing.SystemColors.MenuText;
            this.dt_Inicio.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dt_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicio.Location = new System.Drawing.Point(412, 416);
            this.dt_Inicio.Name = "dt_Inicio";
            this.dt_Inicio.Size = new System.Drawing.Size(178, 27);
            this.dt_Inicio.TabIndex = 23;
            this.dt_Inicio.ValueChanged += new System.EventHandler(this.dt_Inicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data Início:";
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Pesquisar.Location = new System.Drawing.Point(16, 416);
            this.txt_Pesquisar.MinimumSize = new System.Drawing.Size(2, 28);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(362, 27);
            this.txt_Pesquisar.TabIndex = 25;
            this.txt_Pesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Pesquisar_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pesquisar:";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoToolTip = true;
            this.toolStripLabel1.DoubleClickEnabled = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 15);
            this.toolStripLabel1.Text = "Ordenação Por ID";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_Inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridTicket);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Help Desk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btn_Pessoas;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.DataGridView dataGridTicket;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_Inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton btn_Alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrevisao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPessoa;
        private System.Windows.Forms.ToolStripButton btn_Imprimir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

