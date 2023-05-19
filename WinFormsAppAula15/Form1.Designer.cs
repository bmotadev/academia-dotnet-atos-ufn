namespace WinFormsAppAula15
{
    partial class FormPrincipal
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
            labelNomeJogador = new Label();
            textBoxNomeJogador = new TextBox();
            buttonGerarEmail = new Button();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxListaEmails = new TextBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // labelNomeJogador
            // 
            labelNomeJogador.AutoSize = true;
            labelNomeJogador.Location = new Point(12, 14);
            labelNomeJogador.Name = "labelNomeJogador";
            labelNomeJogador.Size = new Size(102, 15);
            labelNomeJogador.TabIndex = 0;
            labelNomeJogador.Text = "Nome do Jogador";
            // 
            // textBoxNomeJogador
            // 
            textBoxNomeJogador.Location = new Point(120, 11);
            textBoxNomeJogador.Name = "textBoxNomeJogador";
            textBoxNomeJogador.Size = new Size(343, 23);
            textBoxNomeJogador.TabIndex = 1;
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.Location = new Point(120, 110);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(75, 23);
            buttonGerarEmail.TabIndex = 2;
            buttonGerarEmail.Text = "Gerar Email";
            buttonGerarEmail.UseVisualStyleBackColor = true;
            buttonGerarEmail.Click += buttonGerarEmail_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(120, 54);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(343, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(57, 57);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // textBoxListaEmails
            // 
            textBoxListaEmails.Location = new Point(269, 110);
            textBoxListaEmails.Multiline = true;
            textBoxListaEmails.Name = "textBoxListaEmails";
            textBoxListaEmails.ReadOnly = true;
            textBoxListaEmails.ScrollBars = ScrollBars.Vertical;
            textBoxListaEmails.Size = new Size(194, 167);
            textBoxListaEmails.TabIndex = 5;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Enabled = false;
            buttonLimpar.Location = new Point(120, 155);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 6;
            buttonLimpar.TabStop = false;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 289);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxListaEmails);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonGerarEmail);
            Controls.Add(textBoxNomeJogador);
            Controls.Add(labelNomeJogador);
            Name = "FormPrincipal";
            Text = "Titulo do Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeJogador;
        private TextBox textBoxNomeJogador;
        private Button buttonGerarEmail;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxListaEmails;
        private Button buttonLimpar;
    }
}