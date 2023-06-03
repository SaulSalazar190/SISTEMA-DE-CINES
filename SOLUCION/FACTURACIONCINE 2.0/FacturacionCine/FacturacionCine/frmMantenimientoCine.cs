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
    public partial class frmMantenimientoCine : Form
    {
        public frmMantenimientoCine()
        {
            InitializeComponent();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            frmPopupCine ofrmMantenimientoCine = new frmPopupCine();
            ofrmMantenimientoCine.accion = "Nuevo";
            ofrmMantenimientoCine.ShowDialog();
            if (ofrmMantenimientoCine.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            frmPopupCine ofrmMantenimientoCine = new frmPopupCine();
            ofrmMantenimientoCine.accion = "Editar";
            ofrmMantenimientoCine.id = dgvCIne.CurrentRow.Cells[0].Value.ToString();
            ofrmMantenimientoCine.ShowDialog();
            if (ofrmMantenimientoCine.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void frmMantenimientoCine_Load(object sender, EventArgs e)
        {
            listar();
            dgvCIne.Columns[0].Width = 200;
            dgvCIne.Columns[1].Width = 200;
            dgvCIne.Columns[2].Width = 200;
        }
        private void listar()
        {
            dgvCIne.DataSource = bd.CINE.Where(x => x.BHABILITADO.Equals(1)).Select(
                p => new
                {
                    p.IDCINE,
                    p.NOMBRE,
                    p.DIRECCION
                }

                ).ToList();
        }

        private void filtrar(object sender, EventArgs e)
        {
            dgvCIne.DataSource = bd.CINE.Where(x => x.BHABILITADO.Equals(1) && x.NOMBRE.Contains(txtnombre.Text)).Select(
              p => new
              {
                  p.IDCINE,
                  p.NOMBRE,
                  p.DIRECCION
              }

              ).ToList();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvCIne.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.CINE.Where(p => p.IDCINE.Equals(id));
                foreach (CINE ocine in consulta)
                {
                    ocine.BHABILITADO = 0;
                }
                try
                {
                    bd.SubmitChanges();
                    listar();
                    MessageBox.Show("Se elimino correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
        }
    }
}
