namespace Proyecto_EmpresaPaqueteria
{
    partial class FiltrarPaquetes
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
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonProducto = new System.Windows.Forms.RadioButton();
            this.radioButtonProvincia = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.checkBoxMostrarAsignados = new System.Windows.Forms.CheckBox();
            this.dataGridViewFiltrarProducto = new System.Windows.Forms.DataGridView();
            this.buttonAsignar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(22, 46);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(200, 32);
            this.comboBoxFiltro.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonProvincia);
            this.groupBox1.Controls.Add(this.radioButtonProducto);
            this.groupBox1.Location = new System.Drawing.Point(22, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonProducto
            // 
            this.radioButtonProducto.AutoSize = true;
            this.radioButtonProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProducto.Location = new System.Drawing.Point(23, 54);
            this.radioButtonProducto.Name = "radioButtonProducto";
            this.radioButtonProducto.Size = new System.Drawing.Size(104, 28);
            this.radioButtonProducto.TabIndex = 0;
            this.radioButtonProducto.TabStop = true;
            this.radioButtonProducto.Text = "Producto";
            this.radioButtonProducto.UseVisualStyleBackColor = true;
            // 
            // radioButtonProvincia
            // 
            this.radioButtonProvincia.AutoSize = true;
            this.radioButtonProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProvincia.Location = new System.Drawing.Point(23, 188);
            this.radioButtonProvincia.Name = "radioButtonProvincia";
            this.radioButtonProvincia.Size = new System.Drawing.Size(105, 28);
            this.radioButtonProvincia.TabIndex = 0;
            this.radioButtonProvincia.TabStop = true;
            this.radioButtonProvincia.Text = "Provincia";
            this.radioButtonProvincia.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(22, 399);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(200, 39);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Filtrar";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // checkBoxMostrarAsignados
            // 
            this.checkBoxMostrarAsignados.AutoSize = true;
            this.checkBoxMostrarAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarAsignados.Location = new System.Drawing.Point(425, 12);
            this.checkBoxMostrarAsignados.Name = "checkBoxMostrarAsignados";
            this.checkBoxMostrarAsignados.Size = new System.Drawing.Size(182, 28);
            this.checkBoxMostrarAsignados.TabIndex = 3;
            this.checkBoxMostrarAsignados.Text = "Mostrar asignados";
            this.checkBoxMostrarAsignados.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFiltrarProducto
            // 
            this.dataGridViewFiltrarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltrarProducto.Location = new System.Drawing.Point(228, 46);
            this.dataGridViewFiltrarProducto.Name = "dataGridViewFiltrarProducto";
            this.dataGridViewFiltrarProducto.Size = new System.Drawing.Size(560, 347);
            this.dataGridViewFiltrarProducto.TabIndex = 4;
            // 
            // buttonAsignar
            // 
            this.buttonAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignar.Location = new System.Drawing.Point(228, 399);
            this.buttonAsignar.Name = "buttonAsignar";
            this.buttonAsignar.Size = new System.Drawing.Size(560, 39);
            this.buttonAsignar.TabIndex = 2;
            this.buttonAsignar.Text = "Asignar";
            this.buttonAsignar.UseVisualStyleBackColor = true;
            // 
            // FiltrarPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewFiltrarProducto);
            this.Controls.Add(this.checkBoxMostrarAsignados);
            this.Controls.Add(this.buttonAsignar);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxFiltro);
            this.Name = "FiltrarPaquetes";
            this.Text = "FiltrarPaquetes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonProvincia;
        private System.Windows.Forms.RadioButton radioButtonProducto;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.CheckBox checkBoxMostrarAsignados;
        private System.Windows.Forms.DataGridView dataGridViewFiltrarProducto;
        private System.Windows.Forms.Button buttonAsignar;
    }
}