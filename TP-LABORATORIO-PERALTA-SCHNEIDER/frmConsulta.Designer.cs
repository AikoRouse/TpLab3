namespace TP_LABORATORIO_PERALTA_SCHNEIDER
{
    partial class frmConsulta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.REGISTROS = new System.Windows.Forms.TabControl();
            this.tbRegistros = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProfesion = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdProfesion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.txtIdLocalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LOCALIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGISTROS.SuspendLayout();
            this.tbRegistros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // REGISTROS
            // 
            this.REGISTROS.Controls.Add(this.tbRegistros);
            this.REGISTROS.Controls.Add(this.tabPage2);
            this.REGISTROS.Location = new System.Drawing.Point(1, 1);
            this.REGISTROS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.REGISTROS.Name = "REGISTROS";
            this.REGISTROS.SelectedIndex = 0;
            this.REGISTROS.Size = new System.Drawing.Size(947, 554);
            this.REGISTROS.TabIndex = 0;
            // 
            // tbRegistros
            // 
            this.tbRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRegistros.Controls.Add(this.groupBox2);
            this.tbRegistros.Controls.Add(this.groupBox3);
            this.tbRegistros.Controls.Add(this.groupBox1);
            this.tbRegistros.Location = new System.Drawing.Point(4, 25);
            this.tbRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRegistros.Name = "tbRegistros";
            this.tbRegistros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRegistros.Size = new System.Drawing.Size(939, 525);
            this.tbRegistros.TabIndex = 0;
            this.tbRegistros.Text = "REGISTROS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbProfesion);
            this.groupBox2.Controls.Add(this.cmbLocalidad);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 216);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(427, 289);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(78, 184);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(269, 29);
            this.txtCantidad.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ingrese cantidad:";
            // 
            // cmbProfesion
            // 
            this.cmbProfesion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesion.FormattingEnabled = true;
            this.cmbProfesion.Location = new System.Drawing.Point(78, 122);
            this.cmbProfesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProfesion.Name = "cmbProfesion";
            this.cmbProfesion.Size = new System.Drawing.Size(269, 30);
            this.cmbProfesion.TabIndex = 6;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(78, 60);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(269, 30);
            this.cmbLocalidad.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(179, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione Profesion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione localidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtIdProfesion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtProfesion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(226, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(209, 201);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar profesion";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(80, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIdProfesion
            // 
            this.txtIdProfesion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProfesion.Location = new System.Drawing.Point(5, 116);
            this.txtIdProfesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProfesion.Name = "txtIdProfesion";
            this.txtIdProfesion.Size = new System.Drawing.Size(165, 26);
            this.txtIdProfesion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id ";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesion.Location = new System.Drawing.Point(5, 58);
            this.txtProfesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(165, 26);
            this.txtProfesion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingrese profesion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRegistrar);
            this.groupBox1.Controls.Add(this.txtIdLocalidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(209, 201);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar localidad";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.BackColor = System.Drawing.Color.IndianRed;
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRegistrar.Location = new System.Drawing.Point(80, 150);
            this.cmdRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(109, 43);
            this.cmdRegistrar.TabIndex = 4;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // txtIdLocalidad
            // 
            this.txtIdLocalidad.Location = new System.Drawing.Point(5, 116);
            this.txtIdLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdLocalidad.Name = "txtIdLocalidad";
            this.txtIdLocalidad.Size = new System.Drawing.Size(165, 26);
            this.txtIdLocalidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id ";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(5, 58);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(165, 26);
            this.txtLocalidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese localidad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(939, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTAS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOCALIDADES});
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // LOCALIDADES
            // 
            this.LOCALIDADES.HeaderText = "LOCALIDADES";
            this.LOCALIDADES.MinimumWidth = 6;
            this.LOCALIDADES.Name = "LOCALIDADES";
            this.LOCALIDADES.Width = 125;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(951, 556);
            this.Controls.Add(this.REGISTROS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsulta";
            this.Text = "Registro de Profesiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.REGISTROS.ResumeLayout(false);
            this.tbRegistros.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl REGISTROS;
        private System.Windows.Forms.TabPage tbRegistros;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProfesion;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdProfesion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.TextBox txtIdLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDADES;
    }
}

