namespace Expense
{
    partial class Print_Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_Preview));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.chkSearchByDate = new System.Windows.Forms.CheckBox();
            this.chkSearchByMonth = new System.Windows.Forms.CheckBox();
            this.chkSearchByYear = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrintReport = new System.Drawing.Printing.PrintDocument();
            this.lblSpent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(238, 320);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(339, 320);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(70, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMembers);
            this.panel1.Location = new System.Drawing.Point(9, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 221);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMembers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.Size = new System.Drawing.Size(541, 221);
            this.dataGridViewMembers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "From :-";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "To :-";
            this.label2.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(61, 43);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(99, 20);
            this.dtpFrom.TabIndex = 7;
            this.dtpFrom.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd-MM-yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(206, 43);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(96, 20);
            this.dtpTo.TabIndex = 8;
            this.dtpTo.Visible = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(11, 44);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(99, 21);
            this.cmbMonth.TabIndex = 10;
            this.cmbMonth.Text = "- Select Month -";
            this.cmbMonth.Visible = false;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(137, 320);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(70, 23);
            this.btnPreview.TabIndex = 12;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(124, 44);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(95, 21);
            this.cmbYear.TabIndex = 13;
            this.cmbYear.Text = "- Select Year -";
            this.cmbYear.Visible = false;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // chkSearchByDate
            // 
            this.chkSearchByDate.AutoSize = true;
            this.chkSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchByDate.Location = new System.Drawing.Point(103, 16);
            this.chkSearchByDate.Name = "chkSearchByDate";
            this.chkSearchByDate.Size = new System.Drawing.Size(100, 17);
            this.chkSearchByDate.TabIndex = 14;
            this.chkSearchByDate.Text = "Search by Date";
            this.chkSearchByDate.UseVisualStyleBackColor = true;
            this.chkSearchByDate.CheckedChanged += new System.EventHandler(this.chkSearchByDate_CheckedChanged);
            // 
            // chkSearchByMonth
            // 
            this.chkSearchByMonth.AutoSize = true;
            this.chkSearchByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchByMonth.Location = new System.Drawing.Point(11, 19);
            this.chkSearchByMonth.Name = "chkSearchByMonth";
            this.chkSearchByMonth.Size = new System.Drawing.Size(107, 17);
            this.chkSearchByMonth.TabIndex = 16;
            this.chkSearchByMonth.Text = "Search by Month";
            this.chkSearchByMonth.UseVisualStyleBackColor = true;
            this.chkSearchByMonth.CheckedChanged += new System.EventHandler(this.chkSearchByMonth_CheckedChanged);
            // 
            // chkSearchByYear
            // 
            this.chkSearchByYear.AutoSize = true;
            this.chkSearchByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchByYear.Location = new System.Drawing.Point(124, 19);
            this.chkSearchByYear.Name = "chkSearchByYear";
            this.chkSearchByYear.Size = new System.Drawing.Size(99, 17);
            this.chkSearchByYear.TabIndex = 17;
            this.chkSearchByYear.Text = "Search by Year";
            this.chkSearchByYear.UseVisualStyleBackColor = true;
            this.chkSearchByYear.CheckedChanged += new System.EventHandler(this.chkSearchByYear_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSpent);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.chkSearchByDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 74);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Date";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(36, 320);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(440, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSearchByYear);
            this.groupBox2.Controls.Add(this.cmbMonth);
            this.groupBox2.Controls.Add(this.cmbYear);
            this.groupBox2.Controls.Add(this.chkSearchByMonth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(321, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 74);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Month and Year";
            // 
            // PrintReport
            // 
            this.PrintReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Location = new System.Drawing.Point(218, 18);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(51, 13);
            this.lblSpent.TabIndex = 15;
            this.lblSpent.Text = "Rs 0.00";
            // 
            // Printpreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.panel1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Printpreview";
            this.Text = "Print Preview";
            this.Load += new System.EventHandler(this.Printpreview_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.CheckBox chkSearchByDate;
        private System.Windows.Forms.CheckBox chkSearchByMonth;
        private System.Windows.Forms.CheckBox chkSearchByYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument PrintReport;
        private System.Windows.Forms.Label lblSpent;
    }
}