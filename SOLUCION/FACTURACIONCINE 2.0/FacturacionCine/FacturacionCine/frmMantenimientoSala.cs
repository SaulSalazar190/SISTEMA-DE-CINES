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
    public partial class frmMantenimientoSala : Form
    {
        public frmMantenimientoSala()
        {
            InitializeComponent();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            frmPopupSala ofrmPopupSala = new frmPopupSala();
            ofrmPopupSala.accion = "Nuevo";
            ofrmPopupSala.ShowDialog();
            if (ofrmPopupSala.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            frmPopupSala ofrmPopupSala = new frmPopupSala();
            ofrmPopupSala.accion = "Editar";
            ofrmPopupSala.id = dgvSala.CurrentRow.Cells[0].Value.ToString();
            ofrmPopupSala.ShowDialog();
            if (ofrmPopupSala.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void listar()
        {
            dgvSala.DataSource = (from sala in bd.SALA
                                  join cine in bd.CINE
                                  on sala.IDCINE equals cine.IDCINE
                                  where sala.BHABILITADO.Equals(1)
                                  select new
                                  {
                                      sala.IDSALA,
                                      cine.NOMBRE,
                                      sala.NUMBUTACAS,
                                      sala.NUMEROCOLUMNAS,
                                      sala.NUMEROFILAS
                                  }).ToList();
        }
        private void frmMantenimientoSala_Load(object sender, EventArgs e)
        {
            listar();
            cbonombre.DataSource = bd.CINE.ToList();
            cbonombre.DisplayMember = "NOMBRE";
            cbonombre.ValueMember = "IDCINE";
            dgvSala.Columns[0].Width = 100;
            dgvSala.Columns[1].Width = 150;
            dgvSala.Columns[2].Width = 150;
            dgvSala.Columns[3].Width = 150;
        }

        private void filtrar(object sender, EventArgs e)
        {
            int idcine = int.Parse(cbonombre.SelectedValue.ToString());
            dgvSala.DataSource = (from sala in bd.SALA
                                  join cine in bd.CINE
                                  on sala.IDCINE equals cine.IDCINE
                                  where sala.BHABILITADO.Equals(1) && sala.IDCINE.Equals(idcine)
                                  select new
                                  {
                                      sala.IDSALA,
                                      cine.NOMBRE,
                                      sala.NUMBUTACAS,
                                      sala.NUMEROCOLUMNAS,
                                      sala.NUMEROFILAS
                                  }).ToList();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string id = dgvSala.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                var consulta = bd.SALA.Where(p => p.IDSALA.Equals(id));
                foreach (SALA osala in consulta)
                {
                    osala.BHABILITADO = false;
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
