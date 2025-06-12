namespace Apresentacao
{
    partial class FrmCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCep));
            mtbCep = new MaskedTextBox();
            btnCep = new Button();
            dgvCep = new DataGridView();
            Cep = new DataGridViewTextBoxColumn();
            Dados = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCep).BeginInit();
            SuspendLayout();
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(12, 12);
            mtbCep.Mask = "00000-000";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(159, 23);
            mtbCep.TabIndex = 0;
            mtbCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnCep
            // 
            btnCep.Location = new Point(177, 12);
            btnCep.Name = "btnCep";
            btnCep.Size = new Size(75, 23);
            btnCep.TabIndex = 1;
            btnCep.Text = "Buscar";
            btnCep.UseVisualStyleBackColor = true;
            btnCep.Click += btnCep_Click;
            // 
            // dgvCep
            // 
            dgvCep.AllowUserToAddRows = false;
            dgvCep.AllowUserToDeleteRows = false;
            dgvCep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCep.Columns.AddRange(new DataGridViewColumn[] { Cep, Dados });
            dgvCep.Location = new Point(12, 41);
            dgvCep.Name = "dgvCep";
            dgvCep.ReadOnly = true;
            dgvCep.Size = new Size(395, 263);
            dgvCep.TabIndex = 2;
            // 
            // Cep
            // 
            Cep.HeaderText = "CEP";
            Cep.Name = "Cep";
            Cep.ReadOnly = true;
            // 
            // Dados
            // 
            Dados.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dados.HeaderText = "Dados";
            Dados.Name = "Dados";
            Dados.ReadOnly = true;
            // 
            // FrmCep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 347);
            Controls.Add(dgvCep);
            Controls.Add(btnCep);
            Controls.Add(mtbCep);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCep";
            Text = "CEP";
            ((System.ComponentModel.ISupportInitialize)dgvCep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbCep;
        private Button btnCep;
        private DataGridView dgvCep;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn Dados;
    }
}