namespace Proyecto_EmpresaPaqueteria
{
    partial class FiltrarLote
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
            this.dataGridViewFiltrar = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMostrarEnviados = new System.Windows.Forms.CheckBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFiltrar
            // 
            this.dataGridViewFiltrar.AllowUserToAddRows = false;
            this.dataGridViewFiltrar.AllowUserToDeleteRows = false;
            this.dataGridViewFiltrar.AllowUserToOrderColumns = true;
            this.dataGridViewFiltrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFiltrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltrar.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewFiltrar.Name = "dataGridViewFiltrar";
            this.dataGridViewFiltrar.ReadOnly = true;
            this.dataGridViewFiltrar.Size = new System.Drawing.Size(776, 352);
            this.dataGridViewFiltrar.TabIndex = 0;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(109, 6);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFiltro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "provincia:";
            // 
            // checkBoxMostrarEnviados
            // 
            this.checkBoxMostrarEnviados.AutoSize = true;
            this.checkBoxMostrarEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarEnviados.Location = new System.Drawing.Point(616, 8);
            this.checkBoxMostrarEnviados.Name = "checkBoxMostrarEnviados";
            this.checkBoxMostrarEnviados.Size = new System.Drawing.Size(172, 28);
            this.checkBoxMostrarEnviados.TabIndex = 4;
            this.checkBoxMostrarEnviados.Text = "Mostrar enviados";
            this.checkBoxMostrarEnviados.UseVisualStyleBackColor = true;
            this.checkBoxMostrarEnviados.CheckedChanged += new System.EventHandler(this.checkBoxMostrarEnviados_CheckedChanged);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(368, 6);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(136, 31);
            this.buttonFiltrar.TabIndex = 5;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(12, 407);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(776, 31);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Enviar";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // FiltrarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.checkBoxMostrarEnviados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.dataGridViewFiltrar);
            this.Name = "FiltrarLote";
            this.Text = "FiltrarLote";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFiltrar;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMostrarEnviados;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonSubmit;
    }
}