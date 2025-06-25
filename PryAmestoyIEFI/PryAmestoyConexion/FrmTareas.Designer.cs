namespace PryAmestoyConexion
{
    partial class FrmTareas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
            this.lblTarea = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.pictureMax = new System.Windows.Forms.PictureBox();
            this.pictureRes = new System.Windows.Forms.PictureBox();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.cmbLugares = new System.Windows.Forms.ComboBox();
            this.cmbTareas = new System.Windows.Forms.ComboBox();
            this.panelTareas = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupDetalle = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.panelTareas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.ForeColor = System.Drawing.Color.White;
            this.lblTarea.Location = new System.Drawing.Point(165, 104);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(64, 18);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tareas :";
            // 
            // dgvTareas
            // 
            this.dgvTareas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTareas.ColumnHeadersHeight = 25;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tarea,
            this.Lugar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTareas.EnableHeadersVisualStyles = false;
            this.dgvTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.dgvTareas.Location = new System.Drawing.Point(26, 22);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTareas.Size = new System.Drawing.Size(342, 233);
            this.dgvTareas.TabIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Tarea
            // 
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.Name = "Tarea";
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.paneltop.Controls.Add(this.pictureMin);
            this.paneltop.Controls.Add(this.pictureMax);
            this.paneltop.Controls.Add(this.pictureRes);
            this.paneltop.Controls.Add(this.pictureExit);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(956, 35);
            this.paneltop.TabIndex = 2;
            // 
            // pictureMin
            // 
            this.pictureMin.Image = ((System.Drawing.Image)(resources.GetObject("pictureMin.Image")));
            this.pictureMin.Location = new System.Drawing.Point(871, 7);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(24, 24);
            this.pictureMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMin.TabIndex = 11;
            this.pictureMin.TabStop = false;
            this.pictureMin.Click += new System.EventHandler(this.pictureMin_Click);
            // 
            // pictureMax
            // 
            this.pictureMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureMax.Image")));
            this.pictureMax.Location = new System.Drawing.Point(901, 8);
            this.pictureMax.Name = "pictureMax";
            this.pictureMax.Size = new System.Drawing.Size(24, 24);
            this.pictureMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMax.TabIndex = 10;
            this.pictureMax.TabStop = false;
            this.pictureMax.Click += new System.EventHandler(this.pictureMax_Click);
            // 
            // pictureRes
            // 
            this.pictureRes.Image = ((System.Drawing.Image)(resources.GetObject("pictureRes.Image")));
            this.pictureRes.Location = new System.Drawing.Point(901, 8);
            this.pictureRes.Name = "pictureRes";
            this.pictureRes.Size = new System.Drawing.Size(24, 24);
            this.pictureRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRes.TabIndex = 9;
            this.pictureRes.TabStop = false;
            this.pictureRes.Click += new System.EventHandler(this.pictureRes_Click);
            // 
            // pictureExit
            // 
            this.pictureExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureExit.Image")));
            this.pictureExit.Location = new System.Drawing.Point(929, 8);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(24, 24);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 8;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.ForeColor = System.Drawing.Color.White;
            this.lblLugar.Location = new System.Drawing.Point(165, 61);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(56, 18);
            this.lblLugar.TabIndex = 3;
            this.lblLugar.Text = "Lugar :";
            // 
            // cmbLugares
            // 
            this.cmbLugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugares.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLugares.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugares.FormattingEnabled = true;
            this.cmbLugares.Location = new System.Drawing.Point(227, 61);
            this.cmbLugares.Name = "cmbLugares";
            this.cmbLugares.Size = new System.Drawing.Size(531, 25);
            this.cmbLugares.TabIndex = 4;
            // 
            // cmbTareas
            // 
            this.cmbTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTareas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTareas.FormattingEnabled = true;
            this.cmbTareas.Location = new System.Drawing.Point(227, 104);
            this.cmbTareas.Name = "cmbTareas";
            this.cmbTareas.Size = new System.Drawing.Size(531, 25);
            this.cmbTareas.TabIndex = 5;
            // 
            // panelTareas
            // 
            this.panelTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
            this.panelTareas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTareas.Controls.Add(this.cmbTareas);
            this.panelTareas.Controls.Add(this.btnAgregar);
            this.panelTareas.Controls.Add(this.label1);
            this.panelTareas.Controls.Add(this.cmbLugares);
            this.panelTareas.Controls.Add(this.lblTarea);
            this.panelTareas.Controls.Add(this.lblLugar);
            this.panelTareas.Location = new System.Drawing.Point(0, 37);
            this.panelTareas.Name = "panelTareas";
            this.panelTareas.Size = new System.Drawing.Size(956, 201);
            this.panelTareas.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btnAgregar.Location = new System.Drawing.Point(371, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "REGISTRO DE TAREAS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(19, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reclamos :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.button2.Location = new System.Drawing.Point(24, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "RECIBO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.button1.Location = new System.Drawing.Point(24, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "SALARIO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(365, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 205);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uniforme :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.button4.Location = new System.Drawing.Point(25, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "INCOMPLETO";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.button6.Location = new System.Drawing.Point(25, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 35);
            this.button6.TabIndex = 14;
            this.button6.Text = "INSUMOS";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // groupDetalle
            // 
            this.groupDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(13)))));
            this.groupDetalle.Controls.Add(this.groupBox3);
            this.groupDetalle.Controls.Add(this.groupBox2);
            this.groupDetalle.Controls.Add(this.groupBox1);
            this.groupDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDetalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupDetalle.Location = new System.Drawing.Point(407, 244);
            this.groupDetalle.Name = "groupDetalle";
            this.groupDetalle.Size = new System.Drawing.Size(527, 255);
            this.groupDetalle.TabIndex = 7;
            this.groupDetalle.TabStop = false;
            this.groupDetalle.Text = "Detalle";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(190, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 205);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Licencia :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.button5.Location = new System.Drawing.Point(30, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "VOCACIONES";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.button3.Location = new System.Drawing.Point(30, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "ENFERMEDAD";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvTareas);
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 271);
            this.panel1.TabIndex = 8;
            // 
            // FrmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(956, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupDetalle);
            this.Controls.Add(this.panelTareas);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTareas";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "FrmTareas";
            this.Load += new System.EventHandler(this.FrmTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.panelTareas.ResumeLayout(false);
            this.panelTareas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupDetalle.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ComboBox cmbLugares;
        private System.Windows.Forms.ComboBox cmbTareas;
        private System.Windows.Forms.Panel panelTareas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureMin;
        private System.Windows.Forms.PictureBox pictureMax;
        private System.Windows.Forms.PictureBox pictureRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupDetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}