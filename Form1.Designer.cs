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
            this.EditWorkers = new System.Windows.Forms.TabPage();
            this.AddWorkers = new System.Windows.Forms.TabPage();
            this.Create = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pages.SuspendLayout();
            this.CreateSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.CreateSchedule);
            this.pages.Controls.Add(this.EditWorkers);
            this.pages.Controls.Add(this.AddWorkers);
            this.pages.Location = new System.Drawing.Point(2, -1);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(803, 454);
            this.pages.TabIndex = 0;
            // 
            // CreateSchedule
            // 
            this.CreateSchedule.Controls.Add(this.textBox1);
            this.CreateSchedule.Controls.Add(this.Create);
            this.CreateSchedule.Location = new System.Drawing.Point(4, 25);
            this.CreateSchedule.Name = "CreateSchedule";
            this.CreateSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.CreateSchedule.Size = new System.Drawing.Size(795, 425);
            this.CreateSchedule.TabIndex = 0;
            this.CreateSchedule.Text = "Schedule";
            this.CreateSchedule.UseVisualStyleBackColor = true;
            this.CreateSchedule.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // EditWorkers
            // 
            this.EditWorkers.Location = new System.Drawing.Point(4, 25);
            this.EditWorkers.Name = "EditWorkers";
            this.EditWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.EditWorkers.Size = new System.Drawing.Size(795, 425);
            this.EditWorkers.TabIndex = 1;
            this.EditWorkers.Text = "Edit Workers";
            this.EditWorkers.UseVisualStyleBackColor = true;
            // 
            // AddWorkers
            // 
            this.AddWorkers.Location = new System.Drawing.Point(4, 25);
            this.AddWorkers.Name = "AddWorkers";
            this.AddWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.AddWorkers.Size = new System.Drawing.Size(795, 425);
            this.AddWorkers.TabIndex = 2;
            this.AddWorkers.Text = "Add Workers";
            this.AddWorkers.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(348, 34);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(789, 359);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pages);
            this.Name = "Form1";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pages.ResumeLayout(false);
            this.CreateSchedule.ResumeLayout(false);
            this.CreateSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage CreateSchedule;
        private System.Windows.Forms.TabPage EditWorkers;
        private System.Windows.Forms.TabPage AddWorkers;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox textBox1;
    }
}

