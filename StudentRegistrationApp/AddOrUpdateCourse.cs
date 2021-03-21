using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class AddOrUpdateCourseForm : Form
    {

        /// <summary>
        /// Child form to add or update a course. Uses Controller
        /// </summary>
        public AddOrUpdateCourseForm()
        {
            InitializeComponent();

            //register the event handlers
            this.Load += AddOrUpdateCourseForm_Load;
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpdate.Click += ButtonUpdate_Click;

            //register event handler for when a course is selected
            listBoxCourses.SelectedIndexChanged += (s, e) => GetCourses();
        }

        private void GetCourses()
        {
            if (!(listBoxCourses.SelectedItem is Course course))
                return;
            textBoxCourseNumber.Text = course.CourseNumber.ToString();
            textBoxCourseName.Text = course.CourseName;

            if (listBoxDepartment.SelectedIndex > -1)
            {
                listBoxDepartment.SelectedIndex = (int)course.DepartmentId - 1;
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //making sure course is selected

            if (!(listBoxCourses.SelectedItem is Course course))
            {
                MessageBox.Show("Course must be selected");
                return;
            }

            string text = textBoxCourseNumber.Text;

            course.CourseNumber = int.Parse(text);
            course.CourseName = textBoxCourseName.Text;
            course.DepartmentId = listBoxDepartment.SelectedIndex;

            if (Controller<StudentRegistrationEntities, Course>.UpdateEntity(course) == false)
            {
                MessageBox.Show("Cannot update Course to database");
                return;
            }

            this.DialogResult = DialogResult.OK;

            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // get the course data from the textboxes

            string text = textBoxCourseNumber.Text;
            Course course = new Course()
            {
                CourseNumber = int.Parse(text),
                CourseName = textBoxCourseName.Text,
                DepartmentId = listBoxDepartment.SelectedIndex

            };

            //update the db
            if (Controller<StudentRegistrationEntities, Course>.AddEntity(course) == null)
            {
                MessageBox.Show("Cannot add course to database");
                return;
            }

            //if everything is ok, close the form.
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void AddOrUpdateCourseForm_Load(object sender, EventArgs e)
        {
            // bind the listbox of courses to the inventory table.
            listBoxCourses.DataSource = Controller<StudentRegistrationEntities, Course>.SetBindingList();

            //select only the departmentCode to display in the listbox
            var departments = Controller<StudentRegistrationEntities, Department>.SetBindingList();
            var departmentsCode = departments.Select(c => c.DepartmentCode).ToList();
            listBoxDepartment.DataSource = departmentsCode;


            //no course is selected to start
            listBoxCourses.SelectionMode = SelectionMode.One;
            listBoxCourses.SelectedIndex = -1;
            listBoxDepartment.SelectionMode = SelectionMode.One;
            listBoxDepartment.SelectedIndex = -1;

            //set all textboxes to blank
            textBoxCourseNumber.ResetText();
            textBoxCourseName.ResetText();
        }
    }
}
