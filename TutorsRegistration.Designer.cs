namespace New_Premier_FitnessGym_System
{
    partial class TutorsRegistration
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
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label phone_noLabel;
            System.Windows.Forms.Label specialityLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ageLabel;
            this.btnviewlist = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btngobacktopreviouspage = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.gymTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymTutorsTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.phone_noTextBox = new System.Windows.Forms.TextBox();
            this.specialityComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            phone_noLabel = new System.Windows.Forms.Label();
            specialityLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(41, 63);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(69, 20);
            fnameLabel.TabIndex = 10;
            fnameLabel.Text = "Fname:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(41, 95);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(68, 20);
            lnameLabel.TabIndex = 12;
            lnameLabel.Text = "Lname:";
            // 
            // phone_noLabel
            // 
            phone_noLabel.AutoSize = true;
            phone_noLabel.Location = new System.Drawing.Point(41, 127);
            phone_noLabel.Name = "phone_noLabel";
            phone_noLabel.Size = new System.Drawing.Size(90, 20);
            phone_noLabel.TabIndex = 14;
            phone_noLabel.Text = "Phone no:";
            // 
            // specialityLabel
            // 
            specialityLabel.AutoSize = true;
            specialityLabel.Location = new System.Drawing.Point(43, 172);
            specialityLabel.Name = "specialityLabel";
            specialityLabel.Size = new System.Drawing.Size(88, 20);
            specialityLabel.TabIndex = 15;
            specialityLabel.Text = "speciality:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(43, 214);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(74, 20);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(43, 263);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(46, 20);
            ageLabel.TabIndex = 17;
            ageLabel.Text = "Age:";
            // 
            // btnviewlist
            // 
            this.btnviewlist.Location = new System.Drawing.Point(233, 339);
            this.btnviewlist.Name = "btnviewlist";
            this.btnviewlist.Size = new System.Drawing.Size(132, 64);
            this.btnviewlist.TabIndex = 7;
            this.btnviewlist.Text = "view Tutors List";
            this.btnviewlist.UseVisualStyleBackColor = true;
            this.btnviewlist.Click += new System.EventHandler(this.btnviewlist_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(152, 337);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 64);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(371, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btngobacktopreviouspage
            // 
            this.btngobacktopreviouspage.Location = new System.Drawing.Point(4, 337);
            this.btngobacktopreviouspage.Name = "btngobacktopreviouspage";
            this.btngobacktopreviouspage.Size = new System.Drawing.Size(142, 64);
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
            // gymTutorsBindingSource
            // 
            this.gymTutorsBindingSource.DataMember = "GymTutors";
            this.gymTutorsBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // gymTutorsTableAdapter
            // 
            this.gymTutorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignMembersTableAdapter = null;
            this.tableAdapterManager.AssignTutorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.GymMembersTableAdapter = null;
            this.tableAdapterManager.GymTutorsTableAdapter = this.gymTutorsTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymTutorsBindingSource, "Fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(137, 60);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(237, 26);
            this.fnameTextBox.TabIndex = 11;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymTutorsBindingSource, "Lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(137, 92);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(237, 26);
            this.lnameTextBox.TabIndex = 13;
            // 
            // phone_noTextBox
            // 
            this.phone_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymTutorsBindingSource, "Phone_no", true));
            this.phone_noTextBox.Location = new System.Drawing.Point(137, 124);
            this.phone_noTextBox.Name = "phone_noTextBox";
            this.phone_noTextBox.Size = new System.Drawing.Size(237, 26);
            this.phone_noTextBox.TabIndex = 15;
            // 
            // specialityComboBox
            // 
            this.specialityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymTutorsBindingSource, "speciality", true));
            this.specialityComboBox.FormattingEnabled = true;
            this.specialityComboBox.Items.AddRange(new object[] {
            "Strength training ",
            "Balance Exercises",
            "Dynamic Movement and stretching",
            "YOGA"});
            this.specialityComboBox.Location = new System.Drawing.Point(137, 169);
            this.specialityComboBox.Name = "specialityComboBox";
            this.specialityComboBox.Size = new System.Drawing.Size(237, 28);
            this.specialityComboBox.TabIndex = 16;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymTutorsBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Undefined"});
            this.genderComboBox.Location = new System.Drawing.Point(137, 214);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 28);
            this.genderComboBox.TabIndex = 17;
            // 
            // ageComboBox
            // 
            this.ageComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymTutorsBindingSource, "Age", true));
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "18-25",
            "26-35",
            "36-50"});
            this.ageComboBox.Location = new System.Drawing.Point(137, 255);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(121, 28);
            this.ageComboBox.TabIndex = 18;
            // 
            // TutorsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 403);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(specialityLabel);
            this.Controls.Add(this.specialityComboBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(phone_noLabel);
            this.Controls.Add(this.phone_noTextBox);
            this.Controls.Add(this.btnviewlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btngobacktopreviouspage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TutorsRegistration";
            this.Text = "TutorsRegistration";
            this.Load += new System.EventHandler(this.TutorsRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnviewlist;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btngobacktopreviouspage;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource gymTutorsBindingSource;
        private PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter gymTutorsTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox phone_noTextBox;
        private System.Windows.Forms.ComboBox specialityComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox ageComboBox;
    }
}