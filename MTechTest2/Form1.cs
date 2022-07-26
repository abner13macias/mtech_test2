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
        private List<Employee> employees = new List<Employee>();

        //Path to Employees File
        string txtFile = @"data/employees.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Insert(0, "NotSet");
            comboBoxStatus.Items.Insert(1, "Active");
            comboBoxStatus.Items.Insert(2, "Inactive");

            // Opening the file for reading
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

                //JSON Serializing with NewtonSoft Librarie
                string jsonEmployee = JsonConvert.SerializeObject(employee);

                try
                {
                    //Create/Saving TXT File (Data Store)
                    using (StreamWriter writer = File.AppendText(txtFile))
                    {
                        writer.WriteLine(jsonEmployee);
                    }

                    MessageBox.Show("Employee Saved.", "Success!", MessageBoxButtons.OK);

                    //Update Employees List
                    this.employees.Add(employee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Saving Employee Data.", "Error", MessageBoxButtons.OK);
                }
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabNewEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
