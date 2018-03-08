using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text.pdf;
using System.Net.Mail;
using System.Net;
using iTextSharp.text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf.draw;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

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

            AddDummyData();
        }
        private void AddDummyData()
        {
            // Add Dummy Department
            Department a = new Department(1,"Computer Science", 5);
            Department b = new Department(2,"Computer Engineering", 5);
            Department c = new Department(3,"Electrical", 5);
            Department d = new Department(4,"CIVIL", 5);
            departments.Add(a);
            departments.Add(b);
            departments.Add(c);
            departments.Add(d);
            // Add Dummy Applications
            StudentApplication sa1 = new StudentApplication(1, "Muhammad Adnan","Hafiz Mohib Ali","adnan.muhib@rocketmail.com", 73.95);
            List<Preference> PList1 = new List<Preference>();
            PList1.Add(new Preference("Computer Science", "First"));
            PList1.Add(new Preference("Computer Engineering", "Second"));
            PList1.Add(new Preference("Electrical Engineering", "Third"));
            sa1.preferences = PList1;
            applications.Add(sa1);

            StudentApplication sa2 = new StudentApplication(2, "Saqib Ameen", "Muhammad Ameen", "mrsaqibameen@gmail.com", 90);
            List<Preference> PList2 = new List<Preference>();
            PList2.Add(new Preference("Computer Engineering", "First"));
            PList2.Add(new Preference("Computer Science", "Second"));
            PList2.Add(new Preference("Electrical Engineering", "Third"));
            sa2.preferences = PList2;
            applications.Add(sa2);

            StudentApplication sa3 = new StudentApplication(3, "Muhammad Ramzan", "Nawab Ali", "ramzan595@yahoo.com", 74.344);
            List<Preference> PList3 = new List<Preference>();
            PList3.Add(new Preference("Computer Science", "First"));
            PList3.Add(new Preference("Computer Engineering", "Second"));
            PList3.Add(new Preference("Electrical Engineering", "Third"));
            sa3.preferences = PList3;
            applications.Add(sa3);

            StudentApplication sa4 = new StudentApplication(4, "Aurangzaib Sial", "Muhammad Nawaz", "aurangzaib786@gmail.com", 72.95);
            List<Preference> PList4 = new List<Preference>();
            PList1.Add(new Preference("Electrical Engineering", "First"));
            PList1.Add(new Preference("Computer Engineering", "Second"));
            PList4.Add(new Preference("Computer Science", "Third"));
            
            
            sa4.preferences = PList4;
            applications.Add(sa4);
            //StudentApplication sa5 = new StudentApplication(1, "Adnan", "Hafiz Mohib Ali", "adnan.muhib@rocketmail.com", 73.95);
            //StudentApplication sa6 = new StudentApplication(1, "Adnan", "Hafiz Mohib Ali", "adnan.muhib@rocketmail.com", 73.95);
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

        public static bool AddDepartment(Department dpt)
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

        public static bool AddSelectedStudent(SelectedStudent std)
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
        public static void GenerateMeritList()
        {
            
            // Sorting Students Applications On the Basis of Merit
            List<StudentApplication> ApplicationsSortedList = APPLICATION.applications.OrderByDescending(o => o.aggregate).ToList();
            // go through all student applications
            foreach (StudentApplication app in ApplicationsSortedList)
            {
                // go through the selectd preferences of the student 
                // if not selected in first preference
                foreach(Preference p in app.preferences)
                {
                    // get the Department object to check the seats quota
                    Department d = departments.Single(o => o.dept_name.Equals(p.pref_dept_name));
                    if (d.dept_seats_quota != 0)
                    {
                        // create new object of selected Student to add in the list
                        SelectedStudent selected = new SelectedStudent();
                        selected.ARN = app.app_ref_number;
                        selected.email_id = app.std_email;
                        selected.father_name = app.std_father_name;
                        selected.name = app.student_name;
                        selected.aggregate = app.aggregate;
                        selected.department = p.pref_dept_name;
                        // add student to the list of selected students
                        selectedStudents.Add(selected);
                        // change the remaining seats in the departments
                        foreach(Department dpt in departments)
                        {
                            if (dpt.dept_name.Equals(d.dept_name))
                            {
                                dpt.dept_seats_quota = dpt.dept_seats_quota - 1;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        // Customized Email to the selected students 
        public static  void EmailSelectedStudents()
        {
            //email("adnan.muhib@rocketmail.com", "Adnan");
            // Send Email to all selected students 
            foreach (SelectedStudent std in selectedStudents)
            {
                email(std.email_id,std.name);
            }
        }
        private static void email(string email, string name)
        {
            // email template to send email
            string toaddr = email;
            MailMessage msg = new MailMessage();
            msg.Subject = "Congratulations!! Admission in UET";
            msg.From = new MailAddress(AdmissityUET.Properties.Resources.senderEmail);
            msg.Body = "Dear " + name + ", It is to inform you that you have been shortlisted for Admission in Most Prestigious University of Pakistan, submit your fee to confirm your seat before the due date.";
            msg.To.Add(new MailAddress(toaddr));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential(AdmissityUET.Properties.Resources.senderEmail,
                                                         AdmissityUET.Properties.Resources.senderEmailPassword);
            smtp.Credentials = nc;
            smtp.Send(msg);
        }
        // Customized Email to Non selected Students
        public void EmailNonSelectedStudents()
        {
            // logic to send email 
        }
        // print the merit list on a pdf
        public static bool PrintMeritList()
        {
            if(selectedStudents.Count <= 0)
            {
                return false;
            }
            
            // create a new file stream for pdf file
            FileStream fs = new FileStream("Merit_List.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            
            Rectangle pageSize = new Rectangle(PageSize.A4);
            
            pageSize.BackgroundColor = new BaseColor(System.Drawing.Color.DeepSkyBlue);
            // new document with above page size
            Document doc = new Document(pageSize, 36, 72, 72, 36);
            // pdf writer for the doc and fs
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            // open Doc
            doc.Open();
            // Prepare logo for Display
            string LOGO = "C:\\Users\\Antivirus\\Documents\\Visual Studio 2015\\Projects\\AdmissityUET\\AdmissityUET\\img\\logo.png";
            //string LOGO = Properties.Resources.logo.ToString();
            Image pic = Image.GetInstance(LOGO);
            pic.SpacingBefore = 1f;
            pic.SpacingAfter = 1f;
            pic.Alignment = Element.ALIGN_LEFT;
            pic.SetAbsolutePosition(10f, 10f);
            pic.ScaleAbsoluteHeight(50f);
            pic.ScaleAbsoluteWidth(50f);           
            // create new table with two columns for header
            PdfPTable headTable = new PdfPTable(4);
            headTable.WidthPercentage = 100;
            headTable.DefaultCell.Border = Rectangle.NO_BORDER;
            // create new cell for the logo
            PdfPCell logoCell = new PdfPCell();
            logoCell.Border = 0;
            logoCell.PaddingTop = 5f;
            logoCell.MinimumHeight= 80f;
            
            // add logo picture in the cell
            logoCell.AddElement(pic);
            // add logo cell in the table 
            headTable.AddCell(logoCell);
            
            // create new heading for the PDF
            Paragraph para = new Paragraph();
            para.Add("Merit List UET");
            var titleFont = FontFactory.GetFont("Courier", 23, BaseColor.BLACK);
            para.Font = titleFont;
            para.Alignment = Element.ALIGN_MIDDLE;
            // create new cell for the Heading 
            PdfPCell titleCell = new PdfPCell();
            titleCell.Border = 0;
            titleCell.MinimumHeight = 80f;
            titleCell.Colspan = 3;
            titleCell.HorizontalAlignment = 1;
            titleCell.Padding = 10f;
            // add heading inside the title cell of table
            titleCell.AddElement(para);
            // add heading title inside the table
            headTable.AddCell(titleCell);
            // add table inside the document
            doc.Add(headTable);

            // Add line seperator
            Chunk linebreak = new Chunk(new LineSeparator(1f, 100f, BaseColor.GREEN, Element.ALIGN_CENTER, -1));
            doc.Add(linebreak);

            // Add list of Selected Students in the table
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.PaddingTop = 150f;
            PdfPCell cell = new PdfPCell(new Phrase("Admitted Students"));

            cell.Colspan = 5;

            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right

            table.AddCell(cell);

            table.AddCell("ARN");

            table.AddCell("Name");

            table.AddCell("Father Name");

            table.AddCell("Aggregate");

            table.AddCell("Department");
            foreach(SelectedStudent std in selectedStudents)
            {
                table.AddCell(std.ARN.ToString());
                table.AddCell(std.name);
                table.AddCell(std.father_name);
                table.AddCell(std.aggregate.ToString());
                table.AddCell(std.department);
            }
            /*foreach (StudentApplication std in applications)
            {
                table.AddCell(std.app_ref_number.ToString());
                table.AddCell(std.student_name);
                table.AddCell(std.std_father_name);
                table.AddCell(std.aggregate.ToString());
                table.AddCell(std.std_phone_number);
            }*/
            doc.Add(table);
            doc.Close();
            writer.Close();
            fs.Close();
            printPDFWithAcrobat();
            return true;
        }
        // Show Print Dialogue Box
        public static void printPDFWithAcrobat()
        {
            string Filepath = @"Merit_List.pdf";

            using (PrintDialog Dialog = new PrintDialog())
            {
                Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }
            }
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
