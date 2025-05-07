namespace pryOrellanoConexionBD
{
    partial class frmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminar));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCompletar = new System.Windows.Forms.Label();
            this.numCodigo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(352, 115);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 28);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvMostrar.Location = new System.Drawing.Point(70, 171);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrar.MultiSelect = false;
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.RowHeadersWidth = 62;
            this.dgvMostrar.RowTemplate.Height = 28;
            this.dgvMostrar.ShowCellErrors = false;
            this.dgvMostrar.ShowCellToolTips = false;
            this.dgvMostrar.ShowEditingIcon = false;
            this.dgvMostrar.ShowRowErrors = false;
            this.dgvMostrar.Size = new System.Drawing.Size(641, 252);
            this.dgvMostrar.TabIndex = 27;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(316, 76);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // lblCompletar
            // 
            this.lblCompletar.AutoSize = true;
            this.lblCompletar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompletar.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompletar.Location = new System.Drawing.Point(137, 20);
            this.lblCompletar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletar.Name = "lblCompletar";
            this.lblCompletar.Size = new System.Drawing.Size(506, 25);
            this.lblCompletar.TabIndex = 29;
            this.lblCompletar.Text = "Seleccione el código de la fila que quiere eliminar";
            // 
            // numCodigo
            // 
            this.numCodigo.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigo.Location = new System.Drawing.Point(386, 74);
            this.numCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(90, 27);
            this.numCodigo.TabIndex = 30;
            this.numCodigo.ValueChanged += new System.EventHandler(this.numCodigo_ValueChanged);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 458);
            this.Controls.Add(this.numCodigo);
            this.Controls.Add(this.lblCompletar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Producto";
            this.Load += new System.EventHandler(this.frmEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCompletar;
        private System.Windows.Forms.NumericUpDown numCodigo;
    }
}