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
            this.buttonCancelarOferta = new System.Windows.Forms.Button();
            this.buttonConfirmarOferta = new System.Windows.Forms.Button();
            this.labelInfoVendedor = new System.Windows.Forms.Label();
            this.labelInfoDescripcion = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOferta = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelarOferta
            // 
            this.buttonCancelarOferta.Location = new System.Drawing.Point(262, 234);
            this.buttonCancelarOferta.Name = "buttonCancelarOferta";
            this.buttonCancelarOferta.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarOferta.TabIndex = 23;
            this.buttonCancelarOferta.Text = "CANCELAR";
            this.buttonCancelarOferta.UseVisualStyleBackColor = true;
            this.buttonCancelarOferta.Click += new System.EventHandler(this.buttonCancelarCompra_Click);
            // 
            // buttonConfirmarOferta
            // 
            this.buttonConfirmarOferta.Location = new System.Drawing.Point(45, 234);
            this.buttonConfirmarOferta.Name = "buttonConfirmarOferta";
            this.buttonConfirmarOferta.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmarOferta.TabIndex = 22;
            this.buttonConfirmarOferta.Text = "OFERTAR";
            this.buttonConfirmarOferta.UseVisualStyleBackColor = true;
            this.buttonConfirmarOferta.Click += new System.EventHandler(this.buttonConfirmarCompra_Click);
            // 
            // labelInfoVendedor
            // 
            this.labelInfoVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoVendedor.Location = new System.Drawing.Point(179, 52);
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
            this.labelInfoDescripcion.Location = new System.Drawing.Point(74, 24);
            this.labelInfoDescripcion.Name = "labelInfoDescripcion";
            this.labelInfoDescripcion.Size = new System.Drawing.Size(263, 13);
            this.labelInfoDescripcion.TabIndex = 19;
            this.labelInfoDescripcion.Text = "description";
            this.labelInfoDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(12, 52);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(56, 13);
            this.labelVendedor.TabIndex = 13;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 24);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Oferta:";
            // 
            // textBoxOferta
            // 
            this.textBoxOferta.Location = new System.Drawing.Point(237, 144);
            this.textBoxOferta.Name = "textBoxOferta";
            this.textBoxOferta.Size = new System.Drawing.Size(100, 20);
            this.textBoxOferta.TabIndex = 25;
            this.textBoxOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(12, 84);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 26;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // cantidad
            // 
            this.cantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cantidad.Location = new System.Drawing.Point(179, 84);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(158, 13);
            this.cantidad.TabIndex = 27;
            this.cantidad.Text = "cantidad";
            this.cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cantidad.UseMnemonic = false;
            // 
            // labelPrice
            // 
            this.labelPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPrice.Location = new System.Drawing.Point(179, 114);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(158, 13);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPrice.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Valor actual:";
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 312);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxOferta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelarOferta);
            this.Controls.Add(this.buttonConfirmarOferta);
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

        private System.Windows.Forms.Button buttonCancelarOferta;
        private System.Windows.Forms.Button buttonConfirmarOferta;
        private System.Windows.Forms.Label labelInfoVendedor;
        private System.Windows.Forms.Label labelInfoDescripcion;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOferta;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label3;
    }
}