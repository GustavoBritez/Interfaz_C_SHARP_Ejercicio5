namespace Ejercicio5
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
            this.BTN_COMENZAR = new System.Windows.Forms.Button();
            this.BOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_COMENZAR
            // 
            this.BTN_COMENZAR.Location = new System.Drawing.Point(145, 59);
            this.BTN_COMENZAR.Name = "BTN_COMENZAR";
            this.BTN_COMENZAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_COMENZAR.TabIndex = 0;
            this.BTN_COMENZAR.Text = "button1";
            this.BTN_COMENZAR.UseVisualStyleBackColor = true;
            this.BTN_COMENZAR.Click += new System.EventHandler(this.BTN_COMENZAR_Click);
            // 
            // BOX
            // 
            this.BOX.Location = new System.Drawing.Point(70, 88);
            this.BOX.Multiline = true;
            this.BOX.Name = "BOX";
            this.BOX.Size = new System.Drawing.Size(230, 49);
            this.BOX.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 149);
            this.Controls.Add(this.BOX);
            this.Controls.Add(this.BTN_COMENZAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_COMENZAR;
        private System.Windows.Forms.TextBox BOX;
    }
}

