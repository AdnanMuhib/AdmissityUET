using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class APPLICATION
    {
        public static List<StudentApplication> applications { get; set; }
        public static List<Department> departments { get; set; }
        public static List<SelectedStudent> selectedStudents{ get; set; }
        
        // Add Student Application if it is not already added into the database
        public bool AddStudentApplication(StudentApplication app)
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
    }
}
