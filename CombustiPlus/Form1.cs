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
    }
}
