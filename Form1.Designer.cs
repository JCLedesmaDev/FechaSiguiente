
namespace FechaSiguiente
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
            this.inputDia = new System.Windows.Forms.TextBox();
            this.inputMes = new System.Windows.Forms.TextBox();
            this.inputAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFecha = new System.Windows.Forms.Button();
            this.TextoIngreso = new System.Windows.Forms.Label();
            this.ResultadoFechaSig = new System.Windows.Forms.Label();
            this.RepetirProceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDia
            // 
            this.inputDia.Location = new System.Drawing.Point(185, 178);
            this.inputDia.Name = "inputDia";
            this.inputDia.Size = new System.Drawing.Size(100, 22);
            this.inputDia.TabIndex = 2;
            // 
            // inputMes
            // 
            this.inputMes.Location = new System.Drawing.Point(291, 178);
            this.inputMes.Name = "inputMes";
            this.inputMes.Size = new System.Drawing.Size(100, 22);
            this.inputMes.TabIndex = 3;
            // 
            // inputAño
            // 
            this.inputAño.Location = new System.Drawing.Point(397, 178);
            this.inputAño.Name = "inputAño";
            this.inputAño.Size = new System.Drawing.Size(100, 22);
            this.inputAño.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Año";
            // 
            // BtnFecha
            // 
            this.BtnFecha.Location = new System.Drawing.Point(196, 224);
            this.BtnFecha.Name = "BtnFecha";
            this.BtnFecha.Size = new System.Drawing.Size(167, 49);
            this.BtnFecha.TabIndex = 8;
            this.BtnFecha.Text = "Obtener fecha siguiente";
            this.BtnFecha.UseVisualStyleBackColor = true;
            this.BtnFecha.Click += new System.EventHandler(this.ObtenerFechaSiguiente);
            // 
            // TextoIngreso
            // 
            this.TextoIngreso.AutoSize = true;
            this.TextoIngreso.Location = new System.Drawing.Point(225, 289);
            this.TextoIngreso.Name = "TextoIngreso";
            this.TextoIngreso.Size = new System.Drawing.Size(253, 17);
            this.TextoIngreso.TabIndex = 9;
            this.TextoIngreso.Text = "La fecha siguiente a la que ingreso es:";
            // 
            // ResultadoFechaSig
            // 
            this.ResultadoFechaSig.AutoSize = true;
            this.ResultadoFechaSig.Location = new System.Drawing.Point(285, 315);
            this.ResultadoFechaSig.Name = "ResultadoFechaSig";
            this.ResultadoFechaSig.Size = new System.Drawing.Size(0, 17);
            this.ResultadoFechaSig.TabIndex = 10;
            // 
            // RepetirProceso
            // 
            this.RepetirProceso.Location = new System.Drawing.Point(376, 224);
            this.RepetirProceso.Name = "RepetirProceso";
            this.RepetirProceso.Size = new System.Drawing.Size(111, 49);
            this.RepetirProceso.TabIndex = 11;
            this.RepetirProceso.Text = "Intentar de nuevo";
            this.RepetirProceso.UseVisualStyleBackColor = true;
            this.RepetirProceso.Click += new System.EventHandler(this.IntentarDeNuevo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RepetirProceso);
            this.Controls.Add(this.ResultadoFechaSig);
            this.Controls.Add(this.TextoIngreso);
            this.Controls.Add(this.BtnFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputAño);
            this.Controls.Add(this.inputMes);
            this.Controls.Add(this.inputDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDia;
        private System.Windows.Forms.TextBox inputMes;
        private System.Windows.Forms.TextBox inputAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFecha;
        private System.Windows.Forms.Label TextoIngreso;
        private System.Windows.Forms.Label ResultadoFechaSig;
        private System.Windows.Forms.Button RepetirProceso;
    }
}

