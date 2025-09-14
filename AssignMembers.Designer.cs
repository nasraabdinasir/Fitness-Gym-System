namespace New_Premier_FitnessGym_System
{
    partial class AssignMembers
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
            System.Windows.Forms.Label member_IDLabel;
            System.Windows.Forms.Label class_IDLabel;
            System.Windows.Forms.Label durationLabel;
            this.btnviewlist = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btngobacktopreviouspage = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.assignMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignMembersTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.AssignMembersTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gymMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymMembersTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymMembersTableAdapter();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.ClassesTableAdapter();
            member_IDLabel = new System.Windows.Forms.Label();
            class_IDLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // member_IDLabel
            // 
            member_IDLabel.AutoSize = true;
            member_IDLabel.Location = new System.Drawing.Point(58, 41);
            member_IDLabel.Name = "member_IDLabel";
            member_IDLabel.Size = new System.Drawing.Size(102, 20);
            member_IDLabel.TabIndex = 14;
            member_IDLabel.Text = "Member ID:";
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Location = new System.Drawing.Point(58, 75);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(82, 20);
            class_IDLabel.TabIndex = 16;
            class_IDLabel.Text = "Class ID:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(58, 109);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(83, 20);
            durationLabel.TabIndex = 18;
            durationLabel.Text = "Duration:";
            // 
            // btnviewlist
            // 
            this.btnviewlist.Location = new System.Drawing.Point(245, 195);
            this.btnviewlist.Name = "btnviewlist";
            this.btnviewlist.Size = new System.Drawing.Size(143, 64);
            this.btnviewlist.TabIndex = 11;
            this.btnviewlist.Text = "view Assigned Members";
            this.btnviewlist.UseVisualStyleBackColor = true;
            this.btnviewlist.Click += new System.EventHandler(this.btnviewlist_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(153, 195);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 64);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 62);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngobacktopreviouspage
            // 
            this.btngobacktopreviouspage.Location = new System.Drawing.Point(-6, 195);
            this.btngobacktopreviouspage.Name = "btngobacktopreviouspage";
            this.btngobacktopreviouspage.Size = new System.Drawing.Size(153, 64);
            this.btngobacktopreviouspage.TabIndex = 8;
            this.btngobacktopreviouspage.Text = "Go Back To Previous Page";
            this.btngobacktopreviouspage.UseVisualStyleBackColor = true;
            this.btngobacktopreviouspage.Click += new System.EventHandler(this.btngobacktopreviouspage_Click);
            // 
            // premierFitnessDataSet
            // 
            this.premierFitnessDataSet.DataSetName = "PremierFitnessDataSet";
            this.premierFitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignMembersBindingSource
            // 
            this.assignMembersBindingSource.DataMember = "AssignMembers";
            this.assignMembersBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // assignMembersTableAdapter
            // 
            this.assignMembersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignMembersTableAdapter = this.assignMembersTableAdapter;
            this.tableAdapterManager.AssignTutorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.GymMembersTableAdapter = null;
            this.tableAdapterManager.GymTutorsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignMembersBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(245, 106);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(169, 26);
            this.durationTextBox.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assignMembersBindingSource, "Member ID", true));
            this.comboBox1.DataSource = this.gymMembersBindingSource;
            this.comboBox1.DisplayMember = "Member ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Member ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assignMembersBindingSource, "Class ID", true));
            this.comboBox2.DataSource = this.classesBindingSource;
            this.comboBox2.DisplayMember = "Class ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 28);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "Class ID";
            // 
            // gymMembersBindingSource
            // 
            this.gymMembersBindingSource.DataMember = "GymMembers";
            this.gymMembersBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // gymMembersTableAdapter
            // 
            this.gymMembersTableAdapter.ClearBeforeFill = true;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // AssignMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 279);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(member_IDLabel);
            this.Controls.Add(class_IDLabel);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.btnviewlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btngobacktopreviouspage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AssignMembers";
            this.Text = "AssignMembers";
            this.Load += new System.EventHandler(this.AssignMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnviewlist;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btngobacktopreviouspage;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource assignMembersBindingSource;
        private PremierFitnessDataSetTableAdapters.AssignMembersTableAdapter assignMembersTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource gymMembersBindingSource;
        private PremierFitnessDataSetTableAdapters.GymMembersTableAdapter gymMembersTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private PremierFitnessDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
    }
}