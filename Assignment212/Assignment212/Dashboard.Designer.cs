namespace Assignment212
{
    partial class Dashboard
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
			this.ist2ibDataSet = new Assignment212.ist2ibDataSet();
			this.taAppointments = new Assignment212.ist2ibDataSetTableAdapters.APPOINTMENTSTableAdapter();
			this.taPatients = new Assignment212.ist2ibDataSetTableAdapters.PATIENTSTableAdapter();
			this.taDoctors = new Assignment212.ist2ibDataSetTableAdapters.DOCTORTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// ist2ibDataSet
			// 
			this.ist2ibDataSet.DataSetName = "ist2ibDataSet";
			this.ist2ibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// taAppointments
			// 
			this.taAppointments.ClearBeforeFill = true;
			// 
			// taPatients
			// 
			this.taPatients.ClearBeforeFill = true;
			// 
			// taDoctors
			// 
			this.taDoctors.ClearBeforeFill = true;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(1401, 700);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.UseWaitCursor = true;
			this.Load += new System.EventHandler(this.Dashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
		private ist2ibDataSet ist2ibDataSet;
		private ist2ibDataSetTableAdapters.APPOINTMENTSTableAdapter taAppointments;
		private ist2ibDataSetTableAdapters.PATIENTSTableAdapter taPatients;
		private ist2ibDataSetTableAdapters.DOCTORTableAdapter taDoctors;
	}
}