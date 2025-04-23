namespace pryOrellanoConexionBD
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verProuctosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProuctosToolStripMenuItem,
            this.agregarProductoToolStripMenuItem1,
            this.modificarProductoToolStripMenuItem1,
            this.eliminarProductoToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verProuctosToolStripMenuItem
            // 
            this.verProuctosToolStripMenuItem.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verProuctosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.verProuctosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verProuctosToolStripMenuItem.Image")));
            this.verProuctosToolStripMenuItem.Name = "verProuctosToolStripMenuItem";
            this.verProuctosToolStripMenuItem.Size = new System.Drawing.Size(151, 27);
            this.verProuctosToolStripMenuItem.Text = "Ver Prouctos";
            this.verProuctosToolStripMenuItem.Click += new System.EventHandler(this.verProuctosToolStripMenuItem_Click);
            // 
            // agregarProductoToolStripMenuItem1
            // 
            this.agregarProductoToolStripMenuItem1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProductoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.agregarProductoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agregarProductoToolStripMenuItem1.Image")));
            this.agregarProductoToolStripMenuItem1.Name = "agregarProductoToolStripMenuItem1";
            this.agregarProductoToolStripMenuItem1.Size = new System.Drawing.Size(200, 27);
            this.agregarProductoToolStripMenuItem1.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem1.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem1_Click_1);
            // 
            // modificarProductoToolStripMenuItem1
            // 
            this.modificarProductoToolStripMenuItem1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarProductoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarProductoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modificarProductoToolStripMenuItem1.Image")));
            this.modificarProductoToolStripMenuItem1.Name = "modificarProductoToolStripMenuItem1";
            this.modificarProductoToolStripMenuItem1.Size = new System.Drawing.Size(216, 27);
            this.modificarProductoToolStripMenuItem1.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem1.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem1_Click);
            // 
            // eliminarProductoToolStripMenuItem2
            // 
            this.eliminarProductoToolStripMenuItem2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProductoToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarProductoToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("eliminarProductoToolStripMenuItem2.Image")));
            this.eliminarProductoToolStripMenuItem2.Name = "eliminarProductoToolStripMenuItem2";
            this.eliminarProductoToolStripMenuItem2.Size = new System.Drawing.Size(201, 27);
            this.eliminarProductoToolStripMenuItem2.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem2.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem2_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verProuctosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem2;
    }
}

