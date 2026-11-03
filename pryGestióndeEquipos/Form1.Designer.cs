namespace pryGestióndeEquipos
{
    partial class Gestio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnregistrar = new Button();
            grpcliente = new GroupBox();
            txtapellido = new TextBox();
            txtmail = new TextBox();
            lblapellido = new Label();
            lbltelefono = new Label();
            lblmail = new Label();
            txttelefono = new TextBox();
            lblnombre = new Label();
            txtnombre = new TextBox();
            grpequipo = new GroupBox();
            txtmarca = new TextBox();
            txtdetalles = new TextBox();
            lblmarca = new Label();
            lbldetalles = new Label();
            lbltipo = new Label();
            lblserie = new Label();
            cbotipo = new ComboBox();
            txtserie = new TextBox();
            tabPage2 = new TabPage();
            cbofactura = new ComboBox();
            lblfactura = new Label();
            lblvendedor = new Label();
            cbovendedor = new ComboBox();
            dtphora = new DateTimePicker();
            txtpresupuesto = new TextBox();
            label8 = new Label();
            lblhora = new Label();
            dtpfecha = new DateTimePicker();
            lblfecha = new Label();
            txtnumero = new TextBox();
            btnregistrar2 = new Button();
            label6 = new Label();
            grpdiagnostico = new GroupBox();
            txtdiagnostico = new TextBox();
            lblnumerotck = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpcliente.SuspendLayout();
            grpequipo.SuspendLayout();
            tabPage2.SuspendLayout();
            grpdiagnostico.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(435, 498);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnregistrar);
            tabPage1.Controls.Add(grpcliente);
            tabPage1.Controls.Add(grpequipo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(427, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Generales:";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(160, 410);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(75, 23);
            btnregistrar.TabIndex = 19;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // grpcliente
            // 
            grpcliente.Controls.Add(txtapellido);
            grpcliente.Controls.Add(txtmail);
            grpcliente.Controls.Add(lblapellido);
            grpcliente.Controls.Add(lbltelefono);
            grpcliente.Controls.Add(lblmail);
            grpcliente.Controls.Add(txttelefono);
            grpcliente.Controls.Add(lblnombre);
            grpcliente.Controls.Add(txtnombre);
            grpcliente.Location = new Point(4, 37);
            grpcliente.Name = "grpcliente";
            grpcliente.Size = new Size(419, 97);
            grpcliente.TabIndex = 17;
            grpcliente.TabStop = false;
            grpcliente.Text = "Cliente:";
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(237, 23);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 4;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(237, 60);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(100, 23);
            txtmail.TabIndex = 7;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(177, 26);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(54, 15);
            lblapellido.TabIndex = 1;
            lblapellido.Text = "Apellido:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(6, 63);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(56, 15);
            lbltelefono.TabIndex = 2;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Location = new Point(177, 63);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(33, 15);
            lblmail.TabIndex = 6;
            lblmail.Text = "Mail:";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(68, 60);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(100, 23);
            txttelefono.TabIndex = 5;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(6, 29);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(66, 26);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            // 
            // grpequipo
            // 
            grpequipo.Controls.Add(txtmarca);
            grpequipo.Controls.Add(txtdetalles);
            grpequipo.Controls.Add(lblmarca);
            grpequipo.Controls.Add(lbldetalles);
            grpequipo.Controls.Add(lbltipo);
            grpequipo.Controls.Add(lblserie);
            grpequipo.Controls.Add(cbotipo);
            grpequipo.Controls.Add(txtserie);
            grpequipo.Location = new Point(4, 159);
            grpequipo.Name = "grpequipo";
            grpequipo.Size = new Size(415, 245);
            grpequipo.TabIndex = 18;
            grpequipo.TabStop = false;
            grpequipo.Text = "Equipo:";
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(58, 61);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(100, 23);
            txtmarca.TabIndex = 13;
            // 
            // txtdetalles
            // 
            txtdetalles.Location = new Point(60, 100);
            txtdetalles.Multiline = true;
            txtdetalles.Name = "txtdetalles";
            txtdetalles.ScrollBars = ScrollBars.Horizontal;
            txtdetalles.Size = new Size(336, 119);
            txtdetalles.TabIndex = 16;
            // 
            // lblmarca
            // 
            lblmarca.AutoSize = true;
            lblmarca.Location = new Point(9, 64);
            lblmarca.Name = "lblmarca";
            lblmarca.Size = new Size(43, 15);
            lblmarca.TabIndex = 12;
            lblmarca.Text = "Marca:";
            // 
            // lbldetalles
            // 
            lbldetalles.AutoSize = true;
            lbldetalles.Location = new Point(6, 100);
            lbldetalles.Name = "lbldetalles";
            lbldetalles.Size = new Size(51, 15);
            lbldetalles.TabIndex = 0;
            lbldetalles.Text = "Detalles:";
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(9, 25);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(34, 15);
            lbltipo.TabIndex = 9;
            lbltipo.Text = "Tipo:";
            // 
            // lblserie
            // 
            lblserie.AutoSize = true;
            lblserie.Location = new Point(177, 67);
            lblserie.Name = "lblserie";
            lblserie.Size = new Size(83, 15);
            lblserie.TabIndex = 10;
            lblserie.Text = "Num. de serie:";
            // 
            // cbotipo
            // 
            cbotipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipo.FormattingEnabled = true;
            cbotipo.Location = new Point(49, 22);
            cbotipo.Name = "cbotipo";
            cbotipo.Size = new Size(121, 23);
            cbotipo.Sorted = true;
            cbotipo.TabIndex = 11;
            // 
            // txtserie
            // 
            txtserie.Location = new Point(266, 64);
            txtserie.Name = "txtserie";
            txtserie.Size = new Size(100, 23);
            txtserie.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbofactura);
            tabPage2.Controls.Add(lblfactura);
            tabPage2.Controls.Add(lblvendedor);
            tabPage2.Controls.Add(cbovendedor);
            tabPage2.Controls.Add(dtphora);
            tabPage2.Controls.Add(txtpresupuesto);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(lblhora);
            tabPage2.Controls.Add(dtpfecha);
            tabPage2.Controls.Add(lblfecha);
            tabPage2.Controls.Add(txtnumero);
            tabPage2.Controls.Add(btnregistrar2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(grpdiagnostico);
            tabPage2.Controls.Add(lblnumerotck);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(427, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ticket:";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbofactura
            // 
            cbofactura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbofactura.FormattingEnabled = true;
            cbofactura.Items.AddRange(new object[] { "Consumidor Final", "Factura A", "Ticket común" });
            cbofactura.Location = new Point(94, 329);
            cbofactura.Name = "cbofactura";
            cbofactura.Size = new Size(121, 23);
            cbofactura.Sorted = true;
            cbofactura.TabIndex = 25;
            // 
            // lblfactura
            // 
            lblfactura.AutoSize = true;
            lblfactura.Location = new Point(13, 337);
            lblfactura.Name = "lblfactura";
            lblfactura.Size = new Size(49, 15);
            lblfactura.TabIndex = 24;
            lblfactura.Text = "Factura:";
            // 
            // lblvendedor
            // 
            lblvendedor.AutoSize = true;
            lblvendedor.Location = new Point(13, 27);
            lblvendedor.Name = "lblvendedor";
            lblvendedor.Size = new Size(60, 15);
            lblvendedor.TabIndex = 23;
            lblvendedor.Text = "Vendedor:";
            // 
            // cbovendedor
            // 
            cbovendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbovendedor.FormattingEnabled = true;
            cbovendedor.Location = new Point(79, 22);
            cbovendedor.Name = "cbovendedor";
            cbovendedor.Size = new Size(121, 23);
            cbovendedor.Sorted = true;
            cbovendedor.TabIndex = 22;
            // 
            // dtphora
            // 
            dtphora.Format = DateTimePickerFormat.Time;
            dtphora.Location = new Point(62, 82);
            dtphora.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtphora.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtphora.Name = "dtphora";
            dtphora.ShowUpDown = true;
            dtphora.Size = new Size(69, 23);
            dtphora.TabIndex = 21;
            // 
            // txtpresupuesto
            // 
            txtpresupuesto.Location = new Point(94, 294);
            txtpresupuesto.Name = "txtpresupuesto";
            txtpresupuesto.Size = new Size(111, 23);
            txtpresupuesto.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 297);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 10;
            label8.Text = "Presupuesto:";
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(13, 88);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(36, 15);
            lblhora.TabIndex = 20;
            lblhora.Text = "Hora:";
            // 
            // dtpfecha
            // 
            dtpfecha.Location = new Point(62, 53);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(213, 23);
            dtpfecha.TabIndex = 17;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Location = new Point(13, 59);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(41, 15);
            lblfecha.TabIndex = 12;
            lblfecha.Text = "Fecha:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(281, 22);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(100, 23);
            txtnumero.TabIndex = 13;
            // 
            // btnregistrar2
            // 
            btnregistrar2.Location = new Point(159, 388);
            btnregistrar2.Name = "btnregistrar2";
            btnregistrar2.Size = new Size(75, 23);
            btnregistrar2.TabIndex = 19;
            btnregistrar2.Text = "Registrar";
            btnregistrar2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 53);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 0;
            // 
            // grpdiagnostico
            // 
            grpdiagnostico.Controls.Add(txtdiagnostico);
            grpdiagnostico.Location = new Point(13, 120);
            grpdiagnostico.Name = "grpdiagnostico";
            grpdiagnostico.Size = new Size(363, 159);
            grpdiagnostico.TabIndex = 18;
            grpdiagnostico.TabStop = false;
            grpdiagnostico.Text = "Diagnóstico:";
            // 
            // txtdiagnostico
            // 
            txtdiagnostico.Location = new Point(10, 22);
            txtdiagnostico.Multiline = true;
            txtdiagnostico.Name = "txtdiagnostico";
            txtdiagnostico.ScrollBars = ScrollBars.Horizontal;
            txtdiagnostico.Size = new Size(336, 119);
            txtdiagnostico.TabIndex = 16;
            // 
            // lblnumerotck
            // 
            lblnumerotck.AutoSize = true;
            lblnumerotck.Location = new Point(221, 25);
            lblnumerotck.Name = "lblnumerotck";
            lblnumerotck.Size = new Size(54, 15);
            lblnumerotck.TabIndex = 9;
            lblnumerotck.Text = "Número:";
            // 
            // Gestio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 512);
            Controls.Add(tabControl1);
            Name = "Gestio";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpcliente.ResumeLayout(false);
            grpcliente.PerformLayout();
            grpequipo.ResumeLayout(false);
            grpequipo.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            grpdiagnostico.ResumeLayout(false);
            grpdiagnostico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnregistrar;
        private GroupBox grpcliente;
        private TextBox txtapellido;
        private TextBox txtmail;
        private Label lblapellido;
        private Label lbltelefono;
        private Label lblmail;
        private TextBox txttelefono;
        private Label lblnombre;
        private TextBox txtnombre;
        private GroupBox grpequipo;
        private TextBox txtmarca;
        private TextBox txtdetalles;
        private Label lblmarca;
        private Label lbldetalles;
        private Label lbltipo;
        private Label lblserie;
        private ComboBox cbotipo;
        private TextBox txtserie;
        private TabPage tabPage2;
        private TextBox txtnumero;
        private Button btnregistrar2;
        private Label lblfecha;
        private Label label6;
        private Label lblnumerotck;
        private DateTimePicker dtpfecha;
        private Label lblhora;
        private DateTimePicker dtphora;
        private GroupBox grpdiagnostico;
        private TextBox txtdiagnostico;
        private Label label8;
        private TextBox txtpresupuesto;
        private Label lblfactura;
        private Label lblvendedor;
        private ComboBox cbovendedor;
        private ComboBox cbofactura;
    }
}
