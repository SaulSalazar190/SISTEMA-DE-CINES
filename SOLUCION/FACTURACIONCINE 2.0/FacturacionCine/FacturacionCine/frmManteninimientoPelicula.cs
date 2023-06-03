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
    public partial class frmManteninimientoPelicula : Form
    {
        public frmManteninimientoPelicula()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmPopupPelicula ofrmPopupPelicula = new frmPopupPelicula();
            ofrmPopupPelicula.accion = "Nuevo";
            ofrmPopupPelicula.ShowDialog();
            if (ofrmPopupPelicula.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmPopupPelicula ofrmPopupPelicula = new frmPopupPelicula();
            ofrmPopupPelicula.accion = "Editar";
            ofrmPopupPelicula.id = dgvPelicula.CurrentRow.Cells[0].Value.ToString();
            ofrmPopupPelicula.ShowDialog();
            if (ofrmPopupPelicula.DialogResult.Equals(DialogResult.OK))
            {
                listar();
            }
        }

        private void dgvPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManteninimientoPelicula_Load(object sender, EventArgs e)
        {
            listar();
            dgvPelicula.Columns[1].Width = 150;
            dgvPelicula.Columns[2].Width = 150;
            dgvPelicula.Columns[3].Width = 225;
            dgvPelicula.Columns[4].Width = 150;
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void listar()
        {
            dgvPelicula.DataSource = bd.PELICULA.Where(p => p.BHABILITADO.Equals(1)).Select(p =>
                new
                {
                    p.IDPELICULA,
                    p.TITULO,
                    p.FECHAESTRENO,
                    p.SINOPSIS,
                    p.DURACION
                }).ToList();
        }

        private void filtrar(object sender, EventArgs e)
        {
            dgvPelicula.DataSource = bd.PELICULA.Where(p => p.BHABILITADO.Equals(1) && p.TITULO.Contains(txtnombre.Text)).Select(p =>
             new
             {
                 p.IDPELICULA,
                 p.TITULO,
                 p.FECHAESTRENO,
                 p.SINOPSIS,
                 p.DURACION
             }).ToList();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            string id = dgvPelicula.CurrentRow.Cells[0].Value.ToString();
            var consulta = bd.PELICULA.Where(p => p.IDPELICULA.Equals(id));
            if (MessageBox.Show("Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                foreach (PELICULA item in consulta)
                {
                    item.BHABILITADO = false;
                }
                try
                {
                    bd.SubmitChanges();
                    listar();
                    MessageBox.Show("Se elimino el registro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");

                }
            }
        }
    }
}
