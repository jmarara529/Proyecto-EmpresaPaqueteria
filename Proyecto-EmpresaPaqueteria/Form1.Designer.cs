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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCamion = new System.Windows.Forms.TabPage();
            this.buttonCamionDelete = new System.Windows.Forms.Button();
            this.buttonCamionFiltrar = new System.Windows.Forms.Button();
            this.buttonCamionSubmit = new System.Windows.Forms.Button();
            this.dataGridViewCamion = new System.Windows.Forms.DataGridView();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.checkBoxCamionesBaja = new System.Windows.Forms.CheckBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.tabPageChofer = new System.Windows.Forms.TabPage();
            this.buttonChoferAltaBaja = new System.Windows.Forms.Button();
            this.buttonChoferFiltrar = new System.Windows.Forms.Button();
            this.buttonChoferSubmit = new System.Windows.Forms.Button();
            this.dataGridViewChofer = new System.Windows.Forms.DataGridView();
            this.checkBoxChoferMostrarBajas = new System.Windows.Forms.CheckBox();
            this.textBoxChoferDni = new System.Windows.Forms.TextBox();
            this.textBoxChoferTelefono = new System.Windows.Forms.TextBox();
            this.textBoxChoferApellido2 = new System.Windows.Forms.TextBox();
            this.textBoxChoferApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxChoferNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.camionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaPaqueteriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageChoferCamion = new System.Windows.Forms.TabPage();
            this.tabPagePaquete = new System.Windows.Forms.TabPage();
            this.tabPageLote = new System.Windows.Forms.TabPage();
            this.tabPageEnvio = new System.Windows.Forms.TabPage();
            this.comboBoxAsignarCamion_CamionId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAsignarCamion_ChoferId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewAsignarCamion = new System.Windows.Forms.DataGridView();
            this.checkBoxAsignarCamion_MostrarLibres = new System.Windows.Forms.CheckBox();
            this.buttonAsignarCamion_Submit = new System.Windows.Forms.Button();
            this.buttonAsignarCamion_Filtrar = new System.Windows.Forms.Button();
            this.buttonAsignarCamion_Liberar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamion)).BeginInit();
            this.tabPageChofer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPaqueteriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionBindingSource)).BeginInit();
            this.tabPageChoferCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignarCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCamion);
            this.tabControl1.Controls.Add(this.tabPageChofer);
            this.tabControl1.Controls.Add(this.tabPageChoferCamion);
            this.tabControl1.Controls.Add(this.tabPagePaquete);
            this.tabControl1.Controls.Add(this.tabPageLote);
            this.tabControl1.Controls.Add(this.tabPageEnvio);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCamion
            // 
            this.tabPageCamion.Controls.Add(this.buttonCamionDelete);
            this.tabPageCamion.Controls.Add(this.buttonCamionFiltrar);
            this.tabPageCamion.Controls.Add(this.buttonCamionSubmit);
            this.tabPageCamion.Controls.Add(this.dataGridViewCamion);
            this.tabPageCamion.Controls.Add(this.textBoxMatricula);
            this.tabPageCamion.Controls.Add(this.textBoxModelo);
            this.tabPageCamion.Controls.Add(this.textBoxMarca);
            this.tabPageCamion.Controls.Add(this.checkBoxCamionesBaja);
            this.tabPageCamion.Controls.Add(this.labelMatricula);
            this.tabPageCamion.Controls.Add(this.labelModelo);
            this.tabPageCamion.Controls.Add(this.labelMarca);
            this.tabPageCamion.Location = new System.Drawing.Point(4, 25);
            this.tabPageCamion.Name = "tabPageCamion";
            this.tabPageCamion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCamion.Size = new System.Drawing.Size(1113, 397);
            this.tabPageCamion.TabIndex = 0;
            this.tabPageCamion.Text = "Camión";
            this.tabPageCamion.UseVisualStyleBackColor = true;
            // 
            // buttonCamionDelete
            // 
            this.buttonCamionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamionDelete.Location = new System.Drawing.Point(761, 327);
            this.buttonCamionDelete.Name = "buttonCamionDelete";
            this.buttonCamionDelete.Size = new System.Drawing.Size(287, 44);
            this.buttonCamionDelete.TabIndex = 8;
            this.buttonCamionDelete.Text = "Alta/Baja";
            this.buttonCamionDelete.UseVisualStyleBackColor = true;
            this.buttonCamionDelete.Click += new System.EventHandler(this.buttonCamionDelete_Click);
            // 
            // buttonCamionFiltrar
            // 
            this.buttonCamionFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamionFiltrar.Location = new System.Drawing.Point(389, 327);
            this.buttonCamionFiltrar.Name = "buttonCamionFiltrar";
            this.buttonCamionFiltrar.Size = new System.Drawing.Size(287, 44);
            this.buttonCamionFiltrar.TabIndex = 7;
            this.buttonCamionFiltrar.Text = "Filtrar";
            this.buttonCamionFiltrar.UseVisualStyleBackColor = true;
            this.buttonCamionFiltrar.Click += new System.EventHandler(this.buttonCamionFiltrar_Click);
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
            this.buttonCamionSubmit.Click += new System.EventHandler(this.buttonCamionSubmit_Click);
            // 
            // dataGridViewCamion
            // 
            this.dataGridViewCamion.AllowUserToAddRows = false;
            this.dataGridViewCamion.AllowUserToDeleteRows = false;
            this.dataGridViewCamion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamion.Location = new System.Drawing.Point(333, 54);
            this.dataGridViewCamion.Name = "dataGridViewCamion";
            this.dataGridViewCamion.ReadOnly = true;
            this.dataGridViewCamion.Size = new System.Drawing.Size(754, 247);
            this.dataGridViewCamion.TabIndex = 6;
            this.dataGridViewCamion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCamion_CellContentClick);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatricula.Location = new System.Drawing.Point(147, 272);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(155, 29);
            this.textBoxMatricula.TabIndex = 3;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(147, 164);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(155, 29);
            this.textBoxModelo.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(147, 54);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(155, 29);
            this.textBoxMarca.TabIndex = 1;
            // 
            // checkBoxCamionesBaja
            // 
            this.checkBoxCamionesBaja.AutoSize = true;
            this.checkBoxCamionesBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCamionesBaja.Location = new System.Drawing.Point(507, 13);
            this.checkBoxCamionesBaja.Name = "checkBoxCamionesBaja";
            this.checkBoxCamionesBaja.Size = new System.Drawing.Size(302, 28);
            this.checkBoxCamionesBaja.TabIndex = 5;
            this.checkBoxCamionesBaja.Text = "Mostrar camiones dados de baja";
            this.checkBoxCamionesBaja.UseVisualStyleBackColor = true;
            this.checkBoxCamionesBaja.CheckedChanged += new System.EventHandler(this.checkBoxCamionesBaja_CheckedChanged);
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
            // tabPageChofer
            // 
            this.tabPageChofer.Controls.Add(this.buttonChoferAltaBaja);
            this.tabPageChofer.Controls.Add(this.buttonChoferFiltrar);
            this.tabPageChofer.Controls.Add(this.buttonChoferSubmit);
            this.tabPageChofer.Controls.Add(this.dataGridViewChofer);
            this.tabPageChofer.Controls.Add(this.checkBoxChoferMostrarBajas);
            this.tabPageChofer.Controls.Add(this.textBoxChoferDni);
            this.tabPageChofer.Controls.Add(this.textBoxChoferTelefono);
            this.tabPageChofer.Controls.Add(this.textBoxChoferApellido2);
            this.tabPageChofer.Controls.Add(this.textBoxChoferApellido1);
            this.tabPageChofer.Controls.Add(this.textBoxChoferNombre);
            this.tabPageChofer.Controls.Add(this.label5);
            this.tabPageChofer.Controls.Add(this.label4);
            this.tabPageChofer.Controls.Add(this.label3);
            this.tabPageChofer.Controls.Add(this.label2);
            this.tabPageChofer.Controls.Add(this.label1);
            this.tabPageChofer.Location = new System.Drawing.Point(4, 25);
            this.tabPageChofer.Name = "tabPageChofer";
            this.tabPageChofer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChofer.Size = new System.Drawing.Size(1113, 397);
            this.tabPageChofer.TabIndex = 1;
            this.tabPageChofer.Text = "Chofer";
            this.tabPageChofer.UseVisualStyleBackColor = true;
            // 
            // buttonChoferAltaBaja
            // 
            this.buttonChoferAltaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferAltaBaja.Location = new System.Drawing.Point(775, 349);
            this.buttonChoferAltaBaja.Name = "buttonChoferAltaBaja";
            this.buttonChoferAltaBaja.Size = new System.Drawing.Size(283, 42);
            this.buttonChoferAltaBaja.TabIndex = 4;
            this.buttonChoferAltaBaja.Text = "Alta/Baja";
            this.buttonChoferAltaBaja.UseVisualStyleBackColor = true;
            this.buttonChoferAltaBaja.Click += new System.EventHandler(this.buttonChoferAltaBaja_Click);
            // 
            // buttonChoferFiltrar
            // 
            this.buttonChoferFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferFiltrar.Location = new System.Drawing.Point(335, 349);
            this.buttonChoferFiltrar.Name = "buttonChoferFiltrar";
            this.buttonChoferFiltrar.Size = new System.Drawing.Size(310, 42);
            this.buttonChoferFiltrar.TabIndex = 4;
            this.buttonChoferFiltrar.Text = "Filtrar";
            this.buttonChoferFiltrar.UseVisualStyleBackColor = true;
            this.buttonChoferFiltrar.Click += new System.EventHandler(this.buttonChoferFiltrar_Click);
            // 
            // buttonChoferSubmit
            // 
            this.buttonChoferSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferSubmit.Location = new System.Drawing.Point(40, 349);
            this.buttonChoferSubmit.Name = "buttonChoferSubmit";
            this.buttonChoferSubmit.Size = new System.Drawing.Size(208, 42);
            this.buttonChoferSubmit.TabIndex = 4;
            this.buttonChoferSubmit.Text = "Añadir";
            this.buttonChoferSubmit.UseVisualStyleBackColor = true;
            this.buttonChoferSubmit.Click += new System.EventHandler(this.buttonChoferSubmit_Click);
            // 
            // dataGridViewChofer
            // 
            this.dataGridViewChofer.AllowUserToAddRows = false;
            this.dataGridViewChofer.AllowUserToDeleteRows = false;
            this.dataGridViewChofer.AllowUserToOrderColumns = true;
            this.dataGridViewChofer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChofer.Location = new System.Drawing.Point(320, 41);
            this.dataGridViewChofer.Name = "dataGridViewChofer";
            this.dataGridViewChofer.ReadOnly = true;
            this.dataGridViewChofer.Size = new System.Drawing.Size(787, 288);
            this.dataGridViewChofer.TabIndex = 3;
            this.dataGridViewChofer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChofer_CellContentClick);
            // 
            // checkBoxChoferMostrarBajas
            // 
            this.checkBoxChoferMostrarBajas.AutoSize = true;
            this.checkBoxChoferMostrarBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChoferMostrarBajas.Location = new System.Drawing.Point(636, 7);
            this.checkBoxChoferMostrarBajas.Name = "checkBoxChoferMostrarBajas";
            this.checkBoxChoferMostrarBajas.Size = new System.Drawing.Size(140, 28);
            this.checkBoxChoferMostrarBajas.TabIndex = 2;
            this.checkBoxChoferMostrarBajas.Text = "Mostrar bajas";
            this.checkBoxChoferMostrarBajas.UseVisualStyleBackColor = true;
            this.checkBoxChoferMostrarBajas.CheckedChanged += new System.EventHandler(this.checkBoxChoferMostrarBajas_CheckedChanged);
            // 
            // textBoxChoferDni
            // 
            this.textBoxChoferDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoferDni.Location = new System.Drawing.Point(148, 298);
            this.textBoxChoferDni.Name = "textBoxChoferDni";
            this.textBoxChoferDni.Size = new System.Drawing.Size(166, 31);
            this.textBoxChoferDni.TabIndex = 1;
            this.textBoxChoferDni.TextChanged += new System.EventHandler(this.textBoxChoferDni_TextChanged);
            // 
            // textBoxChoferTelefono
            // 
            this.textBoxChoferTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoferTelefono.Location = new System.Drawing.Point(148, 232);
            this.textBoxChoferTelefono.Name = "textBoxChoferTelefono";
            this.textBoxChoferTelefono.Size = new System.Drawing.Size(166, 31);
            this.textBoxChoferTelefono.TabIndex = 1;
            this.textBoxChoferTelefono.TextChanged += new System.EventHandler(this.textBoxChoferTelefono_TextChanged);
            // 
            // textBoxChoferApellido2
            // 
            this.textBoxChoferApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoferApellido2.Location = new System.Drawing.Point(148, 164);
            this.textBoxChoferApellido2.Name = "textBoxChoferApellido2";
            this.textBoxChoferApellido2.Size = new System.Drawing.Size(166, 31);
            this.textBoxChoferApellido2.TabIndex = 1;
            // 
            // textBoxChoferApellido1
            // 
            this.textBoxChoferApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoferApellido1.Location = new System.Drawing.Point(148, 109);
            this.textBoxChoferApellido1.Name = "textBoxChoferApellido1";
            this.textBoxChoferApellido1.Size = new System.Drawing.Size(166, 31);
            this.textBoxChoferApellido1.TabIndex = 1;
            // 
            // textBoxChoferNombre
            // 
            this.textBoxChoferNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoferNombre.Location = new System.Drawing.Point(148, 41);
            this.textBoxChoferNombre.Name = "textBoxChoferNombre";
            this.textBoxChoferNombre.Size = new System.Drawing.Size(166, 31);
            this.textBoxChoferNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tabPageChoferCamion
            // 
            this.tabPageChoferCamion.Controls.Add(this.buttonAsignarCamion_Liberar);
            this.tabPageChoferCamion.Controls.Add(this.buttonAsignarCamion_Filtrar);
            this.tabPageChoferCamion.Controls.Add(this.buttonAsignarCamion_Submit);
            this.tabPageChoferCamion.Controls.Add(this.checkBoxAsignarCamion_MostrarLibres);
            this.tabPageChoferCamion.Controls.Add(this.dataGridViewAsignarCamion);
            this.tabPageChoferCamion.Controls.Add(this.label7);
            this.tabPageChoferCamion.Controls.Add(this.comboBoxAsignarCamion_ChoferId);
            this.tabPageChoferCamion.Controls.Add(this.label6);
            this.tabPageChoferCamion.Controls.Add(this.comboBoxAsignarCamion_CamionId);
            this.tabPageChoferCamion.Location = new System.Drawing.Point(4, 25);
            this.tabPageChoferCamion.Name = "tabPageChoferCamion";
            this.tabPageChoferCamion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChoferCamion.Size = new System.Drawing.Size(1113, 397);
            this.tabPageChoferCamion.TabIndex = 2;
            this.tabPageChoferCamion.Text = "Asignacion de camion";
            this.tabPageChoferCamion.UseVisualStyleBackColor = true;
            // 
            // tabPagePaquete
            // 
            this.tabPagePaquete.Location = new System.Drawing.Point(4, 25);
            this.tabPagePaquete.Name = "tabPagePaquete";
            this.tabPagePaquete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePaquete.Size = new System.Drawing.Size(1113, 397);
            this.tabPagePaquete.TabIndex = 3;
            this.tabPagePaquete.Text = "Paquete";
            this.tabPagePaquete.UseVisualStyleBackColor = true;
            // 
            // tabPageLote
            // 
            this.tabPageLote.Location = new System.Drawing.Point(4, 25);
            this.tabPageLote.Name = "tabPageLote";
            this.tabPageLote.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLote.Size = new System.Drawing.Size(1113, 397);
            this.tabPageLote.TabIndex = 4;
            this.tabPageLote.Text = "Lote";
            this.tabPageLote.UseVisualStyleBackColor = true;
            // 
            // tabPageEnvio
            // 
            this.tabPageEnvio.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnvio.Name = "tabPageEnvio";
            this.tabPageEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnvio.Size = new System.Drawing.Size(1113, 397);
            this.tabPageEnvio.TabIndex = 5;
            this.tabPageEnvio.Text = "Envio";
            this.tabPageEnvio.UseVisualStyleBackColor = true;
            // 
            // comboBoxAsignarCamion_CamionId
            // 
            this.comboBoxAsignarCamion_CamionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAsignarCamion_CamionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAsignarCamion_CamionId.FormattingEnabled = true;
            this.comboBoxAsignarCamion_CamionId.Location = new System.Drawing.Point(138, 91);
            this.comboBoxAsignarCamion_CamionId.Name = "comboBoxAsignarCamion_CamionId";
            this.comboBoxAsignarCamion_CamionId.Size = new System.Drawing.Size(121, 32);
            this.comboBoxAsignarCamion_CamionId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Camion_id:";
            // 
            // comboBoxAsignarCamion_ChoferId
            // 
            this.comboBoxAsignarCamion_ChoferId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAsignarCamion_ChoferId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAsignarCamion_ChoferId.FormattingEnabled = true;
            this.comboBoxAsignarCamion_ChoferId.Location = new System.Drawing.Point(138, 241);
            this.comboBoxAsignarCamion_ChoferId.Name = "comboBoxAsignarCamion_ChoferId";
            this.comboBoxAsignarCamion_ChoferId.Size = new System.Drawing.Size(121, 32);
            this.comboBoxAsignarCamion_ChoferId.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chofer_id";
            // 
            // dataGridViewAsignarCamion
            // 
            this.dataGridViewAsignarCamion.AllowUserToAddRows = false;
            this.dataGridViewAsignarCamion.AllowUserToDeleteRows = false;
            this.dataGridViewAsignarCamion.AllowUserToOrderColumns = true;
            this.dataGridViewAsignarCamion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAsignarCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignarCamion.Location = new System.Drawing.Point(282, 40);
            this.dataGridViewAsignarCamion.Name = "dataGridViewAsignarCamion";
            this.dataGridViewAsignarCamion.ReadOnly = true;
            this.dataGridViewAsignarCamion.Size = new System.Drawing.Size(825, 302);
            this.dataGridViewAsignarCamion.TabIndex = 2;
            // 
            // checkBoxAsignarCamion_MostrarLibres
            // 
            this.checkBoxAsignarCamion_MostrarLibres.AutoSize = true;
            this.checkBoxAsignarCamion_MostrarLibres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAsignarCamion_MostrarLibres.Location = new System.Drawing.Point(607, 6);
            this.checkBoxAsignarCamion_MostrarLibres.Name = "checkBoxAsignarCamion_MostrarLibres";
            this.checkBoxAsignarCamion_MostrarLibres.Size = new System.Drawing.Size(181, 28);
            this.checkBoxAsignarCamion_MostrarLibres.TabIndex = 3;
            this.checkBoxAsignarCamion_MostrarLibres.Text = "Mostrar solo libres";
            this.checkBoxAsignarCamion_MostrarLibres.UseVisualStyleBackColor = true;
            this.checkBoxAsignarCamion_MostrarLibres.CheckedChanged += new System.EventHandler(this.checkBoxAsignarCamion_MostrarLibres_CheckedChanged);
            // 
            // buttonAsignarCamion_Submit
            // 
            this.buttonAsignarCamion_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignarCamion_Submit.Location = new System.Drawing.Point(10, 348);
            this.buttonAsignarCamion_Submit.Name = "buttonAsignarCamion_Submit";
            this.buttonAsignarCamion_Submit.Size = new System.Drawing.Size(249, 43);
            this.buttonAsignarCamion_Submit.TabIndex = 4;
            this.buttonAsignarCamion_Submit.Text = "Añadir";
            this.buttonAsignarCamion_Submit.UseVisualStyleBackColor = true;
            this.buttonAsignarCamion_Submit.Click += new System.EventHandler(this.buttonAsignarCamion_Submit_Click);
            // 
            // buttonAsignarCamion_Filtrar
            // 
            this.buttonAsignarCamion_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignarCamion_Filtrar.Location = new System.Drawing.Point(314, 348);
            this.buttonAsignarCamion_Filtrar.Name = "buttonAsignarCamion_Filtrar";
            this.buttonAsignarCamion_Filtrar.Size = new System.Drawing.Size(313, 43);
            this.buttonAsignarCamion_Filtrar.TabIndex = 4;
            this.buttonAsignarCamion_Filtrar.Text = "Filtrar";
            this.buttonAsignarCamion_Filtrar.UseVisualStyleBackColor = true;
            // 
            // buttonAsignarCamion_Liberar
            // 
            this.buttonAsignarCamion_Liberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignarCamion_Liberar.Location = new System.Drawing.Point(731, 348);
            this.buttonAsignarCamion_Liberar.Name = "buttonAsignarCamion_Liberar";
            this.buttonAsignarCamion_Liberar.Size = new System.Drawing.Size(313, 43);
            this.buttonAsignarCamion_Liberar.TabIndex = 4;
            this.buttonAsignarCamion_Liberar.Text = "Liberar";
            this.buttonAsignarCamion_Liberar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCamion.ResumeLayout(false);
            this.tabPageCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamion)).EndInit();
            this.tabPageChofer.ResumeLayout(false);
            this.tabPageChofer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPaqueteriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionBindingSource)).EndInit();
            this.tabPageChoferCamion.ResumeLayout(false);
            this.tabPageChoferCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignarCamion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCamion;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TabPage tabPageChofer;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.CheckBox checkBoxCamionesBaja;
        private System.Windows.Forms.DataGridView dataGridViewCamion;
        private System.Windows.Forms.Button buttonCamionDelete;
        private System.Windows.Forms.Button buttonCamionFiltrar;
        private System.Windows.Forms.Button buttonCamionSubmit;
        private System.Windows.Forms.BindingSource empresaPaqueteriaDataSetBindingSource;
        private System.Windows.Forms.BindingSource camionBindingSource;
        private System.Windows.Forms.BindingSource camionBindingSource1;
        private System.Windows.Forms.TextBox textBoxChoferDni;
        private System.Windows.Forms.TextBox textBoxChoferTelefono;
        private System.Windows.Forms.TextBox textBoxChoferApellido2;
        private System.Windows.Forms.TextBox textBoxChoferApellido1;
        private System.Windows.Forms.TextBox textBoxChoferNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewChofer;
        private System.Windows.Forms.CheckBox checkBoxChoferMostrarBajas;
        private System.Windows.Forms.Button buttonChoferAltaBaja;
        private System.Windows.Forms.Button buttonChoferFiltrar;
        private System.Windows.Forms.Button buttonChoferSubmit;
        private System.Windows.Forms.TabPage tabPageChoferCamion;
        private System.Windows.Forms.TabPage tabPagePaquete;
        private System.Windows.Forms.TabPage tabPageLote;
        private System.Windows.Forms.TabPage tabPageEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAsignarCamion_ChoferId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAsignarCamion_CamionId;
        private System.Windows.Forms.CheckBox checkBoxAsignarCamion_MostrarLibres;
        private System.Windows.Forms.DataGridView dataGridViewAsignarCamion;
        private System.Windows.Forms.Button buttonAsignarCamion_Liberar;
        private System.Windows.Forms.Button buttonAsignarCamion_Filtrar;
        private System.Windows.Forms.Button buttonAsignarCamion_Submit;
    }
}

