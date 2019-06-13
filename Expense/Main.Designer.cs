namespace Expense
{
    partial class Main
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
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnDeposits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpenses
            // 
            this.btnExpenses.Location = new System.Drawing.Point(20, 39);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(75, 35);
            this.btnExpenses.TabIndex = 0;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnDeposits
            // 
            this.btnDeposits.Location = new System.Drawing.Point(104, 39);
            this.btnDeposits.Name = "btnDeposits";
            this.btnDeposits.Size = new System.Drawing.Size(75, 35);
            this.btnDeposits.TabIndex = 1;
            this.btnDeposits.Text = "Deposits";
            this.btnDeposits.UseVisualStyleBackColor = true;
            this.btnDeposits.Click += new System.EventHandler(this.btnDeposits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transcations";
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(188, 39);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(75, 35);
            this.btnCredits.TabIndex = 2;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(272, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnExpenses;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(366, 85);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeposits);
            this.Controls.Add(this.btnExpenses);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnDeposits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnClose;
    }
}