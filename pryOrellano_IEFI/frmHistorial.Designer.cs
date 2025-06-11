namespace pryOrellano_IEFI
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.grpTarea = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.grpTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Enabled = false;
            this.dgvTareas.Location = new System.Drawing.Point(31, 249);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.ShowCellErrors = false;
            this.dgvTareas.ShowCellToolTips = false;
            this.dgvTareas.ShowEditingIcon = false;
            this.dgvTareas.ShowRowErrors = false;
            this.dgvTareas.Size = new System.Drawing.Size(916, 253);
            this.dgvTareas.TabIndex = 16;
            // 
            // grpTarea
            // 
            this.grpTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpTarea.BackgroundImage")));
            this.grpTarea.Controls.Add(this.lblLugar);
            this.grpTarea.Controls.Add(this.lblTarea);
            this.grpTarea.Controls.Add(this.lblFecha);
            this.grpTarea.Controls.Add(this.btnBuscar);
            this.grpTarea.Controls.Add(this.cmbLugar);
            this.grpTarea.Controls.Add(this.dtFecha);
            this.grpTarea.Controls.Add(this.cmbTarea);
            this.grpTarea.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTarea.ForeColor = System.Drawing.Color.White;
            this.grpTarea.Location = new System.Drawing.Point(31, 50);
            this.grpTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTarea.Name = "grpTarea";
            this.grpTarea.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTarea.Size = new System.Drawing.Size(932, 91);
            this.grpTarea.TabIndex = 17;
            this.grpTarea.TabStop = false;
            this.grpTarea.Text = "Búsqueda en el historial";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Location = new System.Drawing.Point(281, 38);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 19);
            this.lblLugar.TabIndex = 10;
            this.lblLugar.Text = "Lugar";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblTarea.Location = new System.Drawing.Point(555, 38);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(44, 19);
            this.lblTarea.TabIndex = 9;
            this.lblTarea.Text = "Tarea";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(13, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(830, 34);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(341, 36);
            this.cmbLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(178, 27);
            this.cmbLugar.TabIndex = 4;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(77, 34);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.ShowCheckBox = true;
            this.dtFecha.Size = new System.Drawing.Size(178, 26);
            this.dtFecha.TabIndex = 1;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(620, 36);
            this.cmbTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(178, 27);
            this.cmbTarea.TabIndex = 2;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(992, 535);
            this.Controls.Add(this.grpTarea);
            this.Controls.Add(this.dgvTareas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.grpTarea.ResumeLayout(false);
            this.grpTarea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.GroupBox grpTarea;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbTarea;
    }
}