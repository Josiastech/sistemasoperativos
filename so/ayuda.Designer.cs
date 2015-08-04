namespace so
{
    partial class ayuda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltrabajo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::so.Properties.Resources.logoUMG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbltrabajo);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.lblu);
            this.panel1.Location = new System.Drawing.Point(184, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 257);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltrabajo
            // 
            this.lbltrabajo.AutoSize = true;
            this.lbltrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrabajo.Location = new System.Drawing.Point(30, 194);
            this.lbltrabajo.Name = "lbltrabajo";
            this.lbltrabajo.Size = new System.Drawing.Size(193, 20);
            this.lbltrabajo.TabIndex = 3;
            this.lbltrabajo.Text = "Simulador de Procesos";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(270, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 82);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Curso: Sistemas Operativos\r\nIng. Ricardo Beltran\r\n";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt1.HideSelection = false;
            this.txt1.Location = new System.Drawing.Point(34, 43);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(170, 102);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Estudiante:\r\nJosias Chocooj\r\nCarné: 0901-06-95\r\n\r\nFacultad de Ingenieria en Siste" +
    "mas";
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lblu
            // 
            this.lblu.AutoSize = true;
            this.lblu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblu.Location = new System.Drawing.Point(49, 20);
            this.lblu.Name = "lblu";
            this.lblu.Size = new System.Drawing.Size(440, 20);
            this.lblu.TabIndex = 0;
            this.lblu.Text = "UNIVERSIDAD MARIANO GALVÉZ DE GUATEMALA";
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ayuda";
            this.Text = "ayuda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltrabajo;
        private System.Windows.Forms.TextBox textBox1;

    }
}