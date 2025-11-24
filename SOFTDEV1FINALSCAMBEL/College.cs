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
    public partial class College : Form
    {
        int collegeID, SaveFlag, programID;
        public College()
        {
            InitializeComponent();
        }

        private void College_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(12, 12);
            groupBox2.Location = new Point(12, 12);
            ResetAll();
            this.tbl_CollegeTableAdapter.Fill(this.softDev1DBDataSet.tbl_College);

        }


        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCollegeName.Text = string.Empty;
            txtCollegeCode.Text = string.Empty;
    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (SaveFlag)
            {
                case 0:
                    try
                    {
                        this.tbl_CollegeTableAdapter.InsertQuery(txtCollegeName.Text, txtCollegeCode.Text, 0);
                        MessageBox.Show("New record added");
                        ResetAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;
                case 1:

                    this.tbl_CollegeTableAdapter.UpdateQuery(txtCollegeName.Text, txtCollegeCode.Text, 0, collegeID);
                    MessageBox.Show("Record Update");
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

      

        public void ResetAll()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            txtCollegeName.Text = string.Empty;
            txtCollegeCode.Text = string.Empty;
            this.tbl_CollegeTableAdapter.Fill(this.softDev1DBDataSet.tbl_College);
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

       

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;

            //Select Column
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

            //Action Column
            if (j == 7 && i >= 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;

                programID = Convert.ToInt16(DGV[2, i].Value.ToString());
                txtCollegeName.Text = DGV[3, i].Value.ToString();
                txtCollegeCode.Text = DGV[4, i].Value.ToString();
                SaveFlag = 1;
            }
        }

      
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckUncheckAll(true);
        }

       

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            CheckUncheckAll(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Record/s Delete", "Warning", MessageBoxButtons.YesNo);
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
                                this.tbl_CollegeTableAdapter.DeleteQuery((int)DGV[2, i].Value);

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
                    MessageBox.Show(j + " record/s deleted");
                    this.tbl_CollegeTableAdapter.Fill(this.softDev1DBDataSet.tbl_College);
                    break;
                case DialogResult.No:
                    //DO NOTHING
                    break;
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


    }
}
