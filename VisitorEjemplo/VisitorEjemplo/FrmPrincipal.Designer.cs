namespace VisitorEjemplo
{
    partial class FrmPrincipal
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
            this.lbElementos = new System.Windows.Forms.ListBox();
            this.btnCrearCirculo = new System.Windows.Forms.Button();
            this.btnCrearRectangulo = new System.Windows.Forms.Button();
            this.btnCrearTriangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnSuperficieTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbElementos
            // 
            this.lbElementos.FormattingEnabled = true;
            this.lbElementos.Location = new System.Drawing.Point(284, 21);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(320, 225);
            this.lbElementos.TabIndex = 0;
            this.lbElementos.DoubleClick += new System.EventHandler(this.lbElementos_DoubleClick);
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.Location = new System.Drawing.Point(143, 21);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(97, 23);
            this.btnCrearCirculo.TabIndex = 1;
            this.btnCrearCirculo.Text = "Crear círculo";
            this.btnCrearCirculo.UseVisualStyleBackColor = true;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnCrearCirculo_Click);
            // 
            // btnCrearRectangulo
            // 
            this.btnCrearRectangulo.Location = new System.Drawing.Point(143, 73);
            this.btnCrearRectangulo.Name = "btnCrearRectangulo";
            this.btnCrearRectangulo.Size = new System.Drawing.Size(97, 23);
            this.btnCrearRectangulo.TabIndex = 2;
            this.btnCrearRectangulo.Text = "Crear rectángulo";
            this.btnCrearRectangulo.UseVisualStyleBackColor = true;
            this.btnCrearRectangulo.Click += new System.EventHandler(this.btnCrearRectangulo_Click);
            // 
            // btnCrearTriangulo
            // 
            this.btnCrearTriangulo.Location = new System.Drawing.Point(143, 103);
            this.btnCrearTriangulo.Name = "btnCrearTriangulo";
            this.btnCrearTriangulo.Size = new System.Drawing.Size(97, 23);
            this.btnCrearTriangulo.TabIndex = 3;
            this.btnCrearTriangulo.Text = "Crear triángulo";
            this.btnCrearTriangulo.UseVisualStyleBackColor = true;
            this.btnCrearTriangulo.Click += new System.EventHandler(this.btnCrearTriangulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Altura";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(78, 23);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(30, 20);
            this.txtRadio.TabIndex = 9;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(78, 75);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(30, 20);
            this.txtBase.TabIndex = 10;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(78, 104);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(32, 20);
            this.txtAltura.TabIndex = 11;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(487, 259);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(117, 23);
            this.btnContar.TabIndex = 12;
            this.btnContar.Text = "Contar elementos";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnSuperficieTotal
            // 
            this.btnSuperficieTotal.Location = new System.Drawing.Point(351, 259);
            this.btnSuperficieTotal.Name = "btnSuperficieTotal";
            this.btnSuperficieTotal.Size = new System.Drawing.Size(117, 23);
            this.btnSuperficieTotal.TabIndex = 13;
            this.btnSuperficieTotal.Text = "Superficie total";
            this.btnSuperficieTotal.UseVisualStyleBackColor = true;
            this.btnSuperficieTotal.Click += new System.EventHandler(this.btnSuperficieTotal_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 294);
            this.Controls.Add(this.btnSuperficieTotal);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearTriangulo);
            this.Controls.Add(this.btnCrearRectangulo);
            this.Controls.Add(this.btnCrearCirculo);
            this.Controls.Add(this.lbElementos);
            this.Name = "FrmPrincipal";
            this.Text = "Ejemplo de patrón Visitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbElementos;
        private System.Windows.Forms.Button btnCrearCirculo;
        private System.Windows.Forms.Button btnCrearRectangulo;
        private System.Windows.Forms.Button btnCrearTriangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnSuperficieTotal;
    }
}

