namespace FacturacionCine
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaPorEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaPorClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaPorGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(75, 75);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1333, 85);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaPorEmpleadosToolStripMenuItem,
            this.reservaPorClientesToolStripMenuItem,
            this.peliculaPorGeneroToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(171, 79);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reservaPorEmpleadosToolStripMenuItem
            // 
            this.reservaPorEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservaPorEmpleadosToolStripMenuItem.Image")));
            this.reservaPorEmpleadosToolStripMenuItem.Name = "reservaPorEmpleadosToolStripMenuItem";
            this.reservaPorEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(316, 82);
            this.reservaPorEmpleadosToolStripMenuItem.Text = "Reserva por empleados";
            this.reservaPorEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.reservaPorEmpleadosToolStripMenuItem_Click);
            // 
            // reservaPorClientesToolStripMenuItem
            // 
            this.reservaPorClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservaPorClientesToolStripMenuItem.Image")));
            this.reservaPorClientesToolStripMenuItem.Name = "reservaPorClientesToolStripMenuItem";
            this.reservaPorClientesToolStripMenuItem.Size = new System.Drawing.Size(316, 82);
            this.reservaPorClientesToolStripMenuItem.Text = "Reserva por clientes";
            this.reservaPorClientesToolStripMenuItem.Click += new System.EventHandler(this.reservaPorClientesToolStripMenuItem_Click);
            // 
            // peliculaPorGeneroToolStripMenuItem
            // 
            this.peliculaPorGeneroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculaPorGeneroToolStripMenuItem.Image")));
            this.peliculaPorGeneroToolStripMenuItem.Name = "peliculaPorGeneroToolStripMenuItem";
            this.peliculaPorGeneroToolStripMenuItem.Size = new System.Drawing.Size(316, 82);
            this.peliculaPorGeneroToolStripMenuItem.Text = "Pelicula por genero";
            this.peliculaPorGeneroToolStripMenuItem.Click += new System.EventHandler(this.peliculaPorGeneroToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.cineToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.peliculaToolStripMenuItem,
            this.funcionToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(216, 79);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(239, 82);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoToolStripMenuItem.Image")));
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(239, 82);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // cineToolStripMenuItem
            // 
            this.cineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cineToolStripMenuItem.Image")));
            this.cineToolStripMenuItem.Name = "cineToolStripMenuItem";
            this.cineToolStripMenuItem.Size = new System.Drawing.Size(239, 82);
            this.cineToolStripMenuItem.Text = "Cine";
            this.cineToolStripMenuItem.Click += new System.EventHandler(this.cineToolStripMenuItem_Click);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salaToolStripMenuItem.Image")));
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(239, 82);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculaToolStripMenuItem.Image")));
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(239, 82);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // funcionToolStripMenuItem
            // 
            this.funcionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionToolStripMenuItem.Image")));
            this.funcionToolStripMenuItem.Name = "funcionToolStripMenuItem";
            this.funcionToolStripMenuItem.Size = new System.Drawing.Size(239, 82);
            this.funcionToolStripMenuItem.Text = "Funcion";
            this.funcionToolStripMenuItem.Click += new System.EventHandler(this.funcionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 79);
            this.toolStripMenuItem1.Text = "Procesos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(239, 82);
            this.toolStripMenuItem2.Text = "Reserva";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportePaisesToolStripMenuItem,
            this.reporteEmpleadosToolStripMenuItem,
            this.reporteClientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(164, 79);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportePaisesToolStripMenuItem
            // 
            this.reportePaisesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportePaisesToolStripMenuItem.Image")));
            this.reportePaisesToolStripMenuItem.Name = "reportePaisesToolStripMenuItem";
            this.reportePaisesToolStripMenuItem.Size = new System.Drawing.Size(287, 82);
            this.reportePaisesToolStripMenuItem.Text = "Reporte Paises";
            this.reportePaisesToolStripMenuItem.Click += new System.EventHandler(this.reportePaisesToolStripMenuItem_Click);
            // 
            // reporteEmpleadosToolStripMenuItem
            // 
            this.reporteEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteEmpleadosToolStripMenuItem.Image")));
            this.reporteEmpleadosToolStripMenuItem.Name = "reporteEmpleadosToolStripMenuItem";
            this.reporteEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(287, 82);
            this.reporteEmpleadosToolStripMenuItem.Text = "Reporte Empleados";
            this.reporteEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.reporteEmpleadosToolStripMenuItem_Click);
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteClientesToolStripMenuItem.Image")));
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(287, 82);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(131, 79);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem1.Image")));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(239, 82);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1333, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaPorEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaPorClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaPorGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
    }
}

