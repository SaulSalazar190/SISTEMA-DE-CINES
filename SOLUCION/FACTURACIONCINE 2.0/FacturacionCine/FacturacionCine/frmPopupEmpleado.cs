using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionCine
{
    public partial class frmPopupEmpleado : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        public frmPopupEmpleado()
        {
            InitializeComponent();
        }

        PruebaDataContext bd = new PruebaDataContext();
        private void frmPopupEmpleado_Load(object sender, EventArgs e)
        {
            cboTipoEmpleado.DataSource = bd.TIPOEMPLEADO.ToList();
            cboTipoEmpleado.DisplayMember = "NOMBRE";
            cboTipoEmpleado.ValueMember = "IDTIPOEMPLEADO";
            cboTipoModalidad.DataSource = bd.TIPOMODALIDAD.ToList();
            cboTipoModalidad.DisplayMember = "NOMBRE";
            cboTipoModalidad.ValueMember = "IDTIPOMODALIDAD";
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Ingrese empleado";
            }
            else
            {
                this.Text = "Actualice empleado";
                var consulta = bd.EMPLEADO.Where(p => p.IDEMPLEADO.Equals(id));
                foreach (EMPLEADO emp in consulta)
                {
                    txtnombre.Text = emp.NOMBREEMPLEADO;
                    txtapellidopaterno.Text = emp.APPATERNO;
                    txtapellidomaterno.Text = emp.APMATERNO;
                    txtsueldo.Text = emp.SUELDO.ToString();
                    txtfechainicio.Value = DateTime.Parse(emp.FECHAINICIO.ToString());
                    cboTipoModalidad.SelectedValue = emp.IDTIPOMODALIDAD;
                    cboTipoEmpleado.SelectedValue = emp.IDTIPOEMPLEADO;
                    txtusuario.Text = emp.USUARIO;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Equals(""))
            {
                errorDato.SetError(txtnombre, "Debio ingresaer nombre");

                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtnombre, "");

            }

            if (txtapellidopaterno.Text.Equals(""))
            {
                errorDato.SetError(txtapellidopaterno, "Debio ingresaer apellido paterno");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtapellidopaterno, "");

            }

            if (txtapellidomaterno.Text.Equals(""))
            {
                errorDato.SetError(txtapellidomaterno, "Debio ingresaer apellido materno");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtapellidomaterno, "");

            }

            if (txtusuario.Text.Equals(""))
            {
                errorDato.SetError(txtusuario, "Debio ingresaer usuario");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtapellidomaterno, "");

            }

            if (txtsueldo.Text.Equals(""))
            {
                errorDato.SetError(txtsueldo, "Debio ingresaer  sueldo");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtsueldo, "");

            }
            string nombre = txtnombre.Text;
            string apellidoPaterno = txtapellidopaterno.Text;
            string apellidoMaterno = txtapellidomaterno.Text;
            decimal sueldo = decimal.Parse(txtsueldo.Text);
            DateTime fechaInicio = txtfechainicio.Value;
            int idTipoModalidad = int.Parse(cboTipoModalidad.SelectedValue.ToString());
            int idTipoEMpleado = int.Parse(cboTipoEmpleado.SelectedValue.ToString());
            string usuario = txtusuario.Text;

            string clave = txtcontraseña.Text;
            ////Cifrar la contraseña
            SHA256Managed oSHA256Managed = new SHA256Managed();
            byte[] bufferCadena = Encoding.Default.GetBytes(clave);
            byte[] bufferCadenaCifrada = oSHA256Managed.ComputeHash(bufferCadena);
            //esta variable se guarda en base de datos
            string dataCifrada = BitConverter.ToString(bufferCadenaCifrada).Replace("-", "");

            if (accion.Equals("Nuevo"))
            {
                //flopez   //FLOPEZ
                //FLOPEZ  //FLOPEZ
                var consulta = bd.EMPLEADO.Where(p => p.USUARIO.ToUpper().Equals(usuario.ToUpper()));
                int nveces = consulta.Count();
                if (nveces > 0)
                {
                    MessageBox.Show("Ya existe el usuario");
                    this.DialogResult = DialogResult.None;
                    return;
                }
                if (txtcontraseña.Text.Equals(""))
                {
                    errorDato.SetError(txtcontraseña, "Debio ingresaer  contraseña");
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else
                {
                    errorDato.SetError(txtcontraseña, "");
                }
                EMPLEADO emp = new EMPLEADO
                {
                    NOMBREEMPLEADO = nombre,
                    APMATERNO = apellidoMaterno,
                    APPATERNO = apellidoPaterno,
                    SUELDO = sueldo,
                    FECHAINICIO = fechaInicio,
                    IDTIPOMODALIDAD = idTipoModalidad,
                    IDTIPOEMPLEADO = idTipoEMpleado,
                    USUARIO = usuario,
                    CONTRA = dataCifrada,
                    BHABILITADO = true
                };
                bd.EMPLEADO.InsertOnSubmit(emp);
                //Confirmar los cambios
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
                var consulta = bd.EMPLEADO.Where(p => p.IDEMPLEADO.Equals(id));
                foreach (EMPLEADO emp in consulta)
                {
                    emp.NOMBREEMPLEADO = nombre;
                    emp.APPATERNO = apellidoPaterno;
                    emp.APMATERNO = apellidoMaterno;
                    emp.SUELDO = sueldo;
                    emp.FECHAINICIO = fechaInicio;
                    emp.USUARIO = usuario;
                    emp.IDTIPOEMPLEADO = idTipoEMpleado;
                    emp.IDTIPOMODALIDAD = idTipoModalidad;
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
