﻿namespace WindowsForms.Telas.Cargos
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
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            groupBoxCargo = new GroupBox();
            btnNovoCargo = new Button();
            gvCargos = new DataGridView();
            label1 = new Label();
            btnRecarregar = new Button();
            groupBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(15, 34);
            txtCargo.Name = "txtCargo";
            txtCargo.PlaceholderText = "txtCargo";
            txtCargo.Size = new Size(416, 33);
            txtCargo.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(692, 32);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 33);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(494, 36);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(128, 29);
            chkStatus.TabIndex = 2;
            chkStatus.Text = "Cargo ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCargo.Location = new Point(12, 42);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(776, 77);
            groupBoxCargo.TabIndex = 3;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo cargo";
            groupBoxCargo.Visible = false;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovoCargo.Location = new Point(12, 5);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(166, 31);
            btnNovoCargo.TabIndex = 3;
            btnNovoCargo.Text = "Novo cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // gvCargos
            // 
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(1, 160);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(798, 301);
            gvCargos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 5;
            label1.Text = "Todos os cargos (GridView)";
            // 
            // btnRecarregar
            // 
            btnRecarregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecarregar.Location = new Point(655, 125);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(127, 32);
            btnRecarregar.TabIndex = 3;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(gvCargos);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            Name = "CargoView";
            Text = "CargoView";
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCargo;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private GroupBox groupBoxCargo;
        private Button btnNovoCargo;
        private DataGridView gvCargos;
        private Label label1;
        private Button btnRecarregar;
    }
}