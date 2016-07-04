namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class Historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelPromedioCalif = new System.Windows.Forms.Label();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.buttonOfertas = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dataGridView_Historial = new System.Windows.Forms.DataGridView();
            this.labelNroPagina = new System.Windows.Forms.Label();
            this.linkPrimeraPag = new System.Windows.Forms.LinkLabel();
            this.linkUltimaPag = new System.Windows.Forms.LinkLabel();
            this.label_InfoPagina_CO = new System.Windows.Forms.Label();
            this.label_Anterio_CO = new System.Windows.Forms.LinkLabel();
            this.label_Siguiente_CO = new System.Windows.Forms.LinkLabel();
            this.textBoxCalificacionPromedio = new System.Windows.Forms.TextBox();
            this.textBoxPorCalificar = new System.Windows.Forms.TextBox();
            this.labelPorCalificar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAL CONSOLIDADO";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(406, 26);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(80, 26);
            this.labelCliente.TabIndex = 3;
            this.labelCliente.Text = "Cliente";
            // 
            // labelPromedioCalif
            // 
            this.labelPromedioCalif.AutoSize = true;
            this.labelPromedioCalif.Location = new System.Drawing.Point(45, 74);
            this.labelPromedioCalif.Name = "labelPromedioCalif";
            this.labelPromedioCalif.Size = new System.Drawing.Size(173, 13);
            this.labelPromedioCalif.TabIndex = 4;
            this.labelPromedioCalif.Text = "Promedio de Calificacion Otorgada:";
            // 
            // buttonCompras
            // 
            this.buttonCompras.Location = new System.Drawing.Point(522, 74);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(75, 23);
            this.buttonCompras.TabIndex = 6;
            this.buttonCompras.Text = "COMPRAS";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonOfertas
            // 
            this.buttonOfertas.Location = new System.Drawing.Point(611, 74);
            this.buttonOfertas.Name = "buttonOfertas";
            this.buttonOfertas.Size = new System.Drawing.Size(75, 23);
            this.buttonOfertas.TabIndex = 7;
            this.buttonOfertas.Text = "OFERTAS";
            this.buttonOfertas.UseVisualStyleBackColor = true;
            this.buttonOfertas.Click += new System.EventHandler(this.buttonOfertas_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(691, 429);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 8;
            this.buttonLimpiar.Text = "LIMPIAR";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // dataGridView_Historial
            // 
            this.dataGridView_Historial.AllowUserToAddRows = false;
            this.dataGridView_Historial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_Historial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Historial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Historial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Historial.Location = new System.Drawing.Point(87, 143);
            this.dataGridView_Historial.MultiSelect = false;
            this.dataGridView_Historial.Name = "dataGridView_Historial";
            this.dataGridView_Historial.ReadOnly = true;
            this.dataGridView_Historial.RowHeadersVisible = false;
            this.dataGridView_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Historial.Size = new System.Drawing.Size(568, 331);
            this.dataGridView_Historial.TabIndex = 10;
            // 
            // labelNroPagina
            // 
            this.labelNroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPagina.Location = new System.Drawing.Point(495, 490);
            this.labelNroPagina.Name = "labelNroPagina";
            this.labelNroPagina.Size = new System.Drawing.Size(48, 20);
            this.labelNroPagina.TabIndex = 18;
            this.labelNroPagina.Text = "Nº";
            this.labelNroPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkPrimeraPag
            // 
            this.linkPrimeraPag.AutoSize = true;
            this.linkPrimeraPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrimeraPag.Location = new System.Drawing.Point(367, 493);
            this.linkPrimeraPag.Name = "linkPrimeraPag";
            this.linkPrimeraPag.Size = new System.Drawing.Size(57, 17);
            this.linkPrimeraPag.TabIndex = 17;
            this.linkPrimeraPag.TabStop = true;
            this.linkPrimeraPag.Text = "Primera";
            this.linkPrimeraPag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrimeraPag_LinkClicked_1);
            // 
            // linkUltimaPag
            // 
            this.linkUltimaPag.AutoSize = true;
            this.linkUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUltimaPag.Location = new System.Drawing.Point(622, 493);
            this.linkUltimaPag.Name = "linkUltimaPag";
            this.linkUltimaPag.Size = new System.Drawing.Size(47, 17);
            this.linkUltimaPag.TabIndex = 16;
            this.linkUltimaPag.TabStop = true;
            this.linkUltimaPag.Text = "Ultima";
            this.linkUltimaPag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUltimaPag_LinkClicked);
            // 
            // label_InfoPagina_CO
            // 
            this.label_InfoPagina_CO.AutoSize = true;
            this.label_InfoPagina_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoPagina_CO.Location = new System.Drawing.Point(254, 493);
            this.label_InfoPagina_CO.Name = "label_InfoPagina_CO";
            this.label_InfoPagina_CO.Size = new System.Drawing.Size(66, 20);
            this.label_InfoPagina_CO.TabIndex = 15;
            this.label_InfoPagina_CO.Text = "Paginas";
            // 
            // label_Anterio_CO
            // 
            this.label_Anterio_CO.AutoSize = true;
            this.label_Anterio_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Anterio_CO.Location = new System.Drawing.Point(431, 493);
            this.label_Anterio_CO.Name = "label_Anterio_CO";
            this.label_Anterio_CO.Size = new System.Drawing.Size(58, 17);
            this.label_Anterio_CO.TabIndex = 14;
            this.label_Anterio_CO.TabStop = true;
            this.label_Anterio_CO.Text = "Anterior";
            this.label_Anterio_CO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Anterio_CO_LinkClicked_1);
            // 
            // label_Siguiente_CO
            // 
            this.label_Siguiente_CO.AutoSize = true;
            this.label_Siguiente_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Siguiente_CO.Location = new System.Drawing.Point(549, 493);
            this.label_Siguiente_CO.Name = "label_Siguiente_CO";
            this.label_Siguiente_CO.Size = new System.Drawing.Size(67, 17);
            this.label_Siguiente_CO.TabIndex = 13;
            this.label_Siguiente_CO.TabStop = true;
            this.label_Siguiente_CO.Text = "Siguiente";
            this.label_Siguiente_CO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Siguiente_CO_LinkClicked_1);
            // 
            // textBoxCalificacionPromedio
            // 
            this.textBoxCalificacionPromedio.Location = new System.Drawing.Point(253, 71);
            this.textBoxCalificacionPromedio.Name = "textBoxCalificacionPromedio";
            this.textBoxCalificacionPromedio.Size = new System.Drawing.Size(44, 20);
            this.textBoxCalificacionPromedio.TabIndex = 19;
            this.textBoxCalificacionPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPorCalificar
            // 
            this.textBoxPorCalificar.Location = new System.Drawing.Point(253, 101);
            this.textBoxPorCalificar.Name = "textBoxPorCalificar";
            this.textBoxPorCalificar.Size = new System.Drawing.Size(44, 20);
            this.textBoxPorCalificar.TabIndex = 21;
            this.textBoxPorCalificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPorCalificar
            // 
            this.labelPorCalificar.AutoSize = true;
            this.labelPorCalificar.Location = new System.Drawing.Point(45, 104);
            this.labelPorCalificar.Name = "labelPorCalificar";
            this.labelPorCalificar.Size = new System.Drawing.Size(197, 13);
            this.labelPorCalificar.TabIndex = 20;
            this.labelPorCalificar.Text = "Operaciones pendientes de Calificacion:";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 577);
            this.Controls.Add(this.textBoxPorCalificar);
            this.Controls.Add(this.labelPorCalificar);
            this.Controls.Add(this.textBoxCalificacionPromedio);
            this.Controls.Add(this.labelNroPagina);
            this.Controls.Add(this.linkPrimeraPag);
            this.Controls.Add(this.linkUltimaPag);
            this.Controls.Add(this.label_InfoPagina_CO);
            this.Controls.Add(this.label_Anterio_CO);
            this.Controls.Add(this.label_Siguiente_CO);
            this.Controls.Add(this.dataGridView_Historial);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOfertas);
            this.Controls.Add(this.buttonCompras);
            this.Controls.Add(this.labelPromedioCalif);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.label1);
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadoEnvio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelPromedioCalif;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonOfertas;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridView dataGridView_Historial;
        private System.Windows.Forms.Label labelNroPagina;
        private System.Windows.Forms.LinkLabel linkPrimeraPag;
        private System.Windows.Forms.LinkLabel linkUltimaPag;
        private System.Windows.Forms.Label label_InfoPagina_CO;
        private System.Windows.Forms.LinkLabel label_Anterio_CO;
        private System.Windows.Forms.LinkLabel label_Siguiente_CO;
        private System.Windows.Forms.TextBox textBoxCalificacionPromedio;
        private System.Windows.Forms.TextBox textBoxPorCalificar;
        private System.Windows.Forms.Label labelPorCalificar;
    }
}