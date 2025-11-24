namespace SOFTDEV1FINALSCAMBEL
{
    partial class Programm
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
            this.tblProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softDev1DBDataSet = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSet();
            this.tbl_ProgramTableAdapter = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSetTableAdapters.tbl_ProgramTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblProgramBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.softDev1DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.tblProgramBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.softDev1DBDataSet1 = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSet();
            this.tblProgramBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCollegeCode = new System.Windows.Forms.TextBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProgramBindingSource
            // 
            this.tblProgramBindingSource.DataMember = "tbl_Program";
            this.tblProgramBindingSource.DataSource = this.softDev1DBDataSet;
            // 
            // softDev1DBDataSet
            // 
            this.softDev1DBDataSet.DataSetName = "SoftDev1DBDataSet";
            this.softDev1DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProgramTableAdapter
            // 
            this.tbl_ProgramTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUncheckAll);
            this.groupBox1.Controls.Add(this.btnCheckAll);
            this.groupBox1.Controls.Add(this.btnAddNewRecord);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1252, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage College";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.RowNumber,
            this.programIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.collegeIDDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.Action});
            this.DGV.DataSource = this.tblProgramBindingSource3;
            this.DGV.Location = new System.Drawing.Point(16, 128);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(1211, 255);
            this.DGV.TabIndex = 9;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_RowPostPoint);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 150;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "RowNo.";
            this.RowNumber.MinimumWidth = 8;
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 150;
            // 
            // programIDDataGridViewTextBoxColumn
            // 
            this.programIDDataGridViewTextBoxColumn.DataPropertyName = "programID";
            this.programIDDataGridViewTextBoxColumn.HeaderText = "programID";
            this.programIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.programIDDataGridViewTextBoxColumn.Name = "programIDDataGridViewTextBoxColumn";
            this.programIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.programIDDataGridViewTextBoxColumn.Visible = false;
            this.programIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "College Name";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "College Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 250;
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "collegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            this.collegeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.collegeIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // deletedDataGridViewTextBoxColumn
            // 
            this.deletedDataGridViewTextBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
            this.deletedDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedDataGridViewTextBoxColumn.Visible = false;
            this.deletedDataGridViewTextBoxColumn.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 150;
            // 
            // tblProgramBindingSource3
            // 
            this.tblProgramBindingSource3.DataMember = "tbl_Program";
            this.tblProgramBindingSource3.DataSource = this.softDev1DBDataSetBindingSource;
            // 
            // softDev1DBDataSetBindingSource
            // 
            this.softDev1DBDataSetBindingSource.DataSource = this.softDev1DBDataSet;
            this.softDev1DBDataSetBindingSource.Position = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(947, 60);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 60);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUncheckAll.Location = new System.Drawing.Point(641, 62);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(298, 56);
            this.btnUncheckAll.TabIndex = 7;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = false;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckAll.Location = new System.Drawing.Point(338, 60);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(295, 60);
            this.btnCheckAll.TabIndex = 6;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewRecord.Location = new System.Drawing.Point(16, 60);
            this.btnAddNewRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(314, 60);
            this.btnAddNewRecord.TabIndex = 5;
            this.btnAddNewRecord.Text = "Add New Record";
            this.btnAddNewRecord.UseVisualStyleBackColor = false;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click_1);
            // 
            // tblProgramBindingSource2
            // 
            this.tblProgramBindingSource2.DataMember = "tbl_Program";
            this.tblProgramBindingSource2.DataSource = this.softDev1DBDataSet1;
            // 
            // softDev1DBDataSet1
            // 
            this.softDev1DBDataSet1.DataSetName = "SoftDev1DBDataSet";
            this.softDev1DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProgramBindingSource1
            // 
            this.tblProgramBindingSource1.DataMember = "tbl_Program";
            this.tblProgramBindingSource1.DataSource = this.softDev1DBDataSetBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCollegeID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtCollegeCode);
            this.groupBox2.Controls.Add(this.txtCollegeName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 422);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1245, 612);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New College";
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(250, 197);
            this.txtCollegeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(512, 40);
            this.txtCollegeID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "College ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "College Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "College Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 263);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 51);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 263);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 263);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCollegeCode
            // 
            this.txtCollegeCode.Location = new System.Drawing.Point(250, 138);
            this.txtCollegeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCollegeCode.Name = "txtCollegeCode";
            this.txtCollegeCode.Size = new System.Drawing.Size(512, 40);
            this.txtCollegeCode.TabIndex = 1;
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(250, 85);
            this.txtCollegeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(512, 40);
            this.txtCollegeName.TabIndex = 0;
            // 
            // Programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1594, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Programm";
            this.Text = "Programm";
            this.Load += new System.EventHandler(this.Programm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProgramBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SoftDev1DBDataSet softDev1DBDataSet;
        private System.Windows.Forms.BindingSource tblProgramBindingSource;
        private SoftDev1DBDataSetTableAdapters.tbl_ProgramTableAdapter tbl_ProgramTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.BindingSource tblProgramBindingSource1;
        private System.Windows.Forms.BindingSource softDev1DBDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCollegeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCollegeCode;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.DataGridView DGV;
        private SoftDev1DBDataSet softDev1DBDataSet1;
        private System.Windows.Forms.BindingSource tblProgramBindingSource2;
        private System.Windows.Forms.BindingSource tblProgramBindingSource3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn programIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}