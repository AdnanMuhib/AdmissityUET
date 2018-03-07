using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class StudentApplication
    {
        public const int MAX_PREFS = 3;
        public static int ARN = 0;
        public int app_ref_number { get; set; }
        public string student_name { get; set; }
        public string std_father_name { get; set; }
        public string std_email { get; set; }
        public string std_phone_number { get; set; }
        public string std_id_card { get; set; }
        //public int Matric_total_marks { get; set; }
        public int Matric_got_marks { get; set; }
        //public int FSC_total_marks { get; set; }
        public int FSC_got_marks { get; set; }
        public int ECAT_got_marks { get; set; }
        //public int GAT_total_marks { get; set; }
        public int GAT_got_marks { get; set; }
        public double aggregate { get; set; }
        public List<Preference> preferences { get; set; }

        public StudentApplication()
        {
            // each time new student added a new ARN is generated
            ARN = ARN + 1;
            app_ref_number = ARN;
            student_name = "";
            std_father_name = "";
            std_email = "";
            std_phone_number = "";
            std_id_card = "";
            // Matric_total_marks = 0;
            Matric_got_marks = 0;
            //FSC_total_marks = 0;
            FSC_got_marks = 0;
            ECAT_got_marks = 0;
            //GAT_total_marks = 0;
            GAT_got_marks = 0;
            aggregate = 0.0;
            preferences = new List<Preference>();
        }
        public StudentApplication(int arn, string name, string father, string email, double agre)
        {
            ARN = arn;
            student_name = name;
            std_father_name = father;
            std_email = email;
            aggregate = agre;
        }

        public void PrintReceipt()
        {
            // code to print the receipt
        }

        public bool AddPreference(Preference pref)
        {
            foreach(Preference p in preferences)
            {
                // check if preference is not already added
                if (p.pref_dept_name.Equals(pref.pref_dept_name))
                {
                    return false;
                }
                // check if three preferences are already added
                if(preferences.Count >= MAX_PREFS)
                {
                    return false;
                }
            }
            // Add to the list of preferences
            preferences.Add(pref);
            // return the success status
            return true;
        }
    }
}
