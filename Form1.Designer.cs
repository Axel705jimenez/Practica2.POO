namespace programaclase
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
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnDelfin = new System.Windows.Forms.Button();
            this.btnMarino = new System.Windows.Forms.Button();
            this.btnDelfin1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnimal
            // 
            this.btnAnimal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnimal.Location = new System.Drawing.Point(43, 12);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(212, 57);
            this.btnAnimal.TabIndex = 0;
            this.btnAnimal.Text = "TIPO DE ANIMAL";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelfin
            // 
            this.btnDelfin.Location = new System.Drawing.Point(43, 137);
            this.btnDelfin.Name = "btnDelfin";
            this.btnDelfin.Size = new System.Drawing.Size(212, 56);
            this.btnDelfin.TabIndex = 1;
            this.btnDelfin.Text = "PIEL";
            this.btnDelfin.UseVisualStyleBackColor = true;
            this.btnDelfin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMarino
            // 
            this.btnMarino.Location = new System.Drawing.Point(43, 75);
            this.btnMarino.Name = "btnMarino";
            this.btnMarino.Size = new System.Drawing.Size(212, 56);
            this.btnMarino.TabIndex = 2;
            this.btnMarino.Text = "NOMBRE DEL ANIMAL";
            this.btnMarino.UseVisualStyleBackColor = true;
            this.btnMarino.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelfin1
            // 
            this.btnDelfin1.Location = new System.Drawing.Point(43, 199);
            this.btnDelfin1.Name = "btnDelfin1";
            this.btnDelfin1.Size = new System.Drawing.Size(212, 56);
            this.btnDelfin1.TabIndex = 3;
            this.btnDelfin1.Text = "HABITAT";
            this.btnDelfin1.UseVisualStyleBackColor = true;
            this.btnDelfin1.Click += new System.EventHandler(this.btnDelfin1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::programaclase.Properties.Resources.images__49__1_;
            this.pictureBox1.Location = new System.Drawing.Point(286, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(607, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelfin1);
            this.Controls.Add(this.btnMarino);
            this.Controls.Add(this.btnDelfin);
            this.Controls.Add(this.btnAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private void initializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 767);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnDelfin;
        private System.Windows.Forms.Button btnMarino;
        private System.Windows.Forms.Button btnDelfin1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
