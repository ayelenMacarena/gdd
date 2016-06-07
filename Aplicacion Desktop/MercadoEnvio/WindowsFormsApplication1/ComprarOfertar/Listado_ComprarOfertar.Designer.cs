namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class Listado_ComprarOfertar
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
            this.Grid_ComprarOfertar = new System.Windows.Forms.DataGridView();
            this.Label_Buscador = new System.Windows.Forms.Label();
            this.textBuscado = new System.Windows.Forms.TextBox();
            this.label_Siguiente_CO = new System.Windows.Forms.LinkLabel();
            this.label_Anterio_CO = new System.Windows.Forms.LinkLabel();
            this.label_InfoPagina_CO = new System.Windows.Forms.Label();
            this.linkPrimeraPag = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.labelNroPagina = new System.Windows.Forms.Label();
            this.comboRubros = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ComprarOfertar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_ComprarOfertar
            // 
            this.Grid_ComprarOfertar.AllowUserToAddRows = false;
            this.Grid_ComprarOfertar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Grid_ComprarOfertar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_ComprarOfertar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_ComprarOfertar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_ComprarOfertar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ComprarOfertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ComprarOfertar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton});
            this.Grid_ComprarOfertar.Location = new System.Drawing.Point(185, 150);
            this.Grid_ComprarOfertar.MultiSelect = false;
            this.Grid_ComprarOfertar.Name = "Grid_ComprarOfertar";
            this.Grid_ComprarOfertar.ReadOnly = true;
            this.Grid_ComprarOfertar.RowHeadersVisible = false;
            this.Grid_ComprarOfertar.Size = new System.Drawing.Size(506, 370);
            this.Grid_ComprarOfertar.TabIndex = 0;
            // 
            // Label_Buscador
            // 
            this.Label_Buscador.AutoSize = true;
            this.Label_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Buscador.Location = new System.Drawing.Point(22, 111);
            this.Label_Buscador.Name = "Label_Buscador";
            this.Label_Buscador.Size = new System.Drawing.Size(109, 20);
            this.Label_Buscador.TabIndex = 1;
            this.Label_Buscador.Text = "BUSCADOR";
            // 
            // textBuscado
            // 
            this.textBuscado.Location = new System.Drawing.Point(151, 111);
            this.textBuscado.Name = "textBuscado";
            this.textBuscado.Size = new System.Drawing.Size(530, 20);
            this.textBuscado.TabIndex = 2;
            this.textBuscado.TextChanged += new System.EventHandler(this.textBuscado_TextChanged);
            // 
            // label_Siguiente_CO
            // 
            this.label_Siguiente_CO.AutoSize = true;
            this.label_Siguiente_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Siguiente_CO.Location = new System.Drawing.Point(697, 542);
            this.label_Siguiente_CO.Name = "label_Siguiente_CO";
            this.label_Siguiente_CO.Size = new System.Drawing.Size(67, 17);
            this.label_Siguiente_CO.TabIndex = 3;
            this.label_Siguiente_CO.TabStop = true;
            this.label_Siguiente_CO.Text = "Siguiente";
            this.label_Siguiente_CO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Siguiente_CO_LinkClicked);
            // 
            // label_Anterio_CO
            // 
            this.label_Anterio_CO.AutoSize = true;
            this.label_Anterio_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Anterio_CO.Location = new System.Drawing.Point(579, 542);
            this.label_Anterio_CO.Name = "label_Anterio_CO";
            this.label_Anterio_CO.Size = new System.Drawing.Size(58, 17);
            this.label_Anterio_CO.TabIndex = 4;
            this.label_Anterio_CO.TabStop = true;
            this.label_Anterio_CO.Text = "Anterior";
            this.label_Anterio_CO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Anterio_CO_LinkClicked);
            // 
            // label_InfoPagina_CO
            // 
            this.label_InfoPagina_CO.AutoSize = true;
            this.label_InfoPagina_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoPagina_CO.Location = new System.Drawing.Point(402, 542);
            this.label_InfoPagina_CO.Name = "label_InfoPagina_CO";
            this.label_InfoPagina_CO.Size = new System.Drawing.Size(66, 20);
            this.label_InfoPagina_CO.TabIndex = 5;
            this.label_InfoPagina_CO.Text = "Paginas";
            // 
            // linkPrimeraPag
            // 
            this.linkPrimeraPag.AutoSize = true;
            this.linkPrimeraPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrimeraPag.Location = new System.Drawing.Point(515, 542);
            this.linkPrimeraPag.Name = "linkPrimeraPag";
            this.linkPrimeraPag.Size = new System.Drawing.Size(57, 17);
            this.linkPrimeraPag.TabIndex = 7;
            this.linkPrimeraPag.TabStop = true;
            this.linkPrimeraPag.Text = "Primera";
            this.linkPrimeraPag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrimeraPag_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(770, 542);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ultima";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // labelNroPagina
            // 
            this.labelNroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNroPagina.AutoSize = true;
            this.labelNroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPagina.Location = new System.Drawing.Point(655, 539);
            this.labelNroPagina.Name = "labelNroPagina";
            this.labelNroPagina.Size = new System.Drawing.Size(26, 20);
            this.labelNroPagina.TabIndex = 8;
            this.labelNroPagina.Text = "Nº";
            this.labelNroPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboRubros
            // 
            this.comboRubros.FormattingEnabled = true;
            this.comboRubros.Location = new System.Drawing.Point(74, 17);
            this.comboRubros.Name = "comboRubros";
            this.comboRubros.Size = new System.Drawing.Size(121, 21);
            this.comboRubros.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboRubros);
            this.groupBox1.Location = new System.Drawing.Point(60, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rubros";
            // 
            // Boton
            // 
            this.Boton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Boton.HeaderText = "";
            this.Boton.Name = "Boton";
            this.Boton.ReadOnly = true;
            this.Boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Boton.Text = "Accion";
            this.Boton.Width = 5;
            // 
            // Listado_ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNroPagina);
            this.Controls.Add(this.linkPrimeraPag);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label_InfoPagina_CO);
            this.Controls.Add(this.label_Anterio_CO);
            this.Controls.Add(this.label_Siguiente_CO);
            this.Controls.Add(this.textBuscado);
            this.Controls.Add(this.Label_Buscador);
            this.Controls.Add(this.Grid_ComprarOfertar);
            this.Name = "Listado_ComprarOfertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadoEnvio";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ComprarOfertar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_ComprarOfertar;
        private System.Windows.Forms.Label Label_Buscador;
        private System.Windows.Forms.TextBox textBuscado;
        private System.Windows.Forms.LinkLabel label_Siguiente_CO;
        private System.Windows.Forms.LinkLabel label_Anterio_CO;
        private System.Windows.Forms.Label label_InfoPagina_CO;
        private System.Windows.Forms.LinkLabel linkPrimeraPag;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label labelNroPagina;
        private System.Windows.Forms.ComboBox comboRubros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
    }
}