namespace WorldAtWork
{
    partial class Form3
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
            this.editButton = new System.Windows.Forms.Button();
            this.behaviorLabel = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.prerequisiteLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.behaviorContentLabel = new System.Windows.Forms.Label();
            this.nameContentLabel = new System.Windows.Forms.Label();
            this.statusContentLabel = new System.Windows.Forms.Label();
            this.ticketContentLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.stepsContentLabel = new System.Windows.Forms.Label();
            this.prerequisitesContentLabel = new System.Windows.Forms.Label();
            this.summaryContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(286, 556);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 29;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // behaviorLabel
            // 
            this.behaviorLabel.AutoSize = true;
            this.behaviorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.behaviorLabel.Location = new System.Drawing.Point(62, 397);
            this.behaviorLabel.Name = "behaviorLabel";
            this.behaviorLabel.Size = new System.Drawing.Size(118, 13);
            this.behaviorLabel.TabIndex = 25;
            this.behaviorLabel.Text = "Expected Behavior:";
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsLabel.Location = new System.Drawing.Point(62, 262);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(81, 13);
            this.stepsLabel.TabIndex = 24;
            this.stepsLabel.Text = "Repro Steps:";
            // 
            // prerequisiteLabel
            // 
            this.prerequisiteLabel.AutoSize = true;
            this.prerequisiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prerequisiteLabel.Location = new System.Drawing.Point(62, 200);
            this.prerequisiteLabel.Name = "prerequisiteLabel";
            this.prerequisiteLabel.Size = new System.Drawing.Size(88, 13);
            this.prerequisiteLabel.TabIndex = 23;
            this.prerequisiteLabel.Text = "Prerequisites: ";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.Location = new System.Drawing.Point(62, 130);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(65, 13);
            this.summaryLabel.TabIndex = 22;
            this.summaryLabel.Text = "Summary: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(544, 51);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 13);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Status: ";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(267, 51);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(113, 13);
            this.ticketLabel.TabIndex = 20;
            this.ticketLabel.Text = "Associated Ticket:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(62, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name: ";
            // 
            // behaviorContentLabel
            // 
            this.behaviorContentLabel.Location = new System.Drawing.Point(218, 397);
            this.behaviorContentLabel.Name = "behaviorContentLabel";
            this.behaviorContentLabel.Size = new System.Drawing.Size(476, 140);
            this.behaviorContentLabel.TabIndex = 30;
            this.behaviorContentLabel.Text = "Status: ";
            // 
            // nameContentLabel
            // 
            this.nameContentLabel.AutoSize = true;
            this.nameContentLabel.Location = new System.Drawing.Point(109, 51);
            this.nameContentLabel.Name = "nameContentLabel";
            this.nameContentLabel.Size = new System.Drawing.Size(43, 13);
            this.nameContentLabel.TabIndex = 33;
            this.nameContentLabel.Text = "Status: ";
            // 
            // statusContentLabel
            // 
            this.statusContentLabel.AutoSize = true;
            this.statusContentLabel.Location = new System.Drawing.Point(601, 51);
            this.statusContentLabel.Name = "statusContentLabel";
            this.statusContentLabel.Size = new System.Drawing.Size(43, 13);
            this.statusContentLabel.TabIndex = 35;
            this.statusContentLabel.Text = "Status: ";
            // 
            // ticketContentLabel
            // 
            this.ticketContentLabel.AutoSize = true;
            this.ticketContentLabel.Location = new System.Drawing.Point(386, 51);
            this.ticketContentLabel.Name = "ticketContentLabel";
            this.ticketContentLabel.Size = new System.Drawing.Size(43, 13);
            this.ticketContentLabel.TabIndex = 36;
            this.ticketContentLabel.Text = "Status: ";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(367, 556);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // stepsContentLabel
            // 
            this.stepsContentLabel.Location = new System.Drawing.Point(218, 262);
            this.stepsContentLabel.Name = "stepsContentLabel";
            this.stepsContentLabel.Size = new System.Drawing.Size(476, 113);
            this.stepsContentLabel.TabIndex = 38;
            this.stepsContentLabel.Text = "Status: ";
            // 
            // prerequisitesContentLabel
            // 
            this.prerequisitesContentLabel.Location = new System.Drawing.Point(218, 200);
            this.prerequisitesContentLabel.Name = "prerequisitesContentLabel";
            this.prerequisitesContentLabel.Size = new System.Drawing.Size(476, 44);
            this.prerequisitesContentLabel.TabIndex = 39;
            this.prerequisitesContentLabel.Text = "Status: ";
            // 
            // summaryContentLabel
            // 
            this.summaryContentLabel.Location = new System.Drawing.Point(218, 130);
            this.summaryContentLabel.Name = "summaryContentLabel";
            this.summaryContentLabel.Size = new System.Drawing.Size(476, 44);
            this.summaryContentLabel.TabIndex = 40;
            this.summaryContentLabel.Text = "Status: ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 604);
            this.Controls.Add(this.summaryContentLabel);
            this.Controls.Add(this.prerequisitesContentLabel);
            this.Controls.Add(this.stepsContentLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ticketContentLabel);
            this.Controls.Add(this.statusContentLabel);
            this.Controls.Add(this.nameContentLabel);
            this.Controls.Add(this.behaviorContentLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.behaviorLabel);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.prerequisiteLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label behaviorLabel;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Label prerequisiteLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label behaviorContentLabel;
        private System.Windows.Forms.Label nameContentLabel;
        private System.Windows.Forms.Label statusContentLabel;
        private System.Windows.Forms.Label ticketContentLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label stepsContentLabel;
        private System.Windows.Forms.Label prerequisitesContentLabel;
        private System.Windows.Forms.Label summaryContentLabel;
    }
}