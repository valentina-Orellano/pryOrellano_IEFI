namespace pryOrellano_IEFI
{
    partial class frmAdministracionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracionUsuario));
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.lblUltima = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTiempoUlt = new System.Windows.Forms.Label();
            this.dtFechaC = new System.Windows.Forms.DateTimePicker();
            this.dtUltimaC = new System.Windows.Forms.DateTimePicker();
            this.mskTiempoU = new System.Windows.Forms.MaskedTextBox();
            this.mskTiempoTotal = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.gbUsuario.SuspendLayout();
            this.gbTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbUsuario.Controls.Add(this.cmbEstado);
            this.gbUsuario.Controls.Add(this.lblEstado);
            this.gbUsuario.Controls.Add(this.cmbRol);
            this.gbUsuario.Controls.Add(this.txtContraseña);
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.Controls.Add(this.lblRol);
            this.gbUsuario.Controls.Add(this.lblContraseña);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbUsuario.Location = new System.Drawing.Point(64, 399);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(250, 277);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            // 
            // gbTiempo
            // 
            this.gbTiempo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbTiempo.Controls.Add(this.mskTiempoTotal);
            this.gbTiempo.Controls.Add(this.mskTiempoU);
            this.gbTiempo.Controls.Add(this.dtUltimaC);
            this.gbTiempo.Controls.Add(this.dtFechaC);
            this.gbTiempo.Controls.Add(this.lblTiempoUlt);
            this.gbTiempo.Controls.Add(this.lblTotal);
            this.gbTiempo.Controls.Add(this.lblUltima);
            this.gbTiempo.Controls.Add(this.lblCreacion);
            this.gbTiempo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiempo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTiempo.Location = new System.Drawing.Point(370, 399);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(531, 277);
            this.gbTiempo.TabIndex = 1;
            this.gbTiempo.TabStop = false;
            this.gbTiempo.Text = "Tiempo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(16, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(17, 112);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(87, 24);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(17, 171);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 24);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(110, 49);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(115, 32);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(110, 104);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(115, 32);
            this.txtContraseña.TabIndex = 4;
            // 
            // cmbRol
            // 
            this.cmbRol.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cmbRol.Location = new System.Drawing.Point(110, 163);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 32);
            this.cmbRol.TabIndex = 5;
            // 
            // lblCreacion
            // 
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Location = new System.Drawing.Point(29, 59);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(134, 24);
            this.lblCreacion.TabIndex = 1;
            this.lblCreacion.Text = "Fecha de creación:";
            // 
            // lblUltima
            // 
            this.lblUltima.AutoSize = true;
            this.lblUltima.Location = new System.Drawing.Point(29, 114);
            this.lblUltima.Name = "lblUltima";
            this.lblUltima.Size = new System.Drawing.Size(120, 24);
            this.lblUltima.TabIndex = 2;
            this.lblUltima.Text = "Última conexión:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 218);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Tiempo total:";
            // 
            // lblTiempoUlt
            // 
            this.lblTiempoUlt.AutoSize = true;
            this.lblTiempoUlt.Location = new System.Drawing.Point(29, 171);
            this.lblTiempoUlt.Name = "lblTiempoUlt";
            this.lblTiempoUlt.Size = new System.Drawing.Size(172, 24);
            this.lblTiempoUlt.TabIndex = 4;
            this.lblTiempoUlt.Text = "Tiempo última conexión:";
            // 
            // dtFechaC
            // 
            this.dtFechaC.Location = new System.Drawing.Point(198, 51);
            this.dtFechaC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaC.Name = "dtFechaC";
            this.dtFechaC.Size = new System.Drawing.Size(303, 32);
            this.dtFechaC.TabIndex = 19;
            // 
            // dtUltimaC
            // 
            this.dtUltimaC.Location = new System.Drawing.Point(198, 106);
            this.dtUltimaC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtUltimaC.Name = "dtUltimaC";
            this.dtUltimaC.Size = new System.Drawing.Size(303, 32);
            this.dtUltimaC.TabIndex = 20;
            // 
            // mskTiempoU
            // 
            this.mskTiempoU.Location = new System.Drawing.Point(223, 163);
            this.mskTiempoU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTiempoU.Mask = "90:00:00";
            this.mskTiempoU.Name = "mskTiempoU";
            this.mskTiempoU.Size = new System.Drawing.Size(75, 32);
            this.mskTiempoU.TabIndex = 21;
            this.mskTiempoU.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mskTiempoTotal
            // 
            this.mskTiempoTotal.Location = new System.Drawing.Point(223, 210);
            this.mskTiempoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTiempoTotal.Mask = "90:00:00";
            this.mskTiempoTotal.Name = "mskTiempoTotal";
            this.mskTiempoTotal.Size = new System.Drawing.Size(75, 32);
            this.mskTiempoTotal.TabIndex = 22;
            this.mskTiempoTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(113, 352);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(418, 352);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(738, 352);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 41);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(64, 40);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(837, 289);
            this.dgvMostrar.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(17, 218);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 24);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cmbEstado.Location = new System.Drawing.Point(110, 210);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 32);
            this.cmbEstado.TabIndex = 7;
            // 
            // frmAdministracionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 719);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.gbUsuario);
            this.Name = "frmAdministracionUsuario";
            this.Text = "Administracion Usuario";
            this.Load += new System.EventHandler(this.frmAdministracionUsuario_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbTiempo.ResumeLayout(false);
            this.gbTiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblTiempoUlt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblUltima;
        private System.Windows.Forms.Label lblCreacion;
        private System.Windows.Forms.MaskedTextBox mskTiempoTotal;
        private System.Windows.Forms.MaskedTextBox mskTiempoU;
        private System.Windows.Forms.DateTimePicker dtUltimaC;
        private System.Windows.Forms.DateTimePicker dtFechaC;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}