
namespace CarrerasS_P.Presentacion
{
    partial class EditarCarrera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btncancelarcarrera = new System.Windows.Forms.Button();
            this.btneditarcarrera = new System.Windows.Forms.Button();
            this.btngrabarcarrera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.btncancelardetalle = new System.Windows.Forms.Button();
            this.btneditardetalle = new System.Windows.Forms.Button();
            this.btngrabardetalle = new System.Windows.Forms.Button();
            this.lblasignatura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtsegundocuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbtprimercuatrimestre = new System.Windows.Forms.RadioButton();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.cboasignatura = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Editar carrera:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 20);
            this.textBox1.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(507, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btncancelarcarrera
            // 
            this.btncancelarcarrera.Location = new System.Drawing.Point(347, 128);
            this.btncancelarcarrera.Name = "btncancelarcarrera";
            this.btncancelarcarrera.Size = new System.Drawing.Size(75, 23);
            this.btncancelarcarrera.TabIndex = 33;
            this.btncancelarcarrera.Text = "Cancelar";
            this.btncancelarcarrera.UseVisualStyleBackColor = true;
            // 
            // btneditarcarrera
            // 
            this.btneditarcarrera.Location = new System.Drawing.Point(266, 127);
            this.btneditarcarrera.Name = "btneditarcarrera";
            this.btneditarcarrera.Size = new System.Drawing.Size(75, 23);
            this.btneditarcarrera.TabIndex = 32;
            this.btneditarcarrera.Text = "Editar";
            this.btneditarcarrera.UseVisualStyleBackColor = true;
            // 
            // btngrabarcarrera
            // 
            this.btngrabarcarrera.Location = new System.Drawing.Point(184, 128);
            this.btngrabarcarrera.Name = "btngrabarcarrera";
            this.btngrabarcarrera.Size = new System.Drawing.Size(75, 23);
            this.btngrabarcarrera.TabIndex = 31;
            this.btngrabarcarrera.Text = "Grabar";
            this.btngrabarcarrera.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Editar detalles de la carrera:";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(27, 212);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.Size = new System.Drawing.Size(571, 131);
            this.dgvdetalle.TabIndex = 35;
            // 
            // btncancelardetalle
            // 
            this.btncancelardetalle.Location = new System.Drawing.Point(754, 377);
            this.btncancelardetalle.Name = "btncancelardetalle";
            this.btncancelardetalle.Size = new System.Drawing.Size(75, 23);
            this.btncancelardetalle.TabIndex = 44;
            this.btncancelardetalle.Text = "Cancelar";
            this.btncancelardetalle.UseVisualStyleBackColor = true;
            // 
            // btneditardetalle
            // 
            this.btneditardetalle.Location = new System.Drawing.Point(485, 440);
            this.btneditardetalle.Name = "btneditardetalle";
            this.btneditardetalle.Size = new System.Drawing.Size(75, 23);
            this.btneditardetalle.TabIndex = 43;
            this.btneditardetalle.Text = "Editar";
            this.btneditardetalle.UseVisualStyleBackColor = true;
            // 
            // btngrabardetalle
            // 
            this.btngrabardetalle.Location = new System.Drawing.Point(404, 440);
            this.btngrabardetalle.Name = "btngrabardetalle";
            this.btngrabardetalle.Size = new System.Drawing.Size(75, 23);
            this.btngrabardetalle.TabIndex = 42;
            this.btngrabardetalle.Text = "Grabar";
            this.btngrabardetalle.UseVisualStyleBackColor = true;
            // 
            // lblasignatura
            // 
            this.lblasignatura.AutoSize = true;
            this.lblasignatura.Location = new System.Drawing.Point(20, 404);
            this.lblasignatura.Name = "lblasignatura";
            this.lblasignatura.Size = new System.Drawing.Size(57, 13);
            this.lblasignatura.TabIndex = 41;
            this.lblasignatura.Text = "Asignatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Año";
            // 
            // rbtsegundocuatrimestre
            // 
            this.rbtsegundocuatrimestre.AutoSize = true;
            this.rbtsegundocuatrimestre.Location = new System.Drawing.Point(405, 400);
            this.rbtsegundocuatrimestre.Name = "rbtsegundocuatrimestre";
            this.rbtsegundocuatrimestre.Size = new System.Drawing.Size(126, 17);
            this.rbtsegundocuatrimestre.TabIndex = 39;
            this.rbtsegundocuatrimestre.TabStop = true;
            this.rbtsegundocuatrimestre.Text = "SegundoCuatrimestre";
            this.rbtsegundocuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbtprimercuatrimestre
            // 
            this.rbtprimercuatrimestre.AutoSize = true;
            this.rbtprimercuatrimestre.Location = new System.Drawing.Point(405, 358);
            this.rbtprimercuatrimestre.Name = "rbtprimercuatrimestre";
            this.rbtprimercuatrimestre.Size = new System.Drawing.Size(112, 17);
            this.rbtprimercuatrimestre.TabIndex = 38;
            this.rbtprimercuatrimestre.TabStop = true;
            this.rbtprimercuatrimestre.Text = "PrimerCuatrimestre";
            this.rbtprimercuatrimestre.UseVisualStyleBackColor = true;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(83, 358);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(148, 20);
            this.txtaño.TabIndex = 37;
            // 
            // cboasignatura
            // 
            this.cboasignatura.FormattingEnabled = true;
            this.cboasignatura.Location = new System.Drawing.Point(83, 400);
            this.cboasignatura.Name = "cboasignatura";
            this.cboasignatura.Size = new System.Drawing.Size(273, 21);
            this.cboasignatura.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 45;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancelardetalle);
            this.Controls.Add(this.btneditardetalle);
            this.Controls.Add(this.btngrabardetalle);
            this.Controls.Add(this.lblasignatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtsegundocuatrimestre);
            this.Controls.Add(this.rbtprimercuatrimestre);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.cboasignatura);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancelarcarrera);
            this.Controls.Add(this.btneditarcarrera);
            this.Controls.Add(this.btngrabarcarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditarCarrera";
            this.Text = "EditarCarrera";
            this.Load += new System.EventHandler(this.EditarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btncancelarcarrera;
        private System.Windows.Forms.Button btneditarcarrera;
        private System.Windows.Forms.Button btngrabarcarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Button btncancelardetalle;
        private System.Windows.Forms.Button btneditardetalle;
        private System.Windows.Forms.Button btngrabardetalle;
        private System.Windows.Forms.Label lblasignatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtsegundocuatrimestre;
        private System.Windows.Forms.RadioButton rbtprimercuatrimestre;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.ComboBox cboasignatura;
        private System.Windows.Forms.Button button1;
    }
}