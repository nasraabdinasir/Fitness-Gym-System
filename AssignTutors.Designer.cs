namespace New_Premier_FitnessGym_System
{
    partial class AssignTutors
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
            System.Windows.Forms.Label tutor_IDLabel;
            System.Windows.Forms.Label class_IDLabel;
            System.Windows.Forms.Label durationLabel;
            this.btnviewlist = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btngobacktopreviouspage = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.assignTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignTutorsTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.AssignTutorsTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.classesTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.ClassesTableAdapter();
            this.gymTutorsTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter();
            this.tutor_IDComboBox = new System.Windows.Forms.ComboBox();
            this.gymTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_IDComboBox = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durationTextBox = new System.Windows.Forms.TextBox();
            tutor_IDLabel = new System.Windows.Forms.Label();
            class_IDLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTutorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tutor_IDLabel
            // 
            tutor_IDLabel.AutoSize = true;
            tutor_IDLabel.Location = new System.Drawing.Point(30, 63);
            tutor_IDLabel.Name = "tutor_IDLabel";
            tutor_IDLabel.Size = new System.Drawing.Size(80, 20);
            tutor_IDLabel.TabIndex = 14;
            tutor_IDLabel.Text = "Tutor ID:";
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Location = new System.Drawing.Point(30, 97);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(82, 20);
            class_IDLabel.TabIndex = 16;
            class_IDLabel.Text = "Class ID:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(30, 131);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(83, 20);
            durationLabel.TabIndex = 18;
            durationLabel.Text = "Duration:";
            // 
            // btnviewlist
            // 
            this.btnviewlist.Location = new System.Drawing.Point(259, 160);
            this.btnviewlist.Name = "btnviewlist";
            this.btnviewlist.Size = new System.Drawing.Size(143, 64);
            this.btnviewlist.TabIndex = 11;
            this.btnviewlist.Text = "view Assigned Tutors";
            this.btnviewlist.UseVisualStyleBackColor = true;
            this.btnviewlist.Click += new System.EventHandler(this.btnviewlist_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(167, 160);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 64);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 62);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngobacktopreviouspage
            // 
            this.btngobacktopreviouspage.Location = new System.Drawing.Point(8, 160);
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
            // assignTutorsBindingSource
            // 
            this.assignTutorsBindingSource.DataMember = "AssignTutors";
            this.assignTutorsBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // assignTutorsTableAdapter
            // 
            this.assignTutorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignMembersTableAdapter = null;
            this.tableAdapterManager.AssignTutorsTableAdapter = this.assignTutorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.GymMembersTableAdapter = null;
            this.tableAdapterManager.GymTutorsTableAdapter = this.gymTutorsTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // gymTutorsTableAdapter
            // 
            this.gymTutorsTableAdapter.ClearBeforeFill = true;
            // 
            // tutor_IDComboBox
            // 
            this.tutor_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignTutorsBindingSource, "Tutor ID", true));
            this.tutor_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assignTutorsBindingSource, "Tutor ID", true));
            this.tutor_IDComboBox.DataSource = this.gymTutorsBindingSource;
            this.tutor_IDComboBox.DisplayMember = "Tutor ID";
            this.tutor_IDComboBox.FormattingEnabled = true;
            this.tutor_IDComboBox.Location = new System.Drawing.Point(195, 60);
            this.tutor_IDComboBox.Name = "tutor_IDComboBox";
            this.tutor_IDComboBox.Size = new System.Drawing.Size(177, 28);
            this.tutor_IDComboBox.TabIndex = 15;
            this.tutor_IDComboBox.ValueMember = "Tutor ID";
            // 
            // gymTutorsBindingSource
            // 
            this.gymTutorsBindingSource.DataMember = "GymTutors";
            this.gymTutorsBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // class_IDComboBox
            // 
            this.class_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignTutorsBindingSource, "Class ID", true));
            this.class_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assignTutorsBindingSource, "Class ID", true));
            this.class_IDComboBox.DataSource = this.classesBindingSource;
            this.class_IDComboBox.DisplayMember = "Class ID";
            this.class_IDComboBox.FormattingEnabled = true;
            this.class_IDComboBox.Location = new System.Drawing.Point(195, 94);
            this.class_IDComboBox.Name = "class_IDComboBox";
            this.class_IDComboBox.Size = new System.Drawing.Size(177, 28);
            this.class_IDComboBox.TabIndex = 17;
            this.class_IDComboBox.ValueMember = "Class ID";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignTutorsBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(195, 128);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(102, 26);
            this.durationTextBox.TabIndex = 19;
            // 
            // AssignTutors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 230);
            this.Controls.Add(tutor_IDLabel);
            this.Controls.Add(this.tutor_IDComboBox);
            this.Controls.Add(class_IDLabel);
            this.Controls.Add(this.class_IDComboBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.btnviewlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btngobacktopreviouspage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AssignTutors";
            this.Text = "AssignTutors";
            this.Load += new System.EventHandler(this.AssignTutors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTutorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource assignTutorsBindingSource;
        private PremierFitnessDataSetTableAdapters.AssignTutorsTableAdapter assignTutorsTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter gymTutorsTableAdapter;
        private System.Windows.Forms.ComboBox tutor_IDComboBox;
        private System.Windows.Forms.ComboBox class_IDComboBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.BindingSource gymTutorsBindingSource;
        private PremierFitnessDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
    }
}