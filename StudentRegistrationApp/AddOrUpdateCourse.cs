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
        /// <summary>
        /// Method for Getting the courses
        /// </summary>
        private void GetCourses()
        {
            if (!(listBoxCourses.SelectedItem is Course course))
                return;
            textBoxCourseNumber.Text = course.CourseNumber.ToString();
            textBoxCourseName.Text = course.CourseName;
        }
        /// <summary>
        /// When click the button update the row of courses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //making sure course is selected

            if (!(listBoxCourses.SelectedItem is Course course))
            {
                MessageBox.Show("Course must be selected");
                return;
            }
            course.CourseNumber = Convert.ToInt32(textBoxCourseNumber.Text);
            course.CourseName = textBoxCourseName.Text;

            if (Controller<StudentRegistrationEntities, Course>.UpdateEntity(course) == false)
            {
                MessageBox.Show("Cannot update Course to database");
                return;
            }

            this.DialogResult = DialogResult.OK;

            Close();

        }
        /// <summary>
        /// When button clicked. Add the data typed in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //get the department
            if (!(listBoxDepartment.SelectedItem is Department department))
            {
                MessageBox.Show("Department to be selected");
                return;
            }
            // get the course data from the textboxes
            Course course = new Course()
            {
                CourseNumber = Convert.ToInt32(textBoxCourseNumber.Text),
                CourseName = textBoxCourseName.Text,
                DepartmentId = department.DepartmentId

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

        /// <summary>
        ///  Load the Add or update course form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateCourseForm_Load(object sender, EventArgs e)
        {
            // bind the listbox of courses to the inventory table.
        
            listBoxCourses.DataSource = Controller<StudentRegistrationEntities, Course>.GetEntitiesWithIncluded("Department");

            //select only the departmentCode to display in the listbox
            
            listBoxDepartment.DataSource = Controller<StudentRegistrationEntities, Department>.SetBindingList();

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
