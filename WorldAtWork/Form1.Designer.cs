namespace WorldAtWork
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
            this.testCaseList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTestCaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testCaseList
            // 
            this.testCaseList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.testCaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.summaryColumn,
            this.statusColumn});
            this.testCaseList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.testCaseList.HideSelection = false;
            this.testCaseList.Location = new System.Drawing.Point(0, 0);
            this.testCaseList.Name = "testCaseList";
            this.testCaseList.Size = new System.Drawing.Size(946, 533);
            this.testCaseList.TabIndex = 0;
            this.testCaseList.UseCompatibleStateImageBehavior = false;
            this.testCaseList.View = System.Windows.Forms.View.Details;
            this.testCaseList.ItemActivate += new System.EventHandler(this.testCaseList_Activate);
            this.testCaseList.SelectedIndexChanged += new System.EventHandler(this.testCaseList_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 78;
            // 
            // summaryColumn
            // 
            this.summaryColumn.Text = "Summary";
            this.summaryColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.summaryColumn.Width = 779;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusColumn.Width = 84;
            // 
            // addTestCaseButton
            // 
            this.addTestCaseButton.Location = new System.Drawing.Point(437, 550);
            this.addTestCaseButton.Name = "addTestCaseButton";
            this.addTestCaseButton.Size = new System.Drawing.Size(75, 23);
            this.addTestCaseButton.TabIndex = 1;
            this.addTestCaseButton.Text = "Add Test Case";
            this.addTestCaseButton.UseVisualStyleBackColor = true;
            this.addTestCaseButton.Click += new System.EventHandler(this.addTestCase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 585);
            this.Controls.Add(this.addTestCaseButton);
            this.Controls.Add(this.testCaseList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView testCaseList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader summaryColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.Button addTestCaseButton;
    }
}

