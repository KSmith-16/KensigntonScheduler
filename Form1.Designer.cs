namespace KensigntonScheduler
{
    partial class Form1
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
            this.pages = new System.Windows.Forms.TabControl();
            this.CreateSchedule = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Add_Workers = new System.Windows.Forms.TabPage();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.addSubmitButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManagerButton = new System.Windows.Forms.RadioButton();
            this.supervisorButton = new System.Windows.Forms.RadioButton();
            this.Edit_Workers = new System.Windows.Forms.TabPage();
            this.neitherRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EmployeeLabel_Edit = new System.Windows.Forms.Label();
            this.workerComboBox_Edit = new System.Windows.Forms.ComboBox();
            this.SelectOWrker_Edit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton_Edit = new System.Windows.Forms.RadioButton();
            this.tierButton_Edit = new System.Windows.Forms.RadioButton();
            this.firstButton_Edit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.neitherButton_Edit = new System.Windows.Forms.RadioButton();
            this.superviserButton_Edit = new System.Windows.Forms.RadioButton();
            this.managerButton_Edit = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pages.SuspendLayout();
            this.CreateSchedule.SuspendLayout();
            this.Add_Workers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Edit_Workers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.CreateSchedule);
            this.pages.Controls.Add(this.Add_Workers);
            this.pages.Controls.Add(this.Edit_Workers);
            this.pages.Location = new System.Drawing.Point(2, -1);
            this.pages.Margin = new System.Windows.Forms.Padding(2);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1900, 1045);
            this.pages.TabIndex = 0;
            // 
            // CreateSchedule
            // 
            this.CreateSchedule.Controls.Add(this.textBox1);
            this.CreateSchedule.Controls.Add(this.Create);
            this.CreateSchedule.Location = new System.Drawing.Point(4, 22);
            this.CreateSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.CreateSchedule.Name = "CreateSchedule";
            this.CreateSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.CreateSchedule.Size = new System.Drawing.Size(1892, 1019);
            this.CreateSchedule.TabIndex = 0;
            this.CreateSchedule.Text = "Schedule";
            this.CreateSchedule.UseVisualStyleBackColor = true;
            this.CreateSchedule.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(964, 461);
            this.textBox1.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(426, 28);
            this.Create.Margin = new System.Windows.Forms.Padding(2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(56, 19);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Workers
            // 
            this.Add_Workers.Controls.Add(this.LastNameLabel);
            this.Add_Workers.Controls.Add(this.firstNameLabel);
            this.Add_Workers.Controls.Add(this.LastName);
            this.Add_Workers.Controls.Add(this.addSubmitButton);
            this.Add_Workers.Controls.Add(this.FirstName);
            this.Add_Workers.Controls.Add(this.panel1);
            this.Add_Workers.Location = new System.Drawing.Point(4, 22);
            this.Add_Workers.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Workers.Name = "Add_Workers";
            this.Add_Workers.Padding = new System.Windows.Forms.Padding(2);
            this.Add_Workers.Size = new System.Drawing.Size(1892, 1019);
            this.Add_Workers.TabIndex = 1;
            this.Add_Workers.Text = "Add Workers";
            this.Add_Workers.UseVisualStyleBackColor = true;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(259, 124);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(256, 81);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(386, 124);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 2;
            // 
            // addSubmitButton
            // 
            this.addSubmitButton.Location = new System.Drawing.Point(433, 258);
            this.addSubmitButton.Name = "addSubmitButton";
            this.addSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.addSubmitButton.TabIndex = 1;
            this.addSubmitButton.Text = "Submit";
            this.addSubmitButton.UseVisualStyleBackColor = true;
            this.addSubmitButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(386, 74);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.neitherRadioButton);
            this.panel1.Controls.Add(this.ManagerButton);
            this.panel1.Controls.Add(this.supervisorButton);
            this.panel1.Location = new System.Drawing.Point(550, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 134);
            this.panel1.TabIndex = 7;
            // 
            // ManagerButton
            // 
            this.ManagerButton.AutoSize = true;
            this.ManagerButton.Location = new System.Drawing.Point(12, 76);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(67, 17);
            this.ManagerButton.TabIndex = 6;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.CheckedChanged += new System.EventHandler(this.ManagerButton_CheckedChanged);
            // 
            // supervisorButton
            // 
            this.supervisorButton.AutoSize = true;
            this.supervisorButton.Location = new System.Drawing.Point(12, 44);
            this.supervisorButton.Name = "supervisorButton";
            this.supervisorButton.Size = new System.Drawing.Size(75, 17);
            this.supervisorButton.TabIndex = 5;
            this.supervisorButton.Text = "Supervisor";
            this.supervisorButton.UseVisualStyleBackColor = true;
            this.supervisorButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Edit_Workers
            // 
            this.Edit_Workers.Controls.Add(this.panel3);
            this.Edit_Workers.Controls.Add(this.firstButton_Edit);
            this.Edit_Workers.Controls.Add(this.panel2);
            this.Edit_Workers.Controls.Add(this.SelectOWrker_Edit);
            this.Edit_Workers.Controls.Add(this.workerComboBox_Edit);
            this.Edit_Workers.Controls.Add(this.EmployeeLabel_Edit);
            this.Edit_Workers.Controls.Add(this.textBox2);
            this.Edit_Workers.Location = new System.Drawing.Point(4, 22);
            this.Edit_Workers.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Workers.Name = "Edit_Workers";
            this.Edit_Workers.Padding = new System.Windows.Forms.Padding(2);
            this.Edit_Workers.Size = new System.Drawing.Size(1892, 1019);
            this.Edit_Workers.TabIndex = 2;
            this.Edit_Workers.Text = "Edit Workers";
            this.Edit_Workers.UseVisualStyleBackColor = true;
            // 
            // neitherRadioButton
            // 
            this.neitherRadioButton.AutoSize = true;
            this.neitherRadioButton.Checked = true;
            this.neitherRadioButton.Location = new System.Drawing.Point(12, 11);
            this.neitherRadioButton.Name = "neitherRadioButton";
            this.neitherRadioButton.Size = new System.Drawing.Size(59, 17);
            this.neitherRadioButton.TabIndex = 7;
            this.neitherRadioButton.TabStop = true;
            this.neitherRadioButton.Text = "Neither";
            this.neitherRadioButton.UseVisualStyleBackColor = true;
            this.neitherRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(198, 269);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmployeeLabel_Edit
            // 
            this.EmployeeLabel_Edit.AutoSize = true;
            this.EmployeeLabel_Edit.Location = new System.Drawing.Point(23, 31);
            this.EmployeeLabel_Edit.Name = "EmployeeLabel_Edit";
            this.EmployeeLabel_Edit.Size = new System.Drawing.Size(61, 13);
            this.EmployeeLabel_Edit.TabIndex = 1;
            this.EmployeeLabel_Edit.Text = "Employees:";
            // 
            // workerComboBox_Edit
            // 
            this.workerComboBox_Edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerComboBox_Edit.FormattingEnabled = true;
            this.workerComboBox_Edit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.workerComboBox_Edit.Location = new System.Drawing.Point(476, 62);
            this.workerComboBox_Edit.MaxDropDownItems = 50;
            this.workerComboBox_Edit.Name = "workerComboBox_Edit";
            this.workerComboBox_Edit.Size = new System.Drawing.Size(121, 21);
            this.workerComboBox_Edit.Sorted = true;
            this.workerComboBox_Edit.TabIndex = 2;
            this.workerComboBox_Edit.SelectedIndexChanged += new System.EventHandler(this.workerComboBox_Edit_SelectedIndexChanged);
            // 
            // SelectOWrker_Edit
            // 
            this.SelectOWrker_Edit.AutoSize = true;
            this.SelectOWrker_Edit.Location = new System.Drawing.Point(294, 65);
            this.SelectOWrker_Edit.Name = "SelectOWrker_Edit";
            this.SelectOWrker_Edit.Size = new System.Drawing.Size(75, 13);
            this.SelectOWrker_Edit.TabIndex = 3;
            this.SelectOWrker_Edit.Text = "Select Worker";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tierButton_Edit);
            this.panel2.Controls.Add(this.deleteButton_Edit);
            this.panel2.Location = new System.Drawing.Point(674, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            // 
            // deleteButton_Edit
            // 
            this.deleteButton_Edit.AutoSize = true;
            this.deleteButton_Edit.Checked = true;
            this.deleteButton_Edit.Location = new System.Drawing.Point(21, 3);
            this.deleteButton_Edit.Name = "deleteButton_Edit";
            this.deleteButton_Edit.Size = new System.Drawing.Size(56, 17);
            this.deleteButton_Edit.TabIndex = 0;
            this.deleteButton_Edit.TabStop = true;
            this.deleteButton_Edit.Text = "Delete";
            this.deleteButton_Edit.UseVisualStyleBackColor = true;
            // 
            // tierButton_Edit
            // 
            this.tierButton_Edit.AutoSize = true;
            this.tierButton_Edit.Location = new System.Drawing.Point(21, 52);
            this.tierButton_Edit.Name = "tierButton_Edit";
            this.tierButton_Edit.Size = new System.Drawing.Size(83, 17);
            this.tierButton_Edit.TabIndex = 1;
            this.tierButton_Edit.TabStop = true;
            this.tierButton_Edit.Text = "Change Tier";
            this.tierButton_Edit.UseVisualStyleBackColor = true;
            // 
            // firstButton_Edit
            // 
            this.firstButton_Edit.Location = new System.Drawing.Point(476, 244);
            this.firstButton_Edit.Name = "firstButton_Edit";
            this.firstButton_Edit.Size = new System.Drawing.Size(75, 23);
            this.firstButton_Edit.TabIndex = 5;
            this.firstButton_Edit.Text = "Submit";
            this.firstButton_Edit.UseVisualStyleBackColor = true;
            this.firstButton_Edit.Click += new System.EventHandler(this.firstButton_Edit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.managerButton_Edit);
            this.panel3.Controls.Add(this.superviserButton_Edit);
            this.panel3.Controls.Add(this.neitherButton_Edit);
            this.panel3.Location = new System.Drawing.Point(297, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 100);
            this.panel3.TabIndex = 6;
            // 
            // neitherButton_Edit
            // 
            this.neitherButton_Edit.AutoSize = true;
            this.neitherButton_Edit.Location = new System.Drawing.Point(3, 41);
            this.neitherButton_Edit.Name = "neitherButton_Edit";
            this.neitherButton_Edit.Size = new System.Drawing.Size(49, 17);
            this.neitherButton_Edit.TabIndex = 0;
            this.neitherButton_Edit.TabStop = true;
            this.neitherButton_Edit.Text = "Base";
            this.neitherButton_Edit.UseVisualStyleBackColor = true;
            this.neitherButton_Edit.Visible = false;
            this.neitherButton_Edit.CheckedChanged += new System.EventHandler(this.neitherButton_Edit_CheckedChanged);
            // 
            // superviserButton_Edit
            // 
            this.superviserButton_Edit.AutoSize = true;
            this.superviserButton_Edit.Location = new System.Drawing.Point(179, 41);
            this.superviserButton_Edit.Name = "superviserButton_Edit";
            this.superviserButton_Edit.Size = new System.Drawing.Size(75, 17);
            this.superviserButton_Edit.TabIndex = 1;
            this.superviserButton_Edit.TabStop = true;
            this.superviserButton_Edit.Text = "Superviser";
            this.superviserButton_Edit.UseVisualStyleBackColor = true;
            this.superviserButton_Edit.Visible = false;
            this.superviserButton_Edit.CheckedChanged += new System.EventHandler(this.superviserButton_Edit_CheckedChanged);
            // 
            // managerButton_Edit
            // 
            this.managerButton_Edit.AutoSize = true;
            this.managerButton_Edit.Location = new System.Drawing.Point(377, 41);
            this.managerButton_Edit.Name = "managerButton_Edit";
            this.managerButton_Edit.Size = new System.Drawing.Size(67, 17);
            this.managerButton_Edit.TabIndex = 2;
            this.managerButton_Edit.TabStop = true;
            this.managerButton_Edit.Text = "Manager";
            this.managerButton_Edit.UseVisualStyleBackColor = true;
            this.managerButton_Edit.Visible = false;
            this.managerButton_Edit.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 538);
            this.Controls.Add(this.pages);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pages.ResumeLayout(false);
            this.CreateSchedule.ResumeLayout(false);
            this.CreateSchedule.PerformLayout();
            this.Add_Workers.ResumeLayout(false);
            this.Add_Workers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Edit_Workers.ResumeLayout(false);
            this.Edit_Workers.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage CreateSchedule;
        private System.Windows.Forms.TabPage Edit_Workers;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TabPage Add_Workers;
        private System.Windows.Forms.Button addSubmitButton;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ManagerButton;
        private System.Windows.Forms.RadioButton supervisorButton;
        private System.Windows.Forms.RadioButton neitherRadioButton;
        private System.Windows.Forms.Label EmployeeLabel_Edit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label SelectOWrker_Edit;
        private System.Windows.Forms.ComboBox workerComboBox_Edit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton managerButton_Edit;
        private System.Windows.Forms.RadioButton superviserButton_Edit;
        private System.Windows.Forms.RadioButton neitherButton_Edit;
        private System.Windows.Forms.Button firstButton_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton tierButton_Edit;
        private System.Windows.Forms.RadioButton deleteButton_Edit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

