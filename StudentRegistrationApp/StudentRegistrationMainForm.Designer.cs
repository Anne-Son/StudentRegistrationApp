
namespace StudentRegistrationApp
{
    partial class StudentRegistrationMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewRegistrations = new System.Windows.Forms.DataGridView();
            this.buttonAddOrUpdateStudent = new System.Windows.Forms.Button();
            this.buttonAddOrUpdateCourses = new System.Windows.Forms.Button();
            this.buttonAddOrUpdateDepartment = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registration";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(42, 66);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(538, 211);
            this.dataGridViewStudents.TabIndex = 4;
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(759, 66);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.ReadOnly = true;
            this.dataGridViewDepartments.RowHeadersWidth = 51;
            this.dataGridViewDepartments.RowTemplate.Height = 24;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(538, 211);
            this.dataGridViewDepartments.TabIndex = 5;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(42, 321);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(538, 211);
            this.dataGridViewCourses.TabIndex = 6;
            // 
            // dataGridViewRegistrations
            // 
            this.dataGridViewRegistrations.AllowUserToAddRows = false;
            this.dataGridViewRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrations.Location = new System.Drawing.Point(42, 591);
            this.dataGridViewRegistrations.Name = "dataGridViewRegistrations";
            this.dataGridViewRegistrations.ReadOnly = true;
            this.dataGridViewRegistrations.RowHeadersWidth = 51;
            this.dataGridViewRegistrations.RowTemplate.Height = 24;
            this.dataGridViewRegistrations.Size = new System.Drawing.Size(805, 211);
            this.dataGridViewRegistrations.TabIndex = 7;
            // 
            // buttonAddOrUpdateStudent
            // 
            this.buttonAddOrUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateStudent.Location = new System.Drawing.Point(610, 146);
            this.buttonAddOrUpdateStudent.Name = "buttonAddOrUpdateStudent";
            this.buttonAddOrUpdateStudent.Size = new System.Drawing.Size(109, 89);
            this.buttonAddOrUpdateStudent.TabIndex = 8;
            this.buttonAddOrUpdateStudent.Text = "Add or Update";
            this.buttonAddOrUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrUpdateCourses
            // 
            this.buttonAddOrUpdateCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateCourses.Location = new System.Drawing.Point(610, 388);
            this.buttonAddOrUpdateCourses.Name = "buttonAddOrUpdateCourses";
            this.buttonAddOrUpdateCourses.Size = new System.Drawing.Size(109, 89);
            this.buttonAddOrUpdateCourses.TabIndex = 9;
            this.buttonAddOrUpdateCourses.Text = "Add or Update";
            this.buttonAddOrUpdateCourses.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrUpdateDepartment
            // 
            this.buttonAddOrUpdateDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdateDepartment.Location = new System.Drawing.Point(1312, 146);
            this.buttonAddOrUpdateDepartment.Name = "buttonAddOrUpdateDepartment";
            this.buttonAddOrUpdateDepartment.Size = new System.Drawing.Size(109, 89);
            this.buttonAddOrUpdateDepartment.TabIndex = 10;
            this.buttonAddOrUpdateDepartment.Text = "Add or Update";
            this.buttonAddOrUpdateDepartment.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(908, 624);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(223, 58);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrop.Location = new System.Drawing.Point(908, 727);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(223, 58);
            this.buttonDrop.TabIndex = 12;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 861);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonAddOrUpdateDepartment);
            this.Controls.Add(this.buttonAddOrUpdateCourses);
            this.Controls.Add(this.buttonAddOrUpdateStudent);
            this.Controls.Add(this.dataGridViewRegistrations);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentRegistrationMainForm";
            this.Text = "Student Registration App";
            this.Load += new System.EventHandler(this.StudentRegistrationMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.DataGridView dataGridViewRegistrations;
        private System.Windows.Forms.Button buttonAddOrUpdateStudent;
        private System.Windows.Forms.Button buttonAddOrUpdateCourses;
        private System.Windows.Forms.Button buttonAddOrUpdateDepartment;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonDrop;
    }
}

