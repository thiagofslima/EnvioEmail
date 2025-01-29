namespace EnvioEmail
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtRemetente = new TextBox();
            btnEnviar = new Button();
            label2 = new Label();
            txtDestinatario = new TextBox();
            label3 = new Label();
            txtAssunto = new TextBox();
            txtMensagem = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 0;
            label1.Text = "Remetente:";
            // 
            // txtRemetente
            // 
            txtRemetente.Location = new Point(12, 29);
            txtRemetente.Name = "txtRemetente";
            txtRemetente.Size = new Size(266, 25);
            txtRemetente.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(213, 379);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(136, 38);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 0;
            label2.Text = "Destinatário:";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(12, 79);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.Size = new Size(266, 25);
            txtDestinatario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 59);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 0;
            label3.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(284, 79);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(266, 25);
            txtAssunto.TabIndex = 0;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(12, 120);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(538, 226);
            txtMensagem.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 9);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 0;
            label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(284, 29);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(266, 25);
            txtSenha.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 456);
            Controls.Add(txtMensagem);
            Controls.Add(btnEnviar);
            Controls.Add(txtDestinatario);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtAssunto);
            Controls.Add(label3);
            Controls.Add(txtRemetente);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRemetente;
        private Button btnEnviar;
        private Label label2;
        private TextBox txtDestinatario;
        private Label label3;
        private TextBox txtAssunto;
        private TextBox txtMensagem;
        private Label label4;
        private TextBox txtSenha;
    }
}
