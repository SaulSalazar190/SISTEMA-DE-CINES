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
    public partial class frmMantenimientoEmpleado : Form
    {
        public frmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmPopupEmpleado ofrmPopupEmpleado = new frmPopupEmpleado();
            ofrmPopupEmpleado.accion = "Nuevo";
            ofrmPopupEmpleado.ShowDialog();
            if (ofrmPopupEmpleado.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            frmPopupEmpleado ofrmPopupEmpleado = new frmPopupEmpleado();
            ofrmPopupEmpleado.accion = "Editar";
            ofrmPopupEmpleado.id = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            ofrmPopupEmpleado.lblcontra.Visible = false;
            ofrmPopupEmpleado.txtcontraseña.Visible = false;
            ofrmPopupEmpleado.ShowDialog();
            if (ofrmPopupEmpleado.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void listar()
        {
            dgvEmpleado.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(1)).Select(

                p => new
                {
                    p.IDEMPLEADO,
                    p.NOMBREEMPLEADO,
                    p.APPATERNO,
                    p.APMATERNO,
                    p.FECHAINICIO
                }).ToList();
        }

        private void frmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            listar();
            dgvEmpleado.Columns[0].Width = 150;
            dgvEmpleado.Columns[1].Width = 150;
            dgvEmpleado.Columns[2].Width = 150;
            dgvEmpleado.Columns[3].Width = 150;
            dgvEmpleado.Columns[4].Width = 150;
        }

        private void filtrar(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(1) && p.NOMBREEMPLEADO.Contains(txtnombre.Text)).Select(

               p => new
               {
                   p.IDEMPLEADO,
                   p.NOMBREEMPLEADO,
                   p.APPATERNO,
                   p.APMATERNO,
                   p.FECHAINICIO
               }).ToList();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.EMPLEADO.Where(p => p.IDEMPLEADO.Equals(id));
                foreach (EMPLEADO emp in consulta)
                {
                    emp.BHABILITADO = false;
                }
                try
                {
                    bd.SubmitChanges();
                    listar();
                    MessageBox.Show("Se elimino correctamente");
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
