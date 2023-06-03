using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionCine
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoCliente ofrmMantenimientoCliente = new frmMantenimientoCliente();
            ofrmMantenimientoCliente.ShowDialog();
        }

        private void cineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoCine ofrmMantenimientoCine = new frmMantenimientoCine();
            ofrmMantenimientoCine.ShowDialog();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManteninimientoPelicula ofrmManteninimientoPelicula = new frmManteninimientoPelicula();
            ofrmManteninimientoPelicula.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoSala ofrmMantenimientoSala = new frmMantenimientoSala();
            ofrmMantenimientoSala.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoEmpleado ofrmMantenimientoEmpleado = new frmMantenimientoEmpleado();
            ofrmMantenimientoEmpleado.ShowDialog();
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoFuncion OfrmMantenimientoFuncion = new frmMantenimientoFuncion();
            OfrmMantenimientoFuncion.ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoReserva ofrmProcesoReserva = new frmProcesoReserva();
            ofrmProcesoReserva.ShowDialog(); 
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservaPorEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpleado ofrmConsultaEmpleado = new frmConsultaEmpleado();
            ofrmConsultaEmpleado.ShowDialog();
        }

        private void peliculaPorGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPeliculaPorGenero ofrmConsultaPeliculaPorGenero = new frmConsultaPeliculaPorGenero();
            ofrmConsultaPeliculaPorGenero.ShowDialog();
        }

        private void reservaPorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaReservaCliente ofrmConsultaReservaCliente = new frmConsultaReservaCliente();
            ofrmConsultaReservaCliente.ShowDialog();
        }

        private void reportePaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisReporte PaisReporte1 = new PaisReporte();
            PaisReporte1.ShowDialog();
        }

        private void reporteEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosReportes EmpleadosReportes1 = new EmpleadosReportes();
            EmpleadosReportes1.ShowDialog();
        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteReporte ClienteReporte1 = new ClienteReporte();
            ClienteReporte1.ShowDialog();
        }
    }
}
