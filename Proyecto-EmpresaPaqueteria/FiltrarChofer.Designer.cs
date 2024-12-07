namespace Proyecto_EmpresaPaqueteria
{
    partial class FiltrarChofer
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
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDni = new System.Windows.Forms.RadioButton();
            this.radioButtonApellido = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.checkBoxBajas = new System.Windows.Forms.CheckBox();
            this.dataGridViewChoferFiltrar = new System.Windows.Forms.DataGridView();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonAltaBaja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoferFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltro.Location = new System.Drawing.Point(12, 12);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(200, 29);
            this.textBoxFiltro.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDni);
            this.groupBox1.Controls.Add(this.radioButtonApellido);
            this.groupBox1.Controls.Add(this.radioButtonNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonDni
            // 
            this.radioButtonDni.AutoSize = true;
            this.radioButtonDni.Checked = true;
            this.radioButtonDni.Location = new System.Drawing.Point(15, 290);
            this.radioButtonDni.Name = "radioButtonDni";
            this.radioButtonDni.Size = new System.Drawing.Size(59, 28);
            this.radioButtonDni.TabIndex = 0;
            this.radioButtonDni.TabStop = true;
            this.radioButtonDni.Text = "DNI";
            this.radioButtonDni.UseVisualStyleBackColor = true;
            // 
            // radioButtonApellido
            // 
            this.radioButtonApellido.AutoSize = true;
            this.radioButtonApellido.Location = new System.Drawing.Point(15, 161);
            this.radioButtonApellido.Name = "radioButtonApellido";
            this.radioButtonApellido.Size = new System.Drawing.Size(97, 28);
            this.radioButtonApellido.TabIndex = 0;
            this.radioButtonApellido.Text = "Apellido";
            this.radioButtonApellido.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(15, 28);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(97, 28);
            this.radioButtonNombre.TabIndex = 0;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxBajas
            // 
            this.checkBoxBajas.AutoSize = true;
            this.checkBoxBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBajas.Location = new System.Drawing.Point(481, 12);
            this.checkBoxBajas.Name = "checkBoxBajas";
            this.checkBoxBajas.Size = new System.Drawing.Size(141, 28);
            this.checkBoxBajas.TabIndex = 2;
            this.checkBoxBajas.Text = "Mostrar Bajas";
            this.checkBoxBajas.UseVisualStyleBackColor = true;
            this.checkBoxBajas.CheckedChanged += new System.EventHandler(this.checkBoxBajas_CheckedChanged);
            // 
            // dataGridViewChoferFiltrar
            // 
            this.dataGridViewChoferFiltrar.AllowUserToAddRows = false;
            this.dataGridViewChoferFiltrar.AllowUserToDeleteRows = false;
            this.dataGridViewChoferFiltrar.AllowUserToOrderColumns = true;
            this.dataGridViewChoferFiltrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChoferFiltrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoferFiltrar.Location = new System.Drawing.Point(218, 58);
            this.dataGridViewChoferFiltrar.Name = "dataGridViewChoferFiltrar";
            this.dataGridViewChoferFiltrar.ReadOnly = true;
            this.dataGridViewChoferFiltrar.Size = new System.Drawing.Size(684, 326);
            this.dataGridViewChoferFiltrar.TabIndex = 3;
            this.dataGridViewChoferFiltrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChoferFiltrar_CellContentClick);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(12, 390);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(200, 48);
            this.buttonFiltrar.TabIndex = 4;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonAltaBaja
            // 
            this.buttonAltaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltaBaja.Location = new System.Drawing.Point(218, 390);
            this.buttonAltaBaja.Name = "buttonAltaBaja";
            this.buttonAltaBaja.Size = new System.Drawing.Size(684, 48);
            this.buttonAltaBaja.TabIndex = 4;
            this.buttonAltaBaja.Text = "Alta/Baja";
            this.buttonAltaBaja.UseVisualStyleBackColor = true;
            this.buttonAltaBaja.Click += new System.EventHandler(this.buttonAltaBaja_Click);
            // 
            // FiltrarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.buttonAltaBaja);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.dataGridViewChoferFiltrar);
            this.Controls.Add(this.checkBoxBajas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFiltro);
            this.Name = "FiltrarChofer";
            this.Text = "FiltrarChofer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoferFiltrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDni;
        private System.Windows.Forms.RadioButton radioButtonApellido;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.CheckBox checkBoxBajas;
        private System.Windows.Forms.DataGridView dataGridViewChoferFiltrar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonAltaBaja;
    }
}