namespace New_Premier_FitnessGym_System
{
    partial class StaffRegistration
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phone_noLabel;
            System.Windows.Forms.Label passwordLabel;
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnViewRegisteredStaff = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phone_noTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            usernameLabel = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phone_noLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(12, 282);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 58);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(155, 282);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(105, 58);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnViewRegisteredStaff
            // 
            this.btnViewRegisteredStaff.Location = new System.Drawing.Point(288, 282);
            this.btnViewRegisteredStaff.Name = "btnViewRegisteredStaff";
            this.btnViewRegisteredStaff.Size = new System.Drawing.Size(183, 58);
            this.btnViewRegisteredStaff.TabIndex = 2;
            this.btnViewRegisteredStaff.Text = "View Registered Staff";
            this.btnViewRegisteredStaff.UseVisualStyleBackColor = true;
            this.btnViewRegisteredStaff.Click += new System.EventHandler(this.btnViewRegisteredStaff_Click);
            // 
            // premierFitnessDataSet
            // 
            this.premierFitnessDataSet.DataSetName = "PremierFitnessDataSet";
            this.premierFitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignMembersTableAdapter = null;
            this.tableAdapterManager.AssignTutorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.GymMembersTableAdapter = null;
            this.tableAdapterManager.GymTutorsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(69, 54);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(96, 20);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(204, 51);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(205, 26);
            this.usernameTextBox.TabIndex = 7;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(69, 86);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(69, 20);
            fnameLabel.TabIndex = 8;
            fnameLabel.Text = "Fname:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(204, 83);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(205, 26);
            this.fnameTextBox.TabIndex = 9;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(69, 118);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(68, 20);
            lnameLabel.TabIndex = 10;
            lnameLabel.Text = "Lname:";
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(204, 115);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(205, 26);
            this.lnameTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(69, 150);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(58, 20);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(204, 147);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 26);
            this.emailTextBox.TabIndex = 13;
            // 
            // phone_noLabel
            // 
            phone_noLabel.AutoSize = true;
            phone_noLabel.Location = new System.Drawing.Point(69, 182);
            phone_noLabel.Name = "phone_noLabel";
            phone_noLabel.Size = new System.Drawing.Size(90, 20);
            phone_noLabel.TabIndex = 14;
            phone_noLabel.Text = "Phone no:";
            // 
            // phone_noTextBox
            // 
            this.phone_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Phone_no", true));
            this.phone_noTextBox.Location = new System.Drawing.Point(204, 179);
            this.phone_noTextBox.Name = "phone_noTextBox";
            this.phone_noTextBox.Size = new System.Drawing.Size(205, 26);
            this.phone_noTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(69, 214);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(91, 20);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(204, 211);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(205, 26);
            this.passwordTextBox.TabIndex = 17;
            // 
            // StaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 352);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phone_noLabel);
            this.Controls.Add(this.phone_noTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.btnViewRegisteredStaff);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "StaffRegistration";
            this.Text = "StaffRegistration";
            this.Load += new System.EventHandler(this.StaffRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnViewRegisteredStaff;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private PremierFitnessDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phone_noTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}