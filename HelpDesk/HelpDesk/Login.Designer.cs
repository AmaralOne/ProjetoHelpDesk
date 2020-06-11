namespace HelpDesk
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Nome.Location = new System.Drawing.Point(17, 71);
            this.txt_Nome.MinimumSize = new System.Drawing.Size(0, 28);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(235, 28);
            this.txt_Nome.TabIndex = 14;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Senha.Location = new System.Drawing.Point(17, 134);
            this.txt_Senha.MinimumSize = new System.Drawing.Size(0, 28);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(235, 28);
            this.txt_Senha.TabIndex = 15;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Entrar.Location = new System.Drawing.Point(17, 178);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(87, 33);
            this.btn_Entrar.TabIndex = 18;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sair.Location = new System.Drawing.Point(110, 178);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 33);
            this.btn_Sair.TabIndex = 17;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 223);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Sair;
    }
}