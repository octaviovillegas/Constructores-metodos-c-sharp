namespace VirtualRaceUI
{
    partial class FrmPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbAuto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFabricantes = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoCarrera = new System.Windows.Forms.ComboBox();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.gpbListado = new System.Windows.Forms.GroupBox();
            this.lsbAutos = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gpbCarrera.SuspendLayout();
            this.gpbAuto.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.gpbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Carrera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.txtfecha);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Controls.Add(this.button1);
            this.gpbCarrera.Location = new System.Drawing.Point(22, 13);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(487, 77);
            this.gpbCarrera.TabIndex = 1;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(144, 30);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(102, 13);
            this.lblLugar.TabIndex = 6;
            this.lblLugar.Text = "Lugar de la carrera :";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(147, 46);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(125, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(278, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha :";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(281, 46);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(125, 20);
            this.txtfecha.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de la carrera:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // gpbAuto
            // 
            this.gpbAuto.Controls.Add(this.label2);
            this.gpbAuto.Controls.Add(this.cmbFabricantes);
            this.gpbAuto.Controls.Add(this.btnAgregarAuto);
            this.gpbAuto.Controls.Add(this.label1);
            this.gpbAuto.Controls.Add(this.txtNombrePiloto);
            this.gpbAuto.Location = new System.Drawing.Point(22, 96);
            this.gpbAuto.Name = "gpbAuto";
            this.gpbAuto.Size = new System.Drawing.Size(261, 123);
            this.gpbAuto.TabIndex = 2;
            this.gpbAuto.TabStop = false;
            this.gpbAuto.Text = "Autos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marca:";
            // 
            // cmbFabricantes
            // 
            this.cmbFabricantes.FormattingEnabled = true;
            this.cmbFabricantes.Location = new System.Drawing.Point(9, 89);
            this.cmbFabricantes.Name = "cmbFabricantes";
            this.cmbFabricantes.Size = new System.Drawing.Size(139, 21);
            this.cmbFabricantes.TabIndex = 10;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(163, 41);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(92, 69);
            this.btnAgregarAuto.TabIndex = 9;
            this.btnAgregarAuto.Text = "Agregar auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del piloto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(9, 41);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(143, 20);
            this.txtNombrePiloto.TabIndex = 7;
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.numericUpDown1);
            this.gpbResultado.Controls.Add(this.textBox1);
            this.gpbResultado.Controls.Add(this.label3);
            this.gpbResultado.Controls.Add(this.cmbTipoCarrera);
            this.gpbResultado.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultado.Location = new System.Drawing.Point(22, 225);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(261, 226);
            this.gpbResultado.TabIndex = 3;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 123);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de carrera:";
            // 
            // cmbTipoCarrera
            // 
            this.cmbTipoCarrera.FormattingEnabled = true;
            this.cmbTipoCarrera.Location = new System.Drawing.Point(9, 67);
            this.cmbTipoCarrera.Name = "cmbTipoCarrera";
            this.cmbTipoCarrera.Size = new System.Drawing.Size(143, 21);
            this.cmbTipoCarrera.TabIndex = 13;
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(163, 19);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(92, 69);
            this.btnCorrerCarrera.TabIndex = 12;
            this.btnCorrerCarrera.Text = "Correr";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            // 
            // gpbListado
            // 
            this.gpbListado.Controls.Add(this.lsbAutos);
            this.gpbListado.Location = new System.Drawing.Point(289, 96);
            this.gpbListado.Name = "gpbListado";
            this.gpbListado.Size = new System.Drawing.Size(214, 355);
            this.gpbListado.TabIndex = 4;
            this.gpbListado.TabStop = false;
            this.gpbListado.Text = "Listado de Autos";
            // 
            // lsbAutos
            // 
            this.lsbAutos.FormattingEnabled = true;
            this.lsbAutos.Location = new System.Drawing.Point(19, 31);
            this.lsbAutos.Name = "lsbAutos";
            this.lsbAutos.Size = new System.Drawing.Size(181, 316);
            this.lsbAutos.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 482);
            this.Controls.Add(this.gpbListado);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbAuto);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "FrmPrincipal";
            this.Text = "VRace 1.0.1";
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAuto.ResumeLayout(false);
            this.gpbAuto.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.gpbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbAuto;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.GroupBox gpbListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.ComboBox cmbFabricantes;
        private System.Windows.Forms.ListBox lsbAutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCarrera;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

