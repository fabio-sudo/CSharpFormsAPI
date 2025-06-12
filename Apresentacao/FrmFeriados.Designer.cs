namespace Apresentacao
{
    partial class FrmFeriados
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
            dgvFeriados = new DataGridView();
            btBuscar = new Button();
            btRemover = new Button();
            btAdicionar = new Button();
            tbAno = new TextBox();
            lbAno = new Label();
            btLinha = new Button();
            btAdicionarLinha = new Button();
            btRemoverLinha = new Button();
            btLimparGrid = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).BeginInit();
            SuspendLayout();
            // 
            // dgvFeriados
            // 
            dgvFeriados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeriados.Location = new Point(12, 89);
            dgvFeriados.Name = "dgvFeriados";
            dgvFeriados.Size = new Size(776, 320);
            dgvFeriados.TabIndex = 0;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(177, 60);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 1;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(177, 415);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(140, 23);
            btRemover.TabIndex = 2;
            btRemover.Text = "Remover Selecionada";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(12, 415);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(75, 23);
            btAdicionar.TabIndex = 3;
            btAdicionar.Text = "Coluna";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // tbAno
            // 
            tbAno.Location = new Point(12, 59);
            tbAno.Name = "tbAno";
            tbAno.Size = new Size(159, 23);
            tbAno.TabIndex = 4;
            // 
            // lbAno
            // 
            lbAno.AutoSize = true;
            lbAno.Location = new Point(12, 41);
            lbAno.Name = "lbAno";
            lbAno.Size = new Size(32, 15);
            lbAno.TabIndex = 5;
            lbAno.Text = "Ano:";
            // 
            // btLinha
            // 
            btLinha.Location = new Point(93, 415);
            btLinha.Name = "btLinha";
            btLinha.Size = new Size(75, 23);
            btLinha.TabIndex = 6;
            btLinha.Text = "Linha";
            btLinha.UseVisualStyleBackColor = true;
            btLinha.Click += btLinha_Click;
            // 
            // btAdicionarLinha
            // 
            btAdicionarLinha.Location = new Point(608, 415);
            btAdicionarLinha.Name = "btAdicionarLinha";
            btAdicionarLinha.Size = new Size(75, 23);
            btAdicionarLinha.TabIndex = 7;
            btAdicionarLinha.Text = "LinhaVaziaRow";
            btAdicionarLinha.UseVisualStyleBackColor = true;
            btAdicionarLinha.Click += btAdicionarLinha_Click;
            // 
            // btRemoverLinha
            // 
            btRemoverLinha.Location = new Point(689, 415);
            btRemoverLinha.Name = "btRemoverLinha";
            btRemoverLinha.Size = new Size(99, 23);
            btRemoverLinha.TabIndex = 8;
            btRemoverLinha.Text = "Remover Linha";
            btRemoverLinha.UseVisualStyleBackColor = true;
            btRemoverLinha.Click += btRemoverLinha_Click;
            // 
            // btLimparGrid
            // 
            btLimparGrid.Location = new Point(323, 415);
            btLimparGrid.Name = "btLimparGrid";
            btLimparGrid.Size = new Size(75, 23);
            btLimparGrid.TabIndex = 9;
            btLimparGrid.Text = "Limpar";
            btLimparGrid.UseVisualStyleBackColor = true;
            btLimparGrid.Click += btLimparGrid_Click;
            // 
            // FrmFeriados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btLimparGrid);
            Controls.Add(btRemoverLinha);
            Controls.Add(btAdicionarLinha);
            Controls.Add(btLinha);
            Controls.Add(lbAno);
            Controls.Add(tbAno);
            Controls.Add(btAdicionar);
            Controls.Add(btRemover);
            Controls.Add(btBuscar);
            Controls.Add(dgvFeriados);
            Name = "FrmFeriados";
            Text = "Feriados";
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFeriados;
        private Button btBuscar;
        private Button btRemover;
        private Button btAdicionar;
        private TextBox tbAno;
        private Label lbAno;
        private Button btLinha;
        private Button btAdicionarLinha;
        private Button btRemoverLinha;
        private Button btLimparGrid;
    }
}