namespace Parcial2_Adriel.UI.Consulta
{
    partial class cInscripcion
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
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(336, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Criterio:";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Monto",
            "EstudianteId"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(582, 19);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrocomboBox.TabIndex = 4;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2_Adriel.Properties.Resources.find;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(924, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(91, 32);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(406, 19);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.HastadateTimePicker.TabIndex = 6;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(211, 19);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.DesdedateTimePicker.TabIndex = 7;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(772, 19);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(117, 22);
            this.CriteriotextBox.TabIndex = 8;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 51);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.RowTemplate.Height = 24;
            this.ConsultadataGridView.Size = new System.Drawing.Size(1051, 397);
            this.ConsultadataGridView.TabIndex = 9;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(24, 19);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(104, 21);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Filtro Fecha";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // cInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "cInscripcion";
            this.Text = "cInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.CheckBox checkBox;
    }
}