namespace G4_Ejercicio4
{
    partial class FrmPrograma
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncrearvehiculo = new System.Windows.Forms.Button();
            this.txtrin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbcombustible = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmasavehiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnpasajeros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnllantas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtransmision = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbmotor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbvehiculo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnrefreshmoto = new System.Windows.Forms.Button();
            this.Dgvregistromoto = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnrefreshcarro = new System.Windows.Forms.Button();
            this.DgvregistroCarro = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnrefreshbus = new System.Windows.Forms.Button();
            this.DgvregistroBus = new System.Windows.Forms.DataGridView();
            this.btnsalirprogram = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvregistromoto)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvregistroCarro)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvregistroBus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de vehiculos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 292);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbvehiculo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Vehiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncrearvehiculo);
            this.groupBox1.Controls.Add(this.txtrin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbcombustible);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtmasavehiculo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnpasajeros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnllantas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbtransmision);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbmotor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de a Ingresar:";
            // 
            // btncrearvehiculo
            // 
            this.btncrearvehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncrearvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearvehiculo.ForeColor = System.Drawing.Color.DarkRed;
            this.btncrearvehiculo.Location = new System.Drawing.Point(614, 161);
            this.btncrearvehiculo.Name = "btncrearvehiculo";
            this.btncrearvehiculo.Size = new System.Drawing.Size(120, 35);
            this.btncrearvehiculo.TabIndex = 3;
            this.btncrearvehiculo.Text = "Añadir Vehiculo";
            this.btncrearvehiculo.UseVisualStyleBackColor = false;
            this.btncrearvehiculo.Click += new System.EventHandler(this.btncrearvehiculo_Click);
            // 
            // txtrin
            // 
            this.txtrin.Location = new System.Drawing.Point(430, 157);
            this.txtrin.Name = "txtrin";
            this.txtrin.Size = new System.Drawing.Size(155, 20);
            this.txtrin.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tamaño de rin:";
            // 
            // cmbcombustible
            // 
            this.cmbcombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcombustible.FormattingEnabled = true;
            this.cmbcombustible.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Electricidad"});
            this.cmbcombustible.Location = new System.Drawing.Point(486, 118);
            this.cmbcombustible.Name = "cmbcombustible";
            this.cmbcombustible.Size = new System.Drawing.Size(99, 21);
            this.cmbcombustible.TabIndex = 12;
            this.cmbcombustible.SelectedIndexChanged += new System.EventHandler(this.cmbcombustible_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Combustible que consume:";
            // 
            // txtmasavehiculo
            // 
            this.txtmasavehiculo.Location = new System.Drawing.Point(448, 74);
            this.txtmasavehiculo.Name = "txtmasavehiculo";
            this.txtmasavehiculo.Size = new System.Drawing.Size(137, 20);
            this.txtmasavehiculo.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Masa del vehiculo:";
            // 
            // txtnpasajeros
            // 
            this.txtnpasajeros.Location = new System.Drawing.Point(475, 29);
            this.txtnpasajeros.Name = "txtnpasajeros";
            this.txtnpasajeros.Size = new System.Drawing.Size(110, 20);
            this.txtnpasajeros.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Capasidad de pasajeros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(70, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "*Incluya las llantas que tiene de repuesto";
            // 
            // txtnllantas
            // 
            this.txtnllantas.Location = new System.Drawing.Point(174, 138);
            this.txtnllantas.Name = "txtnllantas";
            this.txtnllantas.Size = new System.Drawing.Size(92, 20);
            this.txtnllantas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de llantas:";
            // 
            // cmbtransmision
            // 
            this.cmbtransmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtransmision.FormattingEnabled = true;
            this.cmbtransmision.Items.AddRange(new object[] {
            "Automatica",
            "Manual"});
            this.cmbtransmision.Location = new System.Drawing.Point(145, 92);
            this.cmbtransmision.Name = "cmbtransmision";
            this.cmbtransmision.Size = new System.Drawing.Size(121, 21);
            this.cmbtransmision.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transmisión:";
            // 
            // cmbmotor
            // 
            this.cmbmotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmotor.FormattingEnabled = true;
            this.cmbmotor.Items.AddRange(new object[] {
            "Electrico",
            "Combustion"});
            this.cmbmotor.Location = new System.Drawing.Point(114, 38);
            this.cmbmotor.Name = "cmbmotor";
            this.cmbmotor.Size = new System.Drawing.Size(152, 21);
            this.cmbmotor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Motor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Vehiculo:";
            // 
            // cmbvehiculo
            // 
            this.cmbvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvehiculo.FormattingEnabled = true;
            this.cmbvehiculo.Items.AddRange(new object[] {
            "Moto",
            "Carro",
            "Bus"});
            this.cmbvehiculo.Location = new System.Drawing.Point(114, 20);
            this.cmbvehiculo.Name = "cmbvehiculo";
            this.cmbvehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbvehiculo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnrefreshmoto);
            this.tabPage2.Controls.Add(this.Dgvregistromoto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros Moto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnrefreshmoto
            // 
            this.btnrefreshmoto.Location = new System.Drawing.Point(6, 223);
            this.btnrefreshmoto.Name = "btnrefreshmoto";
            this.btnrefreshmoto.Size = new System.Drawing.Size(118, 37);
            this.btnrefreshmoto.TabIndex = 1;
            this.btnrefreshmoto.Text = "Actualizar Datos";
            this.btnrefreshmoto.UseVisualStyleBackColor = true;
            // 
            // Dgvregistromoto
            // 
            this.Dgvregistromoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvregistromoto.Location = new System.Drawing.Point(6, 6);
            this.Dgvregistromoto.Name = "Dgvregistromoto";
            this.Dgvregistromoto.Size = new System.Drawing.Size(740, 211);
            this.Dgvregistromoto.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnrefreshcarro);
            this.tabPage3.Controls.Add(this.DgvregistroCarro);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(752, 266);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registros Carro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnrefreshcarro
            // 
            this.btnrefreshcarro.Location = new System.Drawing.Point(6, 226);
            this.btnrefreshcarro.Name = "btnrefreshcarro";
            this.btnrefreshcarro.Size = new System.Drawing.Size(114, 34);
            this.btnrefreshcarro.TabIndex = 1;
            this.btnrefreshcarro.Text = "Actualizar Datos";
            this.btnrefreshcarro.UseVisualStyleBackColor = true;
            // 
            // DgvregistroCarro
            // 
            this.DgvregistroCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvregistroCarro.Location = new System.Drawing.Point(6, 6);
            this.DgvregistroCarro.Name = "DgvregistroCarro";
            this.DgvregistroCarro.Size = new System.Drawing.Size(740, 214);
            this.DgvregistroCarro.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnrefreshbus);
            this.tabPage4.Controls.Add(this.DgvregistroBus);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(752, 266);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Registro Bus";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnrefreshbus
            // 
            this.btnrefreshbus.Location = new System.Drawing.Point(6, 223);
            this.btnrefreshbus.Name = "btnrefreshbus";
            this.btnrefreshbus.Size = new System.Drawing.Size(101, 37);
            this.btnrefreshbus.TabIndex = 1;
            this.btnrefreshbus.Text = "Actualizar Datos";
            this.btnrefreshbus.UseVisualStyleBackColor = true;
            // 
            // DgvregistroBus
            // 
            this.DgvregistroBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvregistroBus.Location = new System.Drawing.Point(6, 6);
            this.DgvregistroBus.Name = "DgvregistroBus";
            this.DgvregistroBus.Size = new System.Drawing.Size(740, 211);
            this.DgvregistroBus.TabIndex = 0;
            // 
            // btnsalirprogram
            // 
            this.btnsalirprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirprogram.Location = new System.Drawing.Point(659, 379);
            this.btnsalirprogram.Name = "btnsalirprogram";
            this.btnsalirprogram.Size = new System.Drawing.Size(109, 35);
            this.btnsalirprogram.TabIndex = 2;
            this.btnsalirprogram.Text = "Salir";
            this.btnsalirprogram.UseVisualStyleBackColor = true;
            this.btnsalirprogram.Click += new System.EventHandler(this.btnsalirprogram_Click);
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 426);
            this.Controls.Add(this.btnsalirprogram);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrograma";
            this.Text = "Registra vehiculo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrograma_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrograma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvregistromoto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvregistroCarro)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvregistroBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgvregistromoto;
        private System.Windows.Forms.Button btnsalirprogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbvehiculo;
        private System.Windows.Forms.Button btnrefreshmoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbcombustible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmasavehiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnpasajeros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnllantas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtransmision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbmotor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncrearvehiculo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnrefreshcarro;
        private System.Windows.Forms.DataGridView DgvregistroCarro;
        private System.Windows.Forms.DataGridView DgvregistroBus;
        private System.Windows.Forms.Button btnrefreshbus;
    }
}