namespace pryOrellanoConexionBD
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.dgvMostrara = new System.Windows.Forms.DataGridView();
            this.lblProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrara
            // 
            this.dgvMostrara.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvMostrara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrara.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvMostrara.Location = new System.Drawing.Point(37, 73);
            this.dgvMostrara.MultiSelect = false;
            this.dgvMostrara.Name = "dgvMostrara";
            this.dgvMostrara.ReadOnly = true;
            this.dgvMostrara.RowHeadersVisible = false;
            this.dgvMostrara.RowHeadersWidth = 51;
            this.dgvMostrara.RowTemplate.Height = 24;
            this.dgvMostrara.ShowCellErrors = false;
            this.dgvMostrara.ShowCellToolTips = false;
            this.dgvMostrara.ShowEditingIcon = false;
            this.dgvMostrara.ShowRowErrors = false;
            this.dgvMostrara.Size = new System.Drawing.Size(967, 506);
            this.dgvMostrara.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductos.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductos.Location = new System.Drawing.Point(389, 20);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(257, 32);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Todos los productos";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.dgvMostrara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrara;
        private System.Windows.Forms.Label lblProductos;
    }
}