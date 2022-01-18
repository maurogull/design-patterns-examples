using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyEjemplo
{
    public partial class frmPrincipal : Form
    {
        List<Trabajador> trabajadores;
        List<Trabajo> trabajos;
        AsignadorTrabajos at;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            trabajadores = new List<Trabajador>();
            trabajos = new List<Trabajo>();

            trabajos.Add(new Trabajo("Pintar paredes"));
            trabajos.Add(new Trabajo("Arreglar techo"));
            trabajos.Add(new Trabajo("Limpiar horno"));
            trabajos.Add(new Trabajo("Limpiar inodoro"));
            trabajos.Add(new Trabajo("Limpiar bañera"));
            trabajos.Add(new Trabajo("Sacar la basura"));

            trabajadores.Add(new Trabajador("Pepe"));
            trabajadores.Add(new Trabajador("María"));
            trabajadores.Add(new Trabajador("Roberto"));


            at = new AsignadorTrabajos();
            at.SetTrabajos(trabajos);
            at.SetTrabajadores(trabajadores);

            lstTrabajos.Items.AddRange(trabajos.ToArray());
            lstTrabajadores.Items.AddRange(trabajadores.ToArray());

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (rbEstrategia1.Checked) at.SetEstrategia(new AsignacionAlAzarStrategy());
            if (rbEstrategia2.Checked) at.SetEstrategia(new AsignacionEquitativaStrategy());

            var asignaciones = new Dictionary<Trabajo,Trabajador>();
            asignaciones = at.Asignar();

            lstResultados.Items.Clear();
            foreach (var a in asignaciones)
            {
                lstResultados.Items.Add(a.Key + " : " + a.Value);
            }

        }
    }
}
