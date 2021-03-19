
namespace StudentRegistrationApp
{
    partial class StudentRegistrationAppMainForm
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewRegistrations = new System.Windows.Forms.DataGridView();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.labelRegistrations = new System.Windows.Forms.Label();
            this.labelDepartments = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddOrUpdateStudent = new System.Windows.Forms.Button();
            this.buttonAddOrUpdateCourse = new System.Windows.Forms.Button();
            this.buttonAddOrUpdateDepartment = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(23, 55);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(490, 150);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(639, 55);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.RowHeadersWidth = 51;
            this.dataGridViewDepartments.RowTemplate.Height = 24;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(414, 150);
            this.dataGridViewDepartments.TabIndex = 1;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(23, 253);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(490, 150);
            this.dataGridViewCourses.TabIndex = 2;
            // 
            // dataGridViewRegistrations
            // 
            this.dataGridViewRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrations.Location = new System.Drawing.Point(23, 450);
            this.dataGridViewRegistrations.Name = "dataGridViewRegistrations";
            this.dataGridViewRegistrations.RowHeadersWidth = 51;
            this.dataGridViewRegistrations.RowTemplate.Height = 24;
            this.dataGridViewRegistrations.Size = new System.Drawing.Size(784, 150);
            this.dataGridViewRegistrations.TabIndex = 3;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(23, 21);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(64, 17);
            this.labelStudents.TabIndex = 4;
            this.labelStudents.Text = "Students";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Location = new System.Drawing.Point(23, 220);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(60, 17);
            this.labelCourses.TabIndex = 5;
            this.labelCourses.Text = "Courses";
            // 
            // labelRegistrations
            // 
            this.labelRegistrations.AutoSize = true;
            this.labelRegistrations.Location = new System.Drawing.Point(20, 418);
            this.labelRegistrations.Name = "labelRegistrations";
            this.labelRegistrations.Size = new System.Drawing.Size(84, 17);
            this.labelRegistrations.TabIndex = 6;
            this.labelRegistrations.Text = "Registration";
            // 
            // labelDepartments
            // 
            this.labelDepartments.AutoSize = true;
            this.labelDepartments.Location = new System.Drawing.Point(636, 21);
            this.labelDepartments.Name = "labelDepartments";
            this.labelDepartments.Size = new System.Drawing.Size(89, 17);
            this.labelDepartments.TabIndex = 7;
            this.labelDepartments.Text = "Departments";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(1000, 460);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(180, 119);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Register by selecting \r\nstudents and courses then \r\nhit Register button.\r\n\r\nDrop " +
    "by selecting \r\nRegistration and then hit\r\nDrop button";
            // 
            // buttonAddOrUpdateStudent
            // 
            this.buttonAddOrUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateStudent.Location = new System.Drawing.Point(535, 84);
            this.buttonAddOrUpdateStudent.Name = "buttonAddOrUpdateStudent";
            this.buttonAddOrUpdateStudent.Size = new System.Drawing.Size(86, 93);
            this.buttonAddOrUpdateStudent.TabIndex = 9;
            this.buttonAddOrUpdateStudent.Text = "Add Or Update Student";
            this.buttonAddOrUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrUpdateCourse
            // 
            this.buttonAddOrUpdateCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateCourse.Location = new System.Drawing.Point(535, 284);
            this.buttonAddOrUpdateCourse.Name = "buttonAddOrUpdateCourse";
            this.buttonAddOrUpdateCourse.Size = new System.Drawing.Size(86, 93);
            this.buttonAddOrUpdateCourse.TabIndex = 10;
            this.buttonAddOrUpdateCourse.Text = "Add Or Update Course";
            this.buttonAddOrUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrUpdateDepartment
            // 
            this.buttonAddOrUpdateDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateDepartment.Location = new System.Drawing.Point(1078, 84);
            this.buttonAddOrUpdateDepartment.Name = "buttonAddOrUpdateDepartment";
            this.buttonAddOrUpdateDepartment.Size = new System.Drawing.Size(102, 93);
            this.buttonAddOrUpdateDepartment.TabIndex = 11;
            this.buttonAddOrUpdateDepartment.Text = "Add Or Update Deparment";
            this.buttonAddOrUpdateDepartment.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(889, 469);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(92, 36);
            this.buttonRegister.TabIndex = 12;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrop.Location = new System.Drawing.Point(889, 532);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(92, 37);
            this.buttonDrop.TabIndex = 13;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationAppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 657);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonAddOrUpdateDepartment);
            this.Controls.Add(this.buttonAddOrUpdateCourse);
            this.Controls.Add(this.buttonAddOrUpdateStudent);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDepartments);
            this.Controls.Add(this.labelRegistrations);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.dataGridViewRegistrations);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "StudentRegistrationAppMainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.DataGridView dataGridViewRegistrations;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.Label labelRegistrations;
        private System.Windows.Forms.Label labelDepartments;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddOrUpdateStudent;
        private System.Windows.Forms.Button buttonAddOrUpdateCourse;
        private System.Windows.Forms.Button buttonAddOrUpdateDepartment;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonDrop;
    }
}

