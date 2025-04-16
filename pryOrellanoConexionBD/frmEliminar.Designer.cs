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
            this.btnEliminar.Location = new System.Drawing.Point(470, 142);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 34);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(94, 210);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 62;
            this.dgvMostrar.RowTemplate.Height = 28;
            this.dgvMostrar.Size = new System.Drawing.Size(855, 310);
            this.dgvMostrar.TabIndex = 27;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(421, 93);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // lblCompletar
            // 
            this.lblCompletar.AutoSize = true;
            this.lblCompletar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletar.Location = new System.Drawing.Point(323, 29);
            this.lblCompletar.Name = "lblCompletar";
            this.lblCompletar.Size = new System.Drawing.Size(403, 20);
            this.lblCompletar.TabIndex = 29;
            this.lblCompletar.Text = "Seleccione el código de la fila que quiere eliminar";
            // 
            // numCodigo
            // 
            this.numCodigo.Location = new System.Drawing.Point(514, 91);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(120, 22);
            this.numCodigo.TabIndex = 30;
            this.numCodigo.ValueChanged += new System.EventHandler(this.numCodigo_ValueChanged);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 564);
            this.Controls.Add(this.numCodigo);
            this.Controls.Add(this.lblCompletar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmEliminar";
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