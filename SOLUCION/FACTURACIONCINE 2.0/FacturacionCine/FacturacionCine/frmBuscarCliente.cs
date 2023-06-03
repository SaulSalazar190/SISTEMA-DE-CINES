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
    public partial class frmBuscarCliente : Form
    {
        public string id { get; set; }
        public string nombreCompleto { get; set; }
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        PruebaDataContext bd = new PruebaDataContext();
        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)).
                Select(
                x => new
                {
                    x.IDCLIENTE,
                    x.DNICLIENTE,
                    x.NOMBRE,
                    x.APPATERNO,
                    x.APMATERNO,
                    x.TELEFONOCELULAR
                }


                ).ToList();
            dgvCliente.Columns[2].Width = 150;
            dgvCliente.Columns[1].HeaderText = "DUI";
            dgvCliente.Columns[3].Width = 150;
            dgvCliente.Columns[4].Width = 150;
            dgvCliente.Columns[5].Width = 150;
        }

        private void filtrarDNI(object sender, EventArgs e)
        {
            string dni = txtdni.Text;
            dgvCliente.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)
            && p.DNICLIENTE.Contains(dni)).
                Select(
                x => new
                {
                    x.IDCLIENTE,
                    x.DNICLIENTE,
                    x.NOMBRE,
                    x.APPATERNO,
                    x.APMATERNO,
                    x.TELEFONOCELULAR
                }


                ).ToList();
        }

        private void filtrarApellido(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;
            dgvCliente.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)
            && (p.APPATERNO.Contains(apellido) || p.APMATERNO.Contains(apellido)))
               .Select(
               x => new
               {
                   x.IDCLIENTE,
                   x.DNICLIENTE,
                   x.NOMBRE,
                   x.APPATERNO,
                   x.APMATERNO,
                   x.TELEFONOCELULAR
               }

               ).ToList();
        }

        private void mostrarDatos(object sender, EventArgs e)
        {
            id = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            nombreCompleto = dgvCliente.CurrentRow.Cells[2].Value.ToString() + " " +
                dgvCliente.CurrentRow.Cells[3].Value.ToString() + " " +
                dgvCliente.CurrentRow.Cells[4].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
