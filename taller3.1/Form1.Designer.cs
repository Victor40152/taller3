namespace taller3._1
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
            this.lblcalculo = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotal1 = new System.Windows.Forms.Label();
            this.btnresultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcalculo
            // 
            this.lblcalculo.AutoSize = true;
            this.lblcalculo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculo.Location = new System.Drawing.Point(229, 44);
            this.lblcalculo.Name = "lblcalculo";
            this.lblcalculo.Size = new System.Drawing.Size(351, 32);
            this.lblcalculo.TabIndex = 0;
            this.lblcalculo.Text = "Calculo del Area del Circulo";
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblradio.Location = new System.Drawing.Point(123, 142);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(71, 24);
            this.lblradio.TabIndex = 1;
            this.lblradio.Text = "Radio:";
            // 
            // txtradio
            // 
            this.txtradio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtradio.Location = new System.Drawing.Point(235, 142);
            this.txtradio.Multiline = true;
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(153, 24);
            this.txtradio.TabIndex = 2;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(122, 210);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(76, 27);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total :";
            // 
            // lbltotal1
            // 
            this.lbltotal1.AutoSize = true;
            this.lbltotal1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal1.Location = new System.Drawing.Point(230, 210);
            this.lbltotal1.Name = "lbltotal1";
            this.lbltotal1.Size = new System.Drawing.Size(25, 27);
            this.lbltotal1.TabIndex = 4;
            this.lbltotal1.Text = "0";
            // 
            // btnresultado
            // 
            this.btnresultado.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultado.Location = new System.Drawing.Point(445, 187);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(123, 50);
            this.btnresultado.TabIndex = 5;
            this.btnresultado.Text = "Calcular";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.lbltotal1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.lblradio);
            this.Controls.Add(this.lblcalculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalculo;
        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotal1;
        private System.Windows.Forms.Button btnresultado;
    }
}

