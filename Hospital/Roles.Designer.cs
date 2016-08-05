namespace Hospital
{
    partial class Roles
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
            this.rolAgregar = new System.Windows.Forms.Button();
            this.rolEditar = new System.Windows.Forms.Button();
            this.rolEliminar = new System.Windows.Forms.Button();
            this.rolCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rolNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // rolAgregar
            // 
            this.rolAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolAgregar.Location = new System.Drawing.Point(52, 322);
            this.rolAgregar.Name = "rolAgregar";
            this.rolAgregar.Size = new System.Drawing.Size(92, 34);
            this.rolAgregar.TabIndex = 1;
            this.rolAgregar.Text = "Agregar";
            this.rolAgregar.UseVisualStyleBackColor = true;
            this.rolAgregar.Click += new System.EventHandler(this.rolAgregar_Click);
            // 
            // rolEditar
            // 
            this.rolEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolEditar.Location = new System.Drawing.Point(150, 322);
            this.rolEditar.Name = "rolEditar";
            this.rolEditar.Size = new System.Drawing.Size(90, 34);
            this.rolEditar.TabIndex = 2;
            this.rolEditar.Text = "Editar";
            this.rolEditar.UseVisualStyleBackColor = true;
            // 
            // rolEliminar
            // 
            this.rolEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolEliminar.Location = new System.Drawing.Point(246, 322);
            this.rolEliminar.Name = "rolEliminar";
            this.rolEliminar.Size = new System.Drawing.Size(85, 34);
            this.rolEliminar.TabIndex = 3;
            this.rolEliminar.Text = "Eliminar";
            this.rolEliminar.UseVisualStyleBackColor = true;
            this.rolEliminar.Click += new System.EventHandler(this.rolEliminar_Click);
            // 
            // rolCerrar
            // 
            this.rolCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolCerrar.Location = new System.Drawing.Point(337, 322);
            this.rolCerrar.Name = "rolCerrar";
            this.rolCerrar.Size = new System.Drawing.Size(81, 34);
            this.rolCerrar.TabIndex = 4;
            this.rolCerrar.Text = "Cerrar";
            this.rolCerrar.UseVisualStyleBackColor = true;
            this.rolCerrar.Click += new System.EventHandler(this.rolCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rolNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rolNombre
            // 
            this.rolNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolNombre.Location = new System.Drawing.Point(120, 27);
            this.rolNombre.Name = "rolNombre";
            this.rolNombre.Size = new System.Drawing.Size(228, 24);
            this.rolNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Rol:";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rolCerrar);
            this.Controls.Add(this.rolEliminar);
            this.Controls.Add(this.rolEditar);
            this.Controls.Add(this.rolAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Roles";
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button rolAgregar;
        private System.Windows.Forms.Button rolEditar;
        private System.Windows.Forms.Button rolEliminar;
        private System.Windows.Forms.Button rolCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rolNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}