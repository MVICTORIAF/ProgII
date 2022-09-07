
namespace CarrerasS_P.Presentacion
{
    partial class frmReporteCarreras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sDCarreras = new CarrerasS_P.Reportes.SDCarreras();
            this.rvCarreras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carreraTableAdapter = new CarrerasS_P.Reportes.SDCarrerasTableAdapters.carreraTableAdapter();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtLetradesde = new System.Windows.Forms.TextBox();
            this.lblaño = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetrahasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataMember = "carrera";
            this.carreraBindingSource.DataSource = this.sDCarreras;
            // 
            // sDCarreras
            // 
            this.sDCarreras.DataSetName = "SDCarreras";
            this.sDCarreras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvCarreras
            // 
            this.rvCarreras.ForeColor = System.Drawing.Color.Lime;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.carreraBindingSource;
            this.rvCarreras.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCarreras.LocalReport.ReportEmbeddedResource = "CarrerasS_P.Reportes.rptCarreras.rdlc";
            this.rvCarreras.Location = new System.Drawing.Point(25, 84);
            this.rvCarreras.Name = "rvCarreras";
            this.rvCarreras.ServerReport.BearerToken = null;
            this.rvCarreras.Size = new System.Drawing.Size(550, 293);
            this.rvCarreras.TabIndex = 0;
            this.rvCarreras.Load += new System.EventHandler(this.rvCarreras_Load);
            // 
            // carreraTableAdapter
            // 
            this.carreraTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(419, 52);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtLetradesde
            // 
            this.txtLetradesde.Location = new System.Drawing.Point(126, 55);
            this.txtLetradesde.Name = "txtLetradesde";
            this.txtLetradesde.Size = new System.Drawing.Size(100, 20);
            this.txtLetradesde.TabIndex = 2;
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblaño.Location = new System.Drawing.Point(59, 58);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(66, 13);
            this.lblaño.TabIndex = 3;
            this.lblaño.Text = "Letra desde ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(232, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Letra hasta";
            // 
            // txtLetrahasta
            // 
            this.txtLetrahasta.Location = new System.Drawing.Point(299, 55);
            this.txtLetrahasta.Name = "txtLetrahasta";
            this.txtLetrahasta.Size = new System.Drawing.Size(100, 20);
            this.txtLetrahasta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(216, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LISTADO DE CARRERAS";
            // 
            // frmReporteCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(602, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLetrahasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.txtLetradesde);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.rvCarreras);
            this.Name = "frmReporteCarreras";
            this.Text = "frmReporteCarreras";
            this.Load += new System.EventHandler(this.frmReporteCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCarreras;
        private Reportes.SDCarreras sDCarreras;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private Reportes.SDCarrerasTableAdapters.carreraTableAdapter carreraTableAdapter;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtLetradesde;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetrahasta;
        private System.Windows.Forms.Label label2;
    }
}