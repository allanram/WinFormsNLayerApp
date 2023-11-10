namespace WindowsForms.Telas.Usuarios
{
    partial class frmUsuarios
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
            txtFrom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMensagem = new TextBox();
            txtTo = new TextBox();
            label4 = new Label();
            txtSubject = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(58, 92);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(326, 23);
            txtFrom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 64);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "DE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 131);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "PARA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 251);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "MENSAGEM";
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(58, 282);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(326, 125);
            txtMensagem.TabIndex = 4;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(58, 149);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(326, 23);
            txtTo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 192);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "ASSUNTO";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(58, 210);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(326, 23);
            txtSubject.TabIndex = 7;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(432, 384);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(105, 23);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtSubject);
            Controls.Add(label4);
            Controls.Add(txtTo);
            Controls.Add(txtMensagem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFrom);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrom;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMensagem;
        private TextBox txtTo;
        private Label label4;
        private TextBox txtSubject;
        private Button btnEnviar;
    }
}