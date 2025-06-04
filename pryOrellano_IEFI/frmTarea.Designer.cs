namespace pryOrellano_IEFI
{
    partial class frmTarea
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
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.lblAgregarLugar = new System.Windows.Forms.Label();
            this.lblAgregarTarea = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.nmCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoUser = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.lblAgregarLugar);
            this.gbAgregar.Controls.Add(this.lblAgregarTarea);
            this.gbAgregar.Controls.Add(this.txtUsuario);
            this.gbAgregar.Controls.Add(this.nmCodigo);
            this.gbAgregar.Controls.Add(this.lblNombre);
            this.gbAgregar.Controls.Add(this.lblCodigoUser);
            this.gbAgregar.Controls.Add(this.lblLugar);
            this.gbAgregar.Controls.Add(this.lblTarea);
            this.gbAgregar.Controls.Add(this.lblFecha);
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Controls.Add(this.cmbLugar);
            this.gbAgregar.Controls.Add(this.dtFecha);
            this.gbAgregar.Controls.Add(this.cmbTarea);
            this.gbAgregar.Location = new System.Drawing.Point(40, 29);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(842, 185);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar Tarea";
            // 
            // lblAgregarLugar
            // 
            this.lblAgregarLugar.AutoSize = true;
            this.lblAgregarLugar.Location = new System.Drawing.Point(450, 74);
            this.lblAgregarLugar.Name = "lblAgregarLugar";
            this.lblAgregarLugar.Size = new System.Drawing.Size(163, 16);
            this.lblAgregarLugar.TabIndex = 29;
            this.lblAgregarLugar.Text = "¿Desea agregar un lugar?";
            // 
            // lblAgregarTarea
            // 
            this.lblAgregarTarea.AutoSize = true;
            this.lblAgregarTarea.Location = new System.Drawing.Point(450, 143);
            this.lblAgregarTarea.Name = "lblAgregarTarea";
            this.lblAgregarTarea.Size = new System.Drawing.Size(172, 16);
            this.lblAgregarTarea.TabIndex = 28;
            this.lblAgregarTarea.Text = "¿Desea agregar una tarea?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(150, 94);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(117, 22);
            this.txtUsuario.TabIndex = 27;
            // 
            // nmCodigo
            // 
            this.nmCodigo.Location = new System.Drawing.Point(150, 43);
            this.nmCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmCodigo.Name = "nmCodigo";
            this.nmCodigo.Size = new System.Drawing.Size(107, 22);
            this.nmCodigo.TabIndex = 26;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 16);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre de Usuario:";
            // 
            // lblCodigoUser
            // 
            this.lblCodigoUser.AutoSize = true;
            this.lblCodigoUser.Location = new System.Drawing.Point(14, 48);
            this.lblCodigoUser.Name = "lblCodigoUser";
            this.lblCodigoUser.Size = new System.Drawing.Size(123, 16);
            this.lblCodigoUser.TabIndex = 24;
            this.lblCodigoUser.Text = "Código de Usuario:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(377, 48);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 16);
            this.lblLugar.TabIndex = 23;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(377, 118);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(47, 16);
            this.lblTarea.TabIndex = 22;
            this.lblTarea.Text = "Tarea:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(14, 143);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(680, 64);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 49);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(444, 42);
            this.cmbLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(178, 24);
            this.cmbLugar.TabIndex = 21;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(150, 143);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(178, 22);
            this.dtFecha.TabIndex = 18;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(444, 115);
            this.cmbTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(178, 24);
            this.cmbTarea.TabIndex = 19;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(39, 235);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(842, 162);
            this.dgvMostrar.TabIndex = 1;
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 537);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.gbAgregar);
            this.Name = "frmTarea";
            this.Text = "Tarea";
            this.Load += new System.EventHandler(this.frmTarea_Load);
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Label lblAgregarLugar;
        private System.Windows.Forms.Label lblAgregarTarea;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.NumericUpDown nmCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoUser;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.DataGridView dgvMostrar;
    }
}