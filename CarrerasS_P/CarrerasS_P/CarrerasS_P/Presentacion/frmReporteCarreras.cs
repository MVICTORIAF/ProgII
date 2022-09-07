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



namespace CarrerasS_P.Presentacion
{
    public partial class frmReporteCarreras : Form
    {
        public object Sqlconnection { get; private set; }

        public frmReporteCarreras()
        {
            InitializeComponent();
        }

        private void frmReporteCarreras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sDCarreras.carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter.Fill(this.sDCarreras.carrera);

            this.rvCarreras.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string letra_desde =  txtLetradesde.Text.ToString();
           string letra_hasta = txtLetrahasta.Text.ToString();

            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-64M431K\SQLEXPRESS;Initial Catalog=Carreras1;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_RE_CARRERA", cnn);
            cmd.Parameters.AddWithValue("@letra_desde", txtLetradesde.Text);
            cmd.Parameters.AddWithValue("@letra_hasta", txtLetrahasta.Text);

            cmd.CommandType = CommandType.StoredProcedure;
     
            table.Load(cmd.ExecuteReader());

            rvCarreras.LocalReport.DataSources.Clear();
            rvCarreras.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));
            rvCarreras.RefreshReport();
            cnn.Close();


        }

        private void rvCarreras_Load(object sender, EventArgs e)
        {

        }
    }
}
