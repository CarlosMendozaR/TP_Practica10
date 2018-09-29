namespace Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlatillo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComer = new System.Windows.Forms.Button();
            this.lbPagado = new System.Windows.Forms.Label();
            this.lbComido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(55, 172);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(147, 48);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbPrecio);
            this.groupBox1.Controls.Add(this.txtbCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPlatillo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Enabled = false;
            this.txtbPrecio.Location = new System.Drawing.Point(388, 54);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtbPrecio.TabIndex = 6;
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Enabled = false;
            this.txtbCantidad.Location = new System.Drawing.Point(232, 54);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtbCantidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // cmbPlatillo
            // 
            this.cmbPlatillo.FormattingEnabled = true;
            this.cmbPlatillo.Location = new System.Drawing.Point(31, 54);
            this.cmbPlatillo.Name = "cmbPlatillo";
            this.cmbPlatillo.Size = new System.Drawing.Size(121, 24);
            this.cmbPlatillo.TabIndex = 1;
            this.cmbPlatillo.SelectedIndexChanged += new System.EventHandler(this.cmbPlatillo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platillo:";
            // 
            // btnComer
            // 
            this.btnComer.Location = new System.Drawing.Point(55, 272);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(147, 50);
            this.btnComer.TabIndex = 2;
            this.btnComer.Text = "Comer";
            this.btnComer.UseVisualStyleBackColor = true;
            this.btnComer.Visible = false;
            this.btnComer.Click += new System.EventHandler(this.btnComer_Click);
            // 
            // lbPagado
            // 
            this.lbPagado.AutoSize = true;
            this.lbPagado.Location = new System.Drawing.Point(256, 172);
            this.lbPagado.Name = "lbPagado";
            this.lbPagado.Size = new System.Drawing.Size(110, 17);
            this.lbPagado.TabIndex = 3;
            this.lbPagado.Text = "MensajePagado";
            this.lbPagado.Visible = false;
            // 
            // lbComido
            // 
            this.lbComido.AutoSize = true;
            this.lbComido.Location = new System.Drawing.Point(38, 339);
            this.lbComido.Name = "lbComido";
            this.lbComido.Size = new System.Drawing.Size(108, 17);
            this.lbComido.TabIndex = 5;
            this.lbComido.Text = "MensajeComido";
            this.lbComido.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbComido);
            this.Controls.Add(this.lbPagado);
            this.Controls.Add(this.btnComer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPagar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPlatillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.TextBox txtbCantidad;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.Label lbPagado;
        private System.Windows.Forms.Label lbComido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

