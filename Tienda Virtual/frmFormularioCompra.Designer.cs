namespace Tienda_Virtual
{
    partial class frmFormularioCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioCompra));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ValidarErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbmMetodoPago = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnComprarEfectivo = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTarjetaPayPlay = new System.Windows.Forms.TextBox();
            this.btnCancelarPayPlay = new System.Windows.Forms.Button();
            this.btnPayPlay = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtClientePayPlay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalPayPlay = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIvaPayPlay = new System.Windows.Forms.TextBox();
            this.txtSubtotalPayPlay = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(186, 207);
            this.textBox5.MaxLength = 4;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 29);
            this.textBox5.TabIndex = 5;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(195, 153);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 29);
            this.textBox4.TabIndex = 4;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(267, 154);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(295, 94);
            this.txtEmail.MaxLength = 16;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 29);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre del cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(3, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 29);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Comprar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Codigo de seguridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de vencimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero de tarjeta:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1003, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ValidarErrores
            // 
            this.ValidarErrores.ContainerControl = this;
            // 
            // cbmMetodoPago
            // 
            this.cbmMetodoPago.FormattingEnabled = true;
            this.cbmMetodoPago.Items.AddRange(new object[] {
            "TarjetaCredito",
            "Efectivo",
            "Payplay"});
            this.cbmMetodoPago.Location = new System.Drawing.Point(94, 14);
            this.cbmMetodoPago.Name = "cbmMetodoPago";
            this.cbmMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cbmMetodoPago.TabIndex = 28;
            this.cbmMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cbmMetodoPago_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbmMetodoPago);
            this.panel1.Location = new System.Drawing.Point(418, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 45);
            this.panel1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Metodo de pago";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(113, 28);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(135, 29);
            this.txtSubtotal.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Subtotal:";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(113, 58);
            this.txtIva.MaxLength = 16;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(135, 29);
            this.txtIva.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Iva:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(113, 93);
            this.txtTotal.MaxLength = 16;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(135, 29);
            this.txtTotal.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtTarjeta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 332);
            this.panel2.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Pago con tarjeta";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Enabled = false;
            this.txtTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(3, 104);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(174, 29);
            this.txtTarjeta.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnComprarEfectivo);
            this.panel3.Controls.Add(this.txtCambio);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtPago);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtIva);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Location = new System.Drawing.Point(408, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 208);
            this.panel3.TabIndex = 38;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(329, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 29);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnComprarEfectivo
            // 
            this.btnComprarEfectivo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarEfectivo.Location = new System.Drawing.Point(163, 176);
            this.btnComprarEfectivo.Name = "btnComprarEfectivo";
            this.btnComprarEfectivo.Size = new System.Drawing.Size(105, 29);
            this.btnComprarEfectivo.TabIndex = 41;
            this.btnComprarEfectivo.Text = "Comprar";
            this.btnComprarEfectivo.UseVisualStyleBackColor = true;
            this.btnComprarEfectivo.Click += new System.EventHandler(this.btnComprarEfectivo_Click);
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(278, 117);
            this.txtCambio.MaxLength = 16;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(174, 29);
            this.txtCambio.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(274, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 21);
            this.label20.TabIndex = 42;
            this.label20.Text = "Cambio:";
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(113, 134);
            this.txtPago.MaxLength = 16;
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(135, 29);
            this.txtPago.TabIndex = 41;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 21);
            this.label19.TabIndex = 40;
            this.label19.Text = "Efectivo:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(278, 45);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(174, 29);
            this.txtCliente.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(274, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 21);
            this.label12.TabIndex = 38;
            this.label12.Text = "Nombre del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Pago en efectivo";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTarjetaPayPlay);
            this.panel4.Controls.Add(this.btnCancelarPayPlay);
            this.panel4.Controls.Add(this.btnPayPlay);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.txtClientePayPlay);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtTotalPayPlay);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtIvaPayPlay);
            this.panel4.Controls.Add(this.txtSubtotalPayPlay);
            this.panel4.Location = new System.Drawing.Point(390, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 205);
            this.panel4.TabIndex = 40;
            // 
            // txtTarjetaPayPlay
            // 
            this.txtTarjetaPayPlay.Enabled = false;
            this.txtTarjetaPayPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaPayPlay.Location = new System.Drawing.Point(295, 163);
            this.txtTarjetaPayPlay.Name = "txtTarjetaPayPlay";
            this.txtTarjetaPayPlay.Size = new System.Drawing.Size(174, 29);
            this.txtTarjetaPayPlay.TabIndex = 45;
            // 
            // btnCancelarPayPlay
            // 
            this.btnCancelarPayPlay.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPayPlay.Location = new System.Drawing.Point(148, 163);
            this.btnCancelarPayPlay.Name = "btnCancelarPayPlay";
            this.btnCancelarPayPlay.Size = new System.Drawing.Size(96, 29);
            this.btnCancelarPayPlay.TabIndex = 44;
            this.btnCancelarPayPlay.Text = "&Cancelar";
            this.btnCancelarPayPlay.UseVisualStyleBackColor = true;
            this.btnCancelarPayPlay.Click += new System.EventHandler(this.btnCancelarPayPlay_Click);
            // 
            // btnPayPlay
            // 
            this.btnPayPlay.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayPlay.Location = new System.Drawing.Point(18, 163);
            this.btnPayPlay.Name = "btnPayPlay";
            this.btnPayPlay.Size = new System.Drawing.Size(104, 29);
            this.btnPayPlay.TabIndex = 43;
            this.btnPayPlay.Text = "Comprar";
            this.btnPayPlay.UseVisualStyleBackColor = true;
            this.btnPayPlay.Click += new System.EventHandler(this.btnPayPlay_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(294, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 21);
            this.label21.TabIndex = 42;
            this.label21.Text = "Numero de tarjeta:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(294, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 21);
            this.label18.TabIndex = 40;
            this.label18.Text = "Email";
            // 
            // txtClientePayPlay
            // 
            this.txtClientePayPlay.Enabled = false;
            this.txtClientePayPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientePayPlay.Location = new System.Drawing.Point(295, 42);
            this.txtClientePayPlay.Name = "txtClientePayPlay";
            this.txtClientePayPlay.Size = new System.Drawing.Size(174, 29);
            this.txtClientePayPlay.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "Nombre del cliente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 21);
            this.label14.TabIndex = 37;
            this.label14.Text = "Pago con Payplay";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "Subtotal:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 21);
            this.label16.TabIndex = 34;
            this.label16.Text = "Iva:";
            // 
            // txtTotalPayPlay
            // 
            this.txtTotalPayPlay.Enabled = false;
            this.txtTotalPayPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayPlay.Location = new System.Drawing.Point(113, 93);
            this.txtTotalPayPlay.MaxLength = 16;
            this.txtTotalPayPlay.Name = "txtTotalPayPlay";
            this.txtTotalPayPlay.Size = new System.Drawing.Size(135, 29);
            this.txtTotalPayPlay.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 21);
            this.label17.TabIndex = 35;
            this.label17.Text = "Total:";
            // 
            // txtIvaPayPlay
            // 
            this.txtIvaPayPlay.Enabled = false;
            this.txtIvaPayPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIvaPayPlay.Location = new System.Drawing.Point(113, 58);
            this.txtIvaPayPlay.MaxLength = 16;
            this.txtIvaPayPlay.Name = "txtIvaPayPlay";
            this.txtIvaPayPlay.Size = new System.Drawing.Size(135, 29);
            this.txtIvaPayPlay.TabIndex = 33;
            // 
            // txtSubtotalPayPlay
            // 
            this.txtSubtotalPayPlay.Enabled = false;
            this.txtSubtotalPayPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalPayPlay.Location = new System.Drawing.Point(113, 28);
            this.txtSubtotalPayPlay.Name = "txtSubtotalPayPlay";
            this.txtSubtotalPayPlay.Size = new System.Drawing.Size(135, 29);
            this.txtSubtotalPayPlay.TabIndex = 31;
            // 
            // frmFormularioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1018, 549);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFormularioCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider ValidarErrores;
        private System.Windows.Forms.ComboBox cbmMetodoPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtClientePayPlay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalPayPlay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIvaPayPlay;
        private System.Windows.Forms.TextBox txtSubtotalPayPlay;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprarEfectivo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCancelarPayPlay;
        private System.Windows.Forms.Button btnPayPlay;
        private System.Windows.Forms.TextBox txtTarjetaPayPlay;
    }
}