namespace Hospital
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programarExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sintomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.examenesToolStripMenuItem,
            this.enfermedadesToolStripMenuItem,
            this.medicamentosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.inventarioMedicamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.programarCitaToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Tag = "1";
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.agregarToolStripMenuItem.Tag = "11";
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.buscarToolStripMenuItem.Tag = "12";
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // programarCitaToolStripMenuItem
            // 
            this.programarCitaToolStripMenuItem.Name = "programarCitaToolStripMenuItem";
            this.programarCitaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.programarCitaToolStripMenuItem.Tag = "13";
            this.programarCitaToolStripMenuItem.Text = "Programar Cita";
            this.programarCitaToolStripMenuItem.Click += new System.EventHandler(this.programarCitaToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.buscarToolStripMenuItem1,
            this.agregarMédicoToolStripMenuItem,
            this.verMédicosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Tag = "2";
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.agregarToolStripMenuItem1.Tag = "21";
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.buscarToolStripMenuItem1.Tag = "22";
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // agregarMédicoToolStripMenuItem
            // 
            this.agregarMédicoToolStripMenuItem.Name = "agregarMédicoToolStripMenuItem";
            this.agregarMédicoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarMédicoToolStripMenuItem.Tag = "23";
            this.agregarMédicoToolStripMenuItem.Text = "Agregar Médico";
            this.agregarMédicoToolStripMenuItem.Click += new System.EventHandler(this.agregarMédicoToolStripMenuItem_Click);
            // 
            // verMédicosToolStripMenuItem
            // 
            this.verMédicosToolStripMenuItem.Name = "verMédicosToolStripMenuItem";
            this.verMédicosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verMédicosToolStripMenuItem.Tag = "24";
            this.verMédicosToolStripMenuItem.Text = "Ver Médicos";
            this.verMédicosToolStripMenuItem.Click += new System.EventHandler(this.verMédicosToolStripMenuItem_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programarExamenToolStripMenuItem,
            this.examenesPendientesToolStripMenuItem,
            this.examenesRealizadosToolStripMenuItem});
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.examenesToolStripMenuItem.Tag = "3";
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // programarExamenToolStripMenuItem
            // 
            this.programarExamenToolStripMenuItem.Name = "programarExamenToolStripMenuItem";
            this.programarExamenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.programarExamenToolStripMenuItem.Tag = "31";
            this.programarExamenToolStripMenuItem.Text = "Programar Examen";
            // 
            // examenesPendientesToolStripMenuItem
            // 
            this.examenesPendientesToolStripMenuItem.Name = "examenesPendientesToolStripMenuItem";
            this.examenesPendientesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.examenesPendientesToolStripMenuItem.Tag = "32";
            this.examenesPendientesToolStripMenuItem.Text = "Examenes pendientes";
            // 
            // examenesRealizadosToolStripMenuItem
            // 
            this.examenesRealizadosToolStripMenuItem.Name = "examenesRealizadosToolStripMenuItem";
            this.examenesRealizadosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.examenesRealizadosToolStripMenuItem.Tag = "33";
            this.examenesRealizadosToolStripMenuItem.Text = "Examenes Realizados";
            this.examenesRealizadosToolStripMenuItem.Click += new System.EventHandler(this.examenesRealizadosToolStripMenuItem_Click);
            // 
            // enfermedadesToolStripMenuItem
            // 
            this.enfermedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.sintomasToolStripMenuItem});
            this.enfermedadesToolStripMenuItem.Name = "enfermedadesToolStripMenuItem";
            this.enfermedadesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.enfermedadesToolStripMenuItem.Tag = "4";
            this.enfermedadesToolStripMenuItem.Text = "Enfermedades";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem.Tag = "41";
            this.registrarToolStripMenuItem.Text = "Consultar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // sintomasToolStripMenuItem
            // 
            this.sintomasToolStripMenuItem.Name = "sintomasToolStripMenuItem";
            this.sintomasToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sintomasToolStripMenuItem.Tag = "43";
            this.sintomasToolStripMenuItem.Text = "Sintomas";
            this.sintomasToolStripMenuItem.Click += new System.EventHandler(this.sintomasToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.consultarToolStripMenuItem1,
            this.AgregarLoteToolStripMenuItem});
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.medicamentosToolStripMenuItem.Tag = "5";
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.agregarToolStripMenuItem2.Tag = "51";
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.consultarToolStripMenuItem1.Tag = "52";
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // AgregarLoteToolStripMenuItem
            // 
            this.AgregarLoteToolStripMenuItem.Name = "AgregarLoteToolStripMenuItem";
            this.AgregarLoteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.AgregarLoteToolStripMenuItem.Tag = "54";
            this.AgregarLoteToolStripMenuItem.Text = "Agregar Lote";
            this.AgregarLoteToolStripMenuItem.Click += new System.EventHandler(this.AgregarLoteToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.buscarToolStripMenuItem2,
            this.agregarRolToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Tag = "6";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(159, 22);
            this.agregarToolStripMenuItem3.Tag = "61";
            this.agregarToolStripMenuItem3.Text = "Agregar Usuario";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // buscarToolStripMenuItem2
            // 
            this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
            this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(159, 22);
            this.buscarToolStripMenuItem2.Tag = "62";
            this.buscarToolStripMenuItem2.Text = "Buscar";
            // 
            // agregarRolToolStripMenuItem
            // 
            this.agregarRolToolStripMenuItem.Name = "agregarRolToolStripMenuItem";
            this.agregarRolToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarRolToolStripMenuItem.Tag = "63";
            this.agregarRolToolStripMenuItem.Text = "Agregar Rol";
            this.agregarRolToolStripMenuItem.Click += new System.EventHandler(this.agregarRolToolStripMenuItem_Click);
            // 
            // inventarioMedicamentosToolStripMenuItem
            // 
            this.inventarioMedicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMedicamentoToolStripMenuItem,
            this.eliminarMedicamentoToolStripMenuItem,
            this.actualizarExistenciasToolStripMenuItem});
            this.inventarioMedicamentosToolStripMenuItem.Name = "inventarioMedicamentosToolStripMenuItem";
            this.inventarioMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.inventarioMedicamentosToolStripMenuItem.Tag = "7";
            this.inventarioMedicamentosToolStripMenuItem.Text = "Inventario Medicamentos";
            // 
            // agregarMedicamentoToolStripMenuItem
            // 
            this.agregarMedicamentoToolStripMenuItem.Name = "agregarMedicamentoToolStripMenuItem";
            this.agregarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.agregarMedicamentoToolStripMenuItem.Tag = "71";
            this.agregarMedicamentoToolStripMenuItem.Text = "Agregar Medicamento";
            this.agregarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.agregarMedicamentosToolStripMenuItem_Click);
            // 
            // eliminarMedicamentoToolStripMenuItem
            // 
            this.eliminarMedicamentoToolStripMenuItem.Name = "eliminarMedicamentoToolStripMenuItem";
            this.eliminarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarMedicamentoToolStripMenuItem.Tag = "72";
            this.eliminarMedicamentoToolStripMenuItem.Text = "Mostrar Inventario";
            this.eliminarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.eliminarMedicamentoToolStripMenuItem_Click);
            // 
            // actualizarExistenciasToolStripMenuItem
            // 
            this.actualizarExistenciasToolStripMenuItem.Name = "actualizarExistenciasToolStripMenuItem";
            this.actualizarExistenciasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.actualizarExistenciasToolStripMenuItem.Tag = "73";
            this.actualizarExistenciasToolStripMenuItem.Text = "Actualizar Existencias";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 778);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // skinEngine1
            // 
            this.skinEngine1.DefaultButtonStyle = Sunisoft.IrisSkin.DefaultButtonStyle.Line;
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 800);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programarExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem examenesPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarExistenciasToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripMenuItem sintomasToolStripMenuItem;
    }
}