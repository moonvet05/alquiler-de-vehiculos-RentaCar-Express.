
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_RentaCar_Thomas
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0;

        public Form1()
        {
            InitializeComponent();

            btnAgregar.Click += btnAgregar_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // INICIAR FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            subtotal = 0;

            dtpSalida.Value = DateTime.Today;

            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            nudDias.Value = 1;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            chkGps.Checked = false;

            lstAlquileres.Items.Clear();

            lblEncabezado.Font = new Font("Consolas", 10);
            lstAlquileres.Font = new Font("Consolas", 10);

            lblEncabezado.Text =
                "Dias".PadRight(6) +
                "Vehiculos".PadRight(7) +
                "Tarifas".PadLeft(10) +
                "Total".PadLeft(12);

            MostrarResultados();
        }

        // AGREGAR VEHICULO
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal tarifa;

            if (textCliente.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca el nombre del cliente.");
                textCliente.Focus();
                return;
            }

            if (txtVehiculo.Text.Trim() == "" ||
                !decimal.TryParse(textTarifa.Text, out tarifa) ||
                tarifa <= 0)
            {
                MessageBox.Show("Introduzca un vehículo y una tarifa válida.");
                return;
            }

            int dias = (int)nudDias.Value;

            decimal tarifaDiaria = tarifa;

            string seguro = "Basico";

            if (rbtCompleto.Checked)
            {
                tarifaDiaria += 300;
                seguro = "FULL";
            }

            if (chkGps.Checked)
            {
                tarifaDiaria += 100;
            }

            decimal totalLinea = tarifaDiaria * dias;

            string vehiculo = txtVehiculo.Text.Trim()
                              + " (" + seguro + ")";

            if (chkGps.Checked)
            {
                vehiculo += " GPS";
            }

            string linea =
                dias.ToString().PadRight(6) +
                vehiculo.PadRight(15) +
                tarifaDiaria.ToString("N2").PadLeft(9) +
                totalLinea.ToString("N2").PadLeft(11);

            lstAlquileres.Items.Add(linea);

            subtotal += totalLinea;

            lblSubtotal.Text = "RD$ " + subtotal.ToString("N2");

            // LIMPIAR VEHICULO
            txtVehiculo.Clear();
            textTarifa.Clear();

            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;

            txtVehiculo.Focus();
        }

        // CALCULAR TOTAL
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar un vehículo.");
                return;
            }

            decimal descuento = subtotal * 0.15m;

            decimal domicilio = 0;

            if (rbtDomicilio.Checked)
            {
                domicilio = 500;
            }

            decimal baseImponible = subtotal - descuento + domicilio;

            decimal itbis = baseImponible * 0.18m;

            decimal total = baseImponible + itbis;

            lblSubtotal.Text = "RD$ " + subtotal.ToString("N2");
            lblDescuento.Text = "RD$ " + descuento.ToString("N2");
            lblDomicilio.Text = "RD$ " + domicilio.ToString("N2");
            lblITBIS.Text = "RD$ " + itbis.ToString("N2");
            lblTotal.Text = "RD$ " + total.ToString("N2");
        }

        // NUEVO ALQUILER
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textCliente.Clear();
            txtVehiculo.Clear();
            textTarifa.Clear();

            dtpSalida.Value = DateTime.Today;

            nudDias.Value = 1;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            chkGps.Checked = false;

            lstAlquileres.Items.Clear();

            subtotal = 0;

            MostrarResultados();

            textCliente.Focus();
        }

        // SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del programa?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        // MOSTRAR RESULTADOS
        private void MostrarResultados()
        {
            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblITBIS.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        // EVENTOS DEL DISEÑADOR
        private void textCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }
    }
}
