namespace SOFTDEV1FINALSCAMBEL
{
    partial class Form1
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
            this.PanelContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCollege = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContent
            // 
            this.PanelContent.Location = new System.Drawing.Point(176, 12);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1442, 697);
            this.PanelContent.TabIndex = 0;
            this.PanelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.btnCollege);
            this.panel2.Controls.Add(this.btnStudentInfo);
            this.panel2.Controls.Add(this.btnProgram);
            this.panel2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 697);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCollege
            // 
            this.btnCollege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCollege.Location = new System.Drawing.Point(3, 79);
            this.btnCollege.Name = "btnCollege";
            this.btnCollege.Size = new System.Drawing.Size(152, 75);
            this.btnCollege.TabIndex = 2;
            this.btnCollege.Text = "College";
            this.btnCollege.UseVisualStyleBackColor = true;
            this.btnCollege.Click += new System.EventHandler(this.btnCollege_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStudentInfo.Location = new System.Drawing.Point(3, 423);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(155, 74);
            this.btnStudentInfo.TabIndex = 4;
            this.btnStudentInfo.Text = "Student Info";
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProgram.Location = new System.Drawing.Point(3, 252);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(152, 74);
            this.btnProgram.TabIndex = 3;
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1691, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCollege;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnStudentInfo;
    }
}

