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
    public partial class frmPopupPelicula : Form
    {
        public string accion { get; set; }
        public string id { get; set; }

        public frmPopupPelicula()
        {
            InitializeComponent();
        }

        PruebaDataContext bd = new PruebaDataContext();
        private void frmPopupPelicula_Load(object sender, EventArgs e)
        {
            cboGenero.DataSource = bd.GENERO.ToList();
            cboGenero.DisplayMember = "NOMBRE";
            cboGenero.ValueMember = "IDGENERO";
            cboPais.DataSource = bd.PAIS.ToList();
            cboPais.DisplayMember = "NOMBRE";
            cboPais.ValueMember = "IDPAIS";
            cboTipoCensura.DataSource = bd.TIPOCENSURA.ToList();
            cboTipoCensura.DisplayMember = "NOMBRE";
            cboTipoCensura.ValueMember = "IDTIPOCENSURA";
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese pelicula";
            }
            else
            {
                this.Text = "Actualice pelicula";
                var consulta = bd.PELICULA.Where(p => p.IDPELICULA.Equals(id));
                foreach (PELICULA pel in consulta)
                {
                    txtIdPelicula.Text = pel.IDPELICULA.ToString();
                    txttitulo.Text = pel.TITULO;
                    txtfecha.Value = DateTime.Parse(pel.FECHAESTRENO.ToString());
                    cboGenero.SelectedValue = pel.IDGENERO;
                    cboPais.SelectedValue = pel.IDPAIS;
                    txtsinopsis.Text = pel.SINOPSIS;
                    txtduracion.Text = pel.DURACION.ToString();
                    cboTipoCensura.SelectedValue = pel.IDTIPOCENSURA;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string titulo = txttitulo.Text;
            if (titulo.Equals(""))
            {
                errorDato.SetError(txttitulo, "Ingrese titulo");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txttitulo, "");
            }

            DateTime fecha = txtfecha.Value;
            int idgenero = int.Parse(cboGenero.SelectedValue.ToString());
            int idpais = int.Parse(cboPais.SelectedValue.ToString());
            string sinopsis = txtsinopsis.Text;
            if (sinopsis.Equals(""))
            {
                errorDato.SetError(txtsinopsis, "Ingrese sinopsis");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txttitulo, "");
            }
            if (txtduracion.Equals(""))
            {
                errorDato.SetError(txtsinopsis, "Ingrese duracion");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtsinopsis, "");
            }
            int duracion = int.Parse(txtduracion.Text);
            int idTipoCensura = int.Parse(cboTipoCensura.SelectedValue.ToString());
            if (accion.Equals("Nuevo"))
            {
                PELICULA opelicula = new PELICULA()
                {
                    TITULO = titulo,
                    FECHAESTRENO = fecha.ToString(),
                    IDGENERO = idgenero,
                    IDPAIS = idpais,
                    SINOPSIS = sinopsis,
                    DURACION = duracion,
                    IDTIPOCENSURA = idTipoCensura,
                    BHABILITADO = true
                };
                bd.PELICULA.InsertOnSubmit(opelicula);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurro un error");
                }
            }
            else
            {
                int id = int.Parse(txtIdPelicula.Text);
                var consulta = bd.PELICULA.Where(p => p.IDPELICULA.Equals(id));
                foreach (PELICULA pel in consulta)
                {
                    pel.TITULO = titulo;
                    pel.FECHAESTRENO = fecha.ToString();
                    pel.IDGENERO = idgenero;
                    pel.IDPAIS = idpais;
                    pel.SINOPSIS = sinopsis;
                    pel.DURACION = duracion;
                    pel.IDTIPOCENSURA = idTipoCensura;
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");

                }


            }
        }
    }
}
