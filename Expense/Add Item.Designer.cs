namespace Expense
{
    partial class Add_Item
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 577);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(112, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name :- ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add New Items";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(98, 541);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(92, 20);
            this.txtItemName.TabIndex = 4;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // dgvItemList
            // 
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(12, 34);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.Size = new System.Drawing.Size(174, 488);
            this.dgvItemList.TabIndex = 5;
            // 
            // Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 610);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Item";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add_Item";
            this.Load += new System.EventHandler(this.Add_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.DataGridView dgvItemList;
    }
}