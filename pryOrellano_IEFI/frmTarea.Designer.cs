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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.cbRecibo = new System.Windows.Forms.CheckBox();
            this.cbSalario = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEnfermedad = new System.Windows.Forms.CheckBox();
            this.cbVacaciones = new System.Windows.Forms.CheckBox();
            this.cbEstudio = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInsumo = new System.Windows.Forms.CheckBox();
            this.gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.grpDetalle.SuspendLayout();
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
            this.lblAgregarLugar.Click += new System.EventHandler(this.lblAgregarLugar_Click);
            // 
            // lblAgregarTarea
            // 
            this.lblAgregarTarea.AutoSize = true;
            this.lblAgregarTarea.Location = new System.Drawing.Point(450, 143);
            this.lblAgregarTarea.Name = "lblAgregarTarea";
            this.lblAgregarTarea.Size = new System.Drawing.Size(172, 16);
            this.lblAgregarTarea.TabIndex = 28;
            this.lblAgregarTarea.Text = "¿Desea agregar una tarea?";
            this.lblAgregarTarea.Click += new System.EventHandler(this.lblAgregarTarea_Click);
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
            this.dgvMostrar.Size = new System.Drawing.Size(842, 127);
            this.dgvMostrar.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(374, 593);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(136, 51);
            this.btnGrabar.TabIndex = 17;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 661);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(481, 389);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(76, 16);
            this.lblComentario.TabIndex = 16;
            this.lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(484, 413);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComentario.Size = new System.Drawing.Size(397, 154);
            this.txtComentario.TabIndex = 14;
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.cbRecibo);
            this.grpDetalle.Controls.Add(this.cbSalario);
            this.grpDetalle.Controls.Add(this.label3);
            this.grpDetalle.Controls.Add(this.cbEnfermedad);
            this.grpDetalle.Controls.Add(this.cbVacaciones);
            this.grpDetalle.Controls.Add(this.cbEstudio);
            this.grpDetalle.Controls.Add(this.label2);
            this.grpDetalle.Controls.Add(this.label1);
            this.grpDetalle.Controls.Add(this.cbInsumo);
            this.grpDetalle.Location = new System.Drawing.Point(39, 389);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDetalle.Size = new System.Drawing.Size(422, 178);
            this.grpDetalle.TabIndex = 13;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle";
            // 
            // cbRecibo
            // 
            this.cbRecibo.AutoSize = true;
            this.cbRecibo.Location = new System.Drawing.Point(312, 110);
            this.cbRecibo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRecibo.Name = "cbRecibo";
            this.cbRecibo.Size = new System.Drawing.Size(73, 20);
            this.cbRecibo.TabIndex = 14;
            this.cbRecibo.Text = "Recibo";
            this.cbRecibo.UseVisualStyleBackColor = true;
            // 
            // cbSalario
            // 
            this.cbSalario.AutoSize = true;
            this.cbSalario.Location = new System.Drawing.Point(312, 70);
            this.cbSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalario.Name = "cbSalario";
            this.cbSalario.Size = new System.Drawing.Size(72, 20);
            this.cbSalario.TabIndex = 17;
            this.cbSalario.Text = "Salario";
            this.cbSalario.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Reclamo";
            // 
            // cbEnfermedad
            // 
            this.cbEnfermedad.AutoSize = true;
            this.cbEnfermedad.Location = new System.Drawing.Point(168, 150);
            this.cbEnfermedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnfermedad.Name = "cbEnfermedad";
            this.cbEnfermedad.Size = new System.Drawing.Size(103, 20);
            this.cbEnfermedad.TabIndex = 15;
            this.cbEnfermedad.Text = "Enfermedad";
            this.cbEnfermedad.UseVisualStyleBackColor = true;
            // 
            // cbVacaciones
            // 
            this.cbVacaciones.AutoSize = true;
            this.cbVacaciones.Location = new System.Drawing.Point(168, 110);
            this.cbVacaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVacaciones.Name = "cbVacaciones";
            this.cbVacaciones.Size = new System.Drawing.Size(101, 20);
            this.cbVacaciones.TabIndex = 14;
            this.cbVacaciones.Text = "Vacaciones";
            this.cbVacaciones.UseVisualStyleBackColor = true;
            // 
            // cbEstudio
            // 
            this.cbEstudio.AutoSize = true;
            this.cbEstudio.Location = new System.Drawing.Point(168, 70);
            this.cbEstudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstudio.Name = "cbEstudio";
            this.cbEstudio.Size = new System.Drawing.Size(74, 20);
            this.cbEstudio.TabIndex = 13;
            this.cbEstudio.Text = "Estudio";
            this.cbEstudio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Licencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Falta de uniforme";
            // 
            // cbInsumo
            // 
            this.cbInsumo.AutoSize = true;
            this.cbInsumo.Location = new System.Drawing.Point(18, 70);
            this.cbInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInsumo.Name = "cbInsumo";
            this.cbInsumo.Size = new System.Drawing.Size(72, 20);
            this.cbInsumo.TabIndex = 6;
            this.cbInsumo.Text = "Insumo";
            this.cbInsumo.UseVisualStyleBackColor = true;
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 744);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.gbAgregar);
            this.Name = "frmTarea";
            this.Text = "Tarea";
            this.Load += new System.EventHandler(this.frmTarea_Load);
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.CheckBox cbRecibo;
        private System.Windows.Forms.CheckBox cbSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEnfermedad;
        private System.Windows.Forms.CheckBox cbVacaciones;
        private System.Windows.Forms.CheckBox cbEstudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbInsumo;
    }
}