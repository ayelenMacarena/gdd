namespace WindowsFormsApplication1.Facturas
{
    partial class consultaFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.calendarFrom = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.salesmanComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceToLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceFromLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFromLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelNroPagina = new System.Windows.Forms.Label();
            this.linkPrimeraPag = new System.Windows.Forms.LinkLabel();
            this.linkUltimaPag = new System.Windows.Forms.LinkLabel();
            this.label_InfoPagina_CO = new System.Windows.Forms.Label();
            this.label_Anterio_CO = new System.Windows.Forms.LinkLabel();
            this.label_Siguiente_CO = new System.Windows.Forms.LinkLabel();
            this.Grid_ListaFacturas = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.calendarFrom);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.salesmanComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.detailsLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceToLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceFromLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateToLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateFromLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de facturas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AllowDrop = true;
            this.monthCalendar1.Location = new System.Drawing.Point(190, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // calendarFrom
            // 
            this.calendarFrom.AllowDrop = true;
            this.calendarFrom.Location = new System.Drawing.Point(190, -11);
            this.calendarFrom.Name = "calendarFrom";
            this.calendarFrom.TabIndex = 13;
            this.calendarFrom.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.calendarFrom.Visible = false;
            this.calendarFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarFrom_DateChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(388, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesmanComboBox
            // 
            this.salesmanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salesmanComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.salesmanComboBox.FormattingEnabled = true;
            this.salesmanComboBox.Location = new System.Drawing.Point(126, 113);
            this.salesmanComboBox.Name = "salesmanComboBox";
            this.salesmanComboBox.Size = new System.Drawing.Size(227, 21);
            this.salesmanComboBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vendedor";
            // 
            // detailsLabel
            // 
            this.detailsLabel.Location = new System.Drawing.Point(126, 84);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(224, 20);
            this.detailsLabel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Detalle";
            // 
            // priceToLabel
            // 
            this.priceToLabel.Location = new System.Drawing.Point(250, 58);
            this.priceToLabel.Name = "priceToLabel";
            this.priceToLabel.Size = new System.Drawing.Size(100, 20);
            this.priceToLabel.TabIndex = 7;
            this.priceToLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "y";
            // 
            // priceFromLabel
            // 
            this.priceFromLabel.Location = new System.Drawing.Point(126, 58);
            this.priceFromLabel.Name = "priceFromLabel";
            this.priceFromLabel.Size = new System.Drawing.Size(100, 20);
            this.priceFromLabel.TabIndex = 5;
            this.priceFromLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            this.priceFromLabel.Validating += new System.ComponentModel.CancelEventHandler(this.priceFromLabel_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe entre ";
            // 
            // dateToLabel
            // 
            this.dateToLabel.CausesValidation = false;
            this.dateToLabel.Location = new System.Drawing.Point(250, 32);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.ReadOnly = true;
            this.dateToLabel.Size = new System.Drawing.Size(100, 20);
            this.dateToLabel.TabIndex = 3;
            this.dateToLabel.Click += new System.EventHandler(this.dateToLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.CausesValidation = false;
            this.dateFromLabel.Location = new System.Drawing.Point(126, 32);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.ReadOnly = true;
            this.dateFromLabel.Size = new System.Drawing.Size(100, 20);
            this.dateFromLabel.TabIndex = 1;
            this.dateFromLabel.Click += new System.EventHandler(this.dateFromLabel_Click);
            this.dateFromLabel.Validating += new System.ComponentModel.CancelEventHandler(this.dateFromLabel_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha entre ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelNroPagina
            // 
            this.labelNroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPagina.Location = new System.Drawing.Point(303, 384);
            this.labelNroPagina.Name = "labelNroPagina";
            this.labelNroPagina.Size = new System.Drawing.Size(48, 26);
            this.labelNroPagina.TabIndex = 24;
            this.labelNroPagina.Text = "Nº";
            this.labelNroPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkPrimeraPag
            // 
            this.linkPrimeraPag.AutoSize = true;
            this.linkPrimeraPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrimeraPag.Location = new System.Drawing.Point(156, 448);
            this.linkPrimeraPag.Name = "linkPrimeraPag";
            this.linkPrimeraPag.Size = new System.Drawing.Size(57, 17);
            this.linkPrimeraPag.TabIndex = 23;
            this.linkPrimeraPag.TabStop = true;
            this.linkPrimeraPag.Text = "Primera";
            this.linkPrimeraPag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrimeraPag_LinkClicked);
            // 
            // linkUltimaPag
            // 
            this.linkUltimaPag.AutoSize = true;
            this.linkUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUltimaPag.Location = new System.Drawing.Point(445, 448);
            this.linkUltimaPag.Name = "linkUltimaPag";
            this.linkUltimaPag.Size = new System.Drawing.Size(47, 17);
            this.linkUltimaPag.TabIndex = 22;
            this.linkUltimaPag.TabStop = true;
            this.linkUltimaPag.Text = "Ultima";
            this.linkUltimaPag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUltimaPag_LinkClicked);
            // 
            // label_InfoPagina_CO
            // 
            this.label_InfoPagina_CO.AutoSize = true;
            this.label_InfoPagina_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoPagina_CO.Location = new System.Drawing.Point(43, 448);
            this.label_InfoPagina_CO.Name = "label_InfoPagina_CO";
            this.label_InfoPagina_CO.Size = new System.Drawing.Size(66, 20);
            this.label_InfoPagina_CO.TabIndex = 21;
            this.label_InfoPagina_CO.Text = "Paginas";
            // 
            // label_Anterio_CO
            // 
            this.label_Anterio_CO.AutoSize = true;
            this.label_Anterio_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Anterio_CO.Location = new System.Drawing.Point(220, 448);
            this.label_Anterio_CO.Name = "label_Anterio_CO";
            this.label_Anterio_CO.Size = new System.Drawing.Size(58, 17);
            this.label_Anterio_CO.TabIndex = 20;
            this.label_Anterio_CO.TabStop = true;
            this.label_Anterio_CO.Text = "Anterior";
            this.label_Anterio_CO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Anterio_CO_LinkClicked);
            // 
            // label_Siguiente_CO
            // 
            this.label_Siguiente_CO.AutoSize = true;
            this.label_Siguiente_CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Siguiente_CO.Location = new System.Drawing.Point(372, 448);
            this.label_Siguiente_CO.Name = "label_Siguiente_CO";
            this.label_Siguiente_CO.Size = new System.Drawing.Size(67, 17);
            this.label_Siguiente_CO.TabIndex = 19;
            this.label_Siguiente_CO.TabStop = true;
            this.label_Siguiente_CO.Text = "Siguiente";
            this.label_Siguiente_CO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Siguiente_CO_LinkClicked);
            // 
            // Grid_ListaFacturas
            // 
            this.Grid_ListaFacturas.AllowUserToAddRows = false;
            this.Grid_ListaFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Grid_ListaFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_ListaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_ListaFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid_ListaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ListaFacturas.Location = new System.Drawing.Point(34, 161);
            this.Grid_ListaFacturas.MultiSelect = false;
            this.Grid_ListaFacturas.Name = "Grid_ListaFacturas";
            this.Grid_ListaFacturas.ReadOnly = true;
            this.Grid_ListaFacturas.RowHeadersVisible = false;
            this.Grid_ListaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ListaFacturas.Size = new System.Drawing.Size(488, 278);
            this.Grid_ListaFacturas.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(528, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Ampliar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // consultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 482);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Grid_ListaFacturas);
            this.Controls.Add(this.labelNroPagina);
            this.Controls.Add(this.linkPrimeraPag);
            this.Controls.Add(this.linkUltimaPag);
            this.Controls.Add(this.label_InfoPagina_CO);
            this.Controls.Add(this.label_Anterio_CO);
            this.Controls.Add(this.label_Siguiente_CO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "consultaFacturas";
            this.Text = "Consulta facturas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceToLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceFromLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateToLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox detailsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox salesmanComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MonthCalendar calendarFrom;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox dateFromLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelNroPagina;
        private System.Windows.Forms.LinkLabel linkPrimeraPag;
        private System.Windows.Forms.LinkLabel linkUltimaPag;
        private System.Windows.Forms.Label label_InfoPagina_CO;
        private System.Windows.Forms.LinkLabel label_Anterio_CO;
        private System.Windows.Forms.LinkLabel label_Siguiente_CO;
        private System.Windows.Forms.DataGridView Grid_ListaFacturas;
        private System.Windows.Forms.Button button4;
    }
}