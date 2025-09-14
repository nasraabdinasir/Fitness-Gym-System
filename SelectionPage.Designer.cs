namespace New_Premier_FitnessGym_System
{
    partial class SelectionPage
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
            this.btnAddGymMembers = new System.Windows.Forms.Button();
            this.btnAddGymTutors = new System.Windows.Forms.Button();
            this.btnAddGymClasses = new System.Windows.Forms.Button();
            this.btnAssignTutors = new System.Windows.Forms.Button();
            this.btnAssignMembers = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddGymMembers
            // 
            this.btnAddGymMembers.Location = new System.Drawing.Point(12, 12);
            this.btnAddGymMembers.Name = "btnAddGymMembers";
            this.btnAddGymMembers.Size = new System.Drawing.Size(135, 53);
            this.btnAddGymMembers.TabIndex = 0;
            this.btnAddGymMembers.Text = "Add Gym Members";
            this.btnAddGymMembers.UseVisualStyleBackColor = true;
            this.btnAddGymMembers.Click += new System.EventHandler(this.btnAddGymMembers_Click);
            // 
            // btnAddGymTutors
            // 
            this.btnAddGymTutors.Location = new System.Drawing.Point(153, 12);
            this.btnAddGymTutors.Name = "btnAddGymTutors";
            this.btnAddGymTutors.Size = new System.Drawing.Size(135, 53);
            this.btnAddGymTutors.TabIndex = 1;
            this.btnAddGymTutors.Text = "Add Gym Tutors";
            this.btnAddGymTutors.UseVisualStyleBackColor = true;
            this.btnAddGymTutors.Click += new System.EventHandler(this.btnAddGymTutors_Click);
            // 
            // btnAddGymClasses
            // 
            this.btnAddGymClasses.Location = new System.Drawing.Point(12, 88);
            this.btnAddGymClasses.Name = "btnAddGymClasses";
            this.btnAddGymClasses.Size = new System.Drawing.Size(135, 53);
            this.btnAddGymClasses.TabIndex = 2;
            this.btnAddGymClasses.Text = "Add Gym Classes";
            this.btnAddGymClasses.UseVisualStyleBackColor = true;
            this.btnAddGymClasses.Click += new System.EventHandler(this.btnAddGymClasses_Click);
            // 
            // btnAssignTutors
            // 
            this.btnAssignTutors.Location = new System.Drawing.Point(309, 98);
            this.btnAssignTutors.Name = "btnAssignTutors";
            this.btnAssignTutors.Size = new System.Drawing.Size(135, 53);
            this.btnAssignTutors.TabIndex = 3;
            this.btnAssignTutors.Text = "Assign Tutors";
            this.btnAssignTutors.UseVisualStyleBackColor = true;
            this.btnAssignTutors.Click += new System.EventHandler(this.btnAssignTutors_Click);
            // 
            // btnAssignMembers
            // 
            this.btnAssignMembers.Location = new System.Drawing.Point(309, 12);
            this.btnAssignMembers.Name = "btnAssignMembers";
            this.btnAssignMembers.Size = new System.Drawing.Size(135, 53);
            this.btnAssignMembers.TabIndex = 4;
            this.btnAssignMembers.Text = "Assign Members";
            this.btnAssignMembers.UseVisualStyleBackColor = true;
            this.btnAssignMembers.Click += new System.EventHandler(this.btnAssignMembers_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(153, 159);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(135, 53);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // SelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 226);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnAssignMembers);
            this.Controls.Add(this.btnAssignTutors);
            this.Controls.Add(this.btnAddGymClasses);
            this.Controls.Add(this.btnAddGymTutors);
            this.Controls.Add(this.btnAddGymMembers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SelectionPage";
            this.Text = "MainGymPage";
            this.Load += new System.EventHandler(this.SelectionPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddGymMembers;
        private System.Windows.Forms.Button btnAddGymTutors;
        private System.Windows.Forms.Button btnAddGymClasses;
        private System.Windows.Forms.Button btnAssignTutors;
        private System.Windows.Forms.Button btnAssignMembers;
        private System.Windows.Forms.Button btnclose;
    }
}