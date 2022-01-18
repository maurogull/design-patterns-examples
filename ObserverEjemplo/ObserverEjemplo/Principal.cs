using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverEjemplo
{
    public partial class frmPrincipal : Form
    {
        Factura f;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            f = new Factura();
            f.agregarObservadorMontoTotal(txtTotal);
            f.agregarObservadorItems(lstItems);
            f.notificarObservadores();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            f.agregarItem(new Item(Decimal.Parse(txtIngreso.Text)));
            txtIngreso.Text = "";
            txtIngreso.Focus();
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            f.borrarItem((Item) lstItems.SelectedItem);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
