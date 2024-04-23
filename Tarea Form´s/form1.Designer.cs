namespace Tarea_Form_s
{
    partial class form1
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
            this.txtIncial = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtVelocida = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIncial
            // 
            this.txtIncial.Location = new System.Drawing.Point(288, 77);
            this.txtIncial.Name = "txtIncial";
            this.txtIncial.Size = new System.Drawing.Size(100, 22);
            this.txtIncial.TabIndex = 0;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(288, 149);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 22);
            this.txtFinal.TabIndex = 1;
            // 
            // txtVelocida
            // 
            this.txtVelocida.Location = new System.Drawing.Point(288, 209);
            this.txtVelocida.Name = "txtVelocida";
            this.txtVelocida.Size = new System.Drawing.Size(100, 22);
            this.txtVelocida.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(288, 262);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "button1";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // form1
            // 
            this.ClientSize = new System.Drawing.Size(718, 436);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVelocida);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtIncial);
            this.Name = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuntoOrigen;
        private System.Windows.Forms.TextBox txtPuntoDestino;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Button btnCalcularTiempo;
        private System.Windows.Forms.TextBox txtIncial;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtVelocida;
        private System.Windows.Forms.Button btnCalcular;
    }
}

