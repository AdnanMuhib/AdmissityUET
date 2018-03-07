using AdmissityUET.forms;
using AdmissityUET.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissityUET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            APPLICATION a = new APPLICATION();
            //Application.Run(new LoginForm());
            Application.Run(new MainForm());
        }
    }
}
