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
    public partial class frmPopupSala : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        public frmPopupSala()
        {
            InitializeComponent();
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void frmPopupSala_Load(object sender, EventArgs e)
        {
            cbonombre.DataSource = bd.CINE.ToList();
            cbonombre.DisplayMember = "NOMBRE";
            cbonombre.ValueMember = "IDCINE";
            if (accion.Equals("Editar"))
            {
                var consulta = bd.SALA.Where(p => p.IDSALA.Equals(id));
                foreach (SALA osala in consulta)
                {
                    cbonombre.SelectedValue = osala.IDCINE;
                    txtnumerobutacas.Value = decimal.Parse(osala.NUMBUTACAS.ToString());
                    txtfila.Value = decimal.Parse(osala.NUMEROFILAS.ToString());
                    txtcolumna.Value = decimal.Parse(osala.NUMEROCOLUMNAS.ToString());
                    txtnombre.Text = osala.NOMBRE;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idcine = int.Parse(cbonombre.SelectedValue.ToString());
            int numeroButacas = int.Parse(txtnumerobutacas.Value.ToString());
            string nombre = txtnombre.Text;
            if (nombre.Equals(""))
            {
                errorDatos.SetError(txtnombre, "Nombre obligatorio");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDatos.SetError(txtnombre, "");
            }
            if (numeroButacas <= 0)
            {
                errorDatos.SetError(txtnumerobutacas, "El numero de butacas tieene que ser mayor 0");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDatos.SetError(txtnumerobutacas, "");

            }
            int numeroFilas = int.Parse(txtfila.Value.ToString());
            if (numeroFilas <= 0)
            {
                errorDatos.SetError(txtfila, "Numero de filas mayor 0");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDatos.SetError(txtfila, "");

            }
            int numeroColumnas = int.Parse(txtcolumna.Value.ToString());
            if (numeroColumnas <= 0)
            {
                errorDatos.SetError(txtcolumna, "Numero de columna mayor 0");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDatos.SetError(txtcolumna, "");

            }
            if (accion.Equals("Nuevo"))
            {
                SALA osala = new SALA()
                {
                    IDCINE = idcine,
                    NUMBUTACAS = numeroButacas,
                    NUMEROFILAS = numeroFilas,
                    NUMEROCOLUMNAS = numeroColumnas,
                    BHABILITADO = true,
                    NOMBRE = nombre
                };
                bd.SALA.InsertOnSubmit(osala);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");

                }
            }
            else
            {
                var consulta = bd.SALA.Where(p => p.IDSALA.Equals(id));
                foreach (SALA osala in consulta)
                {
                    osala.IDCINE = idcine;
                    osala.NUMBUTACAS = numeroButacas;
                    osala.NUMEROFILAS = numeroFilas;
                    osala.NUMEROCOLUMNAS = numeroColumnas;
                    osala.NOMBRE = nombre;
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
