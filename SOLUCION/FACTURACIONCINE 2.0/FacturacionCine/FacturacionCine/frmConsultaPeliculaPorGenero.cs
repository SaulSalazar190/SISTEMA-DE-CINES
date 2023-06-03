using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FacturacionCine
{
    public partial class frmConsultaPeliculaPorGenero : MaterialForm
    {
        public frmConsultaPeliculaPorGenero()
        {
            InitializeComponent();
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void frmConsultaPeliculaPorGenero_Load(object sender, EventArgs e)
        {
            cboGenero.DataSource = bd.GENERO.Where(p => p.BHABILITADO.Equals(true)).ToList();
            cboGenero.DisplayMember = "NOMBRE";
            cboGenero.ValueMember = "IDGENERO";
            listar();
            dgvPelicula.Columns[0].Width = 200;
            dgvPelicula.Columns[1].Width = 200;
            dgvPelicula.Columns[2].Width = 200;
            dgvPelicula.Columns[3].Width = 200;
        }
        private void listar()
        {
            dgvPelicula.DataSource = (from pelicula in bd.PELICULA
                                      join genero in bd.GENERO
                                      on pelicula.IDGENERO equals
                                      genero.IDGENERO
                                      join pais in bd.PAIS
                                      on pelicula.IDPAIS equals
                                      pais.IDPAIS
                                      where pelicula.BHABILITADO.Equals(true)
                                      select new
                                      {
                                          Titulo = pelicula.TITULO,
                                          FechaEstreno = pelicula.FECHAESTRENO,
                                          NombreGenero = genero.NOMBRE,
                                          NombrePais = pais.NOMBRE
                                      }).ToList();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int idGenero = ((GENERO)cboGenero.SelectedItem).IDGENERO;
            dgvPelicula.DataSource = (from pelicula in bd.PELICULA
                                      join genero in bd.GENERO
                                      on pelicula.IDGENERO equals
                                      genero.IDGENERO
                                      join pais in bd.PAIS
                                      on pelicula.IDPAIS equals
                                      pais.IDPAIS
                                      where pelicula.BHABILITADO.Equals(true)
                                           && pelicula.IDGENERO.Equals(idGenero)
                                      select new
                                      {
                                          Titulo = pelicula.TITULO,
                                          FechaEstreno = pelicula.FECHAESTRENO,
                                          NombreGenero = genero.NOMBRE,
                                          NombrePais = pais.NOMBRE
                                      }).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
