namespace MTechTest2
{
    partial class EmployeesMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabEmployees = new System.Windows.Forms.TabControl();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.tabNewEmployee = new System.Windows.Forms.TabPage();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dateTimePickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.labelBornDate = new System.Windows.Forms.Label();
            this.textBoxRFC = new System.Windows.Forms.TextBox();
            this.labelRFC = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNewEmployee = new System.Windows.Forms.Label();
            this.tabEmployees.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabNewEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.tabPageEmployees);
            this.tabEmployees.Controls.Add(this.tabNewEmployee);
            this.tabEmployees.Location = new System.Drawing.Point(12, 3);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.SelectedIndex = 0;
            this.tabEmployees.Size = new System.Drawing.Size(523, 358);
            this.tabEmployees.TabIndex = 0;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageEmployees.Controls.Add(this.labelSearchByName);
            this.tabPageEmployees.Controls.Add(this.buttonSearch);
            this.tabPageEmployees.Controls.Add(this.textBoxSearchName);
            this.tabPageEmployees.Controls.Add(this.dataGridViewEmployees);
            this.tabPageEmployees.Controls.Add(this.labelEmployees);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(515, 332);
            this.tabPageEmployees.TabIndex = 0;
            this.tabPageEmployees.Text = "Employees";
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByName.Location = new System.Drawing.Point(6, 43);
            this.labelSearchByName.MinimumSize = new System.Drawing.Size(130, 0);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(130, 17);
            this.labelSearchByName.TabIndex = 5;
            this.labelSearchByName.Text = "Search by Name";
            this.labelSearchByName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(297, 37);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(146, 40);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(116, 20);
            this.textBoxSearchName.TabIndex = 3;
            this.textBoxSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchName_KeyUp);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(6, 74);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(503, 252);
            this.dataGridViewEmployees.TabIndex = 2;
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployees.Location = new System.Drawing.Point(155, 3);
            this.labelEmployees.MinimumSize = new System.Drawing.Size(230, 25);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(230, 25);
            this.labelEmployees.TabIndex = 1;
            this.labelEmployees.Text = "Employees";
            this.labelEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabNewEmployee
            // 
            this.tabNewEmployee.BackColor = System.Drawing.Color.Ivory;
            this.tabNewEmployee.Controls.Add(this.comboBoxStatus);
            this.tabNewEmployee.Controls.Add(this.buttonCancel);
            this.tabNewEmployee.Controls.Add(this.buttonSave);
            this.tabNewEmployee.Controls.Add(this.labelStatus);
            this.tabNewEmployee.Controls.Add(this.dateTimePickerBornDate);
            this.tabNewEmployee.Controls.Add(this.labelBornDate);
            this.tabNewEmployee.Controls.Add(this.textBoxRFC);
            this.tabNewEmployee.Controls.Add(this.labelRFC);
            this.tabNewEmployee.Controls.Add(this.textBoxLastName);
            this.tabNewEmployee.Controls.Add(this.labelLastName);
            this.tabNewEmployee.Controls.Add(this.textBoxName);
            this.tabNewEmployee.Controls.Add(this.labelName);
            this.tabNewEmployee.Controls.Add(this.labelNewEmployee);
            this.tabNewEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabNewEmployee.Name = "tabNewEmployee";
            this.tabNewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewEmployee.Size = new System.Drawing.Size(515, 332);
            this.tabNewEmployee.TabIndex = 1;
            this.tabNewEmployee.Text = "New Employee";
            this.tabNewEmployee.Click += new System.EventHandler(this.tabNewEmployee_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "NotSet",
            "Active",
            "Inactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(161, 224);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(226, 21);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(144, 273);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 32);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(306, 273);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 32);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(6, 225);
            this.labelStatus.MinimumSize = new System.Drawing.Size(140, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(140, 20);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Employee Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerBornDate
            // 
            this.dateTimePickerBornDate.Location = new System.Drawing.Point(161, 181);
            this.dateTimePickerBornDate.Name = "dateTimePickerBornDate";
            this.dateTimePickerBornDate.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickerBornDate.TabIndex = 8;
            // 
            // labelBornDate
            // 
            this.labelBornDate.AutoSize = true;
            this.labelBornDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBornDate.Location = new System.Drawing.Point(6, 181);
            this.labelBornDate.MinimumSize = new System.Drawing.Size(140, 0);
            this.labelBornDate.Name = "labelBornDate";
            this.labelBornDate.Size = new System.Drawing.Size(140, 20);
            this.labelBornDate.TabIndex = 7;
            this.labelBornDate.Text = "Born Date";
            this.labelBornDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRFC
            // 
            this.textBoxRFC.Location = new System.Drawing.Point(161, 141);
            this.textBoxRFC.MaxLength = 13;
            this.textBoxRFC.Name = "textBoxRFC";
            this.textBoxRFC.Size = new System.Drawing.Size(226, 20);
            this.textBoxRFC.TabIndex = 6;
            // 
            // labelRFC
            // 
            this.labelRFC.AutoSize = true;
            this.labelRFC.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRFC.Location = new System.Drawing.Point(6, 141);
            this.labelRFC.MinimumSize = new System.Drawing.Size(140, 0);
            this.labelRFC.Name = "labelRFC";
            this.labelRFC.Size = new System.Drawing.Size(140, 20);
            this.labelRFC.TabIndex = 5;
            this.labelRFC.Text = "RFC";
            this.labelRFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(161, 101);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(226, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(6, 99);
            this.labelLastName.MinimumSize = new System.Drawing.Size(140, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(140, 20);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(226, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(6, 55);
            this.labelName.MinimumSize = new System.Drawing.Size(140, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewEmployee
            // 
            this.labelNewEmployee.AutoSize = true;
            this.labelNewEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewEmployee.Location = new System.Drawing.Point(157, 3);
            this.labelNewEmployee.MinimumSize = new System.Drawing.Size(230, 25);
            this.labelNewEmployee.Name = "labelNewEmployee";
            this.labelNewEmployee.Size = new System.Drawing.Size(230, 25);
            this.labelNewEmployee.TabIndex = 0;
            this.labelNewEmployee.Text = "New Employee";
            this.labelNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewEmployee.Click += new System.EventHandler(this.labelNewEmployee_Click);
            // 
            // EmployeesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 373);
            this.Controls.Add(this.tabEmployees);
            this.Name = "EmployeesMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabEmployees.ResumeLayout(false);
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabNewEmployee.ResumeLayout(false);
            this.tabNewEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmployees;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabNewEmployee;
        private System.Windows.Forms.Label labelNewEmployee;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerBornDate;
        private System.Windows.Forms.Label labelBornDate;
        private System.Windows.Forms.TextBox textBoxRFC;
        private System.Windows.Forms.Label labelRFC;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchName;
    }
}

