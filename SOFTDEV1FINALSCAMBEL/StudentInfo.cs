using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTDEV1FINALSCAMBEL
{
    public partial class StudentInfo : Form
    {
        int studentID, programID, SaveFlag;
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softDev1DBDataSet3.tbl_Studentinfo' table. You can move, or remove it, as needed.
            this.tbl_StudentinfoTableAdapter.Fill(this.softDev1DBDataSet.tbl_StudentInfo);
            groupBox1.Location = new Point(12, 12);
            groupBox2.Location = new Point(12, 12);
            ResetAll();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            SaveFlag = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (SaveFlag)
            {
                case 0:
                    try
                    {
                        int.TryParse(txtProgramID.Text, out programID);
                        this.tbl_StudentinfoTableAdapter.InsertQuery(txtID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, dateBirthday.Value, txtSex.Text, programID, txtYearLevel.Text, 0);
                        MessageBox.Show("New record added.");
                        ResetAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    int.TryParse(txtProgramID.Text, out programID);
                    this.tbl_StudentinfoTableAdapter.UpdateQuery(txtID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, dateBirthday.Value, txtSex.Text, programID, txtYearLevel.Text, 0, studentID);
                    ResetAll();
                    break;
            }
        }
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            CheckUncheckAll(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record(s)?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    int i = 0;
                    int j = 0;
                    while (i < DGV.RowCount)
                    {
                        if (Convert.ToBoolean(DGV[0, i].Value) == true)
                        {
                            try
                            {
                                this.tbl_StudentinfoTableAdapter.DeleteQuery((int)DGV[2, i].Value);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            j++;
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    MessageBox.Show(j + " record(s) deleted.");
                    this.tbl_StudentinfoTableAdapter.Fill(this.softDev1DBDataSet.tbl_StudentInfo);
                    break;
                case DialogResult.No:
                    CheckUncheckAll(false);
                    break;
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            //Select Column<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (j == 0 && i >= 0)
            {
                if (Convert.ToBoolean(DGV[0, i].Value) == false)
                {
                    DGV[0, i].Value = true;
                }
                else
                {
                    DGV[0, i].Value = false;
                }
            }
            //Action Column<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (j == 12 && i >= 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                studentID = Convert.ToInt16(DGV[2, i].Value.ToString());
                txtFirstName.Text = DGV[3, i].Value.ToString();
                txtMiddleName.Text = DGV[4, i].Value.ToString();
                txtLastName.Text = DGV[5, i].Value.ToString();
                SaveFlag = 1;
            }
        }

        private void DGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            int i = 0;
            while (i < DGV.RowCount)
            {
                DGV.Rows[i].Cells[1].Value = i + 1;
                i++;
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckUncheckAll(true);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void ResetAll()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            this.tbl_StudentinfoTableAdapter.Fill(this.softDev1DBDataSet.tbl_StudentInfo);
        }

        public void CheckUncheckAll(bool x)
        {
            int i = 0;
            while (i < DGV.RowCount)
            {
                DGV.Rows[i].Cells[0].Value = x;
                i++;
            }
        }

        }
}
