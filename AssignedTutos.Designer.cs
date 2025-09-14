namespace New_Premier_FitnessGym_System
{
    partial class AssignedTutos
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
            this.button1 = new System.Windows.Forms.Button();
            this.premierFitnessDataSet = new New_Premier_FitnessGym_System.PremierFitnessDataSet();
            this.assignTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignTutorsTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.AssignTutorsTableAdapter();
            this.tableAdapterManager = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.TableAdapterManager();
            this.assignTutorsDataGridView = new System.Windows.Forms.DataGridView();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.ClassesTableAdapter();
            this.gymTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymTutorsTableAdapter = new New_Premier_FitnessGym_System.PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTutorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTutorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete Row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // assignTutorsDataGridView
            // 
            this.assignTutorsDataGridView.AutoGenerateColumns = false;
            this.assignTutorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignTutorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.assignTutorsDataGridView.DataSource = this.assignTutorsBindingSource;
            this.assignTutorsDataGridView.Location = new System.Drawing.Point(5, 3);
            this.assignTutorsDataGridView.Name = "assignTutorsDataGridView";
            this.assignTutorsDataGridView.Size = new System.Drawing.Size(442, 246);
            this.assignTutorsDataGridView.TabIndex = 2;
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
            // gymTutorsBindingSource
            // 
            this.gymTutorsBindingSource.DataMember = "GymTutors";
            this.gymTutorsBindingSource.DataSource = this.premierFitnessDataSet;
            // 
            // gymTutorsTableAdapter
            // 
            this.gymTutorsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AssignedTutor ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AssignedTutor ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tutor ID";
            this.dataGridViewTextBoxColumn2.DataSource = this.gymTutorsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Fname";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tutor ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class ID";
            this.dataGridViewTextBoxColumn3.DataSource = this.classesBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Class Name";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Class ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // AssignedTutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 326);
            this.Controls.Add(this.assignTutorsDataGridView);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AssignedTutos";
            this.Text = "AssignedTutos";
            this.Load += new System.EventHandler(this.AssignedTutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierFitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTutorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTutorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTutorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private PremierFitnessDataSet premierFitnessDataSet;
        private System.Windows.Forms.BindingSource assignTutorsBindingSource;
        private PremierFitnessDataSetTableAdapters.AssignTutorsTableAdapter assignTutorsTableAdapter;
        private PremierFitnessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView assignTutorsDataGridView;
        private PremierFitnessDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private PremierFitnessDataSetTableAdapters.GymTutorsTableAdapter gymTutorsTableAdapter;
        private System.Windows.Forms.BindingSource gymTutorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}