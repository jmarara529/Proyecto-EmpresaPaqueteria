namespace Proyecto_EmpresaPaqueteria
{
    partial class FiltrarEnvio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonIdLote = new System.Windows.Forms.RadioButton();
            this.radioButtonMarca = new System.Windows.Forms.RadioButton();
            this.radioButtonMatricula = new System.Windows.Forms.RadioButton();
            this.radioButtonDni = new System.Windows.Forms.RadioButton();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.dataGridViewFiltro = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDni);
            this.groupBox1.Controls.Add(this.radioButtonMatricula);
            this.groupBox1.Controls.Add(this.radioButtonMarca);
            this.groupBox1.Controls.Add(this.radioButtonIdLote);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonIdLote
            // 
            this.radioButtonIdLote.AutoSize = true;
            this.radioButtonIdLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdLote.Location = new System.Drawing.Point(6, 19);
            this.radioButtonIdLote.Name = "radioButtonIdLote";
            this.radioButtonIdLote.Size = new System.Drawing.Size(78, 28);
            this.radioButtonIdLote.TabIndex = 0;
            this.radioButtonIdLote.TabStop = true;
            this.radioButtonIdLote.Text = "id lote";
            this.radioButtonIdLote.UseVisualStyleBackColor = true;
            this.radioButtonIdLote.CheckedChanged += new System.EventHandler(this.radioButtonIdLote_CheckedChanged);
            // 
            // radioButtonMarca
            // 
            this.radioButtonMarca.AutoSize = true;
            this.radioButtonMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMarca.Location = new System.Drawing.Point(6, 107);
            this.radioButtonMarca.Name = "radioButtonMarca";
            this.radioButtonMarca.Size = new System.Drawing.Size(178, 28);
            this.radioButtonMarca.TabIndex = 0;
            this.radioButtonMarca.TabStop = true;
            this.radioButtonMarca.Text = "marca del camion";
            this.radioButtonMarca.UseVisualStyleBackColor = true;
            this.radioButtonMarca.CheckedChanged += new System.EventHandler(this.radioButtonMarca_CheckedChanged);
            // 
            // radioButtonMatricula
            // 
            this.radioButtonMatricula.AutoSize = true;
            this.radioButtonMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMatricula.Location = new System.Drawing.Point(6, 207);
            this.radioButtonMatricula.Name = "radioButtonMatricula";
            this.radioButtonMatricula.Size = new System.Drawing.Size(103, 28);
            this.radioButtonMatricula.TabIndex = 0;
            this.radioButtonMatricula.TabStop = true;
            this.radioButtonMatricula.Text = "matricula";
            this.radioButtonMatricula.UseVisualStyleBackColor = true;
            this.radioButtonMatricula.CheckedChanged += new System.EventHandler(this.radioButtonMatricula_CheckedChanged);
            // 
            // radioButtonDni
            // 
            this.radioButtonDni.AutoSize = true;
            this.radioButtonDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDni.Location = new System.Drawing.Point(6, 313);
            this.radioButtonDni.Name = "radioButtonDni";
            this.radioButtonDni.Size = new System.Drawing.Size(117, 28);
            this.radioButtonDni.TabIndex = 0;
            this.radioButtonDni.TabStop = true;
            this.radioButtonDni.Text = "DNI chofer";
            this.radioButtonDni.UseVisualStyleBackColor = true;
            this.radioButtonDni.CheckedChanged += new System.EventHandler(this.radioButtonDni_CheckedChanged);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(12, 13);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(186, 32);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltro.Location = new System.Drawing.Point(12, 400);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(184, 38);
            this.buttonFiltro.TabIndex = 2;
            this.buttonFiltro.Text = "Filtrar";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.buttonFiltro_Click);
            // 
            // dataGridViewFiltro
            // 
            this.dataGridViewFiltro.AllowUserToAddRows = false;
            this.dataGridViewFiltro.AllowUserToDeleteRows = false;
            this.dataGridViewFiltro.AllowUserToOrderColumns = true;
            this.dataGridViewFiltro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltro.Location = new System.Drawing.Point(204, 13);
            this.dataGridViewFiltro.Name = "dataGridViewFiltro";
            this.dataGridViewFiltro.ReadOnly = true;
            this.dataGridViewFiltro.Size = new System.Drawing.Size(763, 425);
            this.dataGridViewFiltro.TabIndex = 3;
            // 
            // FiltrarEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.dataGridViewFiltro);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.groupBox1);
            this.Name = "FiltrarEnvio";
            this.Text = "FiltrarEnvio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDni;
        private System.Windows.Forms.RadioButton radioButtonMatricula;
        private System.Windows.Forms.RadioButton radioButtonMarca;
        private System.Windows.Forms.RadioButton radioButtonIdLote;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.DataGridView dataGridViewFiltro;
    }
}