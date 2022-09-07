using CarrerasS_P.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrerasS_P.Presentacion
{
    public partial class EditarCarrera : Form
    {
        DBHelper oDatos = new DBHelper();

        public EditarCarrera()
        {
            InitializeComponent();

            cargargrilla();
         
        }

        private void EditarCarrera_Load(object sender, EventArgs e)
        {
         

        }

        public void CargarCarrera()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_consultar_carrera");
            cboasignatura.DataSource = tabla;
            cboasignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboasignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        public void CargarAsignaturas()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_consultar_asignatura");
            cboasignatura.DataSource = tabla;
            cboasignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboasignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        public void cargargrilla()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_consultar_carrera");
            dgvdetalle.DataSource = tabla;

        }

        private void cargarCampos(int posicion)
        {

            DataTable tabla = oDatos.ConsultarDB("SP_insertar_detalleCarreras");


            txtaño.Text = Convert.ToString(tabla.Rows[posicion][0]);
            cboasignatura.SelectedValue = (int)tabla.Rows[posicion][2];
            txtaño.Text = Convert.ToString(tabla.Rows[posicion][3]);
            if (Convert.ToInt32(tabla.Rows[posicion][4]) == 1)
                rbtprimercuatrimestre.Checked = true;
            else
                rbtsegundocuatrimestre.Checked = true;


        }

        private void dgvdetalle_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarCampos(dgvdetalle.CurrentRow.Index);
        }

        private void cbocarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboasignatura.SelectedItem;
            txtaño.Text = (string)item.Row.ItemArray[1];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
