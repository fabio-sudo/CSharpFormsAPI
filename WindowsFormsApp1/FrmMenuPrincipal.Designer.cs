namespace WindowsFormsApp1
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.lbCep = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbCep
            // 
            resources.ApplyResources(this.lbCep, "lbCep");
            this.lbCep.Name = "lbCep";
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mtbCep
            // 
            resources.ApplyResources(this.mtbCep, "mtbCep");
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmMenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbCep);
            this.Name = "FrmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mtbCep;
    }
}

