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
    }
}