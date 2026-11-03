using System.Net.Mail;

namespace pryGestióndeEquipos
{
    public partial class Gestio : Form
    {
        // Clases para guardar los datos en memoria
        private class Cliente
        {
            public string Nombre, Apellido, Telefono, Mail;
        }
        private class Equipo
        {
            public string Tipo, Marca, Serie, Detalles;
        }
        private class Ticket
        {
            public int Numero;
            public Cliente Cliente;
            public Equipo Equipo;
            public string Vendedor, Diagnostico, Estado;
            public DateTime FechaHora;
            public decimal Presupuesto;
        }

        private readonly List<Ticket> tickets = new();
        private Cliente clienteActual;
        private Equipo equipoActual;
        private int contador = 1;

        public Gestio()
        {
            InitializeComponent();
            Load += Gestio_Load;
            txttelefono.KeyPress += SoloNumeros_KeyPress;
            txtpresupuesto.KeyPress += Decimal_KeyPress;
            btnregistrar2.Click += btnregistrar2_Click;
            btnregistrar.Click -= btnregistrar_Click;
            btnregistrar.Click += btnregistrar_Click;
        }

        // ---------- CARGA INICIAL ----------
        private void Gestio_Load(object sender, EventArgs e)
        {
            cbotipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipo.Items.AddRange(new object[] { "Notebook", "PC de escritorio", "Impresora", "Monitor", "Tablet", "Otro" });

            cbovendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbovendedor.Items.AddRange(new object[] { "Daniela", "Esteban", "Marcos" , "María" , "Pablo" });

           
            

            txtdetalles.Multiline = true;
            txtdiagnostico.Multiline = true;

            dtpfecha.Format = DateTimePickerFormat.Long;
            dtphora.Format = DateTimePickerFormat.Time;
            dtphora.ShowUpDown = true;

            txtnumero.ReadOnly = true;
            txtnumero.Text = contador.ToString("0000");
            lblfactura.Text = "Factura:";

            tabControl1.SelectedIndex = 0;
            tabPage2.Enabled = false; // se habilita al registrar los datos generales
        }

        // ---------- BOTÓN REGISTRAR (pestaña 1) ----------
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text)) { Aviso("Ingrese el nombre.", txtnombre); return; }
            if (string.IsNullOrWhiteSpace(txtapellido.Text)) { Aviso("Ingrese el apellido.", txtapellido); return; }
            if (txttelefono.Text.Trim().Length < 6) { Aviso("Ingrese un teléfono válido.", txttelefono); return; }
            if (!MailValido(txtmail.Text)) { Aviso("Ingrese un mail válido.", txtmail); return; }
            if (cbotipo.SelectedIndex < 0) { Aviso("Seleccione el tipo de equipo.", cbotipo); return; }
            if (string.IsNullOrWhiteSpace(txtmarca.Text)) { Aviso("Ingrese la marca.", txtmarca); return; }
            if (string.IsNullOrWhiteSpace(txtserie.Text)) { Aviso("Ingrese el número de serie.", txtserie); return; }

            clienteActual = new Cliente
            {
                Nombre = txtnombre.Text.Trim(),
                Apellido = txtapellido.Text.Trim(),
                Telefono = txttelefono.Text.Trim(),
                Mail = txtmail.Text.Trim()
            };
            equipoActual = new Equipo
            {
                Tipo = cbotipo.Text,
                Marca = txtmarca.Text.Trim(),
                Serie = txtserie.Text.Trim(),
                Detalles = txtdetalles.Text.Trim()
            };

            MessageBox.Show("Datos generales registrados. Complete el ticket.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabPage2.Enabled = true;
            tabControl1.SelectedTab = tabPage2;
        }

        // ---------- BOTÓN REGISTRAR (pestaña 2: Ticket) ----------
        private void btnregistrar2_Click(object sender, EventArgs e)
        {
            if (clienteActual == null) { Aviso("Primero registre los datos generales.", null); tabControl1.SelectedTab = tabPage1; return; }
            if (cbovendedor.SelectedIndex < 0) { Aviso("Seleccione el vendedor.", cbovendedor
                ); return; }
            if (string.IsNullOrWhiteSpace(txtdiagnostico.Text)) { Aviso("Ingrese el diagnóstico.", txtdiagnostico); return; }
       
            if (!decimal.TryParse(txtpresupuesto.Text, out decimal presupuesto) || presupuesto <= 0)
            { Aviso("Ingrese un presupuesto válido.", txtpresupuesto); return; }

            var t = new Ticket
            {
                Numero = contador,
                Cliente = clienteActual,
                Equipo = equipoActual,
                Vendedor = cbovendedor.Text,
                FechaHora = dtpfecha.Value.Date + dtphora.Value.TimeOfDay,
                Diagnostico = txtdiagnostico.Text.Trim(),
                Estado = txtdiagnostico.Text,
                Presupuesto = presupuesto
            };
            tickets.Add(t);

            lblfactura.Text = $"Factura: F-{t.Numero:0000}  Total: {presupuesto:C2}";

            MessageBox.Show(
                $"Ticket N° {t.Numero:0000} registrado\n\n" +
                $"Cliente: {t.Cliente.Apellido}, {t.Cliente.Nombre}\n" +
                $"Equipo: {t.Equipo.Tipo} {t.Equipo.Marca}\n" +
                $"Estado: {t.Estado}\n" +
                $"Presupuesto: {presupuesto:C2}",
                "Ticket registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            contador++;
            LimpiarTodo();
        }

        // ---------- AUXILIARES ----------
        private void Aviso(string msg, Control c)
        {
            MessageBox.Show(msg, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c?.Focus();
        }

        private static bool MailValido(string mail)
        {
            try { return new MailAddress(mail.Trim()).Address == mail.Trim(); }
            catch { return false; }
        }

        private void LimpiarTodo()
        {
            foreach (var t in new TextBox[] { txtnombre, txtapellido, txttelefono, txtmail,
                                              txtmarca, txtserie, txtdetalles, txtdiagnostico, txtpresupuesto })
                t.Clear();

            cbotipo.SelectedIndex = -1;
            cbovendedor.SelectedIndex = -1;
           
            dtpfecha.Value = DateTime.Now;
            dtphora.Value = DateTime.Now;
            txtnumero.Text = contador.ToString("0000");

            clienteActual = null;
            equipoActual = null;
            tabPage2.Enabled = false;
            tabControl1.SelectedTab = tabPage1;
            txtnombre.Focus();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !tb.Text.Contains(',') && !tb.Text.Contains('.')) return;
            e.Handled = true;
        }
    }
}