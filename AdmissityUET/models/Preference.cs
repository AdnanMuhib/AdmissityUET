using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class Preference
    {
        public int pref_id { get; set; }
        public string pref_dept_name { get; set; }
        // first, second or third
        public string pref_number { get; set; }
    }
}
