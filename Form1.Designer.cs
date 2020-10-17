namespace expresionesRegulares
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreIn = new System.Windows.Forms.TextBox();
            this.codigoIn = new System.Windows.Forms.TextBox();
            this.correoIn = new System.Windows.Forms.TextBox();
            this.paswordIn = new System.Windows.Forms.TextBox();
            this.btnvalidacion = new System.Windows.Forms.Button();
            this.btnValPas = new System.Windows.Forms.Button();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.salida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Correo";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pasword";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreIn
            // 
            this.nombreIn.Location = new System.Drawing.Point(156, 42);
            this.nombreIn.Name = "nombreIn";
            this.nombreIn.Size = new System.Drawing.Size(100, 20);
            this.nombreIn.TabIndex = 1;
            // 
            // codigoIn
            // 
            this.codigoIn.Location = new System.Drawing.Point(156, 75);
            this.codigoIn.Name = "codigoIn";
            this.codigoIn.Size = new System.Drawing.Size(100, 20);
            this.codigoIn.TabIndex = 1;
            // 
            // correoIn
            // 
            this.correoIn.Location = new System.Drawing.Point(156, 108);
            this.correoIn.Name = "correoIn";
            this.correoIn.Size = new System.Drawing.Size(100, 20);
            this.correoIn.TabIndex = 1;
            // 
            // paswordIn
            // 
            this.paswordIn.Location = new System.Drawing.Point(156, 165);
            this.paswordIn.Name = "paswordIn";
            this.paswordIn.PasswordChar = '*';
            this.paswordIn.Size = new System.Drawing.Size(100, 20);
            this.paswordIn.TabIndex = 1;
            // 
            // btnvalidacion
            // 
            this.btnvalidacion.Location = new System.Drawing.Point(316, 75);
            this.btnvalidacion.Name = "btnvalidacion";
            this.btnvalidacion.Size = new System.Drawing.Size(75, 23);
            this.btnvalidacion.TabIndex = 2;
            this.btnvalidacion.Text = "Validar";
            this.btnvalidacion.UseVisualStyleBackColor = true;
            this.btnvalidacion.Click += new System.EventHandler(this.btnvalidacion_Click_1);
            // 
            // btnValPas
            // 
            this.btnValPas.Location = new System.Drawing.Point(316, 165);
            this.btnValPas.Name = "btnValPas";
            this.btnValPas.Size = new System.Drawing.Size(75, 40);
            this.btnValPas.TabIndex = 2;
            this.btnValPas.Text = "Validar Pasword";
            this.btnValPas.UseVisualStyleBackColor = true;
            this.btnValPas.Click += new System.EventHandler(this.btnValPas_Click);
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(313, 19);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(0, 13);
            this.salida.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 233);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.btnValPas);
            this.Controls.Add(this.btnvalidacion);
            this.Controls.Add(this.paswordIn);
            this.Controls.Add(this.correoIn);
            this.Controls.Add(this.codigoIn);
            this.Controls.Add(this.nombreIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreIn;
        private System.Windows.Forms.TextBox codigoIn;
        private System.Windows.Forms.TextBox correoIn;
        private System.Windows.Forms.TextBox paswordIn;
        private System.Windows.Forms.Button btnvalidacion;
        private System.Windows.Forms.Button btnValPas;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.Label salida;
    }
}

