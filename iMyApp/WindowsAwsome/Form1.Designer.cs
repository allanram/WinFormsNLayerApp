namespace WindowsAwsome
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
            panelMenu = new Panel();
            ibContato = new FontAwesome.Sharp.IconButton();
            ibAdministracao = new FontAwesome.Sharp.IconButton();
            ibFinancas = new FontAwesome.Sharp.IconButton();
            ibOperacoes = new FontAwesome.Sharp.IconButton();
            ibRhOptions = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.MidnightBlue;
            panelMenu.Controls.Add(ibContato);
            panelMenu.Controls.Add(ibAdministracao);
            panelMenu.Controls.Add(ibFinancas);
            panelMenu.Controls.Add(ibOperacoes);
            panelMenu.Controls.Add(ibRhOptions);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 445);
            panelMenu.TabIndex = 0;
            // 
            // ibContato
            // 
            ibContato.Dock = DockStyle.Top;
            ibContato.FlatAppearance.BorderSize = 0;
            ibContato.FlatStyle = FlatStyle.Flat;
            ibContato.ForeColor = Color.Silver;
            ibContato.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            ibContato.IconColor = Color.Silver;
            ibContato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibContato.IconSize = 32;
            ibContato.ImageAlign = ContentAlignment.MiddleLeft;
            ibContato.Location = new Point(0, 380);
            ibContato.Name = "ibContato";
            ibContato.Size = new Size(200, 65);
            ibContato.TabIndex = 5;
            ibContato.Text = "Contact";
            ibContato.TextAlign = ContentAlignment.MiddleLeft;
            ibContato.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibContato.UseVisualStyleBackColor = true;
            ibContato.Click += ibContato_Click;
            // 
            // ibAdministracao
            // 
            ibAdministracao.Dock = DockStyle.Top;
            ibAdministracao.FlatAppearance.BorderSize = 0;
            ibAdministracao.FlatStyle = FlatStyle.Flat;
            ibAdministracao.ForeColor = Color.Silver;
            ibAdministracao.IconChar = FontAwesome.Sharp.IconChar.Cube;
            ibAdministracao.IconColor = Color.Silver;
            ibAdministracao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibAdministracao.IconSize = 32;
            ibAdministracao.ImageAlign = ContentAlignment.MiddleLeft;
            ibAdministracao.Location = new Point(0, 320);
            ibAdministracao.Name = "ibAdministracao";
            ibAdministracao.Size = new Size(200, 60);
            ibAdministracao.TabIndex = 4;
            ibAdministracao.Text = "Administration";
            ibAdministracao.TextAlign = ContentAlignment.MiddleLeft;
            ibAdministracao.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibAdministracao.UseVisualStyleBackColor = true;
            ibAdministracao.Click += ibAdministracao_Click;
            // 
            // ibFinancas
            // 
            ibFinancas.Dock = DockStyle.Top;
            ibFinancas.FlatAppearance.BorderSize = 0;
            ibFinancas.FlatStyle = FlatStyle.Flat;
            ibFinancas.ForeColor = Color.Silver;
            ibFinancas.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            ibFinancas.IconColor = Color.Silver;
            ibFinancas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibFinancas.IconSize = 32;
            ibFinancas.ImageAlign = ContentAlignment.MiddleLeft;
            ibFinancas.Location = new Point(0, 260);
            ibFinancas.Name = "ibFinancas";
            ibFinancas.Size = new Size(200, 60);
            ibFinancas.TabIndex = 3;
            ibFinancas.Text = "Finance";
            ibFinancas.TextAlign = ContentAlignment.MiddleLeft;
            ibFinancas.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibFinancas.UseVisualStyleBackColor = true;
            ibFinancas.Click += ibFinancas_Click;
            // 
            // ibOperacoes
            // 
            ibOperacoes.Dock = DockStyle.Top;
            ibOperacoes.FlatAppearance.BorderSize = 0;
            ibOperacoes.FlatStyle = FlatStyle.Flat;
            ibOperacoes.ForeColor = Color.Silver;
            ibOperacoes.IconChar = FontAwesome.Sharp.IconChar.House;
            ibOperacoes.IconColor = Color.Silver;
            ibOperacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibOperacoes.IconSize = 32;
            ibOperacoes.ImageAlign = ContentAlignment.MiddleLeft;
            ibOperacoes.Location = new Point(0, 200);
            ibOperacoes.Name = "ibOperacoes";
            ibOperacoes.Size = new Size(200, 60);
            ibOperacoes.TabIndex = 2;
            ibOperacoes.Text = "Acessibility";
            ibOperacoes.TextAlign = ContentAlignment.MiddleLeft;
            ibOperacoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibOperacoes.UseVisualStyleBackColor = true;
            ibOperacoes.Click += ibOperacoes_Click;
            // 
            // ibRhOptions
            // 
            ibRhOptions.Dock = DockStyle.Top;
            ibRhOptions.FlatAppearance.BorderSize = 0;
            ibRhOptions.FlatStyle = FlatStyle.Flat;
            ibRhOptions.ForeColor = Color.Silver;
            ibRhOptions.IconChar = FontAwesome.Sharp.IconChar.User;
            ibRhOptions.IconColor = Color.Silver;
            ibRhOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibRhOptions.IconSize = 32;
            ibRhOptions.ImageAlign = ContentAlignment.MiddleLeft;
            ibRhOptions.Location = new Point(0, 140);
            ibRhOptions.Name = "ibRhOptions";
            ibRhOptions.Size = new Size(200, 60);
            ibRhOptions.TabIndex = 1;
            ibRhOptions.Text = "Account";
            ibRhOptions.TextAlign = ContentAlignment.MiddleLeft;
            ibRhOptions.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibRhOptions.UseVisualStyleBackColor = true;
            ibRhOptions.Click += ibRhOptions_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 140);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 445);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibRhOptions;
        private FontAwesome.Sharp.IconButton ibAdministracao;
        private FontAwesome.Sharp.IconButton ibFinancas;
        private FontAwesome.Sharp.IconButton ibOperacoes;
        private FontAwesome.Sharp.IconButton ibContato;
        private Panel panel2;
    }
}