namespace Parcial2_Adriel.UI
{
    partial class rAsignaturas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CreditosnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AsignaturaId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creditos";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial2_Adriel.Properties.Resources.add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(23, 167);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(81, 65);
            this.Nuevobutton.TabIndex = 3;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial2_Adriel.Properties.Resources.save_as;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(151, 167);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(78, 65);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial2_Adriel.Properties.Resources.delete;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(274, 167);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(72, 65);
            this.Eliminarbutton.TabIndex = 5;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(126, 38);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.IdnumericUpDown.TabIndex = 6;
            // 
            // CreditosnumericUpDown
            // 
            this.CreditosnumericUpDown.Location = new System.Drawing.Point(126, 129);
            this.CreditosnumericUpDown.Name = "CreditosnumericUpDown";
            this.CreditosnumericUpDown.Size = new System.Drawing.Size(187, 22);
            this.CreditosnumericUpDown.TabIndex = 7;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(126, 82);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(187, 22);
            this.DescripciontextBox.TabIndex = 8;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2_Adriel.Properties.Resources.find;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(219, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(94, 37);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            // 
            // rAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CreditosnumericUpDown);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "rAsignaturas";
            this.Text = "rAsignaturas";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.NumericUpDown CreditosnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label2;
    }
}