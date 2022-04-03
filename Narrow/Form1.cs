using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narrow
{
    public partial class Form1 : Form
    {

        [DllImport("User32")]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        int MOUSEEVENTF_LEFTDOWN = 0x0002;
        int MOUSEEVENTF_LEFTUP = 0x0004;
        int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        int MOUSEEVENTF_RIGHTUP = 0x0010;

        int VK_LBUTTON = 0x01;
        int VK_RBUTTON = 0x02;

        Random RM_L;
        Random RM_R;

        private NativeTabControl NativeTabControl1;
        private class NativeTabControl : NativeWindow
        {

            protected override void WndProc(ref Message m)
            {
                if ((m.Msg == TCM_ADJUSTRECT))
                {
                    RECT rc = (RECT)m.GetLParam(typeof(RECT));
                    //Adjust these values to suit, dependant upon Appearance
                    rc.Left -= 4;
                    rc.Right += 4;
                    rc.Top -= 4;
                    rc.Bottom += 4;
                    Marshal.StructureToPtr(rc, m.LParam, true);
                }
                base.WndProc(ref m);
            }

            private const Int32 TCM_FIRST = 0x1300;
            private const Int32 TCM_ADJUSTRECT = (TCM_FIRST + 40);
            private struct RECT
            {
                public Int32 Left;
                public Int32 Top;
                public Int32 Right;
                public Int32 Bottom;
            }

        }

        public Form1()
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));

            NativeTabControl1 = new NativeTabControl();
            NativeTabControl1.AssignHandle(TabBox.Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RM_L = new Random();
            RM_R = new Random();
            KeyBind.LeftCheckBox = CheckBox_LClick;
            KeyBind.RightCheckBox = CheckBox_RClick;
            KeyBind.LeftLabel = label_LKeyBind;
            KeyBind.RightLabel = label_RKeyBind;
            KeyBind.Hook_Start();

        }

        
        public bool KeyDown(int keyint)
        {
            return (GetAsyncKeyState(keyint) & 0x8000) != 0;
        }
        
        private void pic_exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel_Title_Move_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0XA1, 2, 0);
        }

        //最小化
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf020, 0);
        }


        //点击后自毁 删除程序  退出
        private void btn_Destruct_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/C ping 127.0.0.1 -n 2 -w 1000 & Del " + GetType().Assembly.Location);
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.CreateNoWindow = true;
            Process.Start(psi);
            Application.Exit();
        }

        //L Min 拖动条拖动事件
        private void Trackbar_CPS_LMin_Scroll(object sender, EventArgs e)
        {
            TrackBar Cps_LMin = (TrackBar)sender;
            if(Cps_LMin.Value > Trackbar_CPS_LMax.Value)
            {
                Cps_LMin.Value = Trackbar_CPS_LMax.Value;
            }
            label_Lmin_CPS.Text = Cps_LMin.Value.ToString();
        }

        private void Trackbar_CPS_LMax_Scroll(object sender, EventArgs e)
        {
            TrackBar Cps_LMax = (TrackBar)sender;
            if (Cps_LMax.Value < Trackbar_CPS_LMin.Value)
            {
                Trackbar_CPS_LMin.Value = Cps_LMax.Value;
            }
            label_Lmin_CPS.Text = Trackbar_CPS_LMin.Value.ToString();
            label_Lmax_CPS.Text = Cps_LMax.Value.ToString();
        }

        private void Trackbar_CPS_RMin_Scroll(object sender, EventArgs e)
        {
            TrackBar Cps_RMin = (TrackBar)sender;
            if(Cps_RMin.Value > Trackbar_CPS_RMax.Value)
            {
                Cps_RMin.Value = Trackbar_CPS_RMax.Value;
            }
            label_Rmin_CPS.Text = Cps_RMin.Value.ToString();
        }

        private void Trackbar_CPS_RMax_Scroll(object sender, EventArgs e)
        {
            TrackBar Cps_RMax = (TrackBar)sender;
            if(Cps_RMax.Value < Trackbar_CPS_RMin.Value)
            {
                Trackbar_CPS_RMin.Value = Cps_RMax.Value;
            }
            label_Rmin_CPS.Text = Trackbar_CPS_RMin.Value.ToString();
            label_Rmax_CPS.Text = Cps_RMax.Value.ToString();
        }

        private void TimerL_CPS_Tick(object sender, EventArgs e)
        {
            if (CheckBox_LClick.Checked && KeyDown(VK_LBUTTON))
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                if(CheckBox_BlockHit.Checked && KeyDown(VK_RBUTTON))
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                }
                int sleep_time = RM_L.Next(Trackbar_CPS_LMin.Value, Trackbar_CPS_LMax.Value);
                Thread.Sleep(1000 / sleep_time);
            }
        }

        private void TimerR_CPS_Tick(object sender, EventArgs e)
        {
            if (CheckBox_LClick.Checked && CheckBox_BlockHit.Checked && KeyDown(VK_LBUTTON))
            {
                return;
            }
            if (CheckBox_RClick.Checked && KeyDown(VK_RBUTTON))
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                int sleep_time = RM_R.Next(Trackbar_CPS_RMin.Value, Trackbar_CPS_RMax.Value);
                Thread.Sleep(1000 / sleep_time);
            }
        }

        private void label_LKeyBind_Click(object sender, EventArgs e)
        {
            ((Label)sender).Text = "Select a key";
            KeyBind.SetLKeyBind = true;
        }

        private void label_RKeyBind_Click(object sender, EventArgs e)
        {
            ((Label)sender).Text = "Select a key";
            KeyBind.SetRKeyBind = true;
        }

        private void GB_Clicker_Paint(object sender, PaintEventArgs e)
        {
            GroupBox TestGroupBox = (GroupBox)sender;
            e.Graphics.Clear(TestGroupBox.BackColor);
            e.Graphics.DrawString(TestGroupBox.Text, TestGroupBox.Font, Brushes.Salmon, 10, 1);
            e.Graphics.DrawLine(Pens.Salmon, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Salmon, 90, 7, TestGroupBox.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Salmon, 1, 7, 1, TestGroupBox.Height - 2);
            e.Graphics.DrawLine(Pens.Salmon, 1, TestGroupBox.Height - 2, TestGroupBox.Width - 2, TestGroupBox.Height - 2);
            e.Graphics.DrawLine(Pens.Salmon, TestGroupBox.Width - 2, 7, TestGroupBox.Width - 2, TestGroupBox.Height - 2);

        }

    }
}
