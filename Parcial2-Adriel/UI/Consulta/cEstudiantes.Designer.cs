namespace Parcial2_Adriel.UI.Consulta
{
    partial class cEstudiantes
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
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2_Adriel.Properties.Resources.find;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(824, 24);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 33);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criterio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtro:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(299, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(45, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Hasta";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(191, 29);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(102, 22);
            this.DesdedateTimePicker.TabIndex = 5;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(360, 29);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(103, 22);
            this.HastadateTimePicker.TabIndex = 6;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todos",
            "ID",
            "Nombres",
            "Balance"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(528, 27);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrocomboBox.TabIndex = 7;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(718, 27);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(100, 22);
            this.CriteriotextBox.TabIndex = 8;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 68);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.Size = new System.Drawing.Size(907, 370);
            this.ConsultadataGridView.TabIndex = 9;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(12, 28);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(104, 21);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Filtro Fecha";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // cEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "cEstudiantes";
            this.Text = "cEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.CheckBox checkBox;
    }
}