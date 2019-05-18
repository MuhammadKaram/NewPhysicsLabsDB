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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExperimentComponentsReport));
            this.devices_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExperimentComponents = new PhysicsLabsDB.Reports.dsExperimentComponents();
            this.devices_tbTableAdapter = new PhysicsLabsDB.Reports.dsExperimentComponentsTableAdapters.devices_tbTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptExperimentComponents1 = new PhysicsLabsDB.Reports.rptExperimentComponents();
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
            // devices_tbTableAdapter
            // 
            this.devices_tbTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptExperimentComponents1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(865, 629);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmExperimentComponentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 629);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExperimentComponentsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كارت التجربة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devices_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExperimentComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource devices_tbBindingSource;
        private dsExperimentComponents dsExperimentComponents;
        private dsExperimentComponentsTableAdapters.devices_tbTableAdapter devices_tbTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptExperimentComponents rptExperimentComponents1;
    }
}