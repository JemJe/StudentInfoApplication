using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void submitBtn(object sender, EventArgs e)
        {
            if (StudentIdBox.Text == "" || LastNameBox.Text == "" || FirstNameBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields before submitting.");
                return;
            }

            StudentInfo student = new StudentInfo(StudentIdBox.Text, LastNameBox.Text, FirstNameBox.Text);

            student.StudentId = StudentIdBox.Text;
            student.LastName = LastNameBox.Text;
            student.FirstName = FirstNameBox.Text;

            StudentIdList.Items.Add(student.StudentId);
            LastNameList.Items.Add(student.LastName);
            FirstNameList.Items.Add(student.FirstName);
        }
    }
}

namespace StudentNamespace
{
    public class StudentInfo
    {
        public string StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public StudentInfo()
        {

        }
        public StudentInfo(string studentId, string lastName, string firstName)
        {
            this.StudentId = studentId;
            this.LastName = lastName;
            this.FirstName = firstName;
        }
    }
}
