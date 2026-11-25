namespace pryDisenoLavadero
{
    partial class frmLavados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLavados));
            gboDatosDelLavado = new GroupBox();
            txtVehiculos = new TextBox();
            cboServicio = new ComboBox();
            txtPatente = new TextBox();
            txtCliente = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            chkClienteFrecuente = new CheckBox();
            gboEntrega = new GroupBox();
            rbnExpress = new RadioButton();
            rbnNormal = new RadioButton();
            lblVehiculos = new Label();
            lblServicio = new Label();
            lblPatente = new Label();
            lblCliente = new Label();
            gboImporte = new GroupBox();
            lblMostrarTotal = new Label();
            lblMostrarDescuento = new Label();
            lblMostrarRecargo = new Label();
            lblMostrarSubtotal = new Label();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblRecargo = new Label();
            lblSubtotal = new Label();
            gboDatosDelLavado.SuspendLayout();
            gboEntrega.SuspendLayout();
            gboImporte.SuspendLayout();
            SuspendLayout();
            // 
            // gboDatosDelLavado
            // 
            gboDatosDelLavado.Controls.Add(txtVehiculos);
            gboDatosDelLavado.Controls.Add(cboServicio);
            gboDatosDelLavado.Controls.Add(txtPatente);
            gboDatosDelLavado.Controls.Add(txtCliente);
            gboDatosDelLavado.Controls.Add(btnLimpiar);
            gboDatosDelLavado.Controls.Add(btnCalcular);
            gboDatosDelLavado.Controls.Add(chkClienteFrecuente);
            gboDatosDelLavado.Controls.Add(gboEntrega);
            gboDatosDelLavado.Controls.Add(lblVehiculos);
            gboDatosDelLavado.Controls.Add(lblServicio);
            gboDatosDelLavado.Controls.Add(lblPatente);
            gboDatosDelLavado.Controls.Add(lblCliente);
            gboDatosDelLavado.Location = new Point(12, 12);
            gboDatosDelLavado.Name = "gboDatosDelLavado";
            gboDatosDelLavado.Size = new Size(334, 342);
            gboDatosDelLavado.TabIndex = 0;
            gboDatosDelLavado.TabStop = false;
            gboDatosDelLavado.Text = "Datos del lavado";
            // 
            // txtVehiculos
            // 
            txtVehiculos.BackColor = Color.Azure;
            txtVehiculos.Location = new Point(134, 137);
            txtVehiculos.MaxLength = 1;
            txtVehiculos.Name = "txtVehiculos";
            txtVehiculos.Size = new Size(52, 23);
            txtVehiculos.TabIndex = 11;
            txtVehiculos.TextChanged += textBox3_TextChanged;
            // 
            // cboServicio
            // 
            cboServicio.BackColor = Color.Azure;
            cboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServicio.FormattingEnabled = true;
            cboServicio.Items.AddRange(new object[] { "Lavado exterior", "Lavado completo", "Lavado con encerado" });
            cboServicio.Location = new Point(134, 100);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(176, 23);
            cboServicio.TabIndex = 10;
            // 
            // txtPatente
            // 
            txtPatente.BackColor = Color.Azure;
            txtPatente.Location = new Point(136, 64);
            txtPatente.MaxLength = 7;
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 9;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.Azure;
            txtCliente.Location = new Point(136, 29);
            txtCliente.MaxLength = 40;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(174, 23);
            txtCliente.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Azure;
            btnLimpiar.Location = new Point(171, 286);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 37);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Azure;
            btnCalcular.Location = new Point(8, 286);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(157, 37);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // chkClienteFrecuente
            // 
            chkClienteFrecuente.AutoSize = true;
            chkClienteFrecuente.Location = new Point(26, 249);
            chkClienteFrecuente.Name = "chkClienteFrecuente";
            chkClienteFrecuente.Size = new Size(174, 19);
            chkClienteFrecuente.TabIndex = 5;
            chkClienteFrecuente.Text = "Cliente frecuente (5 % extra)";
            chkClienteFrecuente.UseVisualStyleBackColor = true;
            // 
            // gboEntrega
            // 
            gboEntrega.Controls.Add(rbnExpress);
            gboEntrega.Controls.Add(rbnNormal);
            gboEntrega.Location = new Point(22, 177);
            gboEntrega.Name = "gboEntrega";
            gboEntrega.Size = new Size(292, 54);
            gboEntrega.TabIndex = 4;
            gboEntrega.TabStop = false;
            gboEntrega.Text = "Entrega";
            // 
            // rbnExpress
            // 
            rbnExpress.AutoSize = true;
            rbnExpress.Location = new Point(153, 22);
            rbnExpress.Name = "rbnExpress";
            rbnExpress.Size = new Size(104, 19);
            rbnExpress.TabIndex = 1;
            rbnExpress.TabStop = true;
            rbnExpress.Text = "Express (+25%)";
            rbnExpress.UseVisualStyleBackColor = true;
            // 
            // rbnNormal
            // 
            rbnNormal.AutoSize = true;
            rbnNormal.Location = new Point(30, 22);
            rbnNormal.Name = "rbnNormal";
            rbnNormal.Size = new Size(65, 19);
            rbnNormal.TabIndex = 0;
            rbnNormal.TabStop = true;
            rbnNormal.Text = "Normal";
            rbnNormal.UseVisualStyleBackColor = true;
            // 
            // lblVehiculos
            // 
            lblVehiculos.AutoSize = true;
            lblVehiculos.Location = new Point(25, 140);
            lblVehiculos.Name = "lblVehiculos";
            lblVehiculos.Size = new Size(95, 15);
            lblVehiculos.TabIndex = 3;
            lblVehiculos.Text = "Vehiculos (1 a 5):";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(25, 103);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(51, 15);
            lblServicio.TabIndex = 2;
            lblServicio.Text = "Servicio:";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(26, 67);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente:";
            lblPatente.Click += label2_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(25, 32);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // gboImporte
            // 
            gboImporte.Controls.Add(lblMostrarTotal);
            gboImporte.Controls.Add(lblMostrarDescuento);
            gboImporte.Controls.Add(lblMostrarRecargo);
            gboImporte.Controls.Add(lblMostrarSubtotal);
            gboImporte.Controls.Add(lblTotal);
            gboImporte.Controls.Add(lblDescuento);
            gboImporte.Controls.Add(lblRecargo);
            gboImporte.Controls.Add(lblSubtotal);
            gboImporte.Location = new Point(12, 360);
            gboImporte.Name = "gboImporte";
            gboImporte.Size = new Size(334, 155);
            gboImporte.TabIndex = 1;
            gboImporte.TabStop = false;
            gboImporte.Text = "Importe";
            // 
            // lblMostrarTotal
            // 
            lblMostrarTotal.AutoSize = true;
            lblMostrarTotal.Location = new Point(211, 115);
            lblMostrarTotal.Name = "lblMostrarTotal";
            lblMostrarTotal.Size = new Size(12, 15);
            lblMostrarTotal.TabIndex = 7;
            lblMostrarTotal.Text = "-";
            // 
            // lblMostrarDescuento
            // 
            lblMostrarDescuento.AutoSize = true;
            lblMostrarDescuento.Location = new Point(211, 86);
            lblMostrarDescuento.Name = "lblMostrarDescuento";
            lblMostrarDescuento.Size = new Size(12, 15);
            lblMostrarDescuento.TabIndex = 6;
            lblMostrarDescuento.Text = "-";
            // 
            // lblMostrarRecargo
            // 
            lblMostrarRecargo.AutoSize = true;
            lblMostrarRecargo.Location = new Point(211, 59);
            lblMostrarRecargo.Name = "lblMostrarRecargo";
            lblMostrarRecargo.Size = new Size(12, 15);
            lblMostrarRecargo.TabIndex = 5;
            lblMostrarRecargo.Text = "-";
            // 
            // lblMostrarSubtotal
            // 
            lblMostrarSubtotal.AutoSize = true;
            lblMostrarSubtotal.Location = new Point(211, 33);
            lblMostrarSubtotal.Name = "lblMostrarSubtotal";
            lblMostrarSubtotal.Size = new Size(12, 15);
            lblMostrarSubtotal.TabIndex = 4;
            lblMostrarSubtotal.Text = "-";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 115);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total a pagar:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(18, 86);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(18, 59);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(53, 15);
            lblRecargo.TabIndex = 1;
            lblRecargo.Text = "Recargo:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(18, 33);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(358, 521);
            Controls.Add(gboImporte);
            Controls.Add(gboDatosDelLavado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLavados";
            Text = "Lavadero Los Andes - Calculo de Servicio";
            Load += frmLavados_Load;
            gboDatosDelLavado.ResumeLayout(false);
            gboDatosDelLavado.PerformLayout();
            gboEntrega.ResumeLayout(false);
            gboEntrega.PerformLayout();
            gboImporte.ResumeLayout(false);
            gboImporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboDatosDelLavado;
        private Label lblVehiculos;
        private Label lblServicio;
        private Label lblPatente;
        private Label lblCliente;
        private GroupBox gboImporte;
        private TextBox txtVehiculos;
        private ComboBox cboServicio;
        private TextBox txtPatente;
        private TextBox txtCliente;
        private Button btnLimpiar;
        private Button btnCalcular;
        private CheckBox chkClienteFrecuente;
        private GroupBox gboEntrega;
        private RadioButton rbnExpress;
        private RadioButton rbnNormal;
        private Label lblMostrarTotal;
        private Label lblMostrarDescuento;
        private Label lblMostrarRecargo;
        private Label lblMostrarSubtotal;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblRecargo;
        private Label lblSubtotal;
    }
}