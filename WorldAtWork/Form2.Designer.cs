namespace WorldAtWork
{
    partial class Form2
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ticketTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.prerequisiteLabel = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.behaviorLabel = new System.Windows.Forms.Label();
            this.prerequisitesTextBox = new System.Windows.Forms.TextBox();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.behaviorTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(101, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // ticketTextBox
            // 
            this.ticketTextBox.Location = new System.Drawing.Point(360, 41);
            this.ticketTextBox.Name = "ticketTextBox";
            this.ticketTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketTextBox.TabIndex = 1;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(576, 41);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 2;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(181, 123);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(495, 45);
            this.summaryTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(54, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name: ";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Location = new System.Drawing.Point(259, 44);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(95, 13);
            this.ticketLabel.TabIndex = 5;
            this.ticketLabel.Text = "Associated Ticket:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(527, 44);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status: ";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(54, 123);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(56, 13);
            this.summaryLabel.TabIndex = 7;
            this.summaryLabel.Text = "Summary: ";
            // 
            // prerequisiteLabel
            // 
            this.prerequisiteLabel.AutoSize = true;
            this.prerequisiteLabel.Location = new System.Drawing.Point(54, 193);
            this.prerequisiteLabel.Name = "prerequisiteLabel";
            this.prerequisiteLabel.Size = new System.Drawing.Size(73, 13);
            this.prerequisiteLabel.TabIndex = 8;
            this.prerequisiteLabel.Text = "Prerequisites: ";
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Location = new System.Drawing.Point(54, 255);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(69, 13);
            this.stepsLabel.TabIndex = 9;
            this.stepsLabel.Text = "Repro Steps:";
            // 
            // behaviorLabel
            // 
            this.behaviorLabel.AutoSize = true;
            this.behaviorLabel.Location = new System.Drawing.Point(54, 390);
            this.behaviorLabel.Name = "behaviorLabel";
            this.behaviorLabel.Size = new System.Drawing.Size(100, 13);
            this.behaviorLabel.TabIndex = 10;
            this.behaviorLabel.Text = "Expected Behavior:";
            // 
            // prerequisitesTextBox
            // 
            this.prerequisitesTextBox.Location = new System.Drawing.Point(181, 193);
            this.prerequisitesTextBox.Multiline = true;
            this.prerequisitesTextBox.Name = "prerequisitesTextBox";
            this.prerequisitesTextBox.Size = new System.Drawing.Size(495, 37);
            this.prerequisitesTextBox.TabIndex = 11;
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.Location = new System.Drawing.Point(181, 255);
            this.stepsTextBox.Multiline = true;
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.Size = new System.Drawing.Size(495, 102);
            this.stepsTextBox.TabIndex = 12;
            // 
            // behaviorTextBox
            // 
            this.behaviorTextBox.Location = new System.Drawing.Point(181, 387);
            this.behaviorTextBox.Multiline = true;
            this.behaviorTextBox.Name = "behaviorTextBox";
            this.behaviorTextBox.Size = new System.Drawing.Size(495, 120);
            this.behaviorTextBox.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(327, 545);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 591);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.behaviorTextBox);
            this.Controls.Add(this.stepsTextBox);
            this.Controls.Add(this.prerequisitesTextBox);
            this.Controls.Add(this.behaviorLabel);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.prerequisiteLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.ticketTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox ticketTextBox;
        public System.Windows.Forms.TextBox statusTextBox;
        public System.Windows.Forms.TextBox summaryTextBox;
        public System.Windows.Forms.TextBox prerequisitesTextBox;
        public System.Windows.Forms.TextBox stepsTextBox;
        public System.Windows.Forms.TextBox behaviorTextBox;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label prerequisiteLabel;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Label behaviorLabel;

        private System.Windows.Forms.Button saveButton;
    }
}