namespace Expense
{
    partial class Expense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrintpreview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem1 = new System.Windows.Forms.TextBox();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.Dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lblDtp1 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.lblExpense1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblDtp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtQuantity1 = new System.Windows.Forms.TextBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintpreview
            // 
            this.btnPrintpreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintpreview.Location = new System.Drawing.Point(508, 219);
            this.btnPrintpreview.Name = "btnPrintpreview";
            this.btnPrintpreview.Size = new System.Drawing.Size(150, 37);
            this.btnPrintpreview.TabIndex = 11;
            this.btnPrintpreview.Text = "Print Preview";
            this.btnPrintpreview.UseVisualStyleBackColor = true;
            this.btnPrintpreview.Click += new System.EventHandler(this.btnPrintpreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(541, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(5, 46);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(40, 15);
            this.lblItem.TabIndex = 56;
            this.lblItem.Text = "Item :-";
            // 
            // txtItem1
            // 
            this.txtItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem1.Location = new System.Drawing.Point(569, 75);
            this.txtItem1.Name = "txtItem1";
            this.txtItem1.Size = new System.Drawing.Size(103, 22);
            this.txtItem1.TabIndex = 6;
            this.txtItem1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem1.Location = new System.Drawing.Point(502, 79);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(40, 15);
            this.lblItem1.TabIndex = 55;
            this.lblItem1.Text = "Item :-";
            // 
            // Dtp1
            // 
            this.Dtp1.CustomFormat = "dd-MM-yyyy";
            this.Dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp1.Location = new System.Drawing.Point(569, 186);
            this.Dtp1.Name = "Dtp1";
            this.Dtp1.Size = new System.Drawing.Size(103, 22);
            this.Dtp1.TabIndex = 9;
            // 
            // lblDtp1
            // 
            this.lblDtp1.AutoSize = true;
            this.lblDtp1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtp1.Location = new System.Drawing.Point(502, 190);
            this.lblDtp1.Name = "lblDtp1";
            this.lblDtp1.Size = new System.Drawing.Size(42, 15);
            this.lblDtp1.TabIndex = 54;
            this.lblDtp1.Text = "Date :-";
            // 
            // txtPrice1
            // 
            this.txtPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice1.Location = new System.Drawing.Point(569, 113);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(103, 22);
            this.txtPrice1.TabIndex = 7;
            this.txtPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpense_KeyPress);
            // 
            // lblExpense1
            // 
            this.lblExpense1.AutoSize = true;
            this.lblExpense1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense1.Location = new System.Drawing.Point(502, 117);
            this.lblExpense1.Name = "lblExpense1";
            this.lblExpense1.Size = new System.Drawing.Size(46, 15);
            this.lblExpense1.TabIndex = 53;
            this.lblExpense1.Text = "Price :- ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(29, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(413, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(285, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Daily Expenses";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(236, 42);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(95, 22);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpense_KeyPress);
            // 
            // Dtp
            // 
            this.Dtp.CustomFormat = "dd-MM-yyyy";
            this.Dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp.Location = new System.Drawing.Point(568, 39);
            this.Dtp.Name = "Dtp";
            this.Dtp.Size = new System.Drawing.Size(103, 22);
            this.Dtp.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 186);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(182, 46);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(43, 15);
            this.lblExpense.TabIndex = 44;
            this.lblExpense.Text = "Price :-";
            // 
            // lblDtp
            // 
            this.lblDtp.AutoSize = true;
            this.lblDtp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtp.Location = new System.Drawing.Point(501, 43);
            this.lblDtp.Name = "lblDtp";
            this.lblDtp.Size = new System.Drawing.Size(42, 15);
            this.lblDtp.TabIndex = 41;
            this.lblDtp.Text = "Date :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Quantity :-";
            // 
            // lblQuantity1
            // 
            this.lblQuantity1.AutoSize = true;
            this.lblQuantity1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity1.Location = new System.Drawing.Point(502, 153);
            this.lblQuantity1.Name = "lblQuantity1";
            this.lblQuantity1.Size = new System.Drawing.Size(67, 15);
            this.lblQuantity1.TabIndex = 60;
            this.lblQuantity1.Text = "Quantity :- ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(395, 42);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity1.Location = new System.Drawing.Point(572, 149);
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity1.TabIndex = 8;
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.SystemColors.Window;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(51, 42);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.Sorted = true;
            this.cmbItem.TabIndex = 0;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(157, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // Expense
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtQuantity1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintpreview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem1);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.Dtp1);
            this.Controls.Add(this.lblDtp1);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.lblExpense1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Dtp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.lblDtp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintpreview;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem1;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.DateTimePicker Dtp1;
        private System.Windows.Forms.Label lblDtp1;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label lblExpense1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker Dtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtQuantity1;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Button button1;
    }
}

