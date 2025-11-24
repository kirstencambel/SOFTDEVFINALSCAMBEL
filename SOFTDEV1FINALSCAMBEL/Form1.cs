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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form form)
        {
            PanelContent.Controls.Clear();          // remove old content
            form.TopLevel = false;            // important!
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;       // fill the panel
            PanelContent.Controls.Add(form);
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCollege_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new College());
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Programm());
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new StudentInfo());
        }
    }
}
