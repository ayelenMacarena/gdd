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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_ComprarOfertar = new System.Windows.Forms.DataGridView();
            this.Label_Buscador = new System.Windows.Forms.Label();
            this.textBuscado = new System.Windows.Forms.TextBox();
            this.label_Siguiente_CO = new System.Windows.Forms.LinkLabel();
            this.label_Anterio_CO = new System.Windows.Forms.LinkLabel();
            this.label_InfoPagina_CO = new System.Windows.Forms.Label();
            this.linkPrimeraPag = new System.Windows.Forms.LinkLabel();
            this.linkUltimaPag = new System.Windows.Forms.LinkLabel();
            this.labelNroPagina = new System.Windows.Forms.Label();
            this.comboRubros = new System.Windows.Forms.ComboBox();
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.buttonLimpiarBusqueda = new System.Windows.Forms.Button();
            this.buttonAgregarRubro = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelRubrosSeleccionados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonOfertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ComprarOfertar)).BeginInit();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_ComprarOfertar
            // 
            this.Grid_ComprarOfertar.AllowUserToAddRows = false;
            this.Grid_ComprarOfertar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Grid_ComprarOfertar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_ComprarOfertar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_ComprarOfertar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_ComprarOfertar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ComprarOfertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ComprarOfertar.Location = new System.Drawing.Point(148, 205);
            this.Grid_ComprarOfertar.MultiSelect = false;
            this.Grid_ComprarOfertar.Name = "Grid_ComprarOfertar";
            this.Grid_ComprarOfertar.ReadOnly = true;
            this.Grid_ComprarOfertar.RowHeadersVisible = false;
            this.Grid_ComprarOfertar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ComprarOfertar.Size = new System.Drawing.Size(568, 331);
            this.Grid_ComprarOfertar.TabIndex = 0;
            this.Grid_ComprarOfertar.SelectionChanged += new System.EventHandler(this.Grid_ComprarOfertar_SelectionChanged);
            // 
            // Label_Buscador
            // 
            this.Label_Buscador.AutoSize = true;
            this.Label_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Buscador.Location = new System.Drawing.Point(6, 158);
            this.Label_Buscador.Name = "Label_Buscador";
            this.Label_Buscador.Size = new System.Drawing.Size(63, 13);
            this.Label_Buscador.TabIndex = 1;
            this.Label_Buscador.Text = "Descripcion";
            // 
            // textBuscado
            // 
            this.textBuscado.Location = new System.Drawing.Point(75, 155);
            this.textBuscado.Name = "textBuscado";
            this.textBuscado.Size = new System.Drawing.Size(486, 20);
            this.textBuscado.TabIndex = 2;
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
            // linkUltimaPag
            // 
            this.linkUltimaPag.AutoSize = true;
            this.linkUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUltimaPag.Location = new System.Drawing.Point(770, 542);
            this.linkUltimaPag.Name = "linkUltimaPag";
            this.linkUltimaPag.Size = new System.Drawing.Size(47, 17);
            this.linkUltimaPag.TabIndex = 6;
            this.linkUltimaPag.TabStop = true;
            this.linkUltimaPag.Text = "Ultima";
            this.linkUltimaPag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUltimaPag_LinkClicked_1);
            // 
            // labelNroPagina
            // 
            this.labelNroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPagina.Location = new System.Drawing.Point(643, 539);
            this.labelNroPagina.Name = "labelNroPagina";
            this.labelNroPagina.Size = new System.Drawing.Size(48, 20);
            this.labelNroPagina.TabIndex = 8;
            this.labelNroPagina.Text = "Nº";
            this.labelNroPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboRubros
            // 
            this.comboRubros.FormattingEnabled = true;
            this.comboRubros.Location = new System.Drawing.Point(75, 116);
            this.comboRubros.Name = "comboRubros";
            this.comboRubros.Size = new System.Drawing.Size(247, 21);
            this.comboRubros.TabIndex = 9;
            this.comboRubros.TextChanged += new System.EventHandler(this.comboRubros_SelectedIndexChanged);
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.labelBusqueda);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.labelTipo);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.comboTipo);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.buttonLimpiarBusqueda);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.buttonAgregarRubro);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.buttonBuscar);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.labelRubrosSeleccionados);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.label1);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.comboRubros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.textBuscado);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.Label_Buscador);
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(60, 5);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(765, 182);
            this.groupBoxFiltrosBusqueda.TabIndex = 10;
            this.groupBoxFiltrosBusqueda.TabStop = false;
            this.groupBoxFiltrosBusqueda.Text = "Filtros";
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.Location = new System.Drawing.Point(37, 16);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(67, 13);
            this.labelBusqueda.TabIndex = 17;
            this.labelBusqueda.Text = "BUSQUEDA";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(230, 34);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(32, 13);
            this.labelTipo.TabIndex = 16;
            this.labelTipo.Text = "TIPO";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "COMPRAS",
            "SUBASTAS"});
            this.comboTipo.Location = new System.Drawing.Point(277, 31);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(205, 21);
            this.comboTipo.TabIndex = 15;
            // 
            // buttonLimpiarBusqueda
            // 
            this.buttonLimpiarBusqueda.Location = new System.Drawing.Point(662, 119);
            this.buttonLimpiarBusqueda.Name = "buttonLimpiarBusqueda";
            this.buttonLimpiarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarBusqueda.TabIndex = 14;
            this.buttonLimpiarBusqueda.Text = "LIMPIAR";
            this.buttonLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.buttonLimpiarBusqueda.Click += new System.EventHandler(this.buttonLimpiarBusqueda_Click);
            // 
            // buttonAgregarRubro
            // 
            this.buttonAgregarRubro.Enabled = false;
            this.buttonAgregarRubro.Location = new System.Drawing.Point(344, 116);
            this.buttonAgregarRubro.Name = "buttonAgregarRubro";
            this.buttonAgregarRubro.Size = new System.Drawing.Size(112, 23);
            this.buttonAgregarRubro.TabIndex = 13;
            this.buttonAgregarRubro.Text = "AGREGAR RUBRO";
            this.buttonAgregarRubro.UseVisualStyleBackColor = true;
            this.buttonAgregarRubro.Click += new System.EventHandler(this.buttonAgregarRubro_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(662, 148);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelRubrosSeleccionados
            // 
            this.labelRubrosSeleccionados.Location = new System.Drawing.Point(54, 66);
            this.labelRubrosSeleccionados.Name = "labelRubrosSeleccionados";
            this.labelRubrosSeleccionados.Size = new System.Drawing.Size(683, 47);
            this.labelRubrosSeleccionados.TabIndex = 11;
            this.labelRubrosSeleccionados.Text = "Rubros Seleccionados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rubros";
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(722, 467);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 11;
            this.buttonComprar.Text = "COMPRAR";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonOfertar
            // 
            this.buttonOfertar.Location = new System.Drawing.Point(722, 467);
            this.buttonOfertar.Name = "buttonOfertar";
            this.buttonOfertar.Size = new System.Drawing.Size(75, 23);
            this.buttonOfertar.TabIndex = 12;
            this.buttonOfertar.Text = "OFERTAR";
            this.buttonOfertar.UseVisualStyleBackColor = true;
            this.buttonOfertar.Click += new System.EventHandler(this.buttonOfertar_Click);
            // 
            // Listado_ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 577);
            this.Controls.Add(this.buttonOfertar);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.Controls.Add(this.labelNroPagina);
            this.Controls.Add(this.linkPrimeraPag);
            this.Controls.Add(this.linkUltimaPag);
            this.Controls.Add(this.label_InfoPagina_CO);
            this.Controls.Add(this.label_Anterio_CO);
            this.Controls.Add(this.label_Siguiente_CO);
            this.Controls.Add(this.Grid_ComprarOfertar);
            this.Name = "Listado_ComprarOfertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadoEnvio";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ComprarOfertar)).EndInit();
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
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
        private System.Windows.Forms.LinkLabel linkUltimaPag;
        private System.Windows.Forms.Label labelNroPagina;
        private System.Windows.Forms.ComboBox comboRubros;
        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRubrosSeleccionados;
        private System.Windows.Forms.Button buttonLimpiarBusqueda;
        private System.Windows.Forms.Button buttonAgregarRubro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelBusqueda;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonOfertar;
    }
}