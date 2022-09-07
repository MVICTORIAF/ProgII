
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

namespace CarrerasS_P.Presentacion
{
    public partial class FrmNuevaCarrera : Form
    {
        private DBHelper gestor;
        private Carrera nuevo;

        public FrmNuevaCarrera()
        {
            InitializeComponent();
            gestor = new DBHelper(); //objeto de cada uno para haacer un nuevo presupuesto y el gestor es quien me hace la gestion con la base de datos 
            nuevo = new Carrera();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            txtNombreCarrera.Text = "";
            txtAnioCursado.Text = "";
            this.ActiveControl = cboMateria;
            cargarCombo();
            cboMateria.DataSource = gestor.ConsultarDB("SP_consultar_asignaturas");
         
        }

        private void cargarCombo()
        {
            DataTable Tabla = new DataTable();
            Tabla = gestor.ConsultarDB("SP_consultar_asignaturas"); //NOMBRE DEL ALMA Y ESO Y ME DEVUELVE UNA TABLA 
            cboMateria.DataSource = Tabla;
            cboMateria.ValueMember = Tabla.Columns[0].ColumnName;
            cboMateria.DisplayMember = Tabla.Columns[1].ColumnName;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            //if (cboMateria.Text.Equals(String.Empty)) //que no este vacio el combo 
            //{
            //    MessageBox.Show("Debe seleccionar una MATERIA!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //   que se pueda selecionar 
            //    return;
            //}

            //if (txtNombreCarrera.Text == "" || !int.TryParse(txtNombreCarrera.Text, out _))  // me ingrese el usuario sea un entero osea una cantidad que no este vacio y que no deje de ser vacio y el out va a ser la variable de salida 
            //{
            //    MessageBox.Show("Debe ingresar un NOMBRE válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}


            //if (txtAnioCursado.Text == "" || !int.TryParse(txtAnioCursado.Text, out _))  // me ingrese el usuario sea un entero osea una cantidad que no este vacio y que no deje de ser vacio y el out va a ser la variable de salida 
            //{
            //    MessageBox.Show("Debe ingresar un AÑO válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colMateria"].Value.ToString().Equals(cboMateria.Text)) 
                {
                    MessageBox.Show("Materia: " + cboMateria.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
            Asignatura asignatura = new Asignatura();
            asignatura.Codigo = Convert.ToInt32(cboMateria.SelectedValue);
            asignatura.Nombre = cboMateria.Text;
            int anioCursado = int.Parse(txtAnioCursado.Text);
            int cuatrimestre = 0;
            if (rbnPrimerCuatrimestre.Checked) cuatrimestre = 1;
            if (rbnSegundoCuatrimestre.Checked) cuatrimestre = 2;

            DetalleCarrera detCarrera = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
            nuevo.AgregarDetalle(detCarrera);
            dgvDetalles.Rows.Add(new Object[] {asignatura.Codigo, asignatura.Nombre, anioCursado, cuatrimestre });
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e) //eliminar un detalle
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevo.EliminarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cboMateria.Text.Equals(String.Empty)) 
            {
                MessageBox.Show("Debe seleccionar una MATERIA!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //   que se pueda selecionar 
                return;
            }

            if (!rbnPrimerCuatrimestre.Checked && !rbnSegundoCuatrimestre.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (dgvDetalles.Rows.Count == 0) //que la grilla al menos tenga una fila 
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarPresupuesto();

        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            nuevo.Nombre_Titulo = txtNombreCarrera.Text;
            
        }

        private void GuardarPresupuesto()
        {
            nuevo.Nombre_Titulo = txtNombreCarrera.Text;

            if (gestor.ConfirmarPresupuesto(nuevo))
            {
                MessageBox.Show("Carrera registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);  //se pudo registar 
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BorrarPresupuesto()
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevo.EliminarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            BorrarPresupuesto();
            dgvDetalles.Rows.Clear();
        }
    }
    }

