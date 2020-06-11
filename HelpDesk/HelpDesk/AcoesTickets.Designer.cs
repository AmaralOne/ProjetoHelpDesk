namespace HelpDesk
{
    partial class AcoesTickets
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Arquivo = new System.Windows.Forms.Button();
            this.lab_Usuario = new System.Windows.Forms.Label();
            this.lab_data = new System.Windows.Forms.Label();
            this.lab_Mensagem = new System.Windows.Forms.Label();
            this.lab_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Arquivo
            // 
            this.btn_Arquivo.Location = new System.Drawing.Point(358, 44);
            this.btn_Arquivo.Name = "btn_Arquivo";
            this.btn_Arquivo.Size = new System.Drawing.Size(75, 23);
            this.btn_Arquivo.TabIndex = 14;
            this.btn_Arquivo.Text = "Arquivo";
            this.btn_Arquivo.UseVisualStyleBackColor = true;
            this.btn_Arquivo.Click += new System.EventHandler(this.btn_Arquivo_Click);
            // 
            // lab_Usuario
            // 
            this.lab_Usuario.AutoSize = true;
            this.lab_Usuario.Location = new System.Drawing.Point(27, 11);
            this.lab_Usuario.Name = "lab_Usuario";
            this.lab_Usuario.Size = new System.Drawing.Size(60, 13);
            this.lab_Usuario.TabIndex = 13;
            this.lab_Usuario.Text = "Flávio Filho";
            // 
            // lab_data
            // 
            this.lab_data.AutoSize = true;
            this.lab_data.Location = new System.Drawing.Point(355, 11);
            this.lab_data.Name = "lab_data";
            this.lab_data.Size = new System.Drawing.Size(95, 13);
            this.lab_data.TabIndex = 12;
            this.lab_data.Text = "10/06/2020 00:00";
            // 
            // lab_Mensagem
            // 
            this.lab_Mensagem.AutoSize = true;
            this.lab_Mensagem.Location = new System.Drawing.Point(8, 30);
            this.lab_Mensagem.MaximumSize = new System.Drawing.Size(330, 60);
            this.lab_Mensagem.MinimumSize = new System.Drawing.Size(330, 40);
            this.lab_Mensagem.Name = "lab_Mensagem";
            this.lab_Mensagem.Size = new System.Drawing.Size(330, 52);
            this.lab_Mensagem.TabIndex = 11;
            this.lab_Mensagem.Text = "teste de mensagem kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk" +
    "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(8, 11);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(13, 13);
            this.lab_id.TabIndex = 10;
            this.lab_id.Text = "1";
            // 
            // AcoesTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_Arquivo);
            this.Controls.Add(this.lab_Usuario);
            this.Controls.Add(this.lab_data);
            this.Controls.Add(this.lab_Mensagem);
            this.Controls.Add(this.lab_id);
            this.Name = "AcoesTickets";
            this.Size = new System.Drawing.Size(480, 85);
            this.Load += new System.EventHandler(this.AcoesTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Arquivo;
        private System.Windows.Forms.Label lab_Usuario;
        private System.Windows.Forms.Label lab_data;
        private System.Windows.Forms.Label lab_Mensagem;
        private System.Windows.Forms.Label lab_id;
    }
}
