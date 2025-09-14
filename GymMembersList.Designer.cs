namespace New_Premier_FitnessGym_System
{
    partial class GymMembersList
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
            this.btndeleterecord = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.gymMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymMembersTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymMembersTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.gymMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeleterecord
            // 
            this.btndeleterecord.Location = new System.Drawing.Point(78, 290);
            this.btndeleterecord.Name = "btndeleterecord";
            this.btndeleterecord.Size = new System.Drawing.Size(204, 37);
            this.btndeleterecord.TabIndex = 0;
            this.btndeleterecord.Text = "Delete Record";
            this.btndeleterecord.UseVisualStyleBackColor = true;
            this.btndeleterecord.Click += new System.EventHandler(this.btndeleterecord_Click);
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
            // gymMembersDataGridView
            // 
            this.gymMembersDataGridView.AutoGenerateColumns = false;
            this.gymMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gymMembersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gymMembersDataGridView.DataSource = this.gymMembersBindingSource;
            this.gymMembersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.gymMembersDataGridView.Name = "gymMembersDataGridView";
            this.gymMembersDataGridView.Size = new System.Drawing.Size(995, 248);
            this.gymMembersDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Member ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Member ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Payment Details";
            this.dataGridViewTextBoxColumn6.HeaderText = "Payment Details";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // GymMembersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 339);
            this.Controls.Add(this.gymMembersDataGridView);
            this.Controls.Add(this.btndeleterecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GymMembersList";
            this.Text = "GymMembersList";
            this.Load += new System.EventHandler(this.GymMembersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeleterecord;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource gymMembersBindingSource;
        private PremierFitnessDataSetTableAdapters.GymMembersTableAdapter gymMembersTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gymMembersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}