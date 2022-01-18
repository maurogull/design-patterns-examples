using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StateEjemplo
{
    public partial class FrmPrincipal : Form
    {
        Avion[] aviones = new Avion[3];
        int avionSeleccionado = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            aviones[0] = new Avion();
            aviones[1] = new Avion();
            aviones[2] = new Avion();
        }


        private void btnEstado1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aviones[0].GetEstado());
        }

        private void btnEstado2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aviones[1].GetEstado());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aviones[2].GetEstado());
        }


        private void rbAvion1_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionAvion();
        }

        private void rbAvion2_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionAvion();
        }

        private void rbAvion3_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionAvion();
        }

        private void SeleccionAvion()
        {
            if (rbAvion1.Checked) avionSeleccionado = 0;
            if (rbAvion2.Checked) avionSeleccionado = 1;
            if (rbAvion3.Checked) avionSeleccionado = 2;
        }

        private void btnEnviarPuerta_Click(object sender, EventArgs e)
        {
            try
            {
                aviones[avionSeleccionado].PonerAvionEnPuerta(Int32.Parse(txtPuerta.Text));
                txtPuerta.Text = "";
                MessageBox.Show("Operacion correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Se produjo una excepcion de tipo "+ ex.GetType());
            }
        }

        private void btnCerrarAvion_Click(object sender, EventArgs e)
        {
            try
            {
                aviones[avionSeleccionado].CerrarAvion();
                MessageBox.Show("Operacion correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Se produjo una excepcion de tipo " + ex.GetType());
            }
        }

        private void btnVerPasajeros_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pasajero> pasajeros = aviones[avionSeleccionado].GetPasajeros();
                string aux = pasajeros.Count + " pasajeros: ";
                foreach (Pasajero p in pasajeros) aux += p + "  ";
                MessageBox.Show(aux);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Se produjo una excepcion de tipo " + ex.GetType());
            }
        }

        private void btnDespegar_Click(object sender, EventArgs e)
        {
            try
            {
                aviones[avionSeleccionado].DespegarAvion();
                MessageBox.Show("Operacion correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Se produjo una excepcion de tipo " + ex.GetType());
            }
        }

        private void btnAterrizar_Click(object sender, EventArgs e)
        {
            try
            {
                aviones[avionSeleccionado].AterrizarAvion();
                MessageBox.Show("Operacion correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Se produjo una excepcion de tipo " + ex.GetType());
            }
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                aviones[avionSeleccionado].AgregarPasajero(new Pasajero(txtNombrePasajero.Text));
                txtNombrePasajero.Text = "";
                MessageBox.Show("Operacion correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Se produjo una excepcion de tipo " + ex.GetType());
            }
        }

 

    }
}
