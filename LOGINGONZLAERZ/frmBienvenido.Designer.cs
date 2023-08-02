namespace LOGINGONZLAERZ
{
    partial class frmBienvenido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenido));
            this.lblCard = new System.Windows.Forms.Label();
            this.lblLabs = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCard
            // 
            resources.ApplyResources(this.lblCard, "lblCard");
            this.lblCard.Name = "lblCard";
            // 
            // lblLabs
            // 
            resources.ApplyResources(this.lblLabs, "lblLabs");
            this.lblLabs.Name = "lblLabs";
            // 
            // lblBienvenido
            // 
            resources.ApplyResources(this.lblBienvenido, "lblBienvenido");
            this.lblBienvenido.Name = "lblBienvenido";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::LOGINGONZLAERZ.Properties.Resources._469940764_Labskeycard1_png_71e7dd6b48ad1758791b26960c46bc98;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmBienvenido
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblLabs);
            this.Controls.Add(this.lblCard);
            this.Name = "frmBienvenido";
            this.Load += new System.EventHandler(this.frmBienvenido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblLabs;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

