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
            this.EditWorkers = new System.Windows.Forms.TabPage();
            this.AddWorkers = new System.Windows.Forms.TabPage();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.addSubmitButton = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.supervisorButton = new System.Windows.Forms.RadioButton();
            this.ManagerButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pages.SuspendLayout();
            this.CreateSchedule.SuspendLayout();
            this.EditWorkers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.CreateSchedule);
            this.pages.Controls.Add(this.EditWorkers);
            this.pages.Controls.Add(this.AddWorkers);
            this.pages.Location = new System.Drawing.Point(2, -1);
            this.pages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(602, 369);
            this.pages.TabIndex = 0;
            // 
            // CreateSchedule
            // 
            this.CreateSchedule.Controls.Add(this.textBox1);
            this.CreateSchedule.Controls.Add(this.Create);
            this.CreateSchedule.Location = new System.Drawing.Point(4, 22);
            this.CreateSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateSchedule.Name = "CreateSchedule";
            this.CreateSchedule.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateSchedule.Size = new System.Drawing.Size(594, 343);
            this.CreateSchedule.TabIndex = 0;
            this.CreateSchedule.Text = "Schedule";
            this.CreateSchedule.UseVisualStyleBackColor = true;
            this.CreateSchedule.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(593, 292);
            this.textBox1.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(261, 28);
            this.Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(56, 19);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditWorkers
            // 
            this.EditWorkers.Controls.Add(this.LastNameLabel);
            this.EditWorkers.Controls.Add(this.firstNameLabel);
            this.EditWorkers.Controls.Add(this.LastName);
            this.EditWorkers.Controls.Add(this.addSubmitButton);
            this.EditWorkers.Controls.Add(this.FirstName);
            this.EditWorkers.Controls.Add(this.panel1);
            this.EditWorkers.Location = new System.Drawing.Point(4, 22);
            this.EditWorkers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditWorkers.Name = "EditWorkers";
            this.EditWorkers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditWorkers.Size = new System.Drawing.Size(594, 343);
            this.EditWorkers.TabIndex = 1;
            this.EditWorkers.Text = "Edit Workers";
            this.EditWorkers.UseVisualStyleBackColor = true;
            // 
            // AddWorkers
            // 
            this.AddWorkers.Location = new System.Drawing.Point(4, 22);
            this.AddWorkers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddWorkers.Name = "AddWorkers";
            this.AddWorkers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddWorkers.Size = new System.Drawing.Size(594, 343);
            this.AddWorkers.TabIndex = 2;
            this.AddWorkers.Text = "Add Workers";
            this.AddWorkers.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(162, 40);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            // 
            // addSubmitButton
            // 
            this.addSubmitButton.Location = new System.Drawing.Point(241, 224);
            this.addSubmitButton.Name = "addSubmitButton";
            this.addSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.addSubmitButton.TabIndex = 1;
            this.addSubmitButton.Text = "Submit";
            this.addSubmitButton.UseVisualStyleBackColor = true;
            this.addSubmitButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(162, 90);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(32, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(35, 90);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // supervisorButton
            // 
            this.supervisorButton.AutoSize = true;
            this.supervisorButton.Location = new System.Drawing.Point(12, 16);
            this.supervisorButton.Name = "supervisorButton";
            this.supervisorButton.Size = new System.Drawing.Size(75, 17);
            this.supervisorButton.TabIndex = 5;
            this.supervisorButton.TabStop = true;
            this.supervisorButton.Text = "Supervisor";
            this.supervisorButton.UseVisualStyleBackColor = true;
            this.supervisorButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ManagerButton
            // 
            this.ManagerButton.AutoSize = true;
            this.ManagerButton.Location = new System.Drawing.Point(12, 64);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(67, 17);
            this.ManagerButton.TabIndex = 6;
            this.ManagerButton.TabStop = true;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.CheckedChanged += new System.EventHandler(this.ManagerButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ManagerButton);
            this.panel1.Controls.Add(this.supervisorButton);
            this.panel1.Location = new System.Drawing.Point(326, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pages);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pages.ResumeLayout(false);
            this.CreateSchedule.ResumeLayout(false);
            this.CreateSchedule.PerformLayout();
            this.EditWorkers.ResumeLayout(false);
            this.EditWorkers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage CreateSchedule;
        private System.Windows.Forms.TabPage AddWorkers;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TabPage EditWorkers;
        private System.Windows.Forms.Button addSubmitButton;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ManagerButton;
        private System.Windows.Forms.RadioButton supervisorButton;
    }
}

