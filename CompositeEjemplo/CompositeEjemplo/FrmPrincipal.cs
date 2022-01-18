using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompositeEjemplo
{
    public partial class FrmPrincipal : Form
    {
        List<IParticipante> participantes;
        List<GrupoEstudiantes> grupos;

        public FrmPrincipal()
        {
            InitializeComponent();

            participantes = new List<IParticipante>();
            participantes.Add(new Estudiante("Pepe", 7.0));
            participantes.Add(new Estudiante("María", 9.5));
            participantes.Add(new Estudiante("Josefina", 4.0));
            participantes.Add(new Estudiante("Roberto", 5.0));

            grupos = new List<GrupoEstudiantes>();

            ActualizarListas();
            clbParticipantes.CheckOnClick = true;
            
        }

        private void ActualizarListas()
        {
            clbParticipantes.Items.Clear();
            clbParticipantes.Items.AddRange(participantes.ToArray());

            lbGrupos.Items.Clear();
            lbGrupos.Items.AddRange(grupos.ToArray());
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if(txtNombreGrupo.Text.Length<1)
            {
                MessageBox.Show("Ingrese un nombre para el nuevo grupo");
                txtNombreGrupo.Focus();
                return;
            }

            GrupoEstudiantes nuevo = new GrupoEstudiantes(txtNombreGrupo.Text);
            foreach(IParticipante p in clbParticipantes.CheckedItems)
            {
                nuevo.agregarParticipante(p);
            }

            participantes.Add(nuevo);
            grupos.Add(nuevo);

            ActualizarListas();
            txtNombreGrupo.Text = "";
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if(lbGrupos.SelectedItem==null)
            {
                MessageBox.Show("Seleccione un grupo para ver su promedio");
                return;
            }

            GrupoEstudiantes aux = (GrupoEstudiantes) lbGrupos.SelectedItem;
            MessageBox.Show(aux.getPromedio().ToString());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
