namespace New_Premier_FitnessGym_System
{
    partial class TutorList
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
            this.gymTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymTutorsTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.gymTutorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeleterecord
            // 
            this.btndeleterecord.Location = new System.Drawing.Point(25, 239);
            this.btndeleterecord.Name = "btndeleterecord";
            this.btndeleterecord.Size = new System.Drawing.Size(204, 37);
            this.btndeleterecord.TabIndex = 1;
            this.btndeleterecord.Text = "Delete Record";
            this.btndeleterecord.UseVisualStyleBackColor = true;
            this.btndeleterecord.Click += new System.EventHandler(this.btndeleterecord_Click);
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
            // gymTutorsDataGridView
            // 
            this.gymTutorsDataGridView.AutoGenerateColumns = false;
            this.gymTutorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gymTutorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gymTutorsDataGridView.DataSource = this.gymTutorsBindingSource;
            this.gymTutorsDataGridView.Location = new System.Drawing.Point(1, 1);
            this.gymTutorsDataGridView.Name = "gymTutorsDataGridView";
            this.gymTutorsDataGridView.Size = new System.Drawing.Size(941, 219);
            this.gymTutorsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tutor ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tutor ID";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone_no";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone_no";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "speciality";
            this.dataGridViewTextBoxColumn5.HeaderText = "speciality";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn7.HeaderText = "Age";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // TutorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 276);
            this.Controls.Add(this.gymTutorsDataGridView);
            this.Controls.Add(this.btndeleterecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TutorList";
            this.Text = "TutorList";
            this.Load += new System.EventHandler(this.TutorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeleterecord;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource gymTutorsBindingSource;
        private PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter gymTutorsTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gymTutorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}