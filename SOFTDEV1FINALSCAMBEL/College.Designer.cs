namespace SOFTDEV1FINALSCAMBEL
{
    partial class College
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblCollegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softDev1DBDataSet = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCollegeCode = new System.Windows.Forms.TextBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.tbl_CollegeTableAdapter = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSetTableAdapters.tbl_CollegeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCollegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUncheckAll);
            this.groupBox1.Controls.Add(this.btnCheckAll);
            this.groupBox1.Controls.Add(this.btnAddNewRecord);
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1179, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage College";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(869, 43);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(281, 62);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUncheckAll.Location = new System.Drawing.Point(590, 43);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(271, 62);
            this.btnUncheckAll.TabIndex = 7;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = false;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckAll.Location = new System.Drawing.Point(314, 43);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(268, 62);
            this.btnCheckAll.TabIndex = 6;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddNewRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewRecord.Location = new System.Drawing.Point(16, 43);
            this.btnAddNewRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(290, 62);
            this.btnAddNewRecord.TabIndex = 5;
            this.btnAddNewRecord.Text = "Add New Record";
            this.btnAddNewRecord.UseVisualStyleBackColor = false;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.RowNumber,
            this.collegeIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.Action});
            this.DGV.DataSource = this.tblCollegeBindingSource;
            this.DGV.GridColor = System.Drawing.Color.Gainsboro;
            this.DGV.Location = new System.Drawing.Point(16, 115);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.Size = new System.Drawing.Size(1134, 181);
            this.DGV.TabIndex = 1;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_RowPostPaint);
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
            this.RowNumber.DataPropertyName = "programID";
            this.RowNumber.HeaderText = "Row No.";
            this.RowNumber.MinimumWidth = 8;
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RowNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RowNumber.Width = 150;
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "collegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "collegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            this.collegeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.collegeIDDataGridViewTextBoxColumn.Visible = false;
            this.collegeIDDataGridViewTextBoxColumn.Width = 150;
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
            this.Action.DataPropertyName = "programID";
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 150;
            // 
            // tblCollegeBindingSource
            // 
            this.tblCollegeBindingSource.DataMember = "tbl_College";
            this.tblCollegeBindingSource.DataSource = this.softDev1DBDataSet;
            // 
            // softDev1DBDataSet
            // 
            this.softDev1DBDataSet.DataSetName = "SoftDev1DBDataSet";
            this.softDev1DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtCollegeCode);
            this.groupBox2.Controls.Add(this.txtCollegeName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 340);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1245, 989);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New College";
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
            this.btnCancel.Location = new System.Drawing.Point(578, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(406, 201);
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
            this.btnSave.Location = new System.Drawing.Point(250, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 49);
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
            // tbl_CollegeTableAdapter
            // 
            this.tbl_CollegeTableAdapter.ClearBeforeFill = true;
            // 
            // College
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1459, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "College";
            this.Text = "College";
            this.Load += new System.EventHandler(this.College_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCollegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.DataGridView DGV;
        private SoftDev1DBDataSet softDev1DBDataSet;
        private System.Windows.Forms.BindingSource tblCollegeBindingSource;
        private SoftDev1DBDataSetTableAdapters.tbl_CollegeTableAdapter tbl_CollegeTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCollegeCode;
        private System.Windows.Forms.TextBox txtCollegeName;
    }
}