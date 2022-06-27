
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LinqPracticeDataSet = new WindowsFormsApp1.LinqPracticeDataSet();
            this.SearchCustomerByCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchCustomerByCountryTableAdapter = new WindowsFormsApp1.LinqPracticeDataSetTableAdapters.SearchCustomerByCountryTableAdapter();
            this.srcLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LinqPracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerByCountryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(389, 72);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 27);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Customers";
            reportDataSource1.Value = this.SearchCustomerByCountryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(125, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 1;
            // 
            // LinqPracticeDataSet
            // 
            this.LinqPracticeDataSet.DataSetName = "LinqPracticeDataSet";
            this.LinqPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchCustomerByCountryBindingSource
            // 
            this.SearchCustomerByCountryBindingSource.DataMember = "SearchCustomerByCountry";
            this.SearchCustomerByCountryBindingSource.DataSource = this.LinqPracticeDataSet;
            // 
            // SearchCustomerByCountryTableAdapter
            // 
            this.SearchCustomerByCountryTableAdapter.ClearBeforeFill = true;
            // 
            // srcLabel
            // 
            this.srcLabel.AutoSize = true;
            this.srcLabel.Location = new System.Drawing.Point(140, 73);
            this.srcLabel.Name = "srcLabel";
            this.srcLabel.Size = new System.Drawing.Size(65, 17);
            this.srcLabel.TabIndex = 2;
            this.srcLabel.Text = "Search : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.srcLabel);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinqPracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerByCountryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SearchCustomerByCountryBindingSource;
        private LinqPracticeDataSet LinqPracticeDataSet;
        private LinqPracticeDataSetTableAdapters.SearchCustomerByCountryTableAdapter SearchCustomerByCountryTableAdapter;
        private System.Windows.Forms.Label srcLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

