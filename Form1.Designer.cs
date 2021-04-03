
namespace Actividad_Integradora_5_Problema_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.txtFiltroServicio = new System.Windows.Forms.TextBox();
            this.dtFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.rbServicios = new System.Windows.Forms.RadioButton();
            this.rbCitasDia = new System.Windows.Forms.RadioButton();
            this.dtFiltroFecha2 = new System.Windows.Forms.DateTimePicker();
            this.lblhasta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(294, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 58);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "René Mascotas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtServicio);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(35, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(294, 186);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(313, 47);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(294, 241);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(313, 47);
            this.txtServicio.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(294, 133);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(313, 47);
            this.txtTipo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(294, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 47);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Servicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Actividad_Integradora_5_Problema_3.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(248, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 293);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblhasta);
            this.groupBox2.Controls.Add(this.dtFiltroFecha2);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.lblServicio);
            this.groupBox2.Controls.Add(this.lblRango);
            this.groupBox2.Controls.Add(this.txtFiltroServicio);
            this.groupBox2.Controls.Add(this.dtFiltroFecha);
            this.groupBox2.Controls.Add(this.rtbInformacion);
            this.groupBox2.Controls.Add(this.rbIngreso);
            this.groupBox2.Controls.Add(this.rbServicios);
            this.groupBox2.Controls.Add(this.rbCitasDia);
            this.groupBox2.Location = new System.Drawing.Point(35, 811);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 592);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administración";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(517, 190);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 58);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(29, 196);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(127, 41);
            this.lblServicio.TabIndex = 7;
            this.lblServicio.Text = "Servicio:";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(45, 137);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(111, 41);
            this.lblRango.TabIndex = 6;
            this.lblRango.Text = "Rango:";
            // 
            // txtFiltroServicio
            // 
            this.txtFiltroServicio.Location = new System.Drawing.Point(176, 196);
            this.txtFiltroServicio.Name = "txtFiltroServicio";
            this.txtFiltroServicio.Size = new System.Drawing.Size(215, 47);
            this.txtFiltroServicio.TabIndex = 5;
            // 
            // dtFiltroFecha
            // 
            this.dtFiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroFecha.Location = new System.Drawing.Point(178, 137);
            this.dtFiltroFecha.Name = "dtFiltroFecha";
            this.dtFiltroFecha.Size = new System.Drawing.Size(247, 47);
            this.dtFiltroFecha.TabIndex = 4;
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(34, 263);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.Size = new System.Drawing.Size(851, 306);
            this.rtbInformacion.TabIndex = 3;
            this.rtbInformacion.Text = "";
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Location = new System.Drawing.Point(618, 76);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(275, 45);
            this.rbIngreso.TabIndex = 2;
            this.rbIngreso.Text = "Ingreso Mensual";
            this.rbIngreso.UseVisualStyleBackColor = true;
            this.rbIngreso.CheckedChanged += new System.EventHandler(this.rbIngreso_CheckedChanged);
            // 
            // rbServicios
            // 
            this.rbServicios.AutoSize = true;
            this.rbServicios.Location = new System.Drawing.Point(294, 76);
            this.rbServicios.Name = "rbServicios";
            this.rbServicios.Size = new System.Drawing.Size(318, 45);
            this.rbServicios.TabIndex = 1;
            this.rbServicios.Text = "Servicios Realizados";
            this.rbServicios.UseVisualStyleBackColor = true;
            this.rbServicios.CheckedChanged += new System.EventHandler(this.rbServicios_CheckedChanged);
            // 
            // rbCitasDia
            // 
            this.rbCitasDia.AutoSize = true;
            this.rbCitasDia.Checked = true;
            this.rbCitasDia.Location = new System.Drawing.Point(45, 76);
            this.rbCitasDia.Name = "rbCitasDia";
            this.rbCitasDia.Size = new System.Drawing.Size(219, 45);
            this.rbCitasDia.TabIndex = 0;
            this.rbCitasDia.TabStop = true;
            this.rbCitasDia.Text = "Citas del Dia";
            this.rbCitasDia.UseVisualStyleBackColor = true;
            this.rbCitasDia.CheckedChanged += new System.EventHandler(this.rbCitasDia_CheckedChanged);
            // 
            // dtFiltroFecha2
            // 
            this.dtFiltroFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroFecha2.Location = new System.Drawing.Point(525, 137);
            this.dtFiltroFecha2.Name = "dtFiltroFecha2";
            this.dtFiltroFecha2.Size = new System.Drawing.Size(247, 47);
            this.dtFiltroFecha2.TabIndex = 9;
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(431, 141);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(88, 41);
            this.lblhasta.TabIndex = 10;
            this.lblhasta.Text = "hasta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 1451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Actividad Integradora 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.TextBox txtFiltroServicio;
        private System.Windows.Forms.DateTimePicker dtFiltroFecha;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.RadioButton rbServicios;
        private System.Windows.Forms.RadioButton rbCitasDia;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.DateTimePicker dtFiltroFecha2;
    }
}

