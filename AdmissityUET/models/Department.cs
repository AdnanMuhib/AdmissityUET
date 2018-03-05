using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class Department
    {
        public int dept_id { get; set; }
        // name of the department
        public string dept_name { get; set; }
        // available seats quota for the department
        public int dept_seats_quota { get; set; }
        
        public Department(string name, int quota)
        {
            dept_name = name;
            dept_seats_quota = quota;
        }
    }
}
