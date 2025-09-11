namespace Agenda
{
    partial class frmAgenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssCambios = new System.Windows.Forms.StatusStrip();
            this.tsslRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.svfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrSave = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.ssCambios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(744, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.eliminarTodoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.archivoToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // eliminarTodoToolStripMenuItem
            // 
            this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
            this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.eliminarTodoToolStripMenuItem.Text = "&Eliminar todo";
            this.eliminarTodoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodoToolStripMenuItem_Click);
            // 
            // ssCambios
            // 
            this.ssCambios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRegistros});
            this.ssCambios.Location = new System.Drawing.Point(0, 428);
            this.ssCambios.Name = "ssCambios";
            this.ssCambios.Size = new System.Drawing.Size(744, 22);
            this.ssCambios.TabIndex = 2;
            this.ssCambios.Text = "statusStrip1";
            // 
            // tsslRegistros
            // 
            this.tsslRegistros.Name = "tsslRegistros";
            this.tsslRegistros.Size = new System.Drawing.Size(158, 17);
            this.tsslRegistros.Text = "No se ha cargado un archivo";
            // 
            // svfdGuardar
            // 
            this.svfdGuardar.Filter = "Registros|*.json";
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.Filter = "Archivo|*.json";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 24);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(744, 404);
            this.dgvDatos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido Paterno";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido Materno";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefono";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Correo";
            this.Column6.Name = "Column6";
            // 
            // tmrSave
            // 
            this.tmrSave.Enabled = true;
            this.tmrSave.Interval = 500;
            this.tmrSave.Tick += new System.EventHandler(this.tmrSave_Tick);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.ssCambios);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssCambios.ResumeLayout(false);
            this.ssCambios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssCambios;
        private System.Windows.Forms.ToolStripStatusLabel tsslRegistros;
        private System.Windows.Forms.SaveFileDialog svfdGuardar;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodoToolStripMenuItem;
        private System.Windows.Forms.Timer tmrSave;
    }
}

