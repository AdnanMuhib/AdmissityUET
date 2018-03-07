using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class Department
    {
        [DisplayName("ID")]
        public int dept_id { get; set; }
        // name of the department
        [DisplayName("Department Name")]
        public string dept_name { get; set; }
        // available seats quota for the department
        [DisplayName("Seats Quota")]
        public int dept_seats_quota { get; set; }
        
        public Department(int id,string name, int quota)
        {
            dept_id = id;
            dept_name = name;
            dept_seats_quota = quota;
        }
    }
}
