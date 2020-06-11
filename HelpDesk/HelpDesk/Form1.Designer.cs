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
            this.btn_Cadastro_Equipe = new System.Windows.Forms.Button();
            this.btn_Cadastro_Status = new System.Windows.Forms.Button();
            this.btn_Cadastro_Servico = new System.Windows.Forms.Button();
            this.btn_Cadastro_Urgencia = new System.Windows.Forms.Button();
            this.btn_NovoTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cadastro_Equipe
            // 
            this.btn_Cadastro_Equipe.Location = new System.Drawing.Point(61, 54);
            this.btn_Cadastro_Equipe.Name = "btn_Cadastro_Equipe";
            this.btn_Cadastro_Equipe.Size = new System.Drawing.Size(113, 41);
            this.btn_Cadastro_Equipe.TabIndex = 0;
            this.btn_Cadastro_Equipe.Text = "Cadastro de Equipe";
            this.btn_Cadastro_Equipe.UseVisualStyleBackColor = true;
            this.btn_Cadastro_Equipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cadastro_Status
            // 
            this.btn_Cadastro_Status.Location = new System.Drawing.Point(180, 54);
            this.btn_Cadastro_Status.Name = "btn_Cadastro_Status";
            this.btn_Cadastro_Status.Size = new System.Drawing.Size(113, 41);
            this.btn_Cadastro_Status.TabIndex = 1;
            this.btn_Cadastro_Status.Text = "Cadastro de Status";
            this.btn_Cadastro_Status.UseVisualStyleBackColor = true;
            this.btn_Cadastro_Status.Click += new System.EventHandler(this.btn_Cadastro_Status_Click);
            // 
            // btn_Cadastro_Servico
            // 
            this.btn_Cadastro_Servico.Location = new System.Drawing.Point(418, 54);
            this.btn_Cadastro_Servico.Name = "btn_Cadastro_Servico";
            this.btn_Cadastro_Servico.Size = new System.Drawing.Size(113, 41);
            this.btn_Cadastro_Servico.TabIndex = 2;
            this.btn_Cadastro_Servico.Text = "Cadastro de Serviço";
            this.btn_Cadastro_Servico.UseVisualStyleBackColor = true;
            this.btn_Cadastro_Servico.Click += new System.EventHandler(this.btn_Cadastro_Servico_Click);
            // 
            // btn_Cadastro_Urgencia
            // 
            this.btn_Cadastro_Urgencia.Location = new System.Drawing.Point(299, 54);
            this.btn_Cadastro_Urgencia.Name = "btn_Cadastro_Urgencia";
            this.btn_Cadastro_Urgencia.Size = new System.Drawing.Size(113, 41);
            this.btn_Cadastro_Urgencia.TabIndex = 3;
            this.btn_Cadastro_Urgencia.Text = "Cadastro de Urgência";
            this.btn_Cadastro_Urgencia.UseVisualStyleBackColor = true;
            this.btn_Cadastro_Urgencia.Click += new System.EventHandler(this.btn_Cadastro_Urgencia_Click);
            // 
            // btn_NovoTicket
            // 
            this.btn_NovoTicket.Location = new System.Drawing.Point(61, 137);
            this.btn_NovoTicket.Name = "btn_NovoTicket";
            this.btn_NovoTicket.Size = new System.Drawing.Size(113, 41);
            this.btn_NovoTicket.TabIndex = 4;
            this.btn_NovoTicket.Text = "Novo Ticket";
            this.btn_NovoTicket.UseVisualStyleBackColor = true;
            this.btn_NovoTicket.Click += new System.EventHandler(this.btn_NovoTicket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NovoTicket);
            this.Controls.Add(this.btn_Cadastro_Urgencia);
            this.Controls.Add(this.btn_Cadastro_Servico);
            this.Controls.Add(this.btn_Cadastro_Status);
            this.Controls.Add(this.btn_Cadastro_Equipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cadastro_Equipe;
        private System.Windows.Forms.Button btn_Cadastro_Status;
        private System.Windows.Forms.Button btn_Cadastro_Servico;
        private System.Windows.Forms.Button btn_Cadastro_Urgencia;
        private System.Windows.Forms.Button btn_NovoTicket;
    }
}

