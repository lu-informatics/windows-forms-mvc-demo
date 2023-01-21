namespace LundUniversity.MvcDemo
{
    partial class FormEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeDepartmentName = new System.Windows.Forms.TextBox();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelEmployeeSalary = new System.Windows.Forms.Label();
            this.labelEmployeeDepartmentName = new System.Windows.Forms.Label();
            this.labelUserMessage = new System.Windows.Forms.Label();
            this.buttonEmployeeAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(117, 47);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(128, 23);
            this.textBoxEmployeeId.TabIndex = 0;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(117, 90);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(128, 23);
            this.textBoxEmployeeName.TabIndex = 1;
            // 
            // textBoxEmployeeSalary
            // 
            this.textBoxEmployeeSalary.Location = new System.Drawing.Point(117, 132);
            this.textBoxEmployeeSalary.Name = "textBoxEmployeeSalary";
            this.textBoxEmployeeSalary.Size = new System.Drawing.Size(128, 23);
            this.textBoxEmployeeSalary.TabIndex = 2;
            // 
            // textBoxEmployeeDepartmentName
            // 
            this.textBoxEmployeeDepartmentName.Location = new System.Drawing.Point(117, 174);
            this.textBoxEmployeeDepartmentName.Name = "textBoxEmployeeDepartmentName";
            this.textBoxEmployeeDepartmentName.Size = new System.Drawing.Size(128, 23);
            this.textBoxEmployeeDepartmentName.TabIndex = 3;
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(33, 50);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(18, 15);
            this.labelEmployeeId.TabIndex = 4;
            this.labelEmployeeId.Text = "ID";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(33, 93);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(39, 15);
            this.labelEmployeeName.TabIndex = 5;
            this.labelEmployeeName.Text = "Name";
            // 
            // labelEmployeeSalary
            // 
            this.labelEmployeeSalary.AutoSize = true;
            this.labelEmployeeSalary.Location = new System.Drawing.Point(33, 135);
            this.labelEmployeeSalary.Name = "labelEmployeeSalary";
            this.labelEmployeeSalary.Size = new System.Drawing.Size(38, 15);
            this.labelEmployeeSalary.TabIndex = 6;
            this.labelEmployeeSalary.Text = "Salary";
            // 
            // labelEmployeeDepartmentName
            // 
            this.labelEmployeeDepartmentName.AutoSize = true;
            this.labelEmployeeDepartmentName.Location = new System.Drawing.Point(33, 177);
            this.labelEmployeeDepartmentName.Name = "labelEmployeeDepartmentName";
            this.labelEmployeeDepartmentName.Size = new System.Drawing.Size(70, 15);
            this.labelEmployeeDepartmentName.TabIndex = 7;
            this.labelEmployeeDepartmentName.Text = "Department";
            // 
            // labelUserMessage
            // 
            this.labelUserMessage.AutoSize = true;
            this.labelUserMessage.Location = new System.Drawing.Point(117, 254);
            this.labelUserMessage.Name = "labelUserMessage";
            this.labelUserMessage.Size = new System.Drawing.Size(53, 15);
            this.labelUserMessage.TabIndex = 8;
            this.labelUserMessage.Text = "message";
            this.labelUserMessage.Visible = false;
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.Location = new System.Drawing.Point(117, 217);
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.Size = new System.Drawing.Size(111, 23);
            this.buttonEmployeeAdd.TabIndex = 9;
            this.buttonEmployeeAdd.Text = "Add Employee";
            this.buttonEmployeeAdd.UseVisualStyleBackColor = true;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonEmployeeAdd_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 314);
            this.Controls.Add(this.buttonEmployeeAdd);
            this.Controls.Add(this.labelUserMessage);
            this.Controls.Add(this.labelEmployeeDepartmentName);
            this.Controls.Add(this.labelEmployeeSalary);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.labelEmployeeId);
            this.Controls.Add(this.textBoxEmployeeDepartmentName);
            this.Controls.Add(this.textBoxEmployeeSalary);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Name = "FormEmployee";
            this.Text = "Employee Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEmployeeId;
        private TextBox textBoxEmployeeName;
        private TextBox textBoxEmployeeSalary;
        private TextBox textBoxEmployeeDepartmentName;
        private Label labelEmployeeId;
        private Label labelEmployeeName;
        private Label labelEmployeeSalary;
        private Label labelEmployeeDepartmentName;
        private Label labelUserMessage;
        private Button buttonEmployeeAdd;
    }
}