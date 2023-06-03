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
    public partial class frmPopupCine : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        public frmPopupCine()
        {
            InitializeComponent();
        }
        PruebaDataContext bd = new PruebaDataContext();
        private void frmPopupCine_Load(object sender, EventArgs e)
        {
            cboTipoCine.DataSource = bd.TIPOCINE.ToList();
            cboTipoCine.DisplayMember = "NOMBRE";
            cboTipoCine.ValueMember = "IDTIPOCINE";
            if (accion.Equals("Editar"))
            {
                this.Text = "Editar cine";
                var consulta = bd.CINE.Where(p => p.IDCINE.Equals(id));
                foreach (CINE ocine in consulta)
                {
                    txtid.Text = ocine.IDCINE.ToString();
                    txtnombre.Text = ocine.NOMBRE;
                    txtdireccion.Text = ocine.DIRECCION;
                    txtfechaapertura.Value = DateTime.Parse(ocine.FECHAAPERTURA.ToString());
                }
            }
            else
            {
                this.Text = "Agregar Cine";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Equals(""))
            {
                errorDato.SetError(txtnombre, "Ingrese nombre");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtnombre, "");
            }

            if (txtdireccion.Text.Equals(""))
            {
                errorDato.SetError(txtdireccion, "Ingrese direccion");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtdireccion, "");
            }

            string id = txtid.Text;
            string nombre = txtnombre.Text;
            int idTipoCine = int.Parse(cboTipoCine.SelectedValue.ToString());
            string direccion = txtdireccion.Text;
            DateTime fechaApertura = txtfechaapertura.Value;
            if (accion.Equals("Nuevo"))
            {
                int nveces = (bd.CINE.Where(p => p.NOMBRE.Equals(txtnombre.Text))).Count();
                if (nveces > 0)
                {
                    MessageBox.Show("Ya existe el cine");
                    return;
                }
                CINE ocine = new CINE()
                {
                    NOMBRE = nombre,
                    IDTIPOCINE = idTipoCine,
                    DIRECCION = direccion,
                    FECHAAPERTURA = fechaApertura,
                    BHABILITADO = 1
                };
                bd.CINE.InsertOnSubmit(ocine);
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
                var consulta = bd.CINE.Where(p => p.IDCINE.Equals(id));
                foreach (CINE ocine in consulta)
                {
                    ocine.NOMBRE = nombre;
                    ocine.IDTIPOCINE = idTipoCine;
                    ocine.DIRECCION = direccion;
                    ocine.FECHAAPERTURA = fechaApertura;
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se edito correctamnte");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }
    }
}
