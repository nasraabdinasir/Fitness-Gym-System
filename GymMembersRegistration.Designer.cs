namespace New_Premier_FitnessGym_System
{
    partial class GymMembersRegistration
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
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label payment_DetailsLabel;
            System.Windows.Forms.Label genderLabel;
            this.btngobacktopreviouspage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnviewlist = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.gymMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymMembersTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymMembersTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.payment_DetailsComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            payment_DetailsLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(91, 44);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(69, 20);
            fnameLabel.TabIndex = 7;
            fnameLabel.Text = "Fname:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(91, 76);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(68, 20);
            lnameLabel.TabIndex = 9;
            lnameLabel.Text = "Lname:";
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Location = new System.Drawing.Point(91, 108);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(129, 20);
            email_AddressLabel.TabIndex = 11;
            email_AddressLabel.Text = "Email Address:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(91, 140);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 20);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // payment_DetailsLabel
            // 
            payment_DetailsLabel.AutoSize = true;
            payment_DetailsLabel.Location = new System.Drawing.Point(91, 179);
            payment_DetailsLabel.Name = "payment_DetailsLabel";
            payment_DetailsLabel.Size = new System.Drawing.Size(144, 20);
            payment_DetailsLabel.TabIndex = 14;
            payment_DetailsLabel.Text = "Payment Details:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(91, 232);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(74, 20);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "Gender:";
            // 
            // btngobacktopreviouspage
            // 
            this.btngobacktopreviouspage.Location = new System.Drawing.Point(14, 344);
            this.btngobacktopreviouspage.Name = "btngobacktopreviouspage";
            this.btngobacktopreviouspage.Size = new System.Drawing.Size(142, 64);
            this.btngobacktopreviouspage.TabIndex = 0;
            this.btngobacktopreviouspage.Text = "Go Back To Previous Page";
            this.btngobacktopreviouspage.UseVisualStyleBackColor = true;
            this.btngobacktopreviouspage.Click += new System.EventHandler(this.btngobacktopreviouspage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 62);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(194, 344);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 64);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnviewlist
            // 
            this.btnviewlist.Location = new System.Drawing.Point(297, 344);
            this.btnviewlist.Name = "btnviewlist";
            this.btnviewlist.Size = new System.Drawing.Size(132, 64);
            this.btnviewlist.TabIndex = 3;
            this.btnviewlist.Text = "view Members List";
            this.btnviewlist.UseVisualStyleBackColor = true;
            this.btnviewlist.Click += new System.EventHandler(this.btnviewlist_Click);
            // 
            // premierFitnessDataSet
            // 
            this.premierFitnessDataSet.DataSetName = "PremierFitnessDataSet";
            this.premierFitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignMembersTableAdapter = null;
            this.tableAdapterManager.AssignTutorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.GymMembersTableAdapter = this.gymMembersTableAdapter;
            this.tableAdapterManager.GymTutorsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymMembersBindingSource, "Fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(241, 41);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(218, 26);
            this.fnameTextBox.TabIndex = 8;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymMembersBindingSource, "Lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(241, 73);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(218, 26);
            this.lnameTextBox.TabIndex = 10;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymMembersBindingSource, "Email Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(241, 105);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(218, 26);
            this.email_AddressTextBox.TabIndex = 12;
            this.email_AddressTextBox.TextChanged += new System.EventHandler(this.email_AddressTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymMembersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(241, 137);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(218, 26);
            this.phoneTextBox.TabIndex = 14;
            // 
            // payment_DetailsComboBox
            // 
            this.payment_DetailsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymMembersBindingSource, "Payment Details", true));
            this.payment_DetailsComboBox.FormattingEnabled = true;
            this.payment_DetailsComboBox.Items.AddRange(new object[] {
            "Student membership= Ksh 6,000",
            ": Corporate Individual= Ksh 45,000"});
            this.payment_DetailsComboBox.Location = new System.Drawing.Point(241, 176);
            this.payment_DetailsComboBox.Name = "payment_DetailsComboBox";
            this.payment_DetailsComboBox.Size = new System.Drawing.Size(374, 28);
            this.payment_DetailsComboBox.TabIndex = 15;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gymMembersBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Undefined"});
            this.genderComboBox.Location = new System.Drawing.Point(241, 229);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(147, 28);
            this.genderComboBox.TabIndex = 16;
            // 
            // GymMembersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 420);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(payment_DetailsLabel);
            this.Controls.Add(this.payment_DetailsComboBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(email_AddressLabel);
            this.Controls.Add(this.email_AddressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.btnviewlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btngobacktopreviouspage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GymMembersRegistration";
            this.Text = "Gym Members Registration";
            this.Load += new System.EventHandler(this.GymMembersRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngobacktopreviouspage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnviewlist;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource gymMembersBindingSource;
        private PremierFitnessDataSetTableAdapters.GymMembersTableAdapter gymMembersTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox payment_DetailsComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
    }
}