using MTechTest2.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTechTest2
{
    public partial class EmployeesMenu : Form
    {
        public EmployeesMenu()
        {
            InitializeComponent();
        }

        //List of Employees stored on File
        private BindingList<Employee> employees = new BindingList<Employee>();

        //Path to Employees File
        string txtFile = @"data/employees.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opening the file for reading
            try
            {
                //Reading Each Line of TXT File
                using (StreamReader sr = File.OpenText(txtFile))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Deserializing JSON to Object
                        Employee em = JsonConvert.DeserializeObject<Employee>(s);
                        employees.Add(em);
                    }

                }

            }
            catch (Exception ex)
            {
                //File Doesn't Exist
                var myFile = File.Create(txtFile);
                myFile.Close();
            }

            //Set ComboBox Items
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Insert(0, "NotSet");
            comboBoxStatus.Items.Insert(1, "Active");
            comboBoxStatus.Items.Insert(2, "Inactive");

            //Order by Born Date
            //Set Employees List as DataSource
            dataGridViewEmployees.DataSource = new BindingList<Employee>(this.employees.OrderBy(x => x.BornDate).ToList());

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void labelNewEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Getting Data Through Forms
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string rfc = textBoxRFC.Text;
            DateTime bornDate = dateTimePickerBornDate.Value;
            int status = comboBoxStatus.SelectedIndex;

            //RFC Regex Validation
            Regex rx = new Regex(@"^([A-ZÑ&]{3,4})(?:- )?(\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01]))(?:- )?([A-Z\d]{2})([A\d])$");

            //First Coincidence by RFC
            Employee empCoincidence = employees.FirstOrDefault(emp => emp.RFC == rfc);

            if (!rx.IsMatch(rfc))
            {
                //Wrong RFC Error Messages
                string msg = "Wrong RFC Format Applied: " + rfc;
                string caption = "Wrong RFC";

                MessageBox.Show(msg, caption, MessageBoxButtons.OK);
            }
            else if(empCoincidence != null){

                //Duplicated RFC Error Messages
                string msg = "RFC Already Exists: " + rfc;
                string caption = "RFC Registered";

                MessageBox.Show(msg, caption, MessageBoxButtons.OK);
            }
            else
            {
                Employee employee = new Employee();

                //Data Assignment
                employee.Name = name;
                employee.LastName = lastName;
                employee.RFC = rfc;
                employee.BornDate = bornDate;

                //Status Assignment
                switch (status)
                {
                    //Index 0 => Not Status
                    case 0:
                        employee.Status = EmployeeStatus.NotSet;
                        break;
                    //Index 1 => Active
                    case 1:
                        employee.Status = EmployeeStatus.Active;
                        break;
                    //Index 2 => Inactive
                    case 2:
                        employee.Status = EmployeeStatus.Inactive;
                        break;
                }

                //ID Assignment
                int lastID = 0;
                if (employees.Count > 0)
                {
                    lastID = employees[employees.Count - 1].Id;
                }
                lastID++;
                employee.Id = lastID;

                //JSON Serializing with NewtonSoft Librarie
                string jsonEmployee = JsonConvert.SerializeObject(employee);

                try
                {
                    //Create/Saving TXT File (Data Store)
                    using (StreamWriter writer = File.AppendText(txtFile))
                    {
                        writer.WriteLine(jsonEmployee);
                    }

                    DialogResult result = MessageBox.Show("Employee Saved.", "Success!", MessageBoxButtons.OK);

                    //Update Employees List
                    this.employees.Add(employee);

                    //Order List By Born Date
                    dataGridViewEmployees.DataSource = new BindingList<Employee>(this.employees.OrderBy(x => x.BornDate).ToList());

                    //Clean Elements
                    if (result == DialogResult.OK)
                    {
                        textBoxName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxRFC.Text = "";
                        dateTimePickerBornDate.Value = DateTime.Now;
                        comboBoxStatus.SelectedIndex = -1;
                    }

                    //Switch to Previous Tab
                    tabEmployees.SelectedTab = tabPageEmployees;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Clean Elements
            textBoxName.Text = "";
            textBoxLastName.Text = "";
            textBoxRFC.Text = "";
            dateTimePickerBornDate.Value = DateTime.Now;
            comboBoxStatus.SelectedIndex = -1;

            //Switch to Previous Tab
            tabEmployees.SelectedTab = tabPageEmployees;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabNewEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = textBoxSearchName.Text;
            //If we wrote something, we filter, otherwise, reset de DataSource
            if (searchName.Length > 0)
                filterEmployees(searchName);
            else
                resetEmployees();
        }

        private void textBoxSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            //Only Filter When Enter
            if (e.KeyCode == Keys.Enter)
            {
                string searchName = textBoxSearchName.Text;
                //If we wrote something, we filter, otherwise, reset de DataSource
                if (searchName.Length > 0)
                    filterEmployees(searchName);
                else
                    resetEmployees();
            }
        }

        private void filterEmployees(string searchName)
        {
            //Employees Lisit Filtered By Name
            BindingList<Employee> filteredBindingList = new BindingList<Employee>(employees.Where(emp => emp.Name.ToLower() == searchName.ToLower()).ToList());

            //Set Filtered List as DataSource
            dataGridViewEmployees.DataSource = filteredBindingList;
        }

        private void resetEmployees()
        {
            //Set Original List as DataSource
            dataGridViewEmployees.DataSource = employees;
        }
    }
}
