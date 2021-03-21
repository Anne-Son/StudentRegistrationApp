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
    /// <summary>
    /// Child form to add or update a department. Uses Controller
    /// </summary>
    public partial class AddOrUpdateDepartmentForm : Form
    {
        public AddOrUpdateDepartmentForm()
        {
            InitializeComponent();

            //register the event handlers
            this.Load += AddOrUpdateStudentForm_Load;
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpdate.Click += ButtonUpdate_Click;

            //register event handler for when a student is selected

            listBoxDepartment.SelectedIndexChanged += (s, e) => GetDepartment();
        }
        /// <summary>
        /// Load the Department add or update form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateStudentForm_Load(object sender, EventArgs e)
        {
            // bind the listbox of deparment to the inventory table.
            listBoxDepartment.DataSource = Controller<StudentRegistrationEntities, Department>.SetBindingList();

            //no student is selected to start
            listBoxDepartment.SelectedIndex = -1;

            //set all textboxes to blank
            textBoxDepartmentCode.ResetText();
            textBoxDepartmentName.ResetText();

        }

        /// <summary>
        /// Getting the departments from db
        /// </summary>
        private void GetDepartment()
        {
            if (!(listBoxDepartment.SelectedItem is Department department))
                return;
            textBoxDepartmentCode.Text = department.DepartmentCode;
            textBoxDepartmentName.Text = department.DepartmentName;

        }
        /// <summary>
        /// When click on update button update Department
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //making sure a department is selected
            if (!(listBoxDepartment.SelectedItem is Department department))
            {
                MessageBox.Show("Department to be updated must be selected");
                return;
            }

            department.DepartmentCode = textBoxDepartmentCode.Text;
            department.DepartmentName = textBoxDepartmentName.Text;

            if (Controller<StudentRegistrationEntities, Department>.UpdateEntity(department) == false)
            {
                MessageBox.Show("Cannot update car to database");
                return;
            }

            this.DialogResult = DialogResult.OK;

            Close();
        }
        /// <summary>
        /// When click on add button add Department
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //get the department data from the textboxes and listbox

            Department department = new Department()
            {
                DepartmentCode = textBoxDepartmentCode.Text,
                DepartmentName = textBoxDepartmentName.Text,
            };

            //update the db
            if (Controller<StudentRegistrationEntities, Department>.AddEntity(department) == null)
            {
                MessageBox.Show("Cannot add department to database");
                return;
            }

            //if everything is ok, close the form.
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
