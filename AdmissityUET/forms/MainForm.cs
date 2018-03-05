using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissityUET.forms
{
    public partial class MainForm : Form
    {
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
        public MainForm()
        {
            InitializeComponent();
            personalInfoPanel.BringToFront();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
        }

        private void btnMoveToEduPanel_Click(object sender, EventArgs e)
        {
            educationalInfoPanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personalInfoPanel.BringToFront();
        }

        private void btnMoveToPrefListPanel_Click(object sender, EventArgs e)
        {
            panelPreferenceList.BringToFront();
        }

        private void btnBackToEducationalInfo_Click(object sender, EventArgs e)
        {
            educationalInfoPanel.BringToFront();
        }

        private void btnSubmitApplication_Click(object sender, EventArgs e)
        {
            // Do Something to Submit the Application
            Console.WriteLine("Application Submitted");
        }

        private void btnAddPreference_Click(object sender, EventArgs e)
        {

        }
    }
}
