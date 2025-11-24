namespace SOFTDEV1FINALSCAMBEL
{
    partial class StudentInfo
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softDev1DBDataSet = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtYearLevel = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtProgramID = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_StudentinfoTableAdapter = new SOFTDEV1FINALSCAMBEL.SoftDev1DBDataSetTableAdapters.tbl_StudentInfoTableAdapter();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDev1DBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUncheckAll);
            this.groupBox1.Controls.Add(this.btnCheckAll);
            this.groupBox1.Controls.Add(this.btnAddNewRecord);
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1502, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage College Student Info";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(974, 46);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 56);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.BackColor = System.Drawing.Color.Pink;
            this.btnUncheckAll.Location = new System.Drawing.Point(664, 46);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(302, 56);
            this.btnUncheckAll.TabIndex = 11;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = false;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckAll.Location = new System.Drawing.Point(365, 44);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(291, 58);
            this.btnCheckAll.TabIndex = 10;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.BackColor = System.Drawing.Color.Pink;
            this.btnAddNewRecord.Location = new System.Drawing.Point(39, 42);
            this.btnAddNewRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(318, 60);
            this.btnAddNewRecord.TabIndex = 9;
            this.btnAddNewRecord.Text = "Add New Record";
            this.btnAddNewRecord.UseVisualStyleBackColor = false;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.RowNumber,
            this.iDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.bdayDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.Action});
            this.DGV.DataSource = this.tblStudentInfoBindingSource;
            this.DGV.Location = new System.Drawing.Point(8, 108);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.Size = new System.Drawing.Size(1445, 167);
            this.DGV.TabIndex = 0;
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
            this.RowNumber.HeaderText = "Row No.";
            this.RowNumber.MinimumWidth = 8;
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "Bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "Bday";
            this.bdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            this.bdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.bdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 150;
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tbl_StudentInfo";
            this.tblStudentInfoBindingSource.DataSource = this.softDev1DBDataSet;
            // 
            // softDev1DBDataSet
            // 
            this.softDev1DBDataSet.DataSetName = "SoftDev1DBDataSet";
            this.softDev1DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateBirthday);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtYearLevel);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtMiddleName);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtProgramID);
            this.groupBox2.Controls.Add(this.txtSex);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 347);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1661, 485);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Student Info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(874, 422);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 51);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(702, 422);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 49);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 422);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 49);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtYearLevel
            // 
            this.txtYearLevel.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtYearLevel.Location = new System.Drawing.Point(786, 319);
            this.txtYearLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYearLevel.Name = "txtYearLevel";
            this.txtYearLevel.Size = new System.Drawing.Size(445, 35);
            this.txtYearLevel.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtID.Location = new System.Drawing.Point(260, 62);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(364, 35);
            this.txtID.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFirstName.Location = new System.Drawing.Point(260, 109);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(762, 35);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMiddleName.Location = new System.Drawing.Point(260, 154);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(762, 35);
            this.txtMiddleName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtLastName.Location = new System.Drawing.Point(260, 206);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(762, 35);
            this.txtLastName.TabIndex = 11;
            // 
            // txtProgramID
            // 
            this.txtProgramID.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtProgramID.Location = new System.Drawing.Point(260, 263);
            this.txtProgramID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProgramID.Name = "txtProgramID";
            this.txtProgramID.Size = new System.Drawing.Size(364, 35);
            this.txtProgramID.TabIndex = 9;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSex.Location = new System.Drawing.Point(260, 322);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(364, 35);
            this.txtSex.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 325);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Year Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birthday";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "ProgramID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID";
            // 
            // tbl_StudentinfoTableAdapter
            // 
            this.tbl_StudentinfoTableAdapter.ClearBeforeFill = true;
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(786, 267);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(445, 35);
            this.dateBirthday.TabIndex = 19;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1652, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtYearLevel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtProgramID;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SoftDev1DBDataSetTableAdapters.tbl_StudentInfoTableAdapter tbl_StudentinfoTableAdapter;
        private SoftDev1DBDataSet softDev1DBDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private System.Windows.Forms.DateTimePicker dateBirthday;
    }
}