namespace Proyecto_EmpresaPaqueteria
{
    partial class FiltrarAsignarChofer
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
            this.radioButtonFiltroDni = new System.Windows.Forms.RadioButton();
            this.radioButtonFiltroMatricula = new System.Windows.Forms.RadioButton();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonLiberar = new System.Windows.Forms.Button();
            this.checkBoxMostrarSoloOcupados = new System.Windows.Forms.CheckBox();
            this.dataGridViewAsignarChofer = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignarChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(12, 35);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(174, 32);
            this.comboBoxFiltro.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFiltroDni);
            this.groupBox1.Controls.Add(this.radioButtonFiltroMatricula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFiltroDni
            // 
            this.radioButtonFiltroDni.AutoSize = true;
            this.radioButtonFiltroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFiltroDni.Location = new System.Drawing.Point(7, 217);
            this.radioButtonFiltroDni.Name = "radioButtonFiltroDni";
            this.radioButtonFiltroDni.Size = new System.Drawing.Size(59, 28);
            this.radioButtonFiltroDni.TabIndex = 0;
            this.radioButtonFiltroDni.TabStop = true;
            this.radioButtonFiltroDni.Text = "DNI";
            this.radioButtonFiltroDni.UseVisualStyleBackColor = true;
            this.radioButtonFiltroDni.CheckedChanged += new System.EventHandler(this.CargarDni);
            // 
            // radioButtonFiltroMatricula
            // 
            this.radioButtonFiltroMatricula.AutoSize = true;
            this.radioButtonFiltroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFiltroMatricula.Location = new System.Drawing.Point(6, 91);
            this.radioButtonFiltroMatricula.Name = "radioButtonFiltroMatricula";
            this.radioButtonFiltroMatricula.Size = new System.Drawing.Size(103, 28);
            this.radioButtonFiltroMatricula.TabIndex = 0;
            this.radioButtonFiltroMatricula.Text = "Matricula";
            this.radioButtonFiltroMatricula.UseVisualStyleBackColor = true;
            this.radioButtonFiltroMatricula.CheckedChanged += new System.EventHandler(this.CargarMatriculas);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(12, 394);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(174, 44);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonLiberar
            // 
            this.buttonLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLiberar.Location = new System.Drawing.Point(192, 394);
            this.buttonLiberar.Name = "buttonLiberar";
            this.buttonLiberar.Size = new System.Drawing.Size(596, 44);
            this.buttonLiberar.TabIndex = 2;
            this.buttonLiberar.Text = "Liberar";
            this.buttonLiberar.UseVisualStyleBackColor = true;
            this.buttonLiberar.Click += new System.EventHandler(this.buttonLiberar_Click);
            // 
            // checkBoxMostrarSoloOcupados
            // 
            this.checkBoxMostrarSoloOcupados.AutoSize = true;
            this.checkBoxMostrarSoloOcupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSoloOcupados.Location = new System.Drawing.Point(413, 21);
            this.checkBoxMostrarSoloOcupados.Name = "checkBoxMostrarSoloOcupados";
            this.checkBoxMostrarSoloOcupados.Size = new System.Drawing.Size(220, 28);
            this.checkBoxMostrarSoloOcupados.TabIndex = 3;
            this.checkBoxMostrarSoloOcupados.Text = "mostrar solo ocupados";
            this.checkBoxMostrarSoloOcupados.UseVisualStyleBackColor = true;
            this.checkBoxMostrarSoloOcupados.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSoloOcupados_CheckedChanged);
            // 
            // dataGridViewAsignarChofer
            // 
            this.dataGridViewAsignarChofer.AllowUserToAddRows = false;
            this.dataGridViewAsignarChofer.AllowUserToDeleteRows = false;
            this.dataGridViewAsignarChofer.AllowUserToOrderColumns = true;
            this.dataGridViewAsignarChofer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAsignarChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignarChofer.Location = new System.Drawing.Point(192, 55);
            this.dataGridViewAsignarChofer.Name = "dataGridViewAsignarChofer";
            this.dataGridViewAsignarChofer.ReadOnly = true;
            this.dataGridViewAsignarChofer.Size = new System.Drawing.Size(596, 333);
            this.dataGridViewAsignarChofer.TabIndex = 4;
            // 
            // FiltrarAsignarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAsignarChofer);
            this.Controls.Add(this.checkBoxMostrarSoloOcupados);
            this.Controls.Add(this.buttonLiberar);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxFiltro);
            this.Name = "FiltrarAsignarChofer";
            this.Text = "FiltrarAsignarChofer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignarChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFiltroDni;
        private System.Windows.Forms.RadioButton radioButtonFiltroMatricula;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonLiberar;
        private System.Windows.Forms.CheckBox checkBoxMostrarSoloOcupados;
        private System.Windows.Forms.DataGridView dataGridViewAsignarChofer;
    }
}