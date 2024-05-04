namespace SerieIII
{
    partial class Form1
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
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.textTasadeInteres = new System.Windows.Forms.TextBox();
            this.txtPlazodePrestamo = new System.Windows.Forms.TextBox();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblTotalIntereses = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMontoPrestamo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPrestamo.Location = new System.Drawing.Point(86, 94);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(155, 30);
            this.txtMontoPrestamo.TabIndex = 0;
            this.txtMontoPrestamo.Text = "Monto Prestamo";
            this.txtMontoPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoPrestamo.TextChanged += new System.EventHandler(this.txtMontoPrestamo_TextChanged);
            // 
            // textTasadeInteres
            // 
            this.textTasadeInteres.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textTasadeInteres.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTasadeInteres.Location = new System.Drawing.Point(86, 170);
            this.textTasadeInteres.Name = "textTasadeInteres";
            this.textTasadeInteres.Size = new System.Drawing.Size(154, 30);
            this.textTasadeInteres.TabIndex = 1;
            this.textTasadeInteres.Text = "Tasa de Interes";
            this.textTasadeInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTasadeInteres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPlazodePrestamo
            // 
            this.txtPlazodePrestamo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPlazodePrestamo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazodePrestamo.Location = new System.Drawing.Point(86, 246);
            this.txtPlazodePrestamo.Name = "txtPlazodePrestamo";
            this.txtPlazodePrestamo.Size = new System.Drawing.Size(155, 30);
            this.txtPlazodePrestamo.TabIndex = 2;
            this.txtPlazodePrestamo.Text = "Plazo de Prestamo";
            this.txtPlazodePrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(496, 94);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(126, 24);
            this.lblCuotaMensual.TabIndex = 4;
            this.lblCuotaMensual.Text = "Cuota Mensual";
            this.lblCuotaMensual.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalIntereses
            // 
            this.lblTotalIntereses.AutoSize = true;
            this.lblTotalIntereses.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalIntereses.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIntereses.Location = new System.Drawing.Point(496, 156);
            this.lblTotalIntereses.Name = "lblTotalIntereses";
            this.lblTotalIntereses.Size = new System.Drawing.Size(147, 24);
            this.lblTotalIntereses.TabIndex = 5;
            this.lblTotalIntereses.Text = "Total de Intereses";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(500, 246);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(135, 24);
            this.lblTotalPagar.TabIndex = 6;
            this.lblTotalPagar.Text = "Total a Pagar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblTotalIntereses);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.txtPlazodePrestamo);
            this.Controls.Add(this.textTasadeInteres);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.TextBox textTasadeInteres;
        private System.Windows.Forms.TextBox txtPlazodePrestamo;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label lblTotalIntereses;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button button1;
    }
}

