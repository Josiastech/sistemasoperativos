namespace so
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblquantum = new System.Windows.Forms.Label();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.txtquantum = new System.Windows.Forms.TextBox();
            this.ck_estado = new System.Windows.Forms.CheckBox();
            this.trakbarra = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblrequeridocpu = new System.Windows.Forms.Label();
            this.lblproceso = new System.Windows.Forms.Label();
            this.txtrequerimiento = new System.Windows.Forms.TextBox();
            this.txtproceso = new System.Windows.Forms.TextBox();
            this.tblprocesos = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbletiqueta = new System.Windows.Forms.Label();
            this.tblprocesamiento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proceasrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trakbarra)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblprocesos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblprocesamiento)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblquantum);
            this.panel1.Controls.Add(this.btnprocesar);
            this.panel1.Controls.Add(this.txtquantum);
            this.panel1.Controls.Add(this.ck_estado);
            this.panel1.Controls.Add(this.trakbarra);
            this.panel1.Location = new System.Drawing.Point(825, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblquantum
            // 
            this.lblquantum.AutoSize = true;
            this.lblquantum.Location = new System.Drawing.Point(39, 6);
            this.lblquantum.Name = "lblquantum";
            this.lblquantum.Size = new System.Drawing.Size(50, 13);
            this.lblquantum.TabIndex = 5;
            this.lblquantum.Text = "Quantum";
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(246, 6);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(97, 55);
            this.btnprocesar.TabIndex = 4;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // txtquantum
            // 
            this.txtquantum.Location = new System.Drawing.Point(109, 2);
            this.txtquantum.Name = "txtquantum";
            this.txtquantum.Size = new System.Drawing.Size(66, 20);
            this.txtquantum.TabIndex = 3;
            this.txtquantum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ck_estado
            // 
            this.ck_estado.AutoSize = true;
            this.ck_estado.Location = new System.Drawing.Point(184, 5);
            this.ck_estado.Name = "ck_estado";
            this.ck_estado.Size = new System.Drawing.Size(52, 17);
            this.ck_estado.TabIndex = 2;
            this.ck_estado.Text = "editar";
            this.ck_estado.UseVisualStyleBackColor = true;
            this.ck_estado.CheckedChanged += new System.EventHandler(this.ck_estado_CheckedChanged);
            // 
            // trakbarra
            // 
            this.trakbarra.Location = new System.Drawing.Point(6, 29);
            this.trakbarra.Name = "trakbarra";
            this.trakbarra.Size = new System.Drawing.Size(230, 45);
            this.trakbarra.TabIndex = 1;
            this.trakbarra.Scroll += new System.EventHandler(this.trakbarra_Scroll);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.lblrequeridocpu);
            this.panel2.Controls.Add(this.lblproceso);
            this.panel2.Controls.Add(this.txtrequerimiento);
            this.panel2.Controls.Add(this.txtproceso);
            this.panel2.Controls.Add(this.tblprocesos);
            this.panel2.Location = new System.Drawing.Point(825, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 505);
            this.panel2.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(242, 9);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(101, 50);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblrequeridocpu
            // 
            this.lblrequeridocpu.AutoSize = true;
            this.lblrequeridocpu.Location = new System.Drawing.Point(3, 31);
            this.lblrequeridocpu.Name = "lblrequeridocpu";
            this.lblrequeridocpu.Size = new System.Drawing.Size(100, 13);
            this.lblrequeridocpu.TabIndex = 4;
            this.lblrequeridocpu.Text = "Requerimiento CPU";
            // 
            // lblproceso
            // 
            this.lblproceso.AutoSize = true;
            this.lblproceso.Location = new System.Drawing.Point(3, 9);
            this.lblproceso.Name = "lblproceso";
            this.lblproceso.Size = new System.Drawing.Size(46, 13);
            this.lblproceso.TabIndex = 3;
            this.lblproceso.Text = "Proceso";
            // 
            // txtrequerimiento
            // 
            this.txtrequerimiento.Location = new System.Drawing.Point(109, 28);
            this.txtrequerimiento.Name = "txtrequerimiento";
            this.txtrequerimiento.Size = new System.Drawing.Size(99, 20);
            this.txtrequerimiento.TabIndex = 2;
            // 
            // txtproceso
            // 
            this.txtproceso.Location = new System.Drawing.Point(55, 6);
            this.txtproceso.Name = "txtproceso";
            this.txtproceso.Size = new System.Drawing.Size(135, 20);
            this.txtproceso.TabIndex = 1;
            // 
            // tblprocesos
            // 
            this.tblprocesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblprocesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12});
            this.tblprocesos.Location = new System.Drawing.Point(3, 65);
            this.tblprocesos.Name = "tblprocesos";
            this.tblprocesos.Size = new System.Drawing.Size(340, 435);
            this.tblprocesos.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Proceso";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Requerimiento CPU";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Color";
            this.Column12.Name = "Column12";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbletiqueta);
            this.panel3.Controls.Add(this.tblprocesamiento);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 580);
            this.panel3.TabIndex = 2;
            // 
            // lbletiqueta
            // 
            this.lbletiqueta.AutoSize = true;
            this.lbletiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiqueta.Location = new System.Drawing.Point(115, 7);
            this.lbletiqueta.Name = "lbletiqueta";
            this.lbletiqueta.Size = new System.Drawing.Size(494, 25);
            this.lbletiqueta.TabIndex = 1;
            this.lbletiqueta.Text = "Simulador de Procesos - Sistemas Operativos";
            this.lbletiqueta.Click += new System.EventHandler(this.lbletiqueta_Click);
            // 
            // tblprocesamiento
            // 
            this.tblprocesamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblprocesamiento.ColumnHeadersVisible = false;
            this.tblprocesamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column13,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblprocesamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblprocesamiento.Location = new System.Drawing.Point(3, 35);
            this.tblprocesamiento.Name = "tblprocesamiento";
            this.tblprocesamiento.RowHeadersVisible = false;
            this.tblprocesamiento.Size = new System.Drawing.Size(799, 540);
            this.tblprocesamiento.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proceasrToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proceasrToolStripMenuItem
            // 
            this.proceasrToolStripMenuItem.Name = "proceasrToolStripMenuItem";
            this.proceasrToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.proceasrToolStripMenuItem.Text = "Procesar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 627);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Planificacion Round Robin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trakbarra)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblprocesos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblprocesamiento)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtquantum;
        private System.Windows.Forms.CheckBox ck_estado;
        private System.Windows.Forms.TrackBar trakbarra;
        private System.Windows.Forms.DataGridView tblprocesos;
        private System.Windows.Forms.DataGridView tblprocesamiento;
        private System.Windows.Forms.Label lblrequeridocpu;
        private System.Windows.Forms.Label lblproceso;
        private System.Windows.Forms.TextBox txtrequerimiento;
        private System.Windows.Forms.TextBox txtproceso;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proceasrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label lbletiqueta;
        private System.Windows.Forms.Label lblquantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

