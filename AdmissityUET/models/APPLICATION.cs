using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class APPLICATION
    {
        public static List<StudentApplication> applications = new List<StudentApplication>();
        public static List<Department> departments = new List<Department>();
        public static List<SelectedStudent> selectedStudents = new List<SelectedStudent>();
        
        // Add some dummy data on the application launch
        public APPLICATION()
        {
            Department a = new Department("Computer Science",5);
            Department b = new Department("Computer Engineering", 5);
            Department c = new Department("Electrical", 5);
            Department d = new Department("CIVIL", 5);
            departments.Add(a);
            departments.Add(b);
            departments.Add(c);
            departments.Add(d);
        }

        // Add Student Application if it is not already added into the database
        public static bool AddStudentApplication(StudentApplication app)
        {
            foreach(StudentApplication std in applications)
            {
                // check on the behalf of the Uniquely identified ID Card number
                if (std.std_id_card.Equals(app.std_id_card))
                {
                    return false;
                }
            }
            applications.Add(app);
            // code to insert in the database
            return true;
        }

        public bool AddDepartment(Department dpt)
        {
            // check if the department is not already added 
            foreach (Department d in departments)
            {
                if (d.dept_name.Equals(dpt.dept_name))
                {
                    return false;
                }
            }
            // otherwise add to list of departments
            departments.Add(dpt);
            // code to insert in the database
            //
            return true;
        }

        public bool AddSelectedStudent(SelectedStudent std)
        {
            // check if student is not already selected
            foreach(SelectedStudent s in selectedStudents)
            {
                // check on uniquely identified email address
                if (s.email_id.Equals(std.email_id))
                {
                    return false;
                }
            }
            // otherwise insert in the list of selected students
            selectedStudents.Add(std);
            // Code to insert into  database
            return true;
        }
        // core algorithm to generate the merit list
        public void GenerateMeritList()
        {
            // logic to generate the merit list of student on behalf of different  criteria
        }

        // Customized Email to the selected students 
        public void EmailSelectedStudents()
        {
            // logic to send email
        }
        // Customized Email to Non selected Students
        public void EmailNonSelectedStudents()
        {
            // logic to send email 
        }
        // print the merit list on a pdf
        public bool PrintMeritList()
        {
            if(selectedStudents.Count <= 0)
            {
                return false;
            }
            return true;
        }
        // Verify the Login Credentials
        public static bool VerifyOperator(Operator op)
        {
            // code to match the credentials from the database 
            if(op.operator_user_name.Equals("admin") && op.operator_password.Equals("admin"))
            {
                return true;
            }
            // if not matched
            return false;
        }
    }
}
