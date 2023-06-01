
namespace LoloV2
{
    partial class FormFoto
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
            System.Windows.Forms.Label iD_PDOLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label cOLORLabel;
            System.Windows.Forms.Label pRECIOLabel;
            System.Windows.Forms.Label gRAFICOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoto));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mibaseDataSet2 = new LoloV2.mibaseDataSet2();
            this.mitabla2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitabla2TableAdapter = new LoloV2.mibaseDataSet2TableAdapters.mitabla2TableAdapter();
            this.tableAdapterManager = new LoloV2.mibaseDataSet2TableAdapters.TableAdapterManager();
            this.mitabla2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mitabla2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mitabla2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_PDOTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.cOLORTextBox = new System.Windows.Forms.TextBox();
            this.pRECIOTextBox = new System.Windows.Forms.TextBox();
            this.gRAFICOTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            iD_PDOLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            cOLORLabel = new System.Windows.Forms.Label();
            pRECIOLabel = new System.Windows.Forms.Label();
            gRAFICOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mibaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitabla2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitabla2BindingNavigator)).BeginInit();
            this.mitabla2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitabla2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PDOLabel
            // 
            iD_PDOLabel.AutoSize = true;
            iD_PDOLabel.Location = new System.Drawing.Point(71, 129);
            iD_PDOLabel.Name = "iD_PDOLabel";
            iD_PDOLabel.Size = new System.Drawing.Size(68, 20);
            iD_PDOLabel.TabIndex = 8;
            iD_PDOLabel.Text = "ID PDO:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(73, 182);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(83, 20);
            nOMBRELabel.TabIndex = 9;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cOLORLabel
            // 
            cOLORLabel.AutoSize = true;
            cOLORLabel.Location = new System.Drawing.Point(83, 245);
            cOLORLabel.Name = "cOLORLabel";
            cOLORLabel.Size = new System.Drawing.Size(69, 20);
            cOLORLabel.TabIndex = 10;
            cOLORLabel.Text = "COLOR:";
            // 
            // pRECIOLabel
            // 
            pRECIOLabel.AutoSize = true;
            pRECIOLabel.Location = new System.Drawing.Point(80, 300);
            pRECIOLabel.Name = "pRECIOLabel";
            pRECIOLabel.Size = new System.Drawing.Size(74, 20);
            pRECIOLabel.TabIndex = 12;
            pRECIOLabel.Text = "PRECIO:";
            // 
            // gRAFICOLabel
            // 
            gRAFICOLabel.AutoSize = true;
            gRAFICOLabel.Location = new System.Drawing.Point(83, 347);
            gRAFICOLabel.Name = "gRAFICOLabel";
            gRAFICOLabel.Size = new System.Drawing.Size(87, 20);
            gRAFICOLabel.TabIndex = 14;
            gRAFICOLabel.Text = "GRAFICO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Imagen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(688, 107);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(510, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // mibaseDataSet2
            // 
            this.mibaseDataSet2.DataSetName = "mibaseDataSet2";
            this.mibaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitabla2BindingSource
            // 
            this.mitabla2BindingSource.DataMember = "mitabla2";
            this.mitabla2BindingSource.DataSource = this.mibaseDataSet2;
            // 
            // mitabla2TableAdapter
            // 
            this.mitabla2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mitabla2TableAdapter = this.mitabla2TableAdapter;
            this.tableAdapterManager.mitablaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoloV2.mibaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mitabla2BindingNavigator
            // 
            this.mitabla2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mitabla2BindingNavigator.BindingSource = this.mitabla2BindingSource;
            this.mitabla2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mitabla2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mitabla2BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mitabla2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mitabla2BindingNavigatorSaveItem});
            this.mitabla2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mitabla2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mitabla2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mitabla2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mitabla2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mitabla2BindingNavigator.Name = "mitabla2BindingNavigator";
            this.mitabla2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mitabla2BindingNavigator.Size = new System.Drawing.Size(808, 33);
            this.mitabla2BindingNavigator.TabIndex = 7;
            this.mitabla2BindingNavigator.Text = "bindingNavigator1";
            this.mitabla2BindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // mitabla2BindingNavigatorSaveItem
            // 
            this.mitabla2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mitabla2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mitabla2BindingNavigatorSaveItem.Image")));
            this.mitabla2BindingNavigatorSaveItem.Name = "mitabla2BindingNavigatorSaveItem";
            this.mitabla2BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.mitabla2BindingNavigatorSaveItem.Text = "Guardar datos";
            this.mitabla2BindingNavigatorSaveItem.Click += new System.EventHandler(this.mitabla2BindingNavigatorSaveItem_Click_1);
            // 
            // mitabla2DataGridView
            // 
            this.mitabla2DataGridView.AutoGenerateColumns = false;
            this.mitabla2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mitabla2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mitabla2DataGridView.DataSource = this.mitabla2BindingSource;
            this.mitabla2DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mitabla2DataGridView.Location = new System.Drawing.Point(0, 424);
            this.mitabla2DataGridView.Name = "mitabla2DataGridView";
            this.mitabla2DataGridView.RowHeadersWidth = 62;
            this.mitabla2DataGridView.RowTemplate.Height = 28;
            this.mitabla2DataGridView.Size = new System.Drawing.Size(808, 220);
            this.mitabla2DataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PDO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PDO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COLOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "COLOR";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GRAFICO";
            this.dataGridViewTextBoxColumn5.HeaderText = "GRAFICO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // iD_PDOTextBox
            // 
            this.iD_PDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitabla2BindingSource, "ID_PDO", true));
            this.iD_PDOTextBox.Location = new System.Drawing.Point(145, 126);
            this.iD_PDOTextBox.Name = "iD_PDOTextBox";
            this.iD_PDOTextBox.Size = new System.Drawing.Size(100, 26);
            this.iD_PDOTextBox.TabIndex = 9;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitabla2BindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(162, 179);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 26);
            this.nOMBRETextBox.TabIndex = 10;
            // 
            // cOLORTextBox
            // 
            this.cOLORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitabla2BindingSource, "COLOR", true));
            this.cOLORTextBox.Location = new System.Drawing.Point(158, 242);
            this.cOLORTextBox.Name = "cOLORTextBox";
            this.cOLORTextBox.Size = new System.Drawing.Size(100, 26);
            this.cOLORTextBox.TabIndex = 11;
            // 
            // pRECIOTextBox
            // 
            this.pRECIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitabla2BindingSource, "PRECIO", true));
            this.pRECIOTextBox.Location = new System.Drawing.Point(160, 297);
            this.pRECIOTextBox.Name = "pRECIOTextBox";
            this.pRECIOTextBox.Size = new System.Drawing.Size(100, 26);
            this.pRECIOTextBox.TabIndex = 13;
            // 
            // gRAFICOTextBox
            // 
            this.gRAFICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitabla2BindingSource, "GRAFICO", true));
            this.gRAFICOTextBox.Location = new System.Drawing.Point(176, 344);
            this.gRAFICOTextBox.Name = "gRAFICOTextBox";
            this.gRAFICOTextBox.Size = new System.Drawing.Size(100, 26);
            this.gRAFICOTextBox.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(gRAFICOLabel);
            this.Controls.Add(this.gRAFICOTextBox);
            this.Controls.Add(pRECIOLabel);
            this.Controls.Add(this.pRECIOTextBox);
            this.Controls.Add(cOLORLabel);
            this.Controls.Add(this.cOLORTextBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(iD_PDOLabel);
            this.Controls.Add(this.iD_PDOTextBox);
            this.Controls.Add(this.mitabla2DataGridView);
            this.Controls.Add(this.mitabla2BindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFoto";
            this.Load += new System.EventHandler(this.FormFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mibaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitabla2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitabla2BindingNavigator)).EndInit();
            this.mitabla2BindingNavigator.ResumeLayout(false);
            this.mitabla2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitabla2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private mibaseDataSet2 mibaseDataSet2;
        private System.Windows.Forms.BindingSource mitabla2BindingSource;
        private mibaseDataSet2TableAdapters.mitabla2TableAdapter mitabla2TableAdapter;
        private mibaseDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mitabla2BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mitabla2BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mitabla2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iD_PDOTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cOLORTextBox;
        private System.Windows.Forms.TextBox pRECIOTextBox;
        private System.Windows.Forms.TextBox gRAFICOTextBox;
        private System.Windows.Forms.Button button2;
    }
}