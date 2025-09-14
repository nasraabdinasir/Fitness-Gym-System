namespace New_Premier_FitnessGym_System
{
    partial class Classes
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
            System.Windows.Forms.Label class_NameLabel;
            this.btnviewlist = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btngobacktopreviouspage = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.ClassesTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.class_NameComboBox = new System.Windows.Forms.ComboBox();
            class_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnviewlist
            // 
            this.btnviewlist.Location = new System.Drawing.Point(250, 188);
            this.btnviewlist.Name = "btnviewlist";
            this.btnviewlist.Size = new System.Drawing.Size(143, 64);
            this.btnviewlist.TabIndex = 7;
            this.btnviewlist.Text = "view Class List";
            this.btnviewlist.UseVisualStyleBackColor = true;
            this.btnviewlist.Click += new System.EventHandler(this.btnviewlist_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(158, 188);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 64);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngobacktopreviouspage
            // 
            this.btngobacktopreviouspage.Location = new System.Drawing.Point(-1, 188);
            this.btngobacktopreviouspage.Name = "btngobacktopreviouspage";
            this.btngobacktopreviouspage.Size = new System.Drawing.Size(153, 64);
            this.btngobacktopreviouspage.TabIndex = 4;
            this.btngobacktopreviouspage.Text = "Go Back To Previous Page";
            this.btngobacktopreviouspage.UseVisualStyleBackColor = true;
            this.btngobacktopreviouspage.Click += new System.EventHandler(this.btngobacktopreviouspage_Click);
            // 
            // premierFitnessDataSet
            // 
            this.premierFitnessDataSet.DataSetName = "PremierFitnessDataSet";
            this.premierFitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignMembersTableAdapter = null;
            this.tableAdapterManager.AssignTutorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.GymMembersTableAdapter = null;
            this.tableAdapterManager.GymTutorsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // class_NameLabel
            // 
            class_NameLabel.AutoSize = true;
            class_NameLabel.Location = new System.Drawing.Point(12, 87);
            class_NameLabel.Name = "class_NameLabel";
            class_NameLabel.Size = new System.Drawing.Size(109, 20);
            class_NameLabel.TabIndex = 8;
            class_NameLabel.Text = "Class Name:";
            // 
            // class_NameComboBox
            // 
            this.class_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Class Name", true));
            this.class_NameComboBox.FormattingEnabled = true;
            this.class_NameComboBox.Items.AddRange(new object[] {
            "Strength Training ",
            "Balance Exercises",
            "Dynamic Movement and stretching",
            "YOGA"});
            this.class_NameComboBox.Location = new System.Drawing.Point(146, 84);
            this.class_NameComboBox.Name = "class_NameComboBox";
            this.class_NameComboBox.Size = new System.Drawing.Size(313, 28);
            this.class_NameComboBox.TabIndex = 9;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 272);
            this.Controls.Add(class_NameLabel);
            this.Controls.Add(this.class_NameComboBox);
            this.Controls.Add(this.btnviewlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btngobacktopreviouspage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource classesBindingSource;
        private PremierFitnessDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox class_NameComboBox;
    }
}