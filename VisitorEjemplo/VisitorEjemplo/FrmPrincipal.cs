using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorEjemplo
{
    public partial class FrmPrincipal : Form
    {
        private List<Figura> figuras;
        public FrmPrincipal()
        {
            InitializeComponent();

            figuras = new List<Figura>();
        }

        private void ActualizarListaElementos()
        {
            lbElementos.Items.Clear();
            lbElementos.Items.AddRange(figuras.ToArray());
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            figuras.Add(new Circulo(Decimal.Parse(txtRadio.Text)));
            ActualizarListaElementos();
            txtRadio.Text = "";
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            figuras.Add(new Rectangulo(Decimal.Parse(txtBase.Text), Decimal.Parse(txtAltura.Text)));
            ActualizarListaElementos();
            txtBase.Text = "";
            txtAltura.Text = "";
        }

        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            figuras.Add(new Triangulo(Decimal.Parse(txtBase.Text), Decimal.Parse(txtAltura.Text)));
            ActualizarListaElementos();
            txtBase.Text = "";
            txtAltura.Text = "";
        }

        private void lbElementos_DoubleClick(object sender, EventArgs e)
        {
            var aux = new CalculaSuperficieFigura();
            MessageBox.Show(aux.calcular((Figura) lbElementos.SelectedItem).ToString());
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            var aux = new ContadorTiposFigura();
            MessageBox.Show(aux.contar(figuras));
        }

        private void btnSuperficieTotal_Click(object sender, EventArgs e)
        {
            var aux = new CalculaSuperficieColeccionFiguras();
            MessageBox.Show(aux.calcular(figuras).ToString());
        }
    }


}
