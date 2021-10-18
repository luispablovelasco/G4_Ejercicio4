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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnsalirprogram = new System.Windows.Forms.Button();
            this.Dgvregistro = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.cmbvehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncrearvehiculo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmotor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbtransmision = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnllantas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnpasajeros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmasavehiculo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbcombustible = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrin = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvregistro)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnrefresh);
            this.tabPage2.Controls.Add(this.Dgvregistro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Registros";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // Dgvregistro
            // 
            this.Dgvregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvregistro.Location = new System.Drawing.Point(6, 6);
            this.Dgvregistro.Name = "Dgvregistro";
            this.Dgvregistro.Size = new System.Drawing.Size(740, 211);
            this.Dgvregistro.TabIndex = 0;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(6, 223);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(118, 37);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Actualizar Datos";
            this.btnrefresh.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Vehiculo:";
            // 
            // groupBox1
            // 
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
            this.btncrearvehiculo.Location = new System.Drawing.Point(16, 379);
            this.btncrearvehiculo.Name = "btncrearvehiculo";
            this.btncrearvehiculo.Size = new System.Drawing.Size(120, 35);
            this.btncrearvehiculo.TabIndex = 3;
            this.btncrearvehiculo.Text = "Añadir Vehiculo";
            this.btncrearvehiculo.UseVisualStyleBackColor = false;
            this.btncrearvehiculo.Click += new System.EventHandler(this.btncrearvehiculo_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transmisión:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de llantas:";
            // 
            // txtnllantas
            // 
            this.txtnllantas.Location = new System.Drawing.Point(174, 138);
            this.txtnllantas.Name = "txtnllantas";
            this.txtnllantas.Size = new System.Drawing.Size(92, 20);
            this.txtnllantas.TabIndex = 5;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Capasidad de pasajeros:";
            // 
            // txtnpasajeros
            // 
            this.txtnpasajeros.Location = new System.Drawing.Point(565, 26);
            this.txtnpasajeros.Name = "txtnpasajeros";
            this.txtnpasajeros.Size = new System.Drawing.Size(67, 20);
            this.txtnpasajeros.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Masa del vehiculo:";
            // 
            // txtmasavehiculo
            // 
            this.txtmasavehiculo.Location = new System.Drawing.Point(538, 71);
            this.txtmasavehiculo.Name = "txtmasavehiculo";
            this.txtmasavehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtmasavehiculo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Combustible que consume:";
            // 
            // cmbcombustible
            // 
            this.cmbcombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcombustible.FormattingEnabled = true;
            this.cmbcombustible.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Electricidad"});
            this.cmbcombustible.Location = new System.Drawing.Point(576, 115);
            this.cmbcombustible.Name = "cmbcombustible";
            this.cmbcombustible.Size = new System.Drawing.Size(99, 21);
            this.cmbcombustible.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tamaño de rin:";
            // 
            // txtrin
            // 
            this.txtrin.Location = new System.Drawing.Point(520, 154);
            this.txtrin.Name = "txtrin";
            this.txtrin.Size = new System.Drawing.Size(100, 20);
            this.txtrin.TabIndex = 14;
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 426);
            this.Controls.Add(this.btncrearvehiculo);
            this.Controls.Add(this.btnsalirprogram);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrograma";
            this.Text = "Registra vehiculo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrograma_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvregistro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgvregistro;
        private System.Windows.Forms.Button btnsalirprogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbvehiculo;
        private System.Windows.Forms.Button btnrefresh;
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
    }
}