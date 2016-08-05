namespace Hospital
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usuariosRol = new System.Windows.Forms.ComboBox();
            this.usuarioPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usuarioBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdui = new System.Windows.Forms.RadioButton();
            this.rapellidos = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // usuarioPassword
            // 
            this.usuarioPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioPassword.Location = new System.Drawing.Point(327, 324);
            this.usuarioPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuarioPassword.Name = "usuarioPassword";
            this.usuarioPassword.PasswordChar = '*';
            this.usuarioPassword.Size = new System.Drawing.Size(265, 30);
            this.usuarioPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol:";
            // 
            // usuariosRol
            // 
            this.usuariosRol.FormattingEnabled = true;
            this.usuariosRol.Location = new System.Drawing.Point(327, 399);
            this.usuariosRol.Margin = new System.Windows.Forms.Padding(4);
            this.usuariosRol.Name = "usuariosRol";
            this.usuariosRol.Size = new System.Drawing.Size(233, 24);
            this.usuariosRol.TabIndex = 7;
            // 
            // usuarioPassword2
            // 
            this.usuarioPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioPassword2.Location = new System.Drawing.Point(327, 361);
            this.usuarioPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuarioPassword2.Name = "usuarioPassword2";
            this.usuarioPassword2.PasswordChar = '*';
            this.usuarioPassword2.Size = new System.Drawing.Size(265, 30);
            this.usuarioPassword2.TabIndex = 9;
            this.usuarioPassword2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Repetir Contraseña:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar empleado:";
            // 
            // usuarioBuscar
            // 
            this.usuarioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioBuscar.Location = new System.Drawing.Point(271, 34);
            this.usuarioBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioBuscar.Name = "usuarioBuscar";
            this.usuarioBuscar.Size = new System.Drawing.Size(348, 30);
            this.usuarioBuscar.TabIndex = 13;
            this.usuarioBuscar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 185);
            this.dataGridView1.TabIndex = 15;
            // 
            // rdui
            // 
            this.rdui.AutoSize = true;
            this.rdui.Location = new System.Drawing.Point(276, 74);
            this.rdui.Margin = new System.Windows.Forms.Padding(4);
            this.rdui.Name = "rdui";
            this.rdui.Size = new System.Drawing.Size(52, 21);
            this.rdui.TabIndex = 16;
            this.rdui.TabStop = true;
            this.rdui.Text = "DUI";
            this.rdui.UseVisualStyleBackColor = true;
            // 
            // rapellidos
            // 
            this.rapellidos.AutoSize = true;
            this.rapellidos.Location = new System.Drawing.Point(343, 74);
            this.rapellidos.Margin = new System.Windows.Forms.Padding(4);
            this.rapellidos.Name = "rapellidos";
            this.rapellidos.Size = new System.Drawing.Size(86, 21);
            this.rapellidos.TabIndex = 18;
            this.rapellidos.TabStop = true;
            this.rapellidos.Text = "Apellidos";
            this.rapellidos.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(746, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 63);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 519);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rapellidos);
            this.Controls.Add(this.rdui);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.usuarioBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuarioPassword2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariosRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuarioPassword);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox usuariosRol;
        private System.Windows.Forms.TextBox usuarioPassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usuarioBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdui;
        private System.Windows.Forms.RadioButton rapellidos;
        private System.Windows.Forms.Button button3;
    }
}