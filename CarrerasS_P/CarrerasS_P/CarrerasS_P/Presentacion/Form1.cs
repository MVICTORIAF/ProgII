﻿
using CarrerasS_P.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrerasS_P
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
             "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaCarrera nuevaCarrera = new FrmNuevaCarrera();
            nuevaCarrera.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmConsultarCarreras consultaCarreras = new FrmConsultarCarreras();
            consultaCarreras.ShowDialog(); 
        }

        private void nuevoReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReporteCarreras().ShowDialog();
        }

        private void editarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditarCarrera().ShowDialog();
        }
    }
}
