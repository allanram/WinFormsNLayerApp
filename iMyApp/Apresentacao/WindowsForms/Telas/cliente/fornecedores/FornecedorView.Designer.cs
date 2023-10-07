namespace WindowsForms.Telas.cliente.fornecedores
{
    partial class FornecedorView
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
            dgvMostraFornecedores = new DataGridView();
            Excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMostraFornecedores).BeginInit();
            SuspendLayout();
            // 
            // dgvMostraFornecedores
            // 
            dgvMostraFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostraFornecedores.Columns.AddRange(new DataGridViewColumn[] { Excluir });
            dgvMostraFornecedores.Location = new Point(5, 200);
            dgvMostraFornecedores.Name = "dgvMostraFornecedores";
            dgvMostraFornecedores.RowTemplate.Height = 25;
            dgvMostraFornecedores.Size = new Size(796, 238);
            dgvMostraFornecedores.TabIndex = 0;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            // 
            // FornecedorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMostraFornecedores);
            Name = "FornecedorView";
            Text = "FornecedorView";
            Load += FornecedorView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostraFornecedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMostraFornecedores;
        private DataGridViewButtonColumn Excluir;
    }
}