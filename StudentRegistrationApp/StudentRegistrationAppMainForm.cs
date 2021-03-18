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

            //TO DO ADD OR UPDATE 

            // TO DO REGISTER AND REGISTER AND DROP
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

            InitializeDataGridView<Student>(dataGridViewStudents, "Students");
            InitializeDataGridView<Course>(dataGridViewCourses, "Courses");
            InitializeDataGridView<Department>(dataGridViewDepartments, "Departments");
          //TODO REgistration
            //  InitializeDataGridView<StudentCourse>(dataGridViewRegistration, "Registration");
        }

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

        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            //get the item
            T item = e.Row.DataBoundItem as T;

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            //Delete the item in the DB.

            Controller<StudentRegistrationEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();

            //TO DO!!
        }

        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                dataGridView.DataSource = Controller<StudentRegistrationEntities, T>.SetBindingList();

                // update the customer orders report

//TODO REGISTRATION TABLE
              //  dataGridViewCustomerOrders.DataSource = Controller<AutoLotEntities, CustomerOrder>.GetEntitiesNoTracking();
               // dataGridViewCustomerOrders.Refresh();
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            form.Hide();
        }
    }
}
