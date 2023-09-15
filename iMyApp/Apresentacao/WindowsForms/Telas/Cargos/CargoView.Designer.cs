namespace WindowsForms.Telas.Cargos
{
    partial class CargoView
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
            txtCargo = new TextBox();
            chkStatus = new CheckBox();
            btnSalvar = new Button();
            groupBoxCargo = new GroupBox();
            btnNovoCargo = new Button();
            gvCargos = new DataGridView();
            btnRecarregar = new Button();
            label1 = new Label();
            groupBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 28);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 0;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(124, 30);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(89, 19);
            chkStatus.TabIndex = 2;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(282, 25);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 27);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Location = new Point(12, 76);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(581, 64);
            groupBoxCargo.TabIndex = 4;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo Cargo";
            groupBoxCargo.Visible = false;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Location = new Point(12, 31);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(80, 27);
            btnNovoCargo.TabIndex = 4;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // gvCargos
            // 
            gvCargos.AllowUserToAddRows = false;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(12, 176);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(637, 196);
            gvCargos.TabIndex = 5;
            gvCargos.CellMouseClick += gvCargos_CellMouseClick;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(530, 143);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(80, 27);
            btnRecarregar.TabIndex = 4;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 148);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 6;
            label1.Text = "Todos os cargos(GridView)";
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 384);
            Controls.Add(label1);
            Controls.Add(btnRecarregar);
            Controls.Add(gvCargos);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            Name = "CargoView";
            Text = "CargoView";
            Load += CargoView_Load;
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCargo;
        private CheckBox chkStatus;
        private Button btnSalvar;
        private GroupBox groupBoxCargo;
        private Button btnNovoCargo;
        private DataGridView gvCargos;
        private Button btnRecarregar;
        private Label label1;
    }
}