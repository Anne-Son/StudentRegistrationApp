using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using StudentRegistrationCodeFirstFromDB;
using EFControllerUtilities;
using SeedDatabaseExtensions;
using System.Diagnostics;

namespace StudentRegistrationApp
{
    public partial class StudentRegistrationAppMainForm : Form
    {
        public StudentRegistrationAppMainForm()
        {
            InitializeComponent();

            this.Text = "StudentRegistrationApp";

            this.Load += (s, e) => StudentRegistrationAppMainForm_Load();

            //Set button events for operating on various tables. Make use of single generic method for this
            //(AddOrUpdateForm), specifying the type of data, the gridview to update, and the form to open

            //We need a single form to add or updaate each student, department and course
           AddOrUpdateStudentForm addOrUpdateStudentForm = new AddOrUpdateStudentForm();
            buttonAddOrUpdateStudent.Click += (s, e) => AddOrUpdateForm<Student>(dataGridViewStudents, addOrUpdateStudentForm);

           AddOrUpdateDepartmentForm addOrUpdateDepartmentForm = new AddOrUpdateDepartmentForm();
            buttonAddOrUpdateDepartment.Click += (s, e) => AddOrUpdateForm<Department>(dataGridViewDepartments, addOrUpdateDepartmentForm);

            AddOrUpdateCourseForm addOrUpdateCourseForm = new AddOrUpdateCourseForm();
            buttonAddOrUpdateCourse.Click += (s, e) => AddOrUpdateForm<Course>(dataGridViewCourses, addOrUpdateCourseForm);

            //Register event handlers
            buttonRegister.Click += ButtonRegister_Click;
            buttonDrop.Click += ButtonDrop_Click;

        }
        /// <summary>
        /// button lister to drop a course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDrop_Click(object sender, EventArgs e)
        {
            //To get the selected row from the registration table
            var selectedRegistration = dataGridViewRegistrations.SelectedRows
                  .OfType<DataGridViewRow>()
                  .ToArray();
        
            //Checking if the row is selected

            foreach (var row in selectedRegistration)
            {
                using (StudentRegistrationEntities context = new StudentRegistrationEntities())
                {
                    var cou = (data1) row.DataBoundItem;
                  /*  
                    //getting the selected courseNumber
                    int val = (int)row.Cells[1].Value;
                    //getting the selected course name
                    String courseName = (String)row.Cells[2].Value;
                    //getting the selected studentId
                    int id = (int)row.Cells[3].Value;
                    */
                    //select the corusre and delete the student from it

                    
                      // labelDescription.Text = cou.CourseName.ToString();
                    
                    Course course = context.Courses.Include("Students").Where(c => c.CourseNumber == cou.CourseId && c.CourseName == cou.CourseName).FirstOrDefault();
                            course.Students.Remove(context.Students.Where(s => s.StudentId == cou.StudentId).FirstOrDefault());
                            context.SaveChanges();
                      
                   

                }

            }






            dispalyRegistration();

        }
        /// <summary>
        /// button listner for registering a course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
           using(StudentRegistrationEntities context = new StudentRegistrationEntities())
            {

                var selectedCourses =dataGridViewCourses.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(row => !row.IsNewRow)
            .ToArray();
                var selectedStudent = dataGridViewStudents.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(row => !row.IsNewRow)
            .ToArray();

                foreach (var stu in selectedStudent)
                {
                    foreach (var cours in selectedCourses)
                    {
                        Course cour =(Course) cours.DataBoundItem;
                        Student st = (Student)stu.DataBoundItem;
                        Course co= context.Courses.Include("Students").Where(c => c.CourseId == cour.CourseId).FirstOrDefault();
                        co.Students.Add(context.Students.Where(s => s.StudentId == st.StudentId).FirstOrDefault());
                        context.SaveChanges();
                    }

                }
             /*   //get the selected row from both datagridviews
                Course course = (Course)dataGridViewCourses.CurrentRow.DataBoundItem;
                Student student = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                //get the course and add the student to it
                Course cou = context.Courses.Include("Students").Where(c => c.CourseId == course.CourseId).FirstOrDefault();
                cou.Students.Add(context.Students.Where(s => s.StudentId == student.StudentId).FirstOrDefault());
                context.SaveChanges();*/

            }
            dispalyRegistration();

        }

        /// <summary>
        /// Set up all of the datagridview controls
        /// </summary>
        private void StudentRegistrationAppMainForm_Load()
        {
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                context.SeedDatabase();
            }
            //common setup for datagridview controls

            InitializeDataGridView<Student>(dataGridViewStudents, "Department","Courses");
            InitializeDataGridView<Course>(dataGridViewCourses, "Department","Students");
            InitializeDataGridView<Department>(dataGridViewDepartments, "Courses","Students");

            //for Registrationdatagrid
            dataGridViewRegistrations.AllowUserToAddRows = false;
            dataGridViewRegistrations.AllowUserToDeleteRows = true;
            dataGridViewRegistrations.ReadOnly = true;
            dataGridViewRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dispaly registration 
            dispalyRegistration();

        }
        /// <summary>
        /// Displaying registration table
        /// </summary>
        private void dispalyRegistration()
        {
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                var studentRegistrations = (from student in context.Students
                                            from course in student.Courses
                                            select new
                                            {
                                                DepartmentCode = student.Department.DepartmentCode,
                                                CouseNumber = course.CourseNumber,
                                                CourseName = course.CourseName,
                                                StudentId = student.StudentId,
                                                StudentLastName = student.StudentLastName,

                                            }).ToList();
                List<data1> dt = new List<data1>(studentRegistrations.Count);
                foreach(var r in studentRegistrations)
                {

                    data1 d = new data1();
                    d.CourseId = r.CouseNumber;
                    d.DepartmentCode = r.DepartmentCode;
                    d.CourseName = r.CourseName;
                    d.StudentId = r.StudentId;
                    d.StudentLastName = r.StudentLastName;
                    dt.Add(d);
                }

                
                dataGridViewRegistrations.DataSource = dt;

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView dataGridView, params string[] columnsToHide) where T : class
        {
            //Allow users to add/delete rows, and fill out columns to the entire width  of the control
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //set the handler used to delete an item using generics.

            dataGridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            //if there is any issue

            dataGridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            dataGridView.DataSource = Controller<StudentRegistrationEntities, T>.SetBindingList();

           foreach (string column in columnsToHide)
            dataGridView.Columns[column].Visible = false;
        }

        /// <summary>
        /// Method for deleting a row in the registration datagridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="e"></param>
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            //get the item
            T item = e.Row.DataBoundItem as T;

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            //Delete the item in the DB.

            Controller<StudentRegistrationEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();

        }

        /// <summary>
        /// Method to handle error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }
        /// <summary>
        /// A generic method to add or update form
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="form"></param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                dataGridView.DataSource = Controller<StudentRegistrationEntities, T>.SetBindingList();

            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            form.Hide();
        }
        public  partial class data1
        {
            public string DepartmentCode { get; set; }
            public Int32 CourseId { get; set; }
            public string CourseName { get; set; }
            public Int32 StudentId { get; set; }
            public string StudentLastName { get; set; }


        }
    }
}
