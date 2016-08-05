namespace Hospital
{
    partial class Enfermedades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enfermedadesCerrar = new System.Windows.Forms.Button();
            this.enfermedadesEliminar = new System.Windows.Forms.Button();
            this.enfermedadesEditar = new System.Windows.Forms.Button();
            this.enfermedadesAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enfermedadesCancelar = new System.Windows.Forms.Button();
            this.enfermedadesGuardar = new System.Windows.Forms.Button();
            this.enfermedadesCodigo = new System.Windows.Forms.TextBox();
            this.enfermedadesNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enfermedadesBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(482, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // enfermedadesCerrar
            // 
            this.enfermedadesCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesCerrar.Location = new System.Drawing.Point(359, 389);
            this.enfermedadesCerrar.Name = "enfermedadesCerrar";
            this.enfermedadesCerrar.Size = new System.Drawing.Size(81, 34);
            this.enfermedadesCerrar.TabIndex = 8;
            this.enfermedadesCerrar.Text = "Cerrar";
            this.enfermedadesCerrar.UseVisualStyleBackColor = true;
            // 
            // enfermedadesEliminar
            // 
            this.enfermedadesEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesEliminar.Location = new System.Drawing.Point(263, 389);
            this.enfermedadesEliminar.Name = "enfermedadesEliminar";
            this.enfermedadesEliminar.Size = new System.Drawing.Size(85, 34);
            this.enfermedadesEliminar.TabIndex = 7;
            this.enfermedadesEliminar.Text = "Eliminar";
            this.enfermedadesEliminar.UseVisualStyleBackColor = true;
            this.enfermedadesEliminar.Click += new System.EventHandler(this.enfermedadesEliminar_Click);
            // 
            // enfermedadesEditar
            // 
            this.enfermedadesEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesEditar.Location = new System.Drawing.Point(164, 389);
            this.enfermedadesEditar.Name = "enfermedadesEditar";
            this.enfermedadesEditar.Size = new System.Drawing.Size(90, 34);
            this.enfermedadesEditar.TabIndex = 6;
            this.enfermedadesEditar.Text = "Editar";
            this.enfermedadesEditar.UseVisualStyleBackColor = true;
            this.enfermedadesEditar.Click += new System.EventHandler(this.enfermedadesEditar_Click);
            // 
            // enfermedadesAgregar
            // 
            this.enfermedadesAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesAgregar.Location = new System.Drawing.Point(65, 389);
            this.enfermedadesAgregar.Name = "enfermedadesAgregar";
            this.enfermedadesAgregar.Size = new System.Drawing.Size(92, 34);
            this.enfermedadesAgregar.TabIndex = 5;
            this.enfermedadesAgregar.Text = "Agregar";
            this.enfermedadesAgregar.UseVisualStyleBackColor = true;
            this.enfermedadesAgregar.Click += new System.EventHandler(this.rolAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enfermedadesCancelar);
            this.groupBox1.Controls.Add(this.enfermedadesGuardar);
            this.groupBox1.Controls.Add(this.enfermedadesCodigo);
            this.groupBox1.Controls.Add(this.enfermedadesNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // enfermedadesCancelar
            // 
            this.enfermedadesCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesCancelar.Location = new System.Drawing.Point(269, 109);
            this.enfermedadesCancelar.Name = "enfermedadesCancelar";
            this.enfermedadesCancelar.Size = new System.Drawing.Size(93, 29);
            this.enfermedadesCancelar.TabIndex = 16;
            this.enfermedadesCancelar.Text = "Cancelar";
            this.enfermedadesCancelar.UseVisualStyleBackColor = true;
            this.enfermedadesCancelar.Click += new System.EventHandler(this.enfermedadesCancelar_Click);
            // 
            // enfermedadesGuardar
            // 
            this.enfermedadesGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesGuardar.Location = new System.Drawing.Point(173, 109);
            this.enfermedadesGuardar.Name = "enfermedadesGuardar";
            this.enfermedadesGuardar.Size = new System.Drawing.Size(90, 29);
            this.enfermedadesGuardar.TabIndex = 15;
            this.enfermedadesGuardar.Text = "Guardar";
            this.enfermedadesGuardar.UseVisualStyleBackColor = true;
            this.enfermedadesGuardar.Click += new System.EventHandler(this.enfermedadesGuardar_Click);
            // 
            // enfermedadesCodigo
            // 
            this.enfermedadesCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesCodigo.Location = new System.Drawing.Point(111, 66);
            this.enfermedadesCodigo.Name = "enfermedadesCodigo";
            this.enfermedadesCodigo.Size = new System.Drawing.Size(234, 26);
            this.enfermedadesCodigo.TabIndex = 14;
            // 
            // enfermedadesNombre
            // 
            this.enfermedadesNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesNombre.Location = new System.Drawing.Point(111, 25);
            this.enfermedadesNombre.Name = "enfermedadesNombre";
            this.enfermedadesNombre.Size = new System.Drawing.Size(234, 26);
            this.enfermedadesNombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // enfermedadesBuscar
            // 
            this.enfermedadesBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedadesBuscar.Location = new System.Drawing.Point(164, 202);
            this.enfermedadesBuscar.Name = "enfermedadesBuscar";
            this.enfermedadesBuscar.Size = new System.Drawing.Size(330, 26);
            this.enfermedadesBuscar.TabIndex = 10;
            this.enfermedadesBuscar.TextChanged += new System.EventHandler(this.enfermedadesBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buscar:";
            // 
            // Enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enfermedadesBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enfermedadesCerrar);
            this.Controls.Add(this.enfermedadesEliminar);
            this.Controls.Add(this.enfermedadesEditar);
            this.Controls.Add(this.enfermedadesAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Enfermedades";
            this.Text = "Enfermedades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Enfermedades_FormClosing);
            this.Load += new System.EventHandler(this.Enfermedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button enfermedadesCerrar;
        private System.Windows.Forms.Button enfermedadesEliminar;
        private System.Windows.Forms.Button enfermedadesEditar;
        private System.Windows.Forms.Button enfermedadesAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enfermedadesCancelar;
        private System.Windows.Forms.Button enfermedadesGuardar;
        private System.Windows.Forms.TextBox enfermedadesCodigo;
        private System.Windows.Forms.TextBox enfermedadesNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enfermedadesBuscar;
        private System.Windows.Forms.Label label3;
    }
}