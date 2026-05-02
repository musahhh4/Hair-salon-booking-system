namespace Assignment212
{
    partial class Medical_Records
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
			System.Windows.Forms.Label recordIDLabel;
			System.Windows.Forms.Label patientIDLabel;
			System.Windows.Forms.Label doctorIDLabel;
			System.Windows.Forms.Label dateRecordLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical_Records));
			this.ist2ibDataSet = new Assignment212.ist2ibDataSet();
			this.mEDICAL_RECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mEDICAL_RECORDSTableAdapter = new Assignment212.ist2ibDataSetTableAdapters.MEDICAL_RECORDSTableAdapter();
			this.tableAdapterManager = new Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager();
			this.mEDICAL_RECORDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.mEDICAL_RECORDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.recordIDTextBox = new System.Windows.Forms.TextBox();
			this.patientIDTextBox = new System.Windows.Forms.TextBox();
			this.doctorIDTextBox = new System.Windows.Forms.TextBox();
			this.dateRecordDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.mEDICAL_RECORDSDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.button5 = new System.Windows.Forms.Button();
			recordIDLabel = new System.Windows.Forms.Label();
			patientIDLabel = new System.Windows.Forms.Label();
			doctorIDLabel = new System.Windows.Forms.Label();
			dateRecordLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mEDICAL_RECORDSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mEDICAL_RECORDSBindingNavigator)).BeginInit();
			this.mEDICAL_RECORDSBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mEDICAL_RECORDSDataGridView)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// recordIDLabel
			// 
			recordIDLabel.AutoSize = true;
			recordIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			recordIDLabel.Location = new System.Drawing.Point(12, 86);
			recordIDLabel.Name = "recordIDLabel";
			recordIDLabel.Size = new System.Drawing.Size(110, 28);
			recordIDLabel.TabIndex = 1;
			recordIDLabel.Text = "Record ID:";
			// 
			// patientIDLabel
			// 
			patientIDLabel.AutoSize = true;
			patientIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			patientIDLabel.Location = new System.Drawing.Point(140, 86);
			patientIDLabel.Name = "patientIDLabel";
			patientIDLabel.Size = new System.Drawing.Size(112, 28);
			patientIDLabel.TabIndex = 3;
			patientIDLabel.Text = "Patient ID:";
			// 
			// doctorIDLabel
			// 
			doctorIDLabel.AutoSize = true;
			doctorIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			doctorIDLabel.Location = new System.Drawing.Point(286, 86);
			doctorIDLabel.Name = "doctorIDLabel";
			doctorIDLabel.Size = new System.Drawing.Size(109, 28);
			doctorIDLabel.TabIndex = 5;
			doctorIDLabel.Text = "Doctor ID:";
			// 
			// dateRecordLabel
			// 
			dateRecordLabel.AutoSize = true;
			dateRecordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dateRecordLabel.Location = new System.Drawing.Point(434, 86);
			dateRecordLabel.Name = "dateRecordLabel";
			dateRecordLabel.Size = new System.Drawing.Size(134, 28);
			dateRecordLabel.TabIndex = 7;
			dateRecordLabel.Text = "Date Record:";
			// 
			// ist2ibDataSet
			// 
			this.ist2ibDataSet.DataSetName = "ist2ibDataSet";
			this.ist2ibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// mEDICAL_RECORDSBindingSource
			// 
			this.mEDICAL_RECORDSBindingSource.DataMember = "MEDICAL_RECORDS";
			this.mEDICAL_RECORDSBindingSource.DataSource = this.ist2ibDataSet;
			// 
			// mEDICAL_RECORDSTableAdapter
			// 
			this.mEDICAL_RECORDSTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.APPOINTMENTSTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DepartmentDoctorTableAdapter = null;
			this.tableAdapterManager.DEPARTMENTSTableAdapter = null;
			this.tableAdapterManager.DOCTORTableAdapter = null;
			this.tableAdapterManager.LOGIN_USERSTableAdapter = null;
			this.tableAdapterManager.MEDICAL_RECORDSTableAdapter = this.mEDICAL_RECORDSTableAdapter;
			this.tableAdapterManager.PATIENTSTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// mEDICAL_RECORDSBindingNavigator
			// 
			this.mEDICAL_RECORDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.mEDICAL_RECORDSBindingNavigator.BindingSource = this.mEDICAL_RECORDSBindingSource;
			this.mEDICAL_RECORDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.mEDICAL_RECORDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.mEDICAL_RECORDSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mEDICAL_RECORDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mEDICAL_RECORDSBindingNavigatorSaveItem});
			this.mEDICAL_RECORDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.mEDICAL_RECORDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.mEDICAL_RECORDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.mEDICAL_RECORDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.mEDICAL_RECORDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.mEDICAL_RECORDSBindingNavigator.Name = "mEDICAL_RECORDSBindingNavigator";
			this.mEDICAL_RECORDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.mEDICAL_RECORDSBindingNavigator.Size = new System.Drawing.Size(800, 31);
			this.mEDICAL_RECORDSBindingNavigator.TabIndex = 0;
			this.mEDICAL_RECORDSBindingNavigator.Text = "bindingNavigator1";
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
			// mEDICAL_RECORDSBindingNavigatorSaveItem
			// 
			this.mEDICAL_RECORDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.mEDICAL_RECORDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mEDICAL_RECORDSBindingNavigatorSaveItem.Image")));
			this.mEDICAL_RECORDSBindingNavigatorSaveItem.Name = "mEDICAL_RECORDSBindingNavigatorSaveItem";
			this.mEDICAL_RECORDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 36);
			this.mEDICAL_RECORDSBindingNavigatorSaveItem.Text = "Save Data";
			this.mEDICAL_RECORDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.mEDICAL_RECORDSBindingNavigatorSaveItem_Click_1);
			// 
			// recordIDTextBox
			// 
			this.recordIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAL_RECORDSBindingSource, "RecordID", true));
			this.recordIDTextBox.Location = new System.Drawing.Point(12, 108);
			this.recordIDTextBox.Name = "recordIDTextBox";
			this.recordIDTextBox.ReadOnly = true;
			this.recordIDTextBox.Size = new System.Drawing.Size(99, 20);
			this.recordIDTextBox.TabIndex = 2;
			this.recordIDTextBox.TextChanged += new System.EventHandler(this.recordIDTextBox_TextChanged);
			// 
			// patientIDTextBox
			// 
			this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAL_RECORDSBindingSource, "PatientID", true));
			this.patientIDTextBox.Location = new System.Drawing.Point(144, 108);
			this.patientIDTextBox.Name = "patientIDTextBox";
			this.patientIDTextBox.Size = new System.Drawing.Size(115, 20);
			this.patientIDTextBox.TabIndex = 4;
			// 
			// doctorIDTextBox
			// 
			this.doctorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAL_RECORDSBindingSource, "DoctorID", true));
			this.doctorIDTextBox.Location = new System.Drawing.Point(290, 108);
			this.doctorIDTextBox.Name = "doctorIDTextBox";
			this.doctorIDTextBox.Size = new System.Drawing.Size(112, 20);
			this.doctorIDTextBox.TabIndex = 6;
			// 
			// dateRecordDateTimePicker
			// 
			this.dateRecordDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mEDICAL_RECORDSBindingSource, "DateRecord", true));
			this.dateRecordDateTimePicker.Location = new System.Drawing.Point(438, 108);
			this.dateRecordDateTimePicker.Name = "dateRecordDateTimePicker";
			this.dateRecordDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateRecordDateTimePicker.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(62, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 28);
			this.label7.TabIndex = 13;
			this.label7.Text = "Medical Records";
			// 
			// mEDICAL_RECORDSDataGridView
			// 
			this.mEDICAL_RECORDSDataGridView.AutoGenerateColumns = false;
			this.mEDICAL_RECORDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mEDICAL_RECORDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.mEDICAL_RECORDSDataGridView.DataSource = this.mEDICAL_RECORDSBindingSource;
			this.mEDICAL_RECORDSDataGridView.Location = new System.Drawing.Point(75, 158);
			this.mEDICAL_RECORDSDataGridView.Name = "mEDICAL_RECORDSDataGridView";
			this.mEDICAL_RECORDSDataGridView.RowHeadersWidth = 51;
			this.mEDICAL_RECORDSDataGridView.Size = new System.Drawing.Size(494, 122);
			this.mEDICAL_RECORDSDataGridView.TabIndex = 13;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "RecordID";
			this.dataGridViewTextBoxColumn1.HeaderText = "RecordID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientID";
			this.dataGridViewTextBoxColumn2.HeaderText = "PatientID";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "DoctorID";
			this.dataGridViewTextBoxColumn3.HeaderText = "DoctorID";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "DateRecord";
			this.dataGridViewTextBoxColumn4.HeaderText = "DateRecord";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 125;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.01205F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.49398F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 306);
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
			this.button1.Size = new System.Drawing.Size(131, 37);
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
			this.button2.Location = new System.Drawing.Point(140, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 37);
			this.button2.TabIndex = 25;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.White;
			this.pictureBox7.Image = global::Assignment212.Properties.Resources.medical_records;
			this.pictureBox7.Location = new System.Drawing.Point(12, 28);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(44, 40);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 12;
			this.pictureBox7.TabStop = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Crimson;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(749, 38);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(39, 23);
			this.button5.TabIndex = 30;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Medical_Records
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 381);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.mEDICAL_RECORDSDataGridView);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(recordIDLabel);
			this.Controls.Add(this.recordIDTextBox);
			this.Controls.Add(patientIDLabel);
			this.Controls.Add(this.patientIDTextBox);
			this.Controls.Add(doctorIDLabel);
			this.Controls.Add(this.doctorIDTextBox);
			this.Controls.Add(dateRecordLabel);
			this.Controls.Add(this.dateRecordDateTimePicker);
			this.Controls.Add(this.mEDICAL_RECORDSBindingNavigator);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Medical_Records";
			this.Text = "Medical_Records";
			this.Load += new System.EventHandler(this.Medical_Records_Load);
			((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mEDICAL_RECORDSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mEDICAL_RECORDSBindingNavigator)).EndInit();
			this.mEDICAL_RECORDSBindingNavigator.ResumeLayout(false);
			this.mEDICAL_RECORDSBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mEDICAL_RECORDSDataGridView)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ist2ibDataSet ist2ibDataSet;
        private System.Windows.Forms.BindingSource mEDICAL_RECORDSBindingSource;
        private ist2ibDataSetTableAdapters.MEDICAL_RECORDSTableAdapter mEDICAL_RECORDSTableAdapter;
        private ist2ibDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mEDICAL_RECORDSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mEDICAL_RECORDSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox recordIDTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox doctorIDTextBox;
        private System.Windows.Forms.DateTimePicker dateRecordDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView mEDICAL_RECORDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}