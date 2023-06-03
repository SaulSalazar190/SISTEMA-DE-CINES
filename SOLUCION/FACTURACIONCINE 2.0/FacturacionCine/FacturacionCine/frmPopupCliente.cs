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
    public partial class frmPopupCliente : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        public frmPopupCliente()
        {
            InitializeComponent();
        }

        PruebaDataContext bd = new PruebaDataContext();
        private void frmPopupCliente_Load_1(object sender, EventArgs e)
        {
            cboSexo.DataSource = bd.SEXO.ToList();
            cboSexo.DisplayMember = "NOMBRE";
            cboSexo.ValueMember = "IDSEXO";
            if (accion.Equals("Nuevo")) 
            {
                this.Text = "INGRESE NUEVO CLIENTE";
            }
            else
            {
                //editar
                this.Text = "ACTUALICE CLIENTE";
                var consulta = bd.CLIENTE.Where(p => p.IDCLIENTE.Equals(id));
                foreach (CLIENTE cli in consulta)
                {
                    txtdni.Text = cli.DNICLIENTE.ToString();
                    txtnombre.Text = cli.NOMBRE;
                    txtapellidoPaterno.Text = cli.APPATERNO;
                    txtapellidoMaterno.Text = cli.APMATERNO;
                    txtfecha.Value = DateTime.Parse(cli.FECHANAC.ToString());
                    txtdireccion.Text = cli.DIRECCION;
                    txttelefonofijo.Text = cli.TELEFONOFIJO;
                    txttelefonocelular.Text = cli.TELEFONOCELULAR;
                    cboSexo.SelectedValue = cli.IDSEXO;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text.Equals(""))
            {
                errorDato.SetError(txtdni, "Ingrese DNI");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtdni, "");
            }


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


            if (txtapellidoPaterno.Text.Equals(""))
            {
                errorDato.SetError(txtapellidoPaterno, "Ingrese apellido paterno");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtapellidoPaterno, "");
            }

            if (txtapellidoMaterno.Text.Equals(""))
            {
                errorDato.SetError(txtapellidoMaterno, "Ingrese apellido materno");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorDato.SetError(txtapellidoMaterno, "");
            }

            string dni = txtdni.Text;
            string nombre = txtnombre.Text;
            string apellidoPaterno = txtapellidoPaterno.Text;
            string apellidoMaterno = txtapellidoMaterno.Text;
            DateTime fecha = txtfecha.Value;
            string direccion = txtdireccion.Text;
            string telefonoFijo = txttelefonofijo.Text;
            string telefonoCelular = txttelefonocelular.Text;
            int idSexo = int.Parse(cboSexo.SelectedValue.ToString());

            //si existe el dni en la BD ya no me deberia permite registrar 
            /*int numero = (bd.CLIENTE.Where(p => p.DNICLIENTE.Equals(dni))).Count();
            if (numero > 0)
            {
                MessageBox.Show("EL DNI ya existe en la base de datos");
                return;
            }*/
            if (accion.Equals("Nuevo"))
            {
                int numero = (bd.CLIENTE.Where(p => p.DNICLIENTE.Equals(dni))).Count();
                if (numero > 0)
                {
                    MessageBox.Show("EL DNI ya existe en la base de datos");
                    return;
                }
                CLIENTE cli = new CLIENTE()
                {
                    DNICLIENTE = dni,
                    NOMBRE = nombre,
                    APPATERNO = apellidoPaterno,
                    APMATERNO = apellidoMaterno,
                    FECHANAC = fecha,
                    DIRECCION = direccion,
                    TELEFONOFIJO = telefonoFijo,
                    TELEFONOCELULAR = telefonoCelular,
                    IDSEXO = idSexo,
                    BHABILITADO = true
                };
                bd.CLIENTE.InsertOnSubmit(cli);
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
                //Editar
                /*var consulta = bd.CLIENTE.Where(p => p.IDCLIENTE.Equals(id));
                foreach (CLIENTE cli in consulta)

                {
                    cli.DNICLIENTE = dni;
                    cli.NOMBRE = nombre;
                    cli.APPATERNO = apellidoPaterno;
                    cli.APMATERNO = apellidoMaterno;
                    cli.FECHANAC = fecha;
                    cli.DIRECCION = direccion;
                    cli.TELEFONOCELULAR = telefonoCelular;
                    cli.TELEFONOFIJO = telefonoFijo;
                    cli.IDSEXO = idSexo;
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se edito correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");

                }*/
                // Editar cliente existente
                var clienteExistente = bd.CLIENTE.FirstOrDefault(p => p.IDCLIENTE.Equals(id));
                if (clienteExistente != null && clienteExistente.DNICLIENTE != dni)
                {
                    // Verificar si el DNI ya existe en la base de datos (excepto el cliente actual que se está editando)
                    int numero = bd.CLIENTE.Count(p => p.DNICLIENTE == dni);
                    if (numero > 0)
                    {
                        MessageBox.Show("El DNI ya existe en la base de datos");
                        return;
                    }
                }

                clienteExistente.DNICLIENTE = dni;
                clienteExistente.NOMBRE = nombre;
                clienteExistente.APPATERNO = apellidoPaterno;
                clienteExistente.APMATERNO = apellidoMaterno;
                clienteExistente.FECHANAC = fecha;
                clienteExistente.DIRECCION = direccion;
                clienteExistente.TELEFONOCELULAR = telefonoCelular;
                clienteExistente.TELEFONOFIJO = telefonoFijo;
                clienteExistente.IDSEXO = idSexo;

                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se editó correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }
    }
}
