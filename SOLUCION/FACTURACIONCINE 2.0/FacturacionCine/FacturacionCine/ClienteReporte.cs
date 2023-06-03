using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionCine
{
    public partial class ClienteReporte : Form
    {
        public string servidor, db;
        public string cadena;
        public SqlConnection conn;
        public ClienteReporte()
        {
            InitializeComponent();
        }

        private void ClienteReporte_Load(object sender, EventArgs e)
        {
            string servidor = "localhost";
            string db = "ReservaCine1";
            string cadena = "Data Source=" + servidor + ";Initial Catalog=" + db + ";Integrated Security=True";

            string username = Environment.UserName;

            conn = new SqlConnection(cadena);

            try
            {
                conn.Open();
                string sql = "SELECT IDCLIENTE, DNICLIENTE, NOMBRE, APPATERNO, APMATERNO, TELEFONOCELULAR FROM CLIENTE";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                SqlDataReader rdr = cmd.ExecuteReader();
                List<ClientesReportes> lrp = new List<ClientesReportes>();
                while (rdr.Read())
                {
                    ClientesReportes rp = new ClientesReportes();
                    rp.IDCLIENTE = int.Parse(rdr[0].ToString());
                    rp.DNICLIENTE = rdr[1].ToString();
                    rp.NOMBRE = rdr[2].ToString();
                    rp.APPATERNO = rdr[3].ToString();
                    rp.APMATERNO = rdr[4].ToString();
                    rp.TELEFONOCELULAR = rdr[5].ToString();

                    lrp.Add(rp);
                    rp = null;
                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("ClientesReportes", lrp);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FacturacionCine.Report3.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
        }
    }
}
