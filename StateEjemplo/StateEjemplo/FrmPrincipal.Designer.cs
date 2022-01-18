namespace StateEjemplo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstado1 = new System.Windows.Forms.Button();
            this.btnEstado2 = new System.Windows.Forms.Button();
            this.btnEstado3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAterrizar = new System.Windows.Forms.Button();
            this.btnDespegar = new System.Windows.Forms.Button();
            this.btnCerrarAvion = new System.Windows.Forms.Button();
            this.btnVerPasajeros = new System.Windows.Forms.Button();
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.btnEnviarPuerta = new System.Windows.Forms.Button();
            this.rbAvion3 = new System.Windows.Forms.RadioButton();
            this.rbAvion2 = new System.Windows.Forms.RadioButton();
            this.rbAvion1 = new System.Windows.Forms.RadioButton();
            this.txtPuerta = new System.Windows.Forms.TextBox();
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "avion.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración de Flota de Aviones";
            // 
            // btnEstado1
            // 
            this.btnEstado1.Location = new System.Drawing.Point(12, 115);
            this.btnEstado1.Name = "btnEstado1";
            this.btnEstado1.Size = new System.Drawing.Size(126, 38);
            this.btnEstado1.TabIndex = 5;
            this.btnEstado1.Text = "Estado Avión 1";
            this.btnEstado1.UseVisualStyleBackColor = true;
            this.btnEstado1.Click += new System.EventHandler(this.btnEstado1_Click);
            // 
            // btnEstado2
            // 
            this.btnEstado2.Location = new System.Drawing.Point(195, 115);
            this.btnEstado2.Name = "btnEstado2";
            this.btnEstado2.Size = new System.Drawing.Size(126, 38);
            this.btnEstado2.TabIndex = 6;
            this.btnEstado2.Text = "Estado Avión 2";
            this.btnEstado2.UseVisualStyleBackColor = true;
            this.btnEstado2.Click += new System.EventHandler(this.btnEstado2_Click);
            // 
            // btnEstado3
            // 
            this.btnEstado3.Location = new System.Drawing.Point(380, 115);
            this.btnEstado3.Name = "btnEstado3";
            this.btnEstado3.Size = new System.Drawing.Size(126, 38);
            this.btnEstado3.TabIndex = 7;
            this.btnEstado3.Text = "Estado Avión 3";
            this.btnEstado3.UseVisualStyleBackColor = true;
            this.btnEstado3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombrePasajero);
            this.groupBox1.Controls.Add(this.txtPuerta);
            this.groupBox1.Controls.Add(this.btnAterrizar);
            this.groupBox1.Controls.Add(this.btnDespegar);
            this.groupBox1.Controls.Add(this.btnCerrarAvion);
            this.groupBox1.Controls.Add(this.btnVerPasajeros);
            this.groupBox1.Controls.Add(this.btnAgregarPasajero);
            this.groupBox1.Controls.Add(this.btnEnviarPuerta);
            this.groupBox1.Controls.Add(this.rbAvion3);
            this.groupBox1.Controls.Add(this.rbAvion2);
            this.groupBox1.Controls.Add(this.rbAvion1);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 182);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envio de comandos";
            // 
            // btnAterrizar
            // 
            this.btnAterrizar.Location = new System.Drawing.Point(342, 142);
            this.btnAterrizar.Name = "btnAterrizar";
            this.btnAterrizar.Size = new System.Drawing.Size(126, 23);
            this.btnAterrizar.TabIndex = 19;
            this.btnAterrizar.Text = "Aterrizar avión";
            this.btnAterrizar.UseVisualStyleBackColor = true;
            this.btnAterrizar.Click += new System.EventHandler(this.btnAterrizar_Click);
            // 
            // btnDespegar
            // 
            this.btnDespegar.Location = new System.Drawing.Point(177, 142);
            this.btnDespegar.Name = "btnDespegar";
            this.btnDespegar.Size = new System.Drawing.Size(150, 23);
            this.btnDespegar.TabIndex = 18;
            this.btnDespegar.Text = "Despegar avión";
            this.btnDespegar.UseVisualStyleBackColor = true;
            this.btnDespegar.Click += new System.EventHandler(this.btnDespegar_Click);
            // 
            // btnCerrarAvion
            // 
            this.btnCerrarAvion.Location = new System.Drawing.Point(342, 18);
            this.btnCerrarAvion.Name = "btnCerrarAvion";
            this.btnCerrarAvion.Size = new System.Drawing.Size(126, 23);
            this.btnCerrarAvion.TabIndex = 17;
            this.btnCerrarAvion.Text = "Cerrar avión";
            this.btnCerrarAvion.UseVisualStyleBackColor = true;
            this.btnCerrarAvion.Click += new System.EventHandler(this.btnCerrarAvion_Click);
            // 
            // btnVerPasajeros
            // 
            this.btnVerPasajeros.Location = new System.Drawing.Point(342, 92);
            this.btnVerPasajeros.Name = "btnVerPasajeros";
            this.btnVerPasajeros.Size = new System.Drawing.Size(126, 23);
            this.btnVerPasajeros.TabIndex = 16;
            this.btnVerPasajeros.Text = "Ver pasajeros";
            this.btnVerPasajeros.UseVisualStyleBackColor = true;
            this.btnVerPasajeros.Click += new System.EventHandler(this.btnVerPasajeros_Click);
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.Location = new System.Drawing.Point(177, 92);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(150, 24);
            this.btnAgregarPasajero.TabIndex = 15;
            this.btnAgregarPasajero.Text = "Agregar pasajero";
            this.btnAgregarPasajero.UseVisualStyleBackColor = true;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnAgregarPasajero_Click);
            // 
            // btnEnviarPuerta
            // 
            this.btnEnviarPuerta.Location = new System.Drawing.Point(207, 18);
            this.btnEnviarPuerta.Name = "btnEnviarPuerta";
            this.btnEnviarPuerta.Size = new System.Drawing.Size(120, 23);
            this.btnEnviarPuerta.TabIndex = 14;
            this.btnEnviarPuerta.Text = "Enviar a puerta";
            this.btnEnviarPuerta.UseVisualStyleBackColor = true;
            this.btnEnviarPuerta.Click += new System.EventHandler(this.btnEnviarPuerta_Click);
            // 
            // rbAvion3
            // 
            this.rbAvion3.AutoSize = true;
            this.rbAvion3.Location = new System.Drawing.Point(37, 105);
            this.rbAvion3.Name = "rbAvion3";
            this.rbAvion3.Size = new System.Drawing.Size(61, 17);
            this.rbAvion3.TabIndex = 13;
            this.rbAvion3.Text = "Avión 3";
            this.rbAvion3.UseVisualStyleBackColor = true;
            this.rbAvion3.CheckedChanged += new System.EventHandler(this.rbAvion3_CheckedChanged);
            // 
            // rbAvion2
            // 
            this.rbAvion2.AutoSize = true;
            this.rbAvion2.Location = new System.Drawing.Point(37, 83);
            this.rbAvion2.Name = "rbAvion2";
            this.rbAvion2.Size = new System.Drawing.Size(61, 17);
            this.rbAvion2.TabIndex = 12;
            this.rbAvion2.Text = "Avión 2";
            this.rbAvion2.UseVisualStyleBackColor = true;
            this.rbAvion2.CheckedChanged += new System.EventHandler(this.rbAvion2_CheckedChanged);
            // 
            // rbAvion1
            // 
            this.rbAvion1.AutoSize = true;
            this.rbAvion1.Checked = true;
            this.rbAvion1.Location = new System.Drawing.Point(37, 60);
            this.rbAvion1.Name = "rbAvion1";
            this.rbAvion1.Size = new System.Drawing.Size(61, 17);
            this.rbAvion1.TabIndex = 11;
            this.rbAvion1.TabStop = true;
            this.rbAvion1.Text = "Avión 1";
            this.rbAvion1.UseVisualStyleBackColor = true;
            this.rbAvion1.CheckedChanged += new System.EventHandler(this.rbAvion1_CheckedChanged);
            // 
            // txtPuerta
            // 
            this.txtPuerta.Location = new System.Drawing.Point(177, 18);
            this.txtPuerta.Name = "txtPuerta";
            this.txtPuerta.Size = new System.Drawing.Size(24, 20);
            this.txtPuerta.TabIndex = 20;
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.Location = new System.Drawing.Point(177, 66);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.Size = new System.Drawing.Size(150, 20);
            this.txtNombrePasajero.TabIndex = 21;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEstado3);
            this.Controls.Add(this.btnEstado2);
            this.Controls.Add(this.btnEstado1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Ejemplo de patrón State";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstado1;
        private System.Windows.Forms.Button btnEstado2;
        private System.Windows.Forms.Button btnEstado3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAvion3;
        private System.Windows.Forms.RadioButton rbAvion2;
        private System.Windows.Forms.RadioButton rbAvion1;
        private System.Windows.Forms.Button btnAgregarPasajero;
        private System.Windows.Forms.Button btnEnviarPuerta;
        private System.Windows.Forms.Button btnVerPasajeros;
        private System.Windows.Forms.Button btnAterrizar;
        private System.Windows.Forms.Button btnDespegar;
        private System.Windows.Forms.Button btnCerrarAvion;
        private System.Windows.Forms.TextBox txtPuerta;
        private System.Windows.Forms.TextBox txtNombrePasajero;
    }
}