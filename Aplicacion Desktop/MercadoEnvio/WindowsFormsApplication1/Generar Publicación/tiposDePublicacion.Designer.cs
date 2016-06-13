namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class tiposDePublicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCompra = new System.Windows.Forms.Button();
            this.buttonSubasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de publicación que desea crear";
            // 
            // buttonCompra
            // 
            this.buttonCompra.Location = new System.Drawing.Point(15, 75);
            this.buttonCompra.Name = "buttonCompra";
            this.buttonCompra.Size = new System.Drawing.Size(126, 23);
            this.buttonCompra.TabIndex = 1;
            this.buttonCompra.Text = "Compra inmediata";
            this.buttonCompra.UseVisualStyleBackColor = true;
            this.buttonCompra.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // buttonSubasta
            // 
            this.buttonSubasta.Location = new System.Drawing.Point(170, 75);
            this.buttonSubasta.Name = "buttonSubasta";
            this.buttonSubasta.Size = new System.Drawing.Size(75, 23);
            this.buttonSubasta.TabIndex = 2;
            this.buttonSubasta.Text = "Subasta";
            this.buttonSubasta.UseVisualStyleBackColor = true;
            // 
            // tiposDePublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.buttonSubasta);
            this.Controls.Add(this.buttonCompra);
            this.Controls.Add(this.label1);
            this.Name = "tiposDePublicacion";
            this.Text = "tiposDePublicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.Button buttonSubasta;

    }
}