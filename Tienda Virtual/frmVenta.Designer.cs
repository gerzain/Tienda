namespace Tienda_Virtual
{
    partial class frmVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.pnlPersona = new System.Windows.Forms.Panel();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlPrecios = new System.Windows.Forms.Panel();
            this.btnProcesarVenta = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtEstadoVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.btnSeguirComrando = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.pnlPersona.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlPrecios.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(19, 124);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 21);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.Location = new System.Drawing.Point(28, 40);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(56, 21);
            this.lblCurp.TabIndex = 2;
            this.lblCurp.Text = "CURP:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(3, 97);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 21);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(85, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(389, 29);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(85, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(389, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCURP
            // 
            this.txtCURP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCURP.Location = new System.Drawing.Point(85, 32);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.ReadOnly = true;
            this.txtCURP.Size = new System.Drawing.Size(389, 29);
            this.txtCURP.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(85, 90);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(389, 29);
            this.txtTelefono.TabIndex = 7;
            // 
            // dtgVentas
            // 
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(12, 44);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            this.dtgVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVentas.Size = new System.Drawing.Size(699, 321);
            this.dtgVentas.TabIndex = 8;
            this.dtgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVentas_CellContentClick);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(6, 29);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(79, 21);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(45, 58);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(40, 21);
            this.lblIva.TabIndex = 10;
            this.lblIva.Text = "IVA:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(33, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 21);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(91, 11);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubtotal.Size = new System.Drawing.Size(216, 29);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(91, 44);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIVA.Size = new System.Drawing.Size(216, 29);
            this.txtIVA.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(91, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(216, 29);
            this.txtTotal.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(85, 61);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(389, 29);
            this.txtDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(-3, 69);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 21);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdvertencia.Location = new System.Drawing.Point(9, 7);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(660, 21);
            this.lblAdvertencia.TabIndex = 23;
            this.lblAdvertencia.Text = "*Si quieres BORRAR algun producto, da click sobre el nombre del producto de la ta" +
    "bla";
            // 
            // pnlPersona
            // 
            this.pnlPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPersona.Controls.Add(this.txtNombre);
            this.pnlPersona.Controls.Add(this.lblCorreo);
            this.pnlPersona.Controls.Add(this.lblNombre);
            this.pnlPersona.Controls.Add(this.txtDireccion);
            this.pnlPersona.Controls.Add(this.lblCurp);
            this.pnlPersona.Controls.Add(this.lblDireccion);
            this.pnlPersona.Controls.Add(this.lblTelefono);
            this.pnlPersona.Controls.Add(this.txtCorreo);
            this.pnlPersona.Controls.Add(this.txtCURP);
            this.pnlPersona.Controls.Add(this.txtTelefono);
            this.pnlPersona.Location = new System.Drawing.Point(12, 7);
            this.pnlPersona.Name = "pnlPersona";
            this.pnlPersona.Size = new System.Drawing.Size(479, 154);
            this.pnlPersona.TabIndex = 25;
            // 
            // pnlProductos
            // 
            this.pnlProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductos.Controls.Add(this.button4);
            this.pnlProductos.Controls.Add(this.btnBorrar);
            this.pnlProductos.Controls.Add(this.dtgVentas);
            this.pnlProductos.Controls.Add(this.lblAdvertencia);
            this.pnlProductos.Location = new System.Drawing.Point(12, 167);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(808, 379);
            this.pnlProductos.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(714, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 67);
            this.button4.TabIndex = 26;
            this.button4.Text = "Imprimir";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::Tienda_Virtual.Properties.Resources.cart_delete;
            this.btnBorrar.Location = new System.Drawing.Point(717, 44);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 66);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlPrecios
            // 
            this.pnlPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrecios.Controls.Add(this.btnProcesarVenta);
            this.pnlPrecios.Controls.Add(this.txtEstadoVenta);
            this.pnlPrecios.Controls.Add(this.label3);
            this.pnlPrecios.Controls.Add(this.pais);
            this.pnlPrecios.Controls.Add(this.label2);
            this.pnlPrecios.Controls.Add(this.label1);
            this.pnlPrecios.Controls.Add(this.cmbPais);
            this.pnlPrecios.Controls.Add(this.lblSubtotal);
            this.pnlPrecios.Controls.Add(this.lblIva);
            this.pnlPrecios.Controls.Add(this.lblTotal);
            this.pnlPrecios.Controls.Add(this.btnSeguirComrando);
            this.pnlPrecios.Controls.Add(this.txtSubtotal);
            this.pnlPrecios.Controls.Add(this.btnComprar);
            this.pnlPrecios.Controls.Add(this.txtIVA);
            this.pnlPrecios.Controls.Add(this.txtTotal);
            this.pnlPrecios.Location = new System.Drawing.Point(497, 7);
            this.pnlPrecios.Name = "pnlPrecios";
            this.pnlPrecios.Size = new System.Drawing.Size(532, 154);
            this.pnlPrecios.TabIndex = 27;
            // 
            // btnProcesarVenta
            // 
            this.btnProcesarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarVenta.ImageIndex = 0;
            this.btnProcesarVenta.ImageList = this.imageList1;
            this.btnProcesarVenta.Location = new System.Drawing.Point(395, 112);
            this.btnProcesarVenta.Name = "btnProcesarVenta";
            this.btnProcesarVenta.Size = new System.Drawing.Size(109, 37);
            this.btnProcesarVenta.TabIndex = 35;
            this.btnProcesarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesarVenta.UseVisualStyleBackColor = true;
            this.btnProcesarVenta.Click += new System.EventHandler(this.btnProcesarVenta_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "1467089606_ok-sign.png");
            this.imageList1.Images.SetKeyName(1, "1467089656_Shop-Payment-86.png");
            // 
            // txtEstadoVenta
            // 
            this.txtEstadoVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoVenta.Location = new System.Drawing.Point(395, 74);
            this.txtEstadoVenta.Name = "txtEstadoVenta";
            this.txtEstadoVenta.ReadOnly = true;
            this.txtEstadoVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEstadoVenta.Size = new System.Drawing.Size(109, 29);
            this.txtEstadoVenta.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Estado:";
            // 
            // pais
            // 
            this.pais.AutoSize = true;
            this.pais.Location = new System.Drawing.Point(392, 53);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(35, 13);
            this.pais.TabIndex = 32;
            this.pais.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Seleciona un pais";
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Colombia",
            "Argentina",
            "Chile"});
            this.cmbPais.Location = new System.Drawing.Point(348, 19);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 29;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // btnSeguirComrando
            // 
            this.btnSeguirComrando.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguirComrando.Image = global::Tienda_Virtual.Properties.Resources.Back_32x32_32;
            this.btnSeguirComrando.Location = new System.Drawing.Point(3, 111);
            this.btnSeguirComrando.Name = "btnSeguirComrando";
            this.btnSeguirComrando.Size = new System.Drawing.Size(191, 37);
            this.btnSeguirComrando.TabIndex = 24;
            this.btnSeguirComrando.Text = "&Seguir comprando";
            this.btnSeguirComrando.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeguirComrando.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguirComrando.UseVisualStyleBackColor = true;
            this.btnSeguirComrando.Click += new System.EventHandler(this.btnSeguirComrando_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Image = global::Tienda_Virtual.Properties.Resources.cart_go;
            this.btnComprar.Location = new System.Drawing.Point(200, 111);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(117, 37);
            this.btnComprar.TabIndex = 19;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tssl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssl1.ForeColor = System.Drawing.SystemColors.Control;
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(1014, 17);
            this.tssl1.Spring = true;
            this.tssl1.Text = "toolStripStatusLabel1";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1029, 575);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlPrecios);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.pnlPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.pnlPersona.ResumeLayout(false);
            this.pnlPersona.PerformLayout();
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            this.pnlPrecios.ResumeLayout(false);
            this.pnlPrecios.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnSeguirComrando;
        private System.Windows.Forms.Panel pnlPersona;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Panel pnlPrecios;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstadoVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesarVenta;
        private System.Windows.Forms.ImageList imageList1;
       // private tiendavirtualcsharpDataSet tiendavirtualcsharpDataSet1;
    }
}