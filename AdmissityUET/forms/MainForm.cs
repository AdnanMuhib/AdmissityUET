using AdmissityUET.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissityUET.forms
{
    public partial class MainForm : Form
    {

        // create Round Corners of Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        // to make the form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // some attributes
        private List<Department> depts { set; get; }
        private List<Preference> prefs { set; get; }
        private const int MATRIC_TOTAL = 1100;
        private const int FSC_TOTAL = 1100;
        private const int ECAT_TOTAL = 400;
        
        // Calculates the Aggrigate
        private double calculateAggrigate(int fsc, int ecat)
        {
            // Formula Logic to calculate the Aggrigate
            double fscSeventyPercentage = (double)fsc / FSC_TOTAL * 100 * 0.7;
            double ecatThirtyPercentage = (double)ecat / ECAT_TOTAL * 100 * 0.3;
            double aggregate = fscSeventyPercentage + ecatThirtyPercentage;
            return aggregate; 
        }

        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panel1.BringToFront();
            // new Binding Source to display in Applications Data Grid
            BindingSource bs = new BindingSource();
            bs.DataSource = APPLICATION.applications;
            dataGridApplications.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "ARN";
            column1.DataPropertyName = "app_ref_number";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Name";
            column2.DataPropertyName = "student_name";
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Father Name";
            column3.DataPropertyName = "std_father_name";
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Aggregate";
            column4.DataPropertyName = "aggregate";

            dataGridApplications.Columns.Add(column1);
            dataGridApplications.Columns.Add(column2);
            dataGridApplications.Columns.Add(column3);
            dataGridApplications.Columns.Add(column4);
            dataGridApplications.DataSource = bs;
            panelApplications.Visible = false;
            // Hiding Extra Row for DataGridViews
            dataGridApplications.AllowUserToAddRows = false;
            dataGridDepartments.AllowUserToAddRows = false;
            dataGridPreferences.AllowUserToAddRows = false;
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            personalInfoPanel.BringToFront();
            panelApplications.Visible = false;
        }

        private void btnMoveToEduPanel_Click(object sender, EventArgs e)
        {
            educationalInfoPanel.BringToFront();
            panelApplications.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personalInfoPanel.BringToFront();
            panelApplications.Visible = false;
        }

        private void btnMoveToPrefListPanel_Click(object sender, EventArgs e)
        {
            dataGridPreferences.DataSource = null;
            // get the list of departments
            depts = APPLICATION.departments;
            // make a string list for dept name only
            List<string> departs = new List<string>();
            // copy every dept name to the list
            foreach(Department d in depts)
            {
                departs.Add(d.dept_name);
            }
            // create a binding source for drop down
            BindingSource bs = new BindingSource();
            bs.DataSource = departs;
            // set binding source to the drop down list departs
            dropDownDepartment.DataSource = bs;

            // create new list to store the preferences 
            prefs = new List<Preference>();
            // Finally bring preference form to front
            panelPreferenceList.BringToFront();
            panelApplications.Visible = false;
        }

        private void btnBackToEducationalInfo_Click(object sender, EventArgs e)
        {
            educationalInfoPanel.BringToFront();
            panelApplications.Visible = false;
        }

        private void btnSubmitApplication_Click(object sender, EventArgs e)
        {
            StudentApplication app = new StudentApplication();
            // check personal Information
            if (txtName.Text.Equals("") ||
                txtFatherName.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                txtPhoneNumber.Text.Equals("") ||
                txtIDCard.Equals(""))
            {
                MessageBox.Show("Personal information Incomplete");
                return;
            }
            try
            {
                MailAddress email = new MailAddress(txtEmail.Text);

            }
            catch
            {
                MessageBox.Show("Email Address is not valid");
            }

            // add Personal Information
            app.student_name = txtName.Text;
            app.std_father_name = txtFatherName.Text;
            app.std_email = txtEmail.Text;
            app.std_phone_number = txtPhoneNumber.Text;
            app.std_id_card = txtIDCard.Text;

            // check Educational Information
            if (numMatricMarks.Value.Equals(0) ||
                numMatricMarks.Value.Equals(0) ||
                numEcatMarks.Value.Equals(0))
            {
                MessageBox.Show("Incomplete Educational Details");
                return;
            }
            // add educational details
            app.Matric_got_marks = Convert.ToInt32(numMatricMarks.Value);
            app.FSC_got_marks = Convert.ToInt32(numFSCMarks.Value);
            app.ECAT_got_marks = Convert.ToInt32(numEcatMarks.Value);
            app.GAT_got_marks = Convert.ToInt32(numGatMarks.Value);
            app.aggregate = calculateAggrigate(app.FSC_got_marks, app.ECAT_got_marks);
            app.app_ref_number = APPLICATION.applications.Count + 1;
            // check Preference List
            if (prefs.Count == 3)
            {
                // Add Preference List
                app.preferences = prefs;
            }
            else
            {
                MessageBox.Show("You Must Add 3 Preferences");
                return;
            }
            // Application Ready.. Now Add into Database
            if (APPLICATION.AddStudentApplication(app))
            {
                MessageBox.Show("Application Submitted Successfully");
                // new Binding Source to display in Applications Data Grid
                BindingSource bs = new BindingSource();
                bs.DataSource = APPLICATION.applications;

                dataGridApplications.DataSource = bs;

                // function call to print the receipt for the Student
                //
                // clear the Filled Text Boxes
                txtName.Text = "";
                txtFatherName.Text = "";
                txtIDCard.Text = "";
                txtPhoneNumber.Text = "";
                txtEmail.Text = "";
                numMatricMarks.Value = 0;
                numFSCMarks.Value = 0;
                numEcatMarks.Value = 0;
                numGatMarks.Value = 0;
                dataGridPreferences.DataSource = null;
                prefs = null;
                personalInfoPanel.BringToFront();
                panelApplications.Visible = false;
            }

            
        }

        private void btnAddPreference_Click(object sender, EventArgs e)
        {
            Preference p = new Preference();
            p.pref_dept_name = dropDownDepartment.SelectedValue.ToString();
            // check if the preference is already selected or not
            foreach (Preference pr in prefs)
            {
                if (p.pref_dept_name.Equals(pr.pref_dept_name))
                {
                    MessageBox.Show("Already Added");
                    return;
                }
            }
            p.pref_id = prefs.Count + 1;
            if(p.pref_id == 1)
            {
                p.pref_number = "First";
            }
            else if (p.pref_id == 2)
            {
                p.pref_number = "Second";
            }
            else if (p.pref_id == 3)
            {
                p.pref_number = "Third";
            }
             // check if three preferences are completed
             if(prefs.Count <3)
            {
                // Add to the Preference List
                prefs.Add(p);
            }
            else
            {
                MessageBox.Show("All Preferences selected");
                return;
            }
            // create biding source 
            BindingSource bs = new BindingSource();
            bs.DataSource = prefs;
            dataGridPreferences.DataSource = bs;
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            // Displaying Departments in the Data Grid View
            BindingSource bs = new BindingSource();
            bs.DataSource = APPLICATION.departments;
            dataGridDepartments.DataSource = bs;
            panelDepartments.BringToFront();
            panelApplications.Visible = false;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if(txtDepartmentName.Text.Equals("") || numDeptSeats.Value.Equals(0))
            {
                MessageBox.Show("Department Name or number of seats is missing");
                return;
            }
            int dept_id = APPLICATION.departments.Count + 1;
            Department d = new Department(dept_id, txtDepartmentName.Text, Convert.ToInt32(numDeptSeats.Value));
            if (APPLICATION.AddDepartment(d)) {
                MessageBox.Show("Department Successfully Added");
                // Displaying Departments in the Data Grid View
                BindingSource bs = new BindingSource();
                bs.DataSource = APPLICATION.departments;
                dataGridDepartments.DataSource = bs;
                txtDepartmentName.Text = "";
                numDeptSeats.Value = 0;
            }
            else
            {
                MessageBox.Show("Department Already Added");
            }
            
        }

        private void btnMeritList_Click(object sender, EventArgs e)
        {
            panelApplications.Visible = true;
            panelApplications.BringToFront();
        }

        private void btnGenerateMeritList_Click(object sender, EventArgs e)
        {
            APPLICATION.GenerateMeritList();
            btnSendEmail.Enabled = true;
            btnPDFPrint.Enabled = true;
            if (APPLICATION.selectedStudents.Count > 0)
            {
                btnPDFPrint.Enabled = true;
                btnSendEmail.Enabled = true;
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            APPLICATION.EmailSelectedStudents();
        }

        private void btnPDFPrint_Click(object sender, EventArgs e)
        {
            APPLICATION.PrintMeritList();
        }
    }
}
