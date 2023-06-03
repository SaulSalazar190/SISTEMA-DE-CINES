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
    public partial class EmpleadosReportes : Form
    {
        public string servidor, usuario, clave, db;
        public string cadena;
        public SqlConnection conn;
        public EmpleadosReportes()
        {
            InitializeComponent();
        }

        private void EmpleadosReportes_Load(object sender, EventArgs e)
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
                string sql = "SELECT IDEMPLEADO, NOMBREEMPLEADO, APPATERNO, APMATERNO, USUARIO FROM EMPLEADO";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                SqlDataReader rdr = cmd.ExecuteReader();
                List<EmpleadoReporte> lrp = new List<EmpleadoReporte>();
                while (rdr.Read())
                {
                    EmpleadoReporte rp = new EmpleadoReporte();
                    rp.IDEMPLEADO = int.Parse(rdr[0].ToString());
                    rp.NOMBREEMPLEADO = rdr[1].ToString();
                    rp.APPATERNO = rdr[2].ToString();
                    rp.APMATERNO = rdr[3].ToString();
                    rp.USUARIO = rdr[4].ToString();

                    lrp.Add(rp);
                    rp = null;
                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("EmpleadoReporte", lrp);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FacturacionCine.Report2.rdlc";
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
