namespace pryRodriguezSp2FerroA
{
    partial class frmFerro
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
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.mcrCostos = new System.Windows.Forms.GroupBox();
            this.lblTotall = new System.Windows.Forms.Label();
            this.lblPrecioo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.mcrCostos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(67, 83);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Dias";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(67, 160);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia";
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(157, 83);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(120, 20);
            this.numDias.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(157, 157);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 3;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // mcrCostos
            // 
            this.mcrCostos.Controls.Add(this.lblTotall);
            this.mcrCostos.Controls.Add(this.lblPrecioo);
            this.mcrCostos.Controls.Add(this.lblTotal);
            this.mcrCostos.Controls.Add(this.lblPrecio);
            this.mcrCostos.Location = new System.Drawing.Point(70, 216);
            this.mcrCostos.Name = "mcrCostos";
            this.mcrCostos.Size = new System.Drawing.Size(281, 125);
            this.mcrCostos.TabIndex = 4;
            this.mcrCostos.TabStop = false;
            this.mcrCostos.Text = "Costos";
            // 
            // lblTotall
            // 
            this.lblTotall.AutoSize = true;
            this.lblTotall.Location = new System.Drawing.Point(142, 74);
            this.lblTotall.Name = "lblTotall";
            this.lblTotall.Size = new System.Drawing.Size(19, 13);
            this.lblTotall.TabIndex = 3;
            this.lblTotall.Text = "....";
            // 
            // lblPrecioo
            // 
            this.lblPrecioo.AutoSize = true;
            this.lblPrecioo.Location = new System.Drawing.Point(139, 43);
            this.lblPrecioo.Name = "lblPrecioo";
            this.lblPrecioo.Size = new System.Drawing.Size(19, 13);
            this.lblPrecioo.TabIndex = 2;
            this.lblPrecioo.Text = "....";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(37, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(37, 43);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio por Km";
            // 
            // frmFerro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 393);
            this.Controls.Add(this.mcrCostos);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Name = "frmFerro";
            this.Text = "FerroCarril";
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.mcrCostos.ResumeLayout(false);
            this.mcrCostos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox mcrCostos;
        private System.Windows.Forms.Label lblTotall;
        private System.Windows.Forms.Label lblPrecioo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
    }
}

