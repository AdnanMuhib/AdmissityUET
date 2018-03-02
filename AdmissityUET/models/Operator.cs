using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissityUET.models
{
    class Operator
    {
        public int operator_id { get; set; }
        public string  operator_user_name { get; set; }
        public string operator_email { get; set; }
        public string operator_password { get; set; }


        public Operator(string user_name, string email, string password)
        {
            this.operator_user_name = user_name;
            this.operator_email = email;
            this.operator_password = password;
        }
    }
}
