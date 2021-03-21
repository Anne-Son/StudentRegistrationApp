
namespace StudentRegistrationApp
{
    partial class AddOrUpdateCourseForm
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
            this.labelCourses = new System.Windows.Forms.Label();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.labelCourseNumber = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.textBoxCourseNumber = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Location = new System.Drawing.Point(13, 44);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(68, 20);
            this.labelCourses.TabIndex = 0;
            this.labelCourses.Text = "Courses";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 20;
            this.listBoxCourses.Location = new System.Drawing.Point(167, 44);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(202, 204);
            this.listBoxCourses.TabIndex = 1;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(12, 293);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(94, 20);
            this.labelDepartment.TabIndex = 2;
            this.labelDepartment.Text = "Department";
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.ItemHeight = 20;
            this.listBoxDepartment.Location = new System.Drawing.Point(167, 293);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(202, 164);
            this.listBoxDepartment.TabIndex = 3;
            // 
            // labelCourseNumber
            // 
            this.labelCourseNumber.AutoSize = true;
            this.labelCourseNumber.Location = new System.Drawing.Point(12, 498);
            this.labelCourseNumber.Name = "labelCourseNumber";
            this.labelCourseNumber.Size = new System.Drawing.Size(120, 20);
            this.labelCourseNumber.TabIndex = 4;
            this.labelCourseNumber.Text = "Course Number";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(12, 552);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(106, 20);
            this.labelCourseName.TabIndex = 5;
            this.labelCourseName.Text = "Course Name";
            // 
            // textBoxCourseNumber
            // 
            this.textBoxCourseNumber.Location = new System.Drawing.Point(167, 491);
            this.textBoxCourseNumber.Name = "textBoxCourseNumber";
            this.textBoxCourseNumber.Size = new System.Drawing.Size(144, 26);
            this.textBoxCourseNumber.TabIndex = 6;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(167, 546);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(144, 26);
            this.textBoxCourseName.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(61, 610);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 31);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(248, 610);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 31);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 707);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseNumber);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelCourseNumber);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.labelCourses);
            this.Name = "AddOrUpdateCourseForm";
            this.Text = "Add Or Update Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.Label labelCourseNumber;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.TextBox textBoxCourseNumber;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
    }
}