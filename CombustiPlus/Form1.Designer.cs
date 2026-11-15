namespace CombustiPlus
{
    partial class Form1
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblGalones = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.nudGalones = new System.Windows.Forms.NumericUpDown();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.lstDetalle = new System.Windows.Forms.ListBox();
            this.lstDespachos = new System.Windows.Forms.ListBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnPorCombustible = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGalones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 51);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(10, 105);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(101, 20);
            this.lblCombustible.TabIndex = 1;
            this.lblCombustible.Text = "Combustible:";
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.Location = new System.Drawing.Point(10, 158);
            this.lblGalones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(73, 20);
            this.lblGalones.TabIndex = 2;
            this.lblGalones.Text = "Galones:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(10, 200);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(50, 20);
            this.lblPago.TabIndex = 3;
            this.lblPago.Text = "Pago:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(186, 40);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(300, 26);
            this.txtPlaca.TabIndex = 4;
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(186, 92);
            this.cmbCombustible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(300, 28);
            this.cmbCombustible.TabIndex = 5;
            // 
            // nudGalones
            // 
            this.nudGalones.Location = new System.Drawing.Point(186, 148);
            this.nudGalones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudGalones.Name = "nudGalones";
            this.nudGalones.Size = new System.Drawing.Size(180, 26);
            this.nudGalones.TabIndex = 6;
            // 
            // cmbPago
            // 
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(184, 188);
            this.cmbPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(301, 28);
            this.cmbPago.TabIndex = 7;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(15, 291);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(112, 35);
            this.btnCotizar.TabIndex = 8;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnDespachar
            // 
            this.btnDespachar.Location = new System.Drawing.Point(273, 289);
            this.btnDespachar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(112, 35);
            this.btnDespachar.TabIndex = 9;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            // 
            // lstDetalle
            // 
            this.lstDetalle.FormattingEnabled = true;
            this.lstDetalle.ItemHeight = 20;
            this.lstDetalle.Location = new System.Drawing.Point(4, 31);
            this.lstDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDetalle.Name = "lstDetalle";
            this.lstDetalle.Size = new System.Drawing.Size(514, 244);
            this.lstDetalle.TabIndex = 10;
            // 
            // lstDespachos
            // 
            this.lstDespachos.FormattingEnabled = true;
            this.lstDespachos.ItemHeight = 20;
            this.lstDespachos.Location = new System.Drawing.Point(6, 12);
            this.lstDespachos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDespachos.Name = "lstDespachos";
            this.lstDespachos.Size = new System.Drawing.Size(847, 304);
            this.lstDespachos.TabIndex = 11;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(567, 495);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(0, 20);
            this.lblResumen.TabIndex = 12;
            // 
            // btnPorCombustible
            // 
            this.btnPorCombustible.Location = new System.Drawing.Point(6, 328);
            this.btnPorCombustible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPorCombustible.Name = "btnPorCombustible";
            this.btnPorCombustible.Size = new System.Drawing.Size(210, 54);
            this.btnPorCombustible.TabIndex = 13;
            this.btnPorCombustible.Text = "Por Combustible";
            this.btnPorCombustible.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDespachar);
            this.groupBox1.Controls.Add(this.btnCotizar);
            this.groupBox1.Controls.Add(this.cmbPago);
            this.groupBox1.Controls.Add(this.nudGalones);
            this.groupBox1.Controls.Add(this.cmbCombustible);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.lblGalones);
            this.groupBox1.Controls.Add(this.lblCombustible);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(506, 369);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPorCombustible);
            this.groupBox2.Controls.Add(this.lstDespachos);
            this.groupBox2.Location = new System.Drawing.Point(526, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(867, 395);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDetalle);
            this.groupBox3.Location = new System.Drawing.Point(14, 423);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(538, 298);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 718);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResumen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGalones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblGalones;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.NumericUpDown nudGalones;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.ListBox lstDetalle;
        private System.Windows.Forms.ListBox lstDespachos;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnPorCombustible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

