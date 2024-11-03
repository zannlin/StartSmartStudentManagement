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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.txt_newStudentID = new System.Windows.Forms.TextBox();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.txt_newAge = new System.Windows.Forms.TextBox();
            this.txt_newCourseID = new System.Windows.Forms.TextBox();
            this.btn_UpdateCom = new System.Windows.Forms.Button();
            this.btn_CancelUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(66, 103);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(132, 16);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Search by Student ID";
            // 
            // lbl_newStudentID
            // 
            this.lbl_newStudentID.AutoSize = true;
            this.lbl_newStudentID.Location = new System.Drawing.Point(110, 329);
            this.lbl_newStudentID.Name = "lbl_newStudentID";
            this.lbl_newStudentID.Size = new System.Drawing.Size(71, 16);
            this.lbl_newStudentID.TabIndex = 1;
            this.lbl_newStudentID.Text = "Student ID:";
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.Location = new System.Drawing.Point(110, 361);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(47, 16);
            this.lbl_newName.TabIndex = 2;
            this.lbl_newName.Text = "Name:";
            // 
            // lbl_newAge
            // 
            this.lbl_newAge.AutoSize = true;
            this.lbl_newAge.Location = new System.Drawing.Point(110, 396);
            this.lbl_newAge.Name = "lbl_newAge";
            this.lbl_newAge.Size = new System.Drawing.Size(35, 16);
            this.lbl_newAge.TabIndex = 3;
            this.lbl_newAge.Text = "Age:";
            // 
            // lbl_newCourseID
            // 
            this.lbl_newCourseID.AutoSize = true;
            this.lbl_newCourseID.Location = new System.Drawing.Point(110, 426);
            this.lbl_newCourseID.Name = "lbl_newCourseID";
            this.lbl_newCourseID.Size = new System.Drawing.Size(69, 16);
            this.lbl_newCourseID.TabIndex = 4;
            this.lbl_newCourseID.Text = "Course ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 175);
            this.dataGridView1.TabIndex = 5;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(217, 101);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(149, 22);
            this.txt_Search.TabIndex = 6;
            // 
            // txt_newStudentID
            // 
            this.txt_newStudentID.Location = new System.Drawing.Point(217, 329);
            this.txt_newStudentID.Name = "txt_newStudentID";
            this.txt_newStudentID.Size = new System.Drawing.Size(270, 22);
            this.txt_newStudentID.TabIndex = 7;
            // 
            // txt_newName
            // 
            this.txt_newName.Location = new System.Drawing.Point(217, 361);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(270, 22);
            this.txt_newName.TabIndex = 8;
            // 
            // txt_newAge
            // 
            this.txt_newAge.Location = new System.Drawing.Point(217, 396);
            this.txt_newAge.Name = "txt_newAge";
            this.txt_newAge.Size = new System.Drawing.Size(270, 22);
            this.txt_newAge.TabIndex = 9;
            // 
            // txt_newCourseID
            // 
            this.txt_newCourseID.Location = new System.Drawing.Point(217, 426);
            this.txt_newCourseID.Name = "txt_newCourseID";
            this.txt_newCourseID.Size = new System.Drawing.Size(270, 22);
            this.txt_newCourseID.TabIndex = 10;
            // 
            // btn_UpdateCom
            // 
            this.btn_UpdateCom.BackColor = System.Drawing.Color.LightGreen;
            this.btn_UpdateCom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UpdateCom.Location = new System.Drawing.Point(179, 469);
            this.btn_UpdateCom.Name = "btn_UpdateCom";
            this.btn_UpdateCom.Size = new System.Drawing.Size(93, 33);
            this.btn_UpdateCom.TabIndex = 11;
            this.btn_UpdateCom.Text = "Update";
            this.btn_UpdateCom.UseVisualStyleBackColor = false;
            // 
            // btn_CancelUpdate
            // 
            this.btn_CancelUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btn_CancelUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CancelUpdate.Location = new System.Drawing.Point(325, 469);
            this.btn_CancelUpdate.Name = "btn_CancelUpdate";
            this.btn_CancelUpdate.Size = new System.Drawing.Size(94, 33);
            this.btn_CancelUpdate.TabIndex = 12;
            this.btn_CancelUpdate.Text = "Cancel";
            this.btn_CancelUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please select the entry you want to update after serching and then edit the detai" +
    "ls in the textboxes.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(91, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "StartSmart Student Management";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(600, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelUpdate);
            this.Controls.Add(this.btn_UpdateCom);
            this.Controls.Add(this.txt_newCourseID);
            this.Controls.Add(this.txt_newAge);
            this.Controls.Add(this.txt_newName);
            this.Controls.Add(this.txt_newStudentID);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_newCourseID);
            this.Controls.Add(this.lbl_newAge);
            this.Controls.Add(this.lbl_newName);
            this.Controls.Add(this.lbl_newStudentID);
            this.Controls.Add(this.lbl_Search);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_newStudentID;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label lbl_newAge;
        private System.Windows.Forms.Label lbl_newCourseID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TextBox txt_newStudentID;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.TextBox txt_newAge;
        private System.Windows.Forms.TextBox txt_newCourseID;
        private System.Windows.Forms.Button btn_UpdateCom;
        private System.Windows.Forms.Button btn_CancelUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}