using System.Data.SqlClient;

namespace LundUniversity.MvcDemo
{
    public partial class FormEmployee : Form
    {
        private readonly DataAccessLayer _layer;
        public FormEmployee()
        {
            _layer = new();
            InitializeComponent();
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmployeeId.Text;
            string empName = textBoxEmployeeName.Text;
            string empSalaryString = textBoxEmployeeSalary.Text;
            string deptName = textBoxEmployeeDepartmentName.Text;

            try
            {
                int empSalary = Int32.Parse(empSalaryString);

                _layer.InsertEmployee(empId, empName, empSalary, deptName);

                labelUserMessage.Text = "Employee added";
                labelUserMessage.ForeColor = Color.Black;
                labelUserMessage.Visible = true;

            } catch(FormatException ex)
            {
                labelUserMessage.Text = "Salary cannot contain letters or special characters";
                labelUserMessage.ForeColor = Color.Red;
                labelUserMessage.Visible = true;
            } catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    labelUserMessage.Text = "An Employee with that ID already exists";
                    labelUserMessage.ForeColor = Color.Red;
                    labelUserMessage.Visible = true;
                } else
                {
                    labelUserMessage.Text = "System Error. Please try again. If the error persists, contact IT";
                    labelUserMessage.ForeColor = Color.Red;
                    labelUserMessage.Visible = true;
                }
            }
        }
    }
}