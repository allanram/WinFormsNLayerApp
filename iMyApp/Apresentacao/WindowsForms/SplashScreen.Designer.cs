namespace WindowsForms
{
    partial class SplashScreen
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
            pbCarregamento = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // pbCarregamento
            // 
            pbCarregamento.BackColor = Color.FromArgb(128, 255, 128);
            pbCarregamento.Location = new Point(359, 497);
            pbCarregamento.Name = "pbCarregamento";
            pbCarregamento.Size = new Size(265, 24);
            pbCarregamento.TabIndex = 0;
            pbCarregamento.Value = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(703, 516);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 1;
            label1.Text = "VERSÃO DEV 1.0 BETA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(458, 474);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "LOADING";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.emil_priver__v9q7v7IX6g_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 573);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbCarregamento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Shown += SplashScreen_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pbCarregamento;
        private Label label1;
        private Label label2;
    }
}