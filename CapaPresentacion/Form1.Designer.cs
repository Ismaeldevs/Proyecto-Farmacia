namespace CapaPresentacion
{
    partial class frmSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picMedicamentos = new System.Windows.Forms.PictureBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.picClientes = new System.Windows.Forms.PictureBox();
            this.picProductos = new System.Windows.Forms.PictureBox();
            this.picVentas = new System.Windows.Forms.PictureBox();
            this.picNuevaVenta = new System.Windows.Forms.PictureBox();
            this.lblOClientes = new System.Windows.Forms.Label();
            this.lblONuevaVenta = new System.Windows.Forms.Label();
            this.lblOVentas = new System.Windows.Forms.Label();
            this.lblOProductos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picQSomos = new System.Windows.Forms.PictureBox();
            this.lblQSomos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmHorario = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQSomos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(568, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(104, 93);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(440, 121);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(322, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "FARMACIA FLORESTA";
            // 
            // picMedicamentos
            // 
            this.picMedicamentos.BackColor = System.Drawing.Color.Transparent;
            this.picMedicamentos.Image = ((System.Drawing.Image)(resources.GetObject("picMedicamentos.Image")));
            this.picMedicamentos.Location = new System.Drawing.Point(768, 99);
            this.picMedicamentos.Name = "picMedicamentos";
            this.picMedicamentos.Size = new System.Drawing.Size(57, 56);
            this.picMedicamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedicamentos.TabIndex = 2;
            this.picMedicamentos.TabStop = false;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.BackColor = System.Drawing.Color.Transparent;
            this.lblOpcion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.White;
            this.lblOpcion.Location = new System.Drawing.Point(34, 188);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(221, 22);
            this.lblOpcion.TabIndex = 3;
            this.lblOpcion.Text = "Seleccione una opción";
            // 
            // picClientes
            // 
            this.picClientes.BackColor = System.Drawing.Color.Transparent;
            this.picClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClientes.Image = ((System.Drawing.Image)(resources.GetObject("picClientes.Image")));
            this.picClientes.Location = new System.Drawing.Point(38, 270);
            this.picClientes.Name = "picClientes";
            this.picClientes.Size = new System.Drawing.Size(142, 124);
            this.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClientes.TabIndex = 4;
            this.picClientes.TabStop = false;
            this.picClientes.Click += new System.EventHandler(this.picClientes_Click);
            // 
            // picProductos
            // 
            this.picProductos.BackColor = System.Drawing.Color.Transparent;
            this.picProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProductos.Image = ((System.Drawing.Image)(resources.GetObject("picProductos.Image")));
            this.picProductos.Location = new System.Drawing.Point(309, 270);
            this.picProductos.Name = "picProductos";
            this.picProductos.Size = new System.Drawing.Size(142, 124);
            this.picProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductos.TabIndex = 5;
            this.picProductos.TabStop = false;
            this.picProductos.Click += new System.EventHandler(this.picProductos_Click);
            // 
            // picVentas
            // 
            this.picVentas.BackColor = System.Drawing.Color.Transparent;
            this.picVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVentas.Image = ((System.Drawing.Image)(resources.GetObject("picVentas.Image")));
            this.picVentas.Location = new System.Drawing.Point(568, 270);
            this.picVentas.Name = "picVentas";
            this.picVentas.Size = new System.Drawing.Size(142, 124);
            this.picVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVentas.TabIndex = 6;
            this.picVentas.TabStop = false;
            this.picVentas.Click += new System.EventHandler(this.picVentas_Click);
            // 
            // picNuevaVenta
            // 
            this.picNuevaVenta.BackColor = System.Drawing.Color.Transparent;
            this.picNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("picNuevaVenta.Image")));
            this.picNuevaVenta.Location = new System.Drawing.Point(827, 270);
            this.picNuevaVenta.Name = "picNuevaVenta";
            this.picNuevaVenta.Size = new System.Drawing.Size(142, 124);
            this.picNuevaVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNuevaVenta.TabIndex = 7;
            this.picNuevaVenta.TabStop = false;
            this.picNuevaVenta.Click += new System.EventHandler(this.picNuevaVenta_Click);
            // 
            // lblOClientes
            // 
            this.lblOClientes.AutoSize = true;
            this.lblOClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblOClientes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOClientes.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOClientes.Location = new System.Drawing.Point(53, 415);
            this.lblOClientes.Name = "lblOClientes";
            this.lblOClientes.Size = new System.Drawing.Size(106, 22);
            this.lblOClientes.TabIndex = 8;
            this.lblOClientes.Text = "CLIENTES";
            // 
            // lblONuevaVenta
            // 
            this.lblONuevaVenta.AutoSize = true;
            this.lblONuevaVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblONuevaVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONuevaVenta.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblONuevaVenta.Location = new System.Drawing.Point(830, 415);
            this.lblONuevaVenta.Name = "lblONuevaVenta";
            this.lblONuevaVenta.Size = new System.Drawing.Size(142, 22);
            this.lblONuevaVenta.TabIndex = 9;
            this.lblONuevaVenta.Text = "NUEVA VENTA";
            // 
            // lblOVentas
            // 
            this.lblOVentas.AutoSize = true;
            this.lblOVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblOVentas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOVentas.ForeColor = System.Drawing.Color.Navy;
            this.lblOVentas.Location = new System.Drawing.Point(585, 415);
            this.lblOVentas.Name = "lblOVentas";
            this.lblOVentas.Size = new System.Drawing.Size(87, 22);
            this.lblOVentas.TabIndex = 10;
            this.lblOVentas.Text = "VENTAS";
            // 
            // lblOProductos
            // 
            this.lblOProductos.AutoSize = true;
            this.lblOProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblOProductos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOProductos.ForeColor = System.Drawing.Color.Gold;
            this.lblOProductos.Location = new System.Drawing.Point(312, 415);
            this.lblOProductos.Name = "lblOProductos";
            this.lblOProductos.Size = new System.Drawing.Size(133, 22);
            this.lblOProductos.TabIndex = 11;
            this.lblOProductos.Text = "PRODUCTOS";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.lblHora.Location = new System.Drawing.Point(1042, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(82, 29);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.lblFecha.Location = new System.Drawing.Point(954, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 19);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // picSalir
            // 
            this.picSalir.BackColor = System.Drawing.Color.Transparent;
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = ((System.Drawing.Image)(resources.GetObject("picSalir.Image")));
            this.picSalir.Location = new System.Drawing.Point(1141, 494);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(75, 66);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalir.TabIndex = 14;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // picQSomos
            // 
            this.picQSomos.BackColor = System.Drawing.Color.Transparent;
            this.picQSomos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQSomos.Image = ((System.Drawing.Image)(resources.GetObject("picQSomos.Image")));
            this.picQSomos.Location = new System.Drawing.Point(89, 34);
            this.picQSomos.Name = "picQSomos";
            this.picQSomos.Size = new System.Drawing.Size(56, 53);
            this.picQSomos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQSomos.TabIndex = 15;
            this.picQSomos.TabStop = false;
            this.picQSomos.Click += new System.EventHandler(this.picQSomos_Click);
            // 
            // lblQSomos
            // 
            this.lblQSomos.AutoSize = true;
            this.lblQSomos.BackColor = System.Drawing.Color.Transparent;
            this.lblQSomos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQSomos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQSomos.Location = new System.Drawing.Point(63, 12);
            this.lblQSomos.Name = "lblQSomos";
            this.lblQSomos.Size = new System.Drawing.Size(134, 19);
            this.lblQSomos.TabIndex = 16;
            this.lblQSomos.Text = "QUINES SOMOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(1083, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "EMPLEADOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1081, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmHorario
            // 
            this.tmHorario.Tick += new System.EventHandler(this.tmHorario_Tick);
            // 
            // frmSistema
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQSomos);
            this.Controls.Add(this.picQSomos);
            this.Controls.Add(this.picSalir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblOProductos);
            this.Controls.Add(this.lblOVentas);
            this.Controls.Add(this.lblONuevaVenta);
            this.Controls.Add(this.lblOClientes);
            this.Controls.Add(this.picNuevaVenta);
            this.Controls.Add(this.picVentas);
            this.Controls.Add(this.picProductos);
            this.Controls.Add(this.picClientes);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.picMedicamentos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Floresta";
            this.Load += new System.EventHandler(this.frmSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQSomos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picMedicamentos;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.PictureBox picClientes;
        private System.Windows.Forms.PictureBox picProductos;
        private System.Windows.Forms.PictureBox picVentas;
        private System.Windows.Forms.PictureBox picNuevaVenta;
        private System.Windows.Forms.Label lblOClientes;
        private System.Windows.Forms.Label lblONuevaVenta;
        private System.Windows.Forms.Label lblOVentas;
        private System.Windows.Forms.Label lblOProductos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picQSomos;
        private System.Windows.Forms.Label lblQSomos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmHorario;
    }
}

