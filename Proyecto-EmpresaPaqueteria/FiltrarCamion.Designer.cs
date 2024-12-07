namespace Proyecto_EmpresaPaqueteria
{
    partial class FiltrarCamion
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
            this.radioButtonCamionFiltrarMarca = new System.Windows.Forms.RadioButton();
            this.radioButtonCamionFiltrarModelo = new System.Windows.Forms.RadioButton();
            this.radioButtonCamionFiltrarMatricula = new System.Windows.Forms.RadioButton();
            this.textBoxCamionFiltrar = new System.Windows.Forms.TextBox();
            this.checkBoxCamionFiltrar = new System.Windows.Forms.CheckBox();
            this.dataGridViewCamionFiltrar = new System.Windows.Forms.DataGridView();
            this.buttonCamionFiltrarSubmit = new System.Windows.Forms.Button();
            this.buttonAltaBaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionFiltrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonCamionFiltrarMarca
            // 
            this.radioButtonCamionFiltrarMarca.AutoSize = true;
            this.radioButtonCamionFiltrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCamionFiltrarMarca.Location = new System.Drawing.Point(33, 19);
            this.radioButtonCamionFiltrarMarca.Name = "radioButtonCamionFiltrarMarca";
            this.radioButtonCamionFiltrarMarca.Size = new System.Drawing.Size(80, 28);
            this.radioButtonCamionFiltrarMarca.TabIndex = 0;
            this.radioButtonCamionFiltrarMarca.Text = "Marca";
            this.radioButtonCamionFiltrarMarca.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamionFiltrarModelo
            // 
            this.radioButtonCamionFiltrarModelo.AutoSize = true;
            this.radioButtonCamionFiltrarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCamionFiltrarModelo.Location = new System.Drawing.Point(33, 74);
            this.radioButtonCamionFiltrarModelo.Name = "radioButtonCamionFiltrarModelo";
            this.radioButtonCamionFiltrarModelo.Size = new System.Drawing.Size(92, 28);
            this.radioButtonCamionFiltrarModelo.TabIndex = 0;
            this.radioButtonCamionFiltrarModelo.Text = "Modelo";
            this.radioButtonCamionFiltrarModelo.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamionFiltrarMatricula
            // 
            this.radioButtonCamionFiltrarMatricula.AutoSize = true;
            this.radioButtonCamionFiltrarMatricula.Checked = true;
            this.radioButtonCamionFiltrarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCamionFiltrarMatricula.Location = new System.Drawing.Point(33, 127);
            this.radioButtonCamionFiltrarMatricula.Name = "radioButtonCamionFiltrarMatricula";
            this.radioButtonCamionFiltrarMatricula.Size = new System.Drawing.Size(103, 28);
            this.radioButtonCamionFiltrarMatricula.TabIndex = 0;
            this.radioButtonCamionFiltrarMatricula.TabStop = true;
            this.radioButtonCamionFiltrarMatricula.Text = "Matricula";
            this.radioButtonCamionFiltrarMatricula.UseVisualStyleBackColor = true;
            // 
            // textBoxCamionFiltrar
            // 
            this.textBoxCamionFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCamionFiltrar.Location = new System.Drawing.Point(55, 46);
            this.textBoxCamionFiltrar.Name = "textBoxCamionFiltrar";
            this.textBoxCamionFiltrar.Size = new System.Drawing.Size(149, 29);
            this.textBoxCamionFiltrar.TabIndex = 1;
            // 
            // checkBoxCamionFiltrar
            // 
            this.checkBoxCamionFiltrar.AutoSize = true;
            this.checkBoxCamionFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCamionFiltrar.Location = new System.Drawing.Point(404, 12);
            this.checkBoxCamionFiltrar.Name = "checkBoxCamionFiltrar";
            this.checkBoxCamionFiltrar.Size = new System.Drawing.Size(245, 28);
            this.checkBoxCamionFiltrar.TabIndex = 2;
            this.checkBoxCamionFiltrar.Text = "Mostrar camiones de baja";
            this.checkBoxCamionFiltrar.UseVisualStyleBackColor = true;
            this.checkBoxCamionFiltrar.CheckedChanged += new System.EventHandler(this.checkBoxCamionFiltrar_CheckedChanged);
            // 
            // dataGridViewCamionFiltrar
            // 
            this.dataGridViewCamionFiltrar.AllowUserToAddRows = false;
            this.dataGridViewCamionFiltrar.AllowUserToDeleteRows = false;
            this.dataGridViewCamionFiltrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCamionFiltrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamionFiltrar.Location = new System.Drawing.Point(244, 46);
            this.dataGridViewCamionFiltrar.Name = "dataGridViewCamionFiltrar";
            this.dataGridViewCamionFiltrar.ReadOnly = true;
            this.dataGridViewCamionFiltrar.Size = new System.Drawing.Size(598, 191);
            this.dataGridViewCamionFiltrar.TabIndex = 3;
            this.dataGridViewCamionFiltrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCamionFiltrar_CellContentClick);
            // 
            // buttonCamionFiltrarSubmit
            // 
            this.buttonCamionFiltrarSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamionFiltrarSubmit.Location = new System.Drawing.Point(55, 260);
            this.buttonCamionFiltrarSubmit.Name = "buttonCamionFiltrarSubmit";
            this.buttonCamionFiltrarSubmit.Size = new System.Drawing.Size(149, 36);
            this.buttonCamionFiltrarSubmit.TabIndex = 4;
            this.buttonCamionFiltrarSubmit.Text = "Filtrar";
            this.buttonCamionFiltrarSubmit.UseVisualStyleBackColor = true;
            this.buttonCamionFiltrarSubmit.Click += new System.EventHandler(this.buttonCamionFiltrarSubmit_Click);
            // 
            // buttonAltaBaja
            // 
            this.buttonAltaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltaBaja.Location = new System.Drawing.Point(244, 260);
            this.buttonAltaBaja.Name = "buttonAltaBaja";
            this.buttonAltaBaja.Size = new System.Drawing.Size(598, 36);
            this.buttonAltaBaja.TabIndex = 4;
            this.buttonAltaBaja.Text = "Alta/Baja";
            this.buttonAltaBaja.UseVisualStyleBackColor = true;
            this.buttonAltaBaja.Click += new System.EventHandler(this.buttonAltaBaja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCamionFiltrarMarca);
            this.groupBox1.Controls.Add(this.radioButtonCamionFiltrarModelo);
            this.groupBox1.Controls.Add(this.radioButtonCamionFiltrarMatricula);
            this.groupBox1.Location = new System.Drawing.Point(55, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FiltrarCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAltaBaja);
            this.Controls.Add(this.buttonCamionFiltrarSubmit);
            this.Controls.Add(this.dataGridViewCamionFiltrar);
            this.Controls.Add(this.checkBoxCamionFiltrar);
            this.Controls.Add(this.textBoxCamionFiltrar);
            this.Name = "FiltrarCamion";
            this.Text = "FiltrarCamion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionFiltrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCamionFiltrarMarca;
        private System.Windows.Forms.RadioButton radioButtonCamionFiltrarModelo;
        private System.Windows.Forms.RadioButton radioButtonCamionFiltrarMatricula;
        private System.Windows.Forms.TextBox textBoxCamionFiltrar;
        private System.Windows.Forms.CheckBox checkBoxCamionFiltrar;
        private System.Windows.Forms.DataGridView dataGridViewCamionFiltrar;
        private System.Windows.Forms.Button buttonCamionFiltrarSubmit;
        private System.Windows.Forms.Button buttonAltaBaja;
        private System.Windows.Forms.GroupBox groupBox1;
        
    }
}