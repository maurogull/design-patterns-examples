namespace StrategyEjemplo
{
    partial class frmPrincipal
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
            this.lstTrabajadores = new System.Windows.Forms.ListBox();
            this.lstTrabajos = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.rbEstrategia1 = new System.Windows.Forms.RadioButton();
            this.rbEstrategia2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTrabajadores
            // 
            this.lstTrabajadores.Enabled = false;
            this.lstTrabajadores.FormattingEnabled = true;
            this.lstTrabajadores.Location = new System.Drawing.Point(9, 31);
            this.lstTrabajadores.Name = "lstTrabajadores";
            this.lstTrabajadores.Size = new System.Drawing.Size(120, 95);
            this.lstTrabajadores.TabIndex = 0;
            // 
            // lstTrabajos
            // 
            this.lstTrabajos.Enabled = false;
            this.lstTrabajos.FormattingEnabled = true;
            this.lstTrabajos.Location = new System.Drawing.Point(139, 31);
            this.lstTrabajos.Name = "lstTrabajos";
            this.lstTrabajos.Size = new System.Drawing.Size(120, 95);
            this.lstTrabajos.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(9, 191);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(113, 28);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar tareas";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(290, 31);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(284, 186);
            this.lstResultados.TabIndex = 3;
            // 
            // rbEstrategia1
            // 
            this.rbEstrategia1.AutoSize = true;
            this.rbEstrategia1.Checked = true;
            this.rbEstrategia1.Location = new System.Drawing.Point(10, 142);
            this.rbEstrategia1.Name = "rbEstrategia1";
            this.rbEstrategia1.Size = new System.Drawing.Size(57, 17);
            this.rbEstrategia1.TabIndex = 4;
            this.rbEstrategia1.TabStop = true;
            this.rbEstrategia1.Text = "Al azar";
            this.rbEstrategia1.UseVisualStyleBackColor = true;
            // 
            // rbEstrategia2
            // 
            this.rbEstrategia2.AutoSize = true;
            this.rbEstrategia2.Location = new System.Drawing.Point(10, 165);
            this.rbEstrategia2.Name = "rbEstrategia2";
            this.rbEstrategia2.Size = new System.Drawing.Size(72, 17);
            this.rbEstrategia2.TabIndex = 5;
            this.rbEstrategia2.Text = "Equitativo";
            this.rbEstrategia2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trabajadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trabajos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultados";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEstrategia2);
            this.Controls.Add(this.rbEstrategia1);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lstTrabajos);
            this.Controls.Add(this.lstTrabajadores);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Ejemplo de patrón Strategy";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTrabajadores;
        private System.Windows.Forms.ListBox lstTrabajos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.RadioButton rbEstrategia1;
        private System.Windows.Forms.RadioButton rbEstrategia2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

