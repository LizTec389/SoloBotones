namespace creacionfichero
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnForma = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(34, 37);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(134, 81);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Fichero";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnForma
            // 
            this.btnForma.Location = new System.Drawing.Point(187, 37);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(122, 81);
            this.btnForma.TabIndex = 1;
            this.btnForma.Text = "Forma 2 de crear";
            this.btnForma.UseVisualStyleBackColor = true;
            this.btnForma.Click += new System.EventHandler(this.btnForma_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(334, 37);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(125, 81);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(474, 37);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(117, 81);
            this.btnArchivo.TabIndex = 3;
            this.btnArchivo.Text = "Leer Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(621, 37);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(121, 81);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Leer Archivo";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(34, 144);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(134, 73);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "Leer Archivo";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(187, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 73);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnForma);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnForma;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnModificar;
    }
}

