namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class Comprar
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.labelInfoDescripcion = new System.Windows.Forms.Label();
            this.labelInfoVendedor = new System.Windows.Forms.Label();
            this.labelInfoPrecio = new System.Windows.Forms.Label();
            this.buttonConfirmarCompra = new System.Windows.Forms.Button();
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 24);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(12, 52);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(56, 13);
            this.labelVendedor.TabIndex = 1;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(12, 83);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(12, 114);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(284, 112);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(53, 20);
            this.numericCantidad.TabIndex = 4;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.ValueChanged += new System.EventHandler(this.numericCantidad_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Forma de Pago:";
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Items.AddRange(new object[] {
            "Efectivo"});
            this.comboBoxFormaPago.Location = new System.Drawing.Point(216, 149);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaPago.TabIndex = 6;
            // 
            // labelInfoDescripcion
            // 
            this.labelInfoDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoDescripcion.Location = new System.Drawing.Point(74, 24);
            this.labelInfoDescripcion.Name = "labelInfoDescripcion";
            this.labelInfoDescripcion.Size = new System.Drawing.Size(263, 13);
            this.labelInfoDescripcion.TabIndex = 7;
            this.labelInfoDescripcion.Text = "description";
            this.labelInfoDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInfoVendedor
            // 
            this.labelInfoVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoVendedor.Location = new System.Drawing.Point(179, 52);
            this.labelInfoVendedor.Name = "labelInfoVendedor";
            this.labelInfoVendedor.Size = new System.Drawing.Size(158, 13);
            this.labelInfoVendedor.TabIndex = 8;
            this.labelInfoVendedor.Text = "salesman";
            this.labelInfoVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoVendedor.UseMnemonic = false;
            // 
            // labelInfoPrecio
            // 
            this.labelInfoPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfoPrecio.Location = new System.Drawing.Point(182, 83);
            this.labelInfoPrecio.Name = "labelInfoPrecio";
            this.labelInfoPrecio.Size = new System.Drawing.Size(155, 13);
            this.labelInfoPrecio.TabIndex = 9;
            this.labelInfoPrecio.Text = "price";
            this.labelInfoPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonConfirmarCompra
            // 
            this.buttonConfirmarCompra.Location = new System.Drawing.Point(45, 234);
            this.buttonConfirmarCompra.Name = "buttonConfirmarCompra";
            this.buttonConfirmarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmarCompra.TabIndex = 10;
            this.buttonConfirmarCompra.Text = "COMPRAR";
            this.buttonConfirmarCompra.UseVisualStyleBackColor = true;
            this.buttonConfirmarCompra.Click += new System.EventHandler(this.buttonConfirmarCompra_Click);
            // 
            // buttonCancelarCompra
            // 
            this.buttonCancelarCompra.Location = new System.Drawing.Point(262, 234);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarCompra.TabIndex = 11;
            this.buttonCancelarCompra.Text = "CANCELAR";
            this.buttonCancelarCompra.UseVisualStyleBackColor = true;
            this.buttonCancelarCompra.Click += new System.EventHandler(this.buttonCancelarCompra_Click);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 312);
            this.Controls.Add(this.buttonCancelarCompra);
            this.Controls.Add(this.buttonConfirmarCompra);
            this.Controls.Add(this.labelInfoPrecio);
            this.Controls.Add(this.labelInfoVendedor);
            this.Controls.Add(this.labelInfoDescripcion);
            this.Controls.Add(this.comboBoxFormaPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.labelDescripcion);
            this.Name = "Comprar";
            this.Text = "Comprar";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label labelInfoDescripcion;
        private System.Windows.Forms.Label labelInfoVendedor;
        private System.Windows.Forms.Label labelInfoPrecio;
        private System.Windows.Forms.Button buttonConfirmarCompra;
        private System.Windows.Forms.Button buttonCancelarCompra;
    }
}