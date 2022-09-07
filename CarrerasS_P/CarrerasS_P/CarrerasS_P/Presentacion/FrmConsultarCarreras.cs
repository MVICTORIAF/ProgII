using CarrerasS_P.AccesoDatos;
using CarrerasS_P.Dominio;
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
using CarrerasS_P.Dominio;


namespace CarrerasS_P.Presentacion
{
   
    public partial class FrmConsultarCarreras : Form
    {
        DBHelper oBD = new DBHelper();
        List<Carrera> lcarrera = new List<Carrera>();

        private DBHelper gestor;
        private Carrera nuevo;

        public FrmConsultarCarreras()
        {
            InitializeComponent();
            gestor = new DBHelper(); 
            nuevo = new Carrera();

        }

        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            cargarCombo();

        }

        private void cargarCombo()
        {
            DataTable Tabla = new DataTable();
            Tabla = gestor.ConsultarDB("SP_consultar_carrera"); //NOMBRE DEL ALMA Y ESO Y ME DEVUELVE UNA TABLA 
            cboConsultarCarrera.DataSource = Tabla;
            cboConsultarCarrera.ValueMember = Tabla.Columns[0].ColumnName;
            cboConsultarCarrera.DisplayMember = Tabla.Columns[1].ColumnName;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-64M431K\SQLEXPRESS;Initial Catalog=Carreras1;Integrated Security=True");


            DataTable table = new DataTable();
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SP_consultar_carrera", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

        }
    }
}
