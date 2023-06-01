
namespace LoloV2
{
    partial class FormAccess
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
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label edadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccess));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblfechayhora = new System.Windows.Forms.Label();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mibaseDataSet = new LoloV2.mibaseDataSet();
            this.mitablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitablaTableAdapter = new LoloV2.mibaseDataSetTableAdapters.mitablaTableAdapter();
            this.tableAdapterManager = new LoloV2.mibaseDataSetTableAdapters.TableAdapterManager();
            this.mitablaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mitablaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mitablaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.horayfecha = new System.Windows.Forms.Timer(this.components);
            this.lblresultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir2 = new System.Windows.Forms.Button();
            claveLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mibaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitablaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitablaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitablaBindingNavigator)).BeginInit();
            this.mitablaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(20, 203);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(49, 20);
            claveLabel.TabIndex = 12;
            claveLabel.Text = "clave:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(20, 235);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 14;
            nombreLabel.Text = "nombre:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(20, 267);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(49, 20);
            edadLabel.TabIndex = 16;
            edadLabel.Text = "edad:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(168, 87);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(13, 20);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = ".";
            // 
            // lblfechayhora
            // 
            this.lblfechayhora.AutoSize = true;
            this.lblfechayhora.Location = new System.Drawing.Point(168, 67);
            this.lblfechayhora.Name = "lblfechayhora";
            this.lblfechayhora.Size = new System.Drawing.Size(178, 20);
            this.lblfechayhora.TabIndex = 2;
            this.lblfechayhora.Text = "aqui va fecha y hora jeje";
            // 
            // btn_mod
            // 
            this.btn_mod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_mod.Location = new System.Drawing.Point(0, 82);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Padding = new System.Windows.Forms.Padding(5);
            this.btn_mod.Size = new System.Drawing.Size(1412, 50);
            this.btn_mod.TabIndex = 2;
            this.btn_mod.Text = "Modificar Registro";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrar.Location = new System.Drawing.Point(0, 182);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Padding = new System.Windows.Forms.Padding(5);
            this.btn_cerrar.Size = new System.Drawing.Size(1412, 50);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "VOLVER";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_eliminar.Location = new System.Drawing.Point(0, 132);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Padding = new System.Windows.Forms.Padding(5);
            this.btn_eliminar.Size = new System.Drawing.Size(1412, 50);
            this.btn_eliminar.TabIndex = 0;
            this.btn_eliminar.Text = "Eliminar registro";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txbUsuario.Location = new System.Drawing.Point(1074, 44);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(215, 26);
            this.txbUsuario.TabIndex = 3;
            this.txbUsuario.Text = "Ingresa tu Usuario";
            // 
            // txbContraseña
            // 
            this.txbContraseña.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txbContraseña.Location = new System.Drawing.Point(1074, 87);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(215, 26);
            this.txbContraseña.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(981, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(953, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // mibaseDataSet
            // 
            this.mibaseDataSet.DataSetName = "mibaseDataSet";
            this.mibaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitablaBindingSource
            // 
            this.mitablaBindingSource.DataMember = "mitabla";
            this.mitablaBindingSource.DataSource = this.mibaseDataSet;
            // 
            // mitablaTableAdapter
            // 
            this.mitablaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mitablaTableAdapter = this.mitablaTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoloV2.mibaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mitablaDataGridView
            // 
            this.mitablaDataGridView.AutoGenerateColumns = false;
            this.mitablaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mitablaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mitablaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mitablaDataGridView.DataSource = this.mitablaBindingSource;
            this.mitablaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mitablaDataGridView.Location = new System.Drawing.Point(0, 689);
            this.mitablaDataGridView.Name = "mitablaDataGridView";
            this.mitablaDataGridView.RowHeadersWidth = 62;
            this.mitablaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mitablaDataGridView.RowTemplate.Height = 28;
            this.mitablaDataGridView.Size = new System.Drawing.Size(1412, 220);
            this.mitablaDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clave";
            this.dataGridViewTextBoxColumn1.HeaderText = "clave";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "edad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitablaBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(93, 200);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(311, 26);
            this.claveTextBox.TabIndex = 13;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitablaBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(93, 232);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(311, 26);
            this.nombreTextBox.TabIndex = 15;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitablaBindingSource, "edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(93, 264);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(311, 26);
            this.edadTextBox.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Alta);
            this.panel1.Controls.Add(this.btn_mod);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 232);
            this.panel1.TabIndex = 18;
            // 
            // btn_Alta
            // 
            this.btn_Alta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Alta.Location = new System.Drawing.Point(0, 32);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Alta.Size = new System.Drawing.Size(1412, 50);
            this.btn_Alta.TabIndex = 3;
            this.btn_Alta.Text = "Agregar Registro";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1295, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 69);
            this.button1.TabIndex = 19;
            this.button1.Text = "INICIAR SECCION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mitablaBindingNavigator
            // 
            this.mitablaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mitablaBindingNavigator.BindingSource = this.mitablaBindingSource;
            this.mitablaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mitablaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mitablaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mitablaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mitablaBindingNavigatorSaveItem});
            this.mitablaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mitablaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mitablaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mitablaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mitablaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mitablaBindingNavigator.Name = "mitablaBindingNavigator";
            this.mitablaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mitablaBindingNavigator.Size = new System.Drawing.Size(1412, 38);
            this.mitablaBindingNavigator.TabIndex = 20;
            this.mitablaBindingNavigator.Text = "bindingNavigator1";
            this.mitablaBindingNavigator.RefreshItems += new System.EventHandler(this.mitablaBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 33);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // mitablaBindingNavigatorSaveItem
            // 
            this.mitablaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mitablaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mitablaBindingNavigatorSaveItem.Image")));
            this.mitablaBindingNavigatorSaveItem.Name = "mitablaBindingNavigatorSaveItem";
            this.mitablaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.mitablaBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // horayfecha
            // 
            this.horayfecha.Tick += new System.EventHandler(this.horayfecha_Tick);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(24, 431);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(13, 20);
            this.lblresultado.TabIndex = 21;
            this.lblresultado.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoloV2.Properties.Resources.pato;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(1295, 119);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(117, 69);
            this.btnSalir2.TabIndex = 22;
            this.btnSalir2.Text = "Volver";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // FormAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 909);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.mitablaBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.mitablaDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblfechayhora);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblnombre);
            this.Name = "FormAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mibaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitablaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitablaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mitablaBindingNavigator)).EndInit();
            this.mitablaBindingNavigator.ResumeLayout(false);
            this.mitablaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblfechayhora;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private mibaseDataSet mibaseDataSet;
        private System.Windows.Forms.BindingSource mitablaBindingSource;
        private mibaseDataSetTableAdapters.mitablaTableAdapter mitablaTableAdapter;
        private mibaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mitablaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator mitablaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mitablaBindingNavigatorSaveItem;
        private System.Windows.Forms.Timer horayfecha;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnSalir2;
    }
}

