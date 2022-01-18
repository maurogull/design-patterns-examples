namespace CompositeEjemplo
{
    partial class FrmPrincipal
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
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.clbParticipantes = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGrupos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(17, 252);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(115, 28);
            this.btnCrearGrupo.TabIndex = 4;
            this.btnCrearGrupo.Text = "Crear grupo";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupos";
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(509, 252);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(118, 28);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "Ver promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de grupo";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(17, 217);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(122, 20);
            this.txtNombreGrupo.TabIndex = 9;
            // 
            // clbParticipantes
            // 
            this.clbParticipantes.FormattingEnabled = true;
            this.clbParticipantes.Location = new System.Drawing.Point(17, 25);
            this.clbParticipantes.Name = "clbParticipantes";
            this.clbParticipantes.Size = new System.Drawing.Size(291, 169);
            this.clbParticipantes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Participantes";
            // 
            // lbGrupos
            // 
            this.lbGrupos.FormattingEnabled = true;
            this.lbGrupos.Location = new System.Drawing.Point(341, 25);
            this.lbGrupos.Name = "lbGrupos";
            this.lbGrupos.Size = new System.Drawing.Size(286, 212);
            this.lbGrupos.TabIndex = 12;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 296);
            this.Controls.Add(this.lbGrupos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbParticipantes);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearGrupo);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Ejemplo de Composite";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.CheckedListBox clbParticipantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbGrupos;
    }
}