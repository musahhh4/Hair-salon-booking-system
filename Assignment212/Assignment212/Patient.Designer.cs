namespace Assignment212
{
    partial class Patient
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
			System.Windows.Forms.Label patientIDLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label cellNoLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label genderLabel;
			System.Windows.Forms.Label addressLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
			this.label1 = new System.Windows.Forms.Label();
			this.ist2ibDataSet = new Assignment212.ist2ibDataSet();
			this.pATIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pATIENTSTableAdapter = new Assignment212.ist2ibDataSetTableAdapters.PATIENTSTableAdapter();
			this.tableAdapterManager = new Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager();
			this.pATIENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.pATIENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.patientIDTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.cellNoTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.pATIENTSDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button6 = new System.Windows.Forms.Button();
			patientIDLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			cellNoLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			genderLabel = new System.Windows.Forms.Label();
			addressLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingNavigator)).BeginInit();
			this.pATIENTSBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pATIENTSDataGridView)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// patientIDLabel
			// 
			patientIDLabel.AutoSize = true;
			patientIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			patientIDLabel.Location = new System.Drawing.Point(8, 100);
			patientIDLabel.Name = "patientIDLabel";
			patientIDLabel.Size = new System.Drawing.Size(112, 28);
			patientIDLabel.TabIndex = 7;
			patientIDLabel.Text = "Patient ID:";
			patientIDLabel.Click += new System.EventHandler(this.patientIDLabel_Click);
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nameLabel.Location = new System.Drawing.Point(115, 100);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(73, 28);
			nameLabel.TabIndex = 9;
			nameLabel.Text = "Name:";
			// 
			// cellNoLabel
			// 
			cellNoLabel.AutoSize = true;
			cellNoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cellNoLabel.Location = new System.Drawing.Point(243, 100);
			cellNoLabel.Name = "cellNoLabel";
			cellNoLabel.Size = new System.Drawing.Size(86, 28);
			cellNoLabel.TabIndex = 11;
			cellNoLabel.Text = "Cell No:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel.Location = new System.Drawing.Point(371, 100);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(69, 28);
			emailLabel.TabIndex = 13;
			emailLabel.Text = "Email:";
			// 
			// genderLabel
			// 
			genderLabel.AutoSize = true;
			genderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			genderLabel.Location = new System.Drawing.Point(511, 100);
			genderLabel.Name = "genderLabel";
			genderLabel.Size = new System.Drawing.Size(86, 28);
			genderLabel.TabIndex = 15;
			genderLabel.Text = "Gender:";
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			addressLabel.Location = new System.Drawing.Point(644, 100);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(92, 28);
			addressLabel.TabIndex = 17;
			addressLabel.Text = "Address:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 28);
			this.label1.TabIndex = 6;
			this.label1.Text = "Patients";
			// 
			// ist2ibDataSet
			// 
			this.ist2ibDataSet.DataSetName = "ist2ibDataSet";
			this.ist2ibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pATIENTSBindingSource
			// 
			this.pATIENTSBindingSource.DataMember = "PATIENTS";
			this.pATIENTSBindingSource.DataSource = this.ist2ibDataSet;
			// 
			// pATIENTSTableAdapter
			// 
			this.pATIENTSTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.APPOINTMENTSTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DepartmentDoctorTableAdapter = null;
			this.tableAdapterManager.DEPARTMENTSTableAdapter = null;
			this.tableAdapterManager.DOCTORTableAdapter = null;
			this.tableAdapterManager.LOGIN_USERSTableAdapter = null;
			this.tableAdapterManager.MEDICAL_RECORDSTableAdapter = null;
			this.tableAdapterManager.PATIENTSTableAdapter = this.pATIENTSTableAdapter;
			this.tableAdapterManager.UpdateOrder = Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// pATIENTSBindingNavigator
			// 
			this.pATIENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.pATIENTSBindingNavigator.BindingSource = this.pATIENTSBindingSource;
			this.pATIENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.pATIENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.pATIENTSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.pATIENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pATIENTSBindingNavigatorSaveItem});
			this.pATIENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.pATIENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.pATIENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.pATIENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.pATIENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.pATIENTSBindingNavigator.Name = "pATIENTSBindingNavigator";
			this.pATIENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.pATIENTSBindingNavigator.Size = new System.Drawing.Size(800, 31);
			this.pATIENTSBindingNavigator.TabIndex = 7;
			this.pATIENTSBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 36);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 36);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 36);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 36);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 36);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 36);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// pATIENTSBindingNavigatorSaveItem
			// 
			this.pATIENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pATIENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pATIENTSBindingNavigatorSaveItem.Image")));
			this.pATIENTSBindingNavigatorSaveItem.Name = "pATIENTSBindingNavigatorSaveItem";
			this.pATIENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 36);
			this.pATIENTSBindingNavigatorSaveItem.Text = "Save Data";
			this.pATIENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pATIENTSBindingNavigatorSaveItem_Click);
			// 
			// patientIDTextBox
			// 
			this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "PatientID", true));
			this.patientIDTextBox.Location = new System.Drawing.Point(12, 124);
			this.patientIDTextBox.Name = "patientIDTextBox";
			this.patientIDTextBox.ReadOnly = true;
			this.patientIDTextBox.Size = new System.Drawing.Size(86, 20);
			this.patientIDTextBox.TabIndex = 8;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(119, 124);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(111, 20);
			this.nameTextBox.TabIndex = 10;
			// 
			// cellNoTextBox
			// 
			this.cellNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "CellNo", true));
			this.cellNoTextBox.Location = new System.Drawing.Point(247, 124);
			this.cellNoTextBox.Name = "cellNoTextBox";
			this.cellNoTextBox.Size = new System.Drawing.Size(100, 20);
			this.cellNoTextBox.TabIndex = 12;
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "Email", true));
			this.emailTextBox.Location = new System.Drawing.Point(375, 124);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(115, 20);
			this.emailTextBox.TabIndex = 14;
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(648, 124);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 18;
			// 
			// pATIENTSDataGridView
			// 
			this.pATIENTSDataGridView.AutoGenerateColumns = false;
			this.pATIENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pATIENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.pATIENTSDataGridView.DataSource = this.pATIENTSBindingSource;
			this.pATIENTSDataGridView.Location = new System.Drawing.Point(50, 170);
			this.pATIENTSDataGridView.Name = "pATIENTSDataGridView";
			this.pATIENTSDataGridView.RowHeadersWidth = 51;
			this.pATIENTSDataGridView.Size = new System.Drawing.Size(645, 167);
			this.pATIENTSDataGridView.TabIndex = 18;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
			this.dataGridViewTextBoxColumn1.HeaderText = "PatientID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "CellNo";
			this.dataGridViewTextBoxColumn3.HeaderText = "CellNo";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
			this.dataGridViewTextBoxColumn4.HeaderText = "Email";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 125;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Gender";
			this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 125;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn6.HeaderText = "Address";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 125;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(166, 353);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 43);
			this.tableLayoutPanel1.TabIndex = 28;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 37);
			this.button1.TabIndex = 24;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(279, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 37);
			this.button3.TabIndex = 26;
			this.button3.Text = "Update";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(141, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 37);
			this.button2.TabIndex = 25;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(702, 353);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 29;
			this.button4.Text = "Sign In";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = global::Assignment212.Properties.Resources.outpatient;
			this.pictureBox1.Location = new System.Drawing.Point(12, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Female",
            "Male"});
			this.comboBox1.Location = new System.Drawing.Point(515, 124);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(113, 21);
			this.comboBox1.TabIndex = 31;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Crimson;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(738, 46);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(39, 23);
			this.button6.TabIndex = 32;
			this.button6.Text = "X";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pATIENTSDataGridView);
			this.Controls.Add(patientIDLabel);
			this.Controls.Add(this.patientIDTextBox);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(cellNoLabel);
			this.Controls.Add(this.cellNoTextBox);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(genderLabel);
			this.Controls.Add(addressLabel);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.pATIENTSBindingNavigator);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Patient";
			this.Text = "Patient";
			this.Load += new System.EventHandler(this.Patient_Load);
			((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingNavigator)).EndInit();
			this.pATIENTSBindingNavigator.ResumeLayout(false);
			this.pATIENTSBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pATIENTSDataGridView)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ist2ibDataSet ist2ibDataSet;
        private System.Windows.Forms.BindingSource pATIENTSBindingSource;
        private ist2ibDataSetTableAdapters.PATIENTSTableAdapter pATIENTSTableAdapter;
        private ist2ibDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pATIENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pATIENTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cellNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DataGridView pATIENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
    }
}