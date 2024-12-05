namespace Proyecto_EmpresaPaqueteria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.checkBoxCamionesBaja = new System.Windows.Forms.CheckBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.dataGridViewCamion = new System.Windows.Forms.DataGridView();
            this.buttonCamionSubmit = new System.Windows.Forms.Button();
            this.buttonCamionFiltrar = new System.Windows.Forms.Button();
            this.buttonCamionDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCamionDelete);
            this.tabPage1.Controls.Add(this.buttonCamionFiltrar);
            this.tabPage1.Controls.Add(this.buttonCamionSubmit);
            this.tabPage1.Controls.Add(this.dataGridViewCamion);
            this.tabPage1.Controls.Add(this.textBoxMatricula);
            this.tabPage1.Controls.Add(this.textBoxModelo);
            this.tabPage1.Controls.Add(this.textBoxMarca);
            this.tabPage1.Controls.Add(this.checkBoxCamionesBaja);
            this.tabPage1.Controls.Add(this.labelMatricula);
            this.tabPage1.Controls.Add(this.labelModelo);
            this.tabPage1.Controls.Add(this.labelMarca);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Camión";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chofer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(57, 57);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(67, 24);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(44, 167);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(79, 24);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(35, 275);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(90, 24);
            this.labelMatricula.TabIndex = 0;
            this.labelMatricula.Text = "Matricula:";
            // 
            // checkBoxCamionesBaja
            // 
            this.checkBoxCamionesBaja.AutoSize = true;
            this.checkBoxCamionesBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCamionesBaja.Location = new System.Drawing.Point(507, 13);
            this.checkBoxCamionesBaja.Name = "checkBoxCamionesBaja";
            this.checkBoxCamionesBaja.Size = new System.Drawing.Size(302, 28);
            this.checkBoxCamionesBaja.TabIndex = 1;
            this.checkBoxCamionesBaja.Text = "Mostrar camiones dados de baja";
            this.checkBoxCamionesBaja.UseVisualStyleBackColor = true;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(147, 54);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(155, 29);
            this.textBoxMarca.TabIndex = 2;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(147, 164);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(155, 29);
            this.textBoxModelo.TabIndex = 2;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatricula.Location = new System.Drawing.Point(147, 272);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(155, 29);
            this.textBoxMatricula.TabIndex = 2;
            // 
            // dataGridViewCamion
            // 
            this.dataGridViewCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamion.Location = new System.Drawing.Point(333, 54);
            this.dataGridViewCamion.Name = "dataGridViewCamion";
            this.dataGridViewCamion.Size = new System.Drawing.Size(754, 247);
            this.dataGridViewCamion.TabIndex = 3;
            // 
            // buttonCamionSubmit
            // 
            this.buttonCamionSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamionSubmit.Location = new System.Drawing.Point(39, 327);
            this.buttonCamionSubmit.Name = "buttonCamionSubmit";
            this.buttonCamionSubmit.Size = new System.Drawing.Size(263, 44);
            this.buttonCamionSubmit.TabIndex = 4;
            this.buttonCamionSubmit.Text = "Añadir";
            this.buttonCamionSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonCamionFiltrar
            // 
            this.buttonCamionFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamionFiltrar.Location = new System.Drawing.Point(389, 327);
            this.buttonCamionFiltrar.Name = "buttonCamionFiltrar";
            this.buttonCamionFiltrar.Size = new System.Drawing.Size(287, 44);
            this.buttonCamionFiltrar.TabIndex = 4;
            this.buttonCamionFiltrar.Text = "Filtrar";
            this.buttonCamionFiltrar.UseVisualStyleBackColor = true;
            // 
            // buttonCamionDelete
            // 
            this.buttonCamionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamionDelete.Location = new System.Drawing.Point(761, 327);
            this.buttonCamionDelete.Name = "buttonCamionDelete";
            this.buttonCamionDelete.Size = new System.Drawing.Size(287, 44);
            this.buttonCamionDelete.TabIndex = 4;
            this.buttonCamionDelete.Text = "Eliminar";
            this.buttonCamionDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.CheckBox checkBoxCamionesBaja;
        private System.Windows.Forms.DataGridView dataGridViewCamion;
        private System.Windows.Forms.Button buttonCamionDelete;
        private System.Windows.Forms.Button buttonCamionFiltrar;
        private System.Windows.Forms.Button buttonCamionSubmit;
    }
}

