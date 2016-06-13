namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class Ofertar
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
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            this.buttonConfirmarCompra = new System.Windows.Forms.Button();
            this.labelInfoVendedor = new System.Windows.Forms.Label();
            this.labelInfoDescripcion = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOferta = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelarCompra
            // 
            this.buttonCancelarCompra.Location = new System.Drawing.Point(271, 244);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarCompra.TabIndex = 23;
            this.buttonCancelarCompra.Text = "CANCELAR";
            this.buttonCancelarCompra.UseVisualStyleBackColor = true;
            this.buttonCancelarCompra.Click += new System.EventHandler(this.buttonCancelarCompra_Click);
            // 
            // buttonConfirmarCompra
            // 
            this.buttonConfirmarCompra.Location = new System.Drawing.Point(58, 244);
            this.buttonConfirmarCompra.Name = "buttonConfirmarCompra";
            this.buttonConfirmarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmarCompra.TabIndex = 22;
            this.buttonConfirmarCompra.Text = "OFERTAR";
            this.buttonConfirmarCompra.UseVisualStyleBackColor = true;
            this.buttonConfirmarCompra.Click += new System.EventHandler(this.buttonConfirmarCompra_Click);
            // 
            // labelInfoVendedor
            // 
            this.labelInfoVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoVendedor.Location = new System.Drawing.Point(188, 96);
            this.labelInfoVendedor.Name = "labelInfoVendedor";
            this.labelInfoVendedor.Size = new System.Drawing.Size(158, 13);
            this.labelInfoVendedor.TabIndex = 20;
            this.labelInfoVendedor.Text = "salesman";
            this.labelInfoVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoVendedor.UseMnemonic = false;
            // 
            // labelInfoDescripcion
            // 
            this.labelInfoDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoDescripcion.Location = new System.Drawing.Point(83, 68);
            this.labelInfoDescripcion.Name = "labelInfoDescripcion";
            this.labelInfoDescripcion.Size = new System.Drawing.Size(263, 13);
            this.labelInfoDescripcion.TabIndex = 19;
            this.labelInfoDescripcion.Text = "description";
            this.labelInfoDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(21, 96);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(56, 13);
            this.labelVendedor.TabIndex = 13;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(21, 68);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Oferta:";
            // 
            // textBoxOferta
            // 
            this.textBoxOferta.Location = new System.Drawing.Point(246, 158);
            this.textBoxOferta.Name = "textBoxOferta";
            this.textBoxOferta.Size = new System.Drawing.Size(100, 20);
            this.textBoxOferta.TabIndex = 25;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(21, 122);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 26;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // cantidad
            // 
            this.cantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cantidad.Location = new System.Drawing.Point(188, 122);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(158, 13);
            this.cantidad.TabIndex = 27;
            this.cantidad.Text = "cantidad";
            this.cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cantidad.UseMnemonic = false;
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxOferta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelarCompra);
            this.Controls.Add(this.buttonConfirmarCompra);
            this.Controls.Add(this.labelInfoVendedor);
            this.Controls.Add(this.labelInfoDescripcion);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.labelDescripcion);
            this.Name = "Ofertar";
            this.Text = "Ofertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelarCompra;
        private System.Windows.Forms.Button buttonConfirmarCompra;
        private System.Windows.Forms.Label labelInfoVendedor;
        private System.Windows.Forms.Label labelInfoDescripcion;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOferta;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label cantidad;
    }
}