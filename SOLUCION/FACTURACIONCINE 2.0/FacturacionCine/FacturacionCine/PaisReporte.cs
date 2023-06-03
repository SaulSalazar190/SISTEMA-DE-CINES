using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace FacturacionCine
{
    public partial class PaisReporte : Form
    {
        public string servidor, usuario, clave, db;
        public string cadena;
        public SqlConnection conn;
        public PaisReporte()
        {
            InitializeComponent();
        }

        private void PaisReporte_Load(object sender, EventArgs e)
        {
            /*servidor = "localhost";
            db = "ReservaCine1";
            usuario = "sauls";
            clave = "123456";
            cadena = "server=" + servidor + "; uid=" + usuario + "; pwd =" + clave + ";database=" + db;

            conn = new SqlConnection(cadena);*/
            string servidor = "localhost";
            string db = "ReservaCine1";
            string cadena = "Data Source=" + servidor + ";Initial Catalog=" + db + ";Integrated Security=True";

            string username = Environment.UserName;

            conn = new SqlConnection(cadena);

            try
            {
                conn.Open();
                string sql = "SELECT IDPAIS, NOMBRE FROM PAIS";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                SqlDataReader rdr = cmd.ExecuteReader();
                List<PaisesReportes> lrp = new List<PaisesReportes>();
                while (rdr.Read())
                {
                    PaisesReportes rp = new PaisesReportes();
                    rp.IDPAIS = int.Parse(rdr[0].ToString());
                    rp.NOMBRE = rdr[1].ToString();

                    lrp.Add(rp);
                    rp = null;
                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("PaisesReportes", lrp);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FacturacionCine.Report1.rdlc";
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
