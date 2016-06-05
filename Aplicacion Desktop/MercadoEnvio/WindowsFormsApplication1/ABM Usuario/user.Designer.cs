namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class user
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
            this.label2 = new System.Windows.Forms.Label();
            this.ingresoUser = new System.Windows.Forms.TextBox();
            this.ingresoPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // ingresoUser
            // 
            this.ingresoUser.Location = new System.Drawing.Point(94, 58);
            this.ingresoUser.Name = "ingresoUser";
            this.ingresoUser.Size = new System.Drawing.Size(100, 20);
            this.ingresoUser.TabIndex = 4;
<<<<<<< HEAD
            this.ingresoUser.Enter += new System.EventHandler(this.textBox2_TextChanged);
=======
           // this.ingresoUser.TextChanged += new System.EventHandler(this.ingresoUser_TextChanged);
           // this.ingresoUser.Enter += new System.EventHandler(this.textBox2_TextChanged);
>>>>>>> 8c24939e1973f2060c7c5a05afc444c313f5404f
            // 
            // ingresoPass
            // 
            this.ingresoPass.Location = new System.Drawing.Point(94, 96);
            this.ingresoPass.Multiline = true;
            this.ingresoPass.Name = "ingresoPass";
            this.ingresoPass.PasswordChar = '*';
            this.ingresoPass.Size = new System.Drawing.Size(100, 20);
            this.ingresoPass.TabIndex = 5;
            this.ingresoPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(4, 239);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(46, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "< Volver";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ingresoPass);
            this.Controls.Add(this.ingresoUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "user";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ingresoUser;
        private System.Windows.Forms.TextBox ingresoPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}