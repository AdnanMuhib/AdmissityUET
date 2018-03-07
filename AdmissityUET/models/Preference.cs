using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class Preference
    {
        [DisplayName("ID")]
        public int pref_id { get; set; }
        [DisplayName("Department Name")]
        public string pref_dept_name { get; set; }
        // first, second or third
        [DisplayName("Preference")]
        public string pref_number { get; set; }

        public Preference(string name, string pref)
        {
            pref_dept_name = name;
            pref_number = pref;
        }
        public Preference()
        {

        }
    }
}
