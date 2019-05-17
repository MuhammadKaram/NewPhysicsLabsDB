namespace PhysicsLabsDB.Reports
{
    partial class frmExperimentComponentsReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExperimentComponentsReport));
            this.devices_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExperimentComponents = new PhysicsLabsDB.Reports.dsExperimentComponents();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.devices_tbTableAdapter = new PhysicsLabsDB.Reports.dsExperimentComponentsTableAdapters.devices_tbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.devices_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExperimentComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // devices_tbBindingSource
            // 
            this.devices_tbBindingSource.DataMember = "devices_tb";
            this.devices_tbBindingSource.DataSource = this.dsExperimentComponents;
            // 
            // dsExperimentComponents
            // 
            this.dsExperimentComponents.DataSetName = "dsExperimentComponents";
            this.dsExperimentComponents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsExperimentComponents";
            reportDataSource1.Value = this.devices_tbBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PhysicsLabsDB.Reports.rptExperimentComponents.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(627, 629);
            this.reportViewer.TabIndex = 0;
            // 
            // devices_tbTableAdapter
            // 
            this.devices_tbTableAdapter.ClearBeforeFill = true;
            // 
            // frmExperimentComponentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 629);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExperimentComponentsReport";
            this.Text = "كارت التجربة";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devices_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExperimentComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource devices_tbBindingSource;
        private dsExperimentComponents dsExperimentComponents;
        private dsExperimentComponentsTableAdapters.devices_tbTableAdapter devices_tbTableAdapter;
    }
}