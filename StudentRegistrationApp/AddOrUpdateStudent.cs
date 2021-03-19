using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;

namespace StudentRegistrationApp
{
    /// <summary>
    /// Child form to add or update a student. Uses Controller
    /// </summary>
    public partial class AddOrUpdateStudentForm : Form
    {
        public AddOrUpdateStudentForm()
        {
            InitializeComponent();

            //register the event handlers
            this.Load += AddOrUpdateStudentForm_Load;
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpdate.Click += ButtonUpdate_Click;

            //register event handler for when a student is selected

            listBoxStudents.SelectedIndexChanged += (s, e) => GetStudents();
           
        }

        private void AddOrUpdateStudentForm_Load(object sender, EventArgs e)
        {
            // bind the listbox of students to the inventory table.
            listBoxStudents.DataSource = Controller<StudentRegistrationEntities, Student>.SetBindingList();

            //select only the departmentCode to display in the listbox
            var departments = Controller<StudentRegistrationEntities, Department>.SetBindingList();
            var departmentsCode = departments.Select(c => c.DepartmentCode).ToList();
            listBoxDepartments.DataSource = departmentsCode;


            //no student is selected to start
            listBoxStudents.SelectedIndex = -1;

            //set all textboxes to blank
            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();
            
        }
        private void GetStudents()
        {
            if (!(listBoxStudents.SelectedItem is Student student))
                return;
            textBoxFirstName.Text = student.StudentFirstName;
            textBoxLastName.Text = student.StudentLastName;
         
            if(listBoxDepartments.SelectedIndex > -1)
            {
                listBoxDepartments.SelectedIndex = (int)student.DepartmentId -1;
            }

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //making sure a student is selected
            if(!(listBoxStudents.SelectedItem is Student student))
            {
                MessageBox.Show("Student to be updated must be selected");
                return;
            }
            
            student.StudentFirstName = textBoxFirstName.Text;
            student.StudentLastName = textBoxLastName.Text;
            student.DepartmentId = listBoxDepartments.SelectedIndex;

            if (Controller<StudentRegistrationEntities, Student>.UpdateEntity(student) == false)
            {
                MessageBox.Show("Cannot update car to database");
                return;
            }

            this.DialogResult = DialogResult.OK;

            Close();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //get the student data from the textboxes and listbox

            Student student = new Student()
            {
                StudentFirstName = textBoxFirstName.Text,
                StudentLastName = textBoxLastName.Text,
                DepartmentId = listBoxDepartments.SelectedIndex
            };

            //update the db
            if (Controller<StudentRegistrationEntities, Student>.AddEntity(student) == null)
            {
                MessageBox.Show("Cannot add student to database");
                return;
            }

            //if everything is ok, close the form.
            this.DialogResult = DialogResult.OK;
            Close();
        }

    
    }
}
