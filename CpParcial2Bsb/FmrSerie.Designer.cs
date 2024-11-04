namespace CpParcial2Bsb
{
    partial class FmrSerie
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblTituloo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpEpisodios = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(311, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SERIES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(197, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(395, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(72, 70);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(119, 20);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar Titulo ";
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(36, 121);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(721, 216);
            this.gbxLista.TabIndex = 4;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Series";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(16, 42);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(699, 150);
            this.dgvLista.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(36, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 59);
            this.panel1.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CpParcial2Bsb.Properties.Resources.Cancel_icon_icons_com_73703;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(521, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 43);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpParcial2Bsb.Properties.Resources._36_104857;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(380, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 43);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpParcial2Bsb.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(245, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 43);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpParcial2Bsb.Properties.Resources.new_file256_25213;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(109, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 43);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cmbIdioma);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.nudEpisodios);
            this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.txtDirector);
            this.gbxDatos.Controls.Add(this.txtSinopsis);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.lblEpisodios);
            this.gbxDatos.Controls.Add(this.lblSinopsis);
            this.gbxDatos.Controls.Add(this.lblDirector);
            this.gbxDatos.Controls.Add(this.lblTituloo);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(36, 422);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(723, 146);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // nudEpisodios
            // 
            this.nudEpisodios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEpisodios.Location = new System.Drawing.Point(440, 37);
            this.nudEpisodios.Name = "nudEpisodios";
            this.nudEpisodios.Size = new System.Drawing.Size(129, 26);
            this.nudEpisodios.TabIndex = 16;
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEstreno.Location = new System.Drawing.Point(440, 70);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(129, 26);
            this.dtpFechaEstreno.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CpParcial2Bsb.Properties.Resources._1486564399_close_81512;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(583, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 55);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CpParcial2Bsb.Properties.Resources.emblemdefault_1037561;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(583, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 55);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(129, 106);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(165, 26);
            this.txtDirector.TabIndex = 10;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(129, 69);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(165, 26);
            this.txtSinopsis.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(129, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(165, 26);
            this.txtTitulo.TabIndex = 7;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEstreno.Location = new System.Drawing.Point(302, 75);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(132, 20);
            this.lblFechaEstreno.TabIndex = 7;
            this.lblFechaEstreno.Text = "Fecha Estreno:";
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodios.Location = new System.Drawing.Point(302, 39);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(92, 20);
            this.lblEpisodios.TabIndex = 6;
            this.lblEpisodios.Text = "Episodios:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopsis.Location = new System.Drawing.Point(26, 72);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(82, 20);
            this.lblSinopsis.TabIndex = 5;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(26, 109);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(78, 20);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director:";
            // 
            // lblTituloo
            // 
            this.lblTituloo.AutoSize = true;
            this.lblTituloo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloo.Location = new System.Drawing.Point(26, 36);
            this.lblTituloo.Name = "lblTituloo";
            this.lblTituloo.Size = new System.Drawing.Size(58, 20);
            this.lblTituloo.TabIndex = 3;
            this.lblTituloo.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpParcial2Bsb.Properties.Resources._11_104884;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(619, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpSinopsis
            // 
            this.erpSinopsis.ContainerControl = this;
            // 
            // erpDirector
            // 
            this.erpDirector.ContainerControl = this;
            // 
            // erpEpisodios
            // 
            this.erpEpisodios.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Idioma: ";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues",
            "Chino",
            "Russo"});
            this.cmbIdioma.Location = new System.Drawing.Point(440, 104);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(129, 28);
            this.cmbIdioma.TabIndex = 18;
            // 
            // FmrSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(775, 592);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmrSerie";
            this.Text = "Serie-Segundo Parcial";
            this.Load += new System.EventHandler(this.FmrSerie_Load);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblEpisodios;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblTituloo;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudEpisodios;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpSinopsis;
        private System.Windows.Forms.ErrorProvider erpDirector;
        private System.Windows.Forms.ErrorProvider erpEpisodios;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label label1;
    }
}

