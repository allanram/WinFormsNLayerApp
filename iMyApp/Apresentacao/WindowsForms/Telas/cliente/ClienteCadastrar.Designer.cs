namespace WindowsForms.Telas.cliente
{
    partial class ClienteCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteCadastrar));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            dtpNascimento = new DateTimePicker();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            cbBolsaEstudos = new ComboBox();
            label6 = new Label();
            chkEhResponsavel = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 72);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 143);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 143);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 72);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 3;
            label4.Text = "Cpf";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(179, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(372, 217);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(188, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(372, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(372, 90);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(164, 23);
            txtCpf.TabIndex = 7;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(179, 161);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(112, 23);
            dtpNascimento.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 199);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // cbBolsaEstudos
            // 
            cbBolsaEstudos.FormattingEnabled = true;
            cbBolsaEstudos.Location = new Point(179, 217);
            cbBolsaEstudos.Name = "cbBolsaEstudos";
            cbBolsaEstudos.Size = new Size(121, 23);
            cbBolsaEstudos.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 199);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 12;
            label6.Text = "Bolsa de Estudos";
            // 
            // chkEhResponsavel
            // 
            chkEhResponsavel.AutoSize = true;
            chkEhResponsavel.Location = new Point(179, 259);
            chkEhResponsavel.Name = "chkEhResponsavel";
            chkEhResponsavel.Size = new Size(102, 19);
            chkEhResponsavel.TabIndex = 13;
            chkEhResponsavel.Text = "E responsavel?";
            chkEhResponsavel.UseVisualStyleBackColor = true;
            // 
            // ClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 401);
            Controls.Add(chkEhResponsavel);
            Controls.Add(label6);
            Controls.Add(cbBolsaEstudos);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(dtpNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteCadastrar";
            Text = "ClienteCadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private DateTimePicker dtpNascimento;
        private Label label5;
        private PictureBox pictureBox1;
        private ComboBox cbBolsaEstudos;
        private Label label6;
        private CheckBox chkEhResponsavel;
    }
}