
namespace WindowsFormsApp1
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
            this.lbl_archivo = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.rtb_archivo = new System.Windows.Forms.RichTextBox();
            this.lbl_palabra = new System.Windows.Forms.Label();
            this.lbl_lineas = new System.Windows.Forms.Label();
            this.btn_palabras = new System.Windows.Forms.Button();
            this.btn_lineas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_archivo
            // 
            this.lbl_archivo.AutoSize = true;
            this.lbl_archivo.Location = new System.Drawing.Point(40, 58);
            this.lbl_archivo.Name = "lbl_archivo";
            this.lbl_archivo.Size = new System.Drawing.Size(43, 13);
            this.lbl_archivo.TabIndex = 1;
            this.lbl_archivo.Text = "Archivo";
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(401, 43);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(89, 23);
            this.btn_cargar.TabIndex = 2;
            this.btn_cargar.Text = "Cargar archivo";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // rtb_archivo
            // 
            this.rtb_archivo.Location = new System.Drawing.Point(95, 43);
            this.rtb_archivo.Name = "rtb_archivo";
            this.rtb_archivo.Size = new System.Drawing.Size(288, 205);
            this.rtb_archivo.TabIndex = 3;
            this.rtb_archivo.Text = "";
            // 
            // lbl_palabra
            // 
            this.lbl_palabra.AutoSize = true;
            this.lbl_palabra.Location = new System.Drawing.Point(159, 304);
            this.lbl_palabra.Name = "lbl_palabra";
            this.lbl_palabra.Size = new System.Drawing.Size(0, 13);
            this.lbl_palabra.TabIndex = 4;
            // 
            // lbl_lineas
            // 
            this.lbl_lineas.AutoSize = true;
            this.lbl_lineas.Location = new System.Drawing.Point(159, 338);
            this.lbl_lineas.Name = "lbl_lineas";
            this.lbl_lineas.Size = new System.Drawing.Size(0, 13);
            this.lbl_lineas.TabIndex = 6;
            // 
            // btn_palabras
            // 
            this.btn_palabras.Location = new System.Drawing.Point(61, 299);
            this.btn_palabras.Name = "btn_palabras";
            this.btn_palabras.Size = new System.Drawing.Size(75, 23);
            this.btn_palabras.TabIndex = 8;
            this.btn_palabras.Text = "Palabras";
            this.btn_palabras.UseVisualStyleBackColor = true;
            this.btn_palabras.Click += new System.EventHandler(this.btn_palabras_Click);
            // 
            // btn_lineas
            // 
            this.btn_lineas.Location = new System.Drawing.Point(61, 333);
            this.btn_lineas.Name = "btn_lineas";
            this.btn_lineas.Size = new System.Drawing.Size(75, 23);
            this.btn_lineas.TabIndex = 9;
            this.btn_lineas.Text = "Lineas";
            this.btn_lineas.UseVisualStyleBackColor = true;
            this.btn_lineas.Click += new System.EventHandler(this.btn_lineas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 448);
            this.Controls.Add(this.btn_lineas);
            this.Controls.Add(this.btn_palabras);
            this.Controls.Add(this.lbl_lineas);
            this.Controls.Add(this.lbl_palabra);
            this.Controls.Add(this.rtb_archivo);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.lbl_archivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_archivo;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.RichTextBox rtb_archivo;
        private System.Windows.Forms.Label lbl_palabra;
        private System.Windows.Forms.Label lbl_lineas;
        private System.Windows.Forms.Button btn_palabras;
        private System.Windows.Forms.Button btn_lineas;
    }
}

