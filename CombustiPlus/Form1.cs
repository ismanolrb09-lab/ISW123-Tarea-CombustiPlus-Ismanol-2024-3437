using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        private List<Despacho> despachos = new List<Despacho>();

        public Form1()
        {
            InitializeComponent();

            // R1- pa ra llenar los ComboBox
            cmbCombustible.Items.Add("Premium");
            cmbCombustible.Items.Add("Regular");
            cmbCombustible.Items.Add("Gasoil");
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Tarjeta");
            cmbCombustible.SelectedIndex = 0;
            cmbPago.SelectedIndex = 0;
        }
        //R3: validaciones con los  if
        private bool Validar()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres.");
                return false;
            }
            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0.");
                return false;
            }
            return true;
        }

        // R4:precio con un switch
        private decimal PrecioPorGalon(string combustible)
        {
            decimal precio = 0m;

            switch (combustible)
            {
                case "Premium":
                    precio = 290.00m;
                    break;

                case "Regular":
                    precio = 272.00m;
                    break;

                case "Gasoil":
                    precio = 225.00m;
                    break;
            }
            return precio;
        }

        //Calcula el total y muestra ssu paso a oaso en el lstDetalle
        private decimal Calcular()
        {
            string combustible = cmbCombustible.Text;
            string pago = cmbPago.Text;
            decimal galones = nudGalones.Value;
            decimal precio = PrecioPorGalon(combustible);

            decimal subtotal = galones * precio;

            // Regla 3 descuento 2% si son 20 galones o mas
            decimal descuento = 0m;
            if (galones >= 20)
            {
                descuento = subtotal * 0.02m;
            }
            decimal conDescuento = subtotal - descuento;

            //Reglas 4 y 5 recargo 3% con tarjeta y despues del descuento
            decimal recargo = 0m;
            if (pago == "Tarjeta")
            {
                recargo = conDescuento * 0.03m;
            }

            decimal total = conDescuento + recargo;

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add("Combustible: " + combustible + " a RD$ " + precio.ToString("N2") + " por galón");
            lstDetalle.Items.Add("Galones: " + galones.ToString("N1"));
            lstDetalle.Items.Add("Subtotal: RD$ " + subtotal.ToString("N2"));

            if (galones >= 20) lstDetalle.Items.Add("Descuento 2%: - RD$ " + descuento.ToString("N2"));
            else lstDetalle.Items.Add("Descuento: no aplica (menos de 20 galones)");

            lstDetalle.Items.Add("Con descuento: RD$ " + conDescuento.ToString("N2"));

            if (pago == "Tarjeta") lstDetalle.Items.Add("Recargo tarjeta 3%: + RD$ " + recargo.ToString("N2"));
            else lstDetalle.Items.Add("Recargo: no aplica (efectivo)");

            lstDetalle.Items.Add("TOTAL: RD$ " + total.ToString("N2"));

            return total;
        }
        //R5
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            {
                if (!Validar()) return;
                Calcular();
            }
        }
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            
                if (!Validar()) return;

                decimal total = Calcular();

                Despacho d = new Despacho();
                d.Numero = despachos.Count + 1;
                d.Placa = txtPlaca.Text;
                d.Combustible = cmbCombustible.Text;
                d.Galones = nudGalones.Value;
                d.Pago = cmbPago.Text;
                d.Total = total;

                despachos.Add(d);
                lstDespachos.Items.Add(d.ToString());

                ActualizarResumen();
        }
        private void ActualizarResumen()
        {
            decimal totalVendido = 0m;
            decimal galonesTotales = 0m;
            Despacho mayor = null;

            foreach (Despacho d in despachos)
            {
                totalVendido += d.Total;
                galonesTotales += d.Galones;

                if (mayor == null || d.Total > mayor.Total)
                {
                    mayor = d;
                }
            }

            lblResumen.Text = despachos.Count + " despachos · Vendido RD$ " + totalVendido.ToString("N2")
            + " · Galones " + galonesTotales.ToString("N1")
            + " · Mayor: #" + mayor.Numero.ToString("00");
        }

        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> galonesPorCombustible = new Dictionary<string, decimal>();
            galonesPorCombustible["Regular"] = 0;
            galonesPorCombustible["Premium"] = 0;
            galonesPorCombustible["Gasoil"] = 0;

            foreach (Despacho d in despachos)
            {
                galonesPorCombustible[d.Combustible] += d.Galones;
            }

            lstDetalle.Items.Clear();
            foreach (KeyValuePair<string, decimal> par in galonesPorCombustible)
            {
                lstDetalle.Items.Add(par.Key + " " + par.Value.ToString("N1"));
            }
        }
    }
}



