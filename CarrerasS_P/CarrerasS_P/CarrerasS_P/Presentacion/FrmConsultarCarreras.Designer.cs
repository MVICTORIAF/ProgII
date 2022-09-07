
namespace CarrerasS_P.Presentacion
{
    partial class FrmConsultarCarreras
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
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.lblDetCarrera = new System.Windows.Forms.Label();
            this.cboConsultarCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(180, 24);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(137, 16);
            this.lblNuevaCarrera.TabIndex = 27;
            this.lblNuevaCarrera.Text = "Consultar Carreras";
            // 
            // lblDetCarrera
            // 
            this.lblDetCarrera.AutoSize = true;
            this.lblDetCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetCarrera.Location = new System.Drawing.Point(60, 149);
            this.lblDetCarrera.Name = "lblDetCarrera";
            this.lblDetCarrera.Size = new System.Drawing.Size(146, 17);
            this.lblDetCarrera.TabIndex = 25;
            this.lblDetCarrera.Text = "Detalles de la Carrera";
            // 
            // cboConsultarCarrera
            // 
            this.cboConsultarCarrera.FormattingEnabled = true;
            this.cboConsultarCarrera.Location = new System.Drawing.Point(212, 80);
            this.cboConsultarCarrera.Name = "cboConsultarCarrera";
            this.cboConsultarCarrera.Size = new System.Drawing.Size(200, 21);
            this.cboConsultarCarrera.TabIndex = 24;
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(62, 80);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(144, 17);
            this.lblCarreras.TabIndex = 23;
            this.lblCarreras.Text = "Seleccione la Carrera";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(212, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 30);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(435, 74);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 30);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(65, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 95);
            this.listBox1.TabIndex = 31;
            // 
            // FrmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 448);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Controls.Add(this.lblDetCarrera);
            this.Controls.Add(this.cboConsultarCarrera);
            this.Controls.Add(this.lblCarreras);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmConsultarCarreras";
            this.Text = "FrmConsultarCarreras";
            this.Load += new System.EventHandler(this.FrmConsultarCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.Label lblDetCarrera;
        private System.Windows.Forms.ComboBox cboConsultarCarrera;
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox listBox1;
    }
}