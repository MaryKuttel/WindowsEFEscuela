namespace WindowsEFEscuela
{
    partial class FormAlumno
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
            this.traerTodosAlumn = new System.Windows.Forms.Button();
            this.bttnInsertarAlumno = new System.Windows.Forms.Button();
            this.modfAlumno = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textIdAlumno = new System.Windows.Forms.TextBox();
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.eliminarAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.traerAlumnID = new System.Windows.Forms.Button();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // traerTodosAlumn
            // 
            this.traerTodosAlumn.Location = new System.Drawing.Point(48, 155);
            this.traerTodosAlumn.Name = "traerTodosAlumn";
            this.traerTodosAlumn.Size = new System.Drawing.Size(126, 38);
            this.traerTodosAlumn.TabIndex = 0;
            this.traerTodosAlumn.Text = "Traer Todos";
            this.traerTodosAlumn.UseVisualStyleBackColor = true;
            this.traerTodosAlumn.Click += new System.EventHandler(this.traerTodosAlumn_Click);
            // 
            // bttnInsertarAlumno
            // 
            this.bttnInsertarAlumno.Location = new System.Drawing.Point(48, 311);
            this.bttnInsertarAlumno.Name = "bttnInsertarAlumno";
            this.bttnInsertarAlumno.Size = new System.Drawing.Size(126, 38);
            this.bttnInsertarAlumno.TabIndex = 2;
            this.bttnInsertarAlumno.Text = "Insertar Alumno";
            this.bttnInsertarAlumno.UseVisualStyleBackColor = true;
            this.bttnInsertarAlumno.Click += new System.EventHandler(this.bttnInsertarAlumno_Click);
            // 
            // modfAlumno
            // 
            this.modfAlumno.Location = new System.Drawing.Point(48, 383);
            this.modfAlumno.Name = "modfAlumno";
            this.modfAlumno.Size = new System.Drawing.Size(126, 38);
            this.modfAlumno.TabIndex = 3;
            this.modfAlumno.Text = "Modificar Alumno";
            this.modfAlumno.UseVisualStyleBackColor = true;
            this.modfAlumno.Click += new System.EventHandler(this.modfAlumno_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(214, 51);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(143, 20);
            this.textNombre.TabIndex = 4;
            // 
            // textIdAlumno
            // 
            this.textIdAlumno.Location = new System.Drawing.Point(536, 51);
            this.textIdAlumno.Name = "textIdAlumno";
            this.textIdAlumno.Size = new System.Drawing.Size(143, 20);
            this.textIdAlumno.TabIndex = 5;
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(214, 155);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.Size = new System.Drawing.Size(465, 266);
            this.gridAlumnos.TabIndex = 6;
            this.gridAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlumnos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(214, 110);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(143, 20);
            this.textApellido.TabIndex = 9;
            // 
            // eliminarAlumno
            // 
            this.eliminarAlumno.BackColor = System.Drawing.Color.Firebrick;
            this.eliminarAlumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eliminarAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarAlumno.Location = new System.Drawing.Point(701, 400);
            this.eliminarAlumno.Name = "eliminarAlumno";
            this.eliminarAlumno.Size = new System.Drawing.Size(87, 38);
            this.eliminarAlumno.TabIndex = 11;
            this.eliminarAlumno.Text = "Eliminar Alumno";
            this.eliminarAlumno.UseVisualStyleBackColor = false;
            this.eliminarAlumno.Click += new System.EventHandler(this.eliminarAlumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // traerAlumnID
            // 
            this.traerAlumnID.Location = new System.Drawing.Point(48, 236);
            this.traerAlumnID.Name = "traerAlumnID";
            this.traerAlumnID.Size = new System.Drawing.Size(126, 38);
            this.traerAlumnID.TabIndex = 1;
            this.traerAlumnID.Text = "Traer por ID";
            this.traerAlumnID.UseVisualStyleBackColor = true;
            this.traerAlumnID.Click += new System.EventHandler(this.traerAlumnID_Click);
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(505, 110);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(209, 20);
            this.dateNacimiento.TabIndex = 14;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eliminarAlumno);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAlumnos);
            this.Controls.Add(this.textIdAlumno);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.modfAlumno);
            this.Controls.Add(this.bttnInsertarAlumno);
            this.Controls.Add(this.traerAlumnID);
            this.Controls.Add(this.traerTodosAlumn);
            this.Name = "FormAlumno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button traerTodosAlumn;
        private System.Windows.Forms.Button bttnInsertarAlumno;
        private System.Windows.Forms.Button modfAlumno;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textIdAlumno;
        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button eliminarAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button traerAlumnID;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
    }
}

