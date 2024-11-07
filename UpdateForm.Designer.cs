namespace StartSmartStudentManagement
{
    partial class UpdateForm
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
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_newStudentID = new System.Windows.Forms.Label();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.lbl_newAge = new System.Windows.Forms.Label();
            this.lbl_newCourseID = new System.Windows.Forms.Label();
            this.dvg_studentInfo = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.txt_newStudentID = new System.Windows.Forms.TextBox();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.txt_newAge = new System.Windows.Forms.TextBox();
            this.txt_newCourseID = new System.Windows.Forms.TextBox();
            this.btn_UpdateCom = new System.Windows.Forms.Button();
            this.btn_CancelUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_SearchN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_studentInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Search.Location = new System.Drawing.Point(159, 121);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(117, 16);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Search Student ID:\r\n";
            // 
            // lbl_newStudentID
            // 
            this.lbl_newStudentID.AutoSize = true;
            this.lbl_newStudentID.ForeColor = System.Drawing.Color.Silver;
            this.lbl_newStudentID.Location = new System.Drawing.Point(159, 350);
            this.lbl_newStudentID.Name = "lbl_newStudentID";
            this.lbl_newStudentID.Size = new System.Drawing.Size(71, 16);
            this.lbl_newStudentID.TabIndex = 1;
            this.lbl_newStudentID.Text = "Student ID:";
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.ForeColor = System.Drawing.Color.Silver;
            this.lbl_newName.Location = new System.Drawing.Point(159, 382);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(47, 16);
            this.lbl_newName.TabIndex = 2;
            this.lbl_newName.Text = "Name:";
            // 
            // lbl_newAge
            // 
            this.lbl_newAge.AutoSize = true;
            this.lbl_newAge.ForeColor = System.Drawing.Color.Silver;
            this.lbl_newAge.Location = new System.Drawing.Point(159, 416);
            this.lbl_newAge.Name = "lbl_newAge";
            this.lbl_newAge.Size = new System.Drawing.Size(35, 16);
            this.lbl_newAge.TabIndex = 3;
            this.lbl_newAge.Text = "Age:";
            // 
            // lbl_newCourseID
            // 
            this.lbl_newCourseID.AutoSize = true;
            this.lbl_newCourseID.ForeColor = System.Drawing.Color.Silver;
            this.lbl_newCourseID.Location = new System.Drawing.Point(159, 446);
            this.lbl_newCourseID.Name = "lbl_newCourseID";
            this.lbl_newCourseID.Size = new System.Drawing.Size(69, 16);
            this.lbl_newCourseID.TabIndex = 4;
            this.lbl_newCourseID.Text = "Course ID:";
            // 
            // dvg_studentInfo
            // 
            this.dvg_studentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.dvg_studentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_studentInfo.Location = new System.Drawing.Point(71, 158);
            this.dvg_studentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvg_studentInfo.Name = "dvg_studentInfo";
            this.dvg_studentInfo.RowHeadersWidth = 51;
            this.dvg_studentInfo.RowTemplate.Height = 24;
            this.dvg_studentInfo.Size = new System.Drawing.Size(592, 175);
            this.dvg_studentInfo.TabIndex = 5;
            this.dvg_studentInfo.SelectionChanged += new System.EventHandler(this.dvg_studentInfo_SelectionChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.Silver;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Location = new System.Drawing.Point(297, 119);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(149, 22);
            this.txt_Search.TabIndex = 6;
            // 
            // txt_newStudentID
            // 
            this.txt_newStudentID.BackColor = System.Drawing.Color.Silver;
            this.txt_newStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newStudentID.Location = new System.Drawing.Point(267, 343);
            this.txt_newStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_newStudentID.Name = "txt_newStudentID";
            this.txt_newStudentID.Size = new System.Drawing.Size(270, 22);
            this.txt_newStudentID.TabIndex = 7;
            // 
            // txt_newName
            // 
            this.txt_newName.BackColor = System.Drawing.Color.Silver;
            this.txt_newName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newName.Location = new System.Drawing.Point(267, 375);
            this.txt_newName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(270, 22);
            this.txt_newName.TabIndex = 8;
            // 
            // txt_newAge
            // 
            this.txt_newAge.BackColor = System.Drawing.Color.Silver;
            this.txt_newAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newAge.Location = new System.Drawing.Point(267, 410);
            this.txt_newAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_newAge.Name = "txt_newAge";
            this.txt_newAge.Size = new System.Drawing.Size(270, 22);
            this.txt_newAge.TabIndex = 9;
            // 
            // txt_newCourseID
            // 
            this.txt_newCourseID.BackColor = System.Drawing.Color.Silver;
            this.txt_newCourseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newCourseID.Location = new System.Drawing.Point(267, 441);
            this.txt_newCourseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_newCourseID.Name = "txt_newCourseID";
            this.txt_newCourseID.Size = new System.Drawing.Size(270, 22);
            this.txt_newCourseID.TabIndex = 10;
            // 
            // btn_UpdateCom
            // 
            this.btn_UpdateCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.btn_UpdateCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateCom.ForeColor = System.Drawing.Color.Silver;
            this.btn_UpdateCom.Location = new System.Drawing.Point(228, 489);
            this.btn_UpdateCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateCom.Name = "btn_UpdateCom";
            this.btn_UpdateCom.Size = new System.Drawing.Size(93, 33);
            this.btn_UpdateCom.TabIndex = 11;
            this.btn_UpdateCom.Text = "Update";
            this.btn_UpdateCom.UseVisualStyleBackColor = false;
            this.btn_UpdateCom.Click += new System.EventHandler(this.btn_UpdateCom_Click);
            // 
            // btn_CancelUpdate
            // 
            this.btn_CancelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.btn_CancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelUpdate.ForeColor = System.Drawing.Color.Silver;
            this.btn_CancelUpdate.Location = new System.Drawing.Point(373, 489);
            this.btn_CancelUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancelUpdate.Name = "btn_CancelUpdate";
            this.btn_CancelUpdate.Size = new System.Drawing.Size(93, 33);
            this.btn_CancelUpdate.TabIndex = 12;
            this.btn_CancelUpdate.Text = "Cancel";
            this.btn_CancelUpdate.UseVisualStyleBackColor = false;
            this.btn_CancelUpdate.Click += new System.EventHandler(this.btn_CancelUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(171, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 67);
            this.label2.TabIndex = 14;
            this.label2.Text = "Start Smart";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 15;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.Silver;
            this.btn_Search.Location = new System.Drawing.Point(442, 109);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 33);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_SearchN
            // 
            this.btn_SearchN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.btn_SearchN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchN.ForeColor = System.Drawing.Color.Silver;
            this.btn_SearchN.Location = new System.Drawing.Point(465, 113);
            this.btn_SearchN.Name = "btn_SearchN";
            this.btn_SearchN.Size = new System.Drawing.Size(93, 32);
            this.btn_SearchN.TabIndex = 16;
            this.btn_SearchN.Text = "Search";
            this.btn_SearchN.UseVisualStyleBackColor = false;
            this.btn_SearchN.Click += new System.EventHandler(this.btn_SearchN_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(732, 569);
            this.Controls.Add(this.btn_SearchN);
            this.Controls.Add(this.btn_CancelUpdate);
            this.Controls.Add(this.btn_UpdateCom);
            this.Controls.Add(this.txt_newCourseID);
            this.Controls.Add(this.txt_newAge);
            this.Controls.Add(this.txt_newName);
            this.Controls.Add(this.txt_newStudentID);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dvg_studentInfo);
            this.Controls.Add(this.lbl_newCourseID);
            this.Controls.Add(this.lbl_newAge);
            this.Controls.Add(this.lbl_newName);
            this.Controls.Add(this.lbl_newStudentID);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_studentInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_newStudentID;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label lbl_newAge;
        private System.Windows.Forms.Label lbl_newCourseID;
        private System.Windows.Forms.DataGridView dvg_studentInfo;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TextBox txt_newStudentID;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.TextBox txt_newAge;
        private System.Windows.Forms.TextBox txt_newCourseID;
        private System.Windows.Forms.Button btn_UpdateCom;
        private System.Windows.Forms.Button btn_CancelUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_SearchN;
    }
}