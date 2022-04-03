using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narrow
{
    [StructLayout(LayoutKind.Sequential)]
    public class KeyBoardHookStruct
    {
        public int vkCode;
        public int scanCode;
        public int flags;
        public int time;
        public int dwExtraInfo;
    }//函数声明

    internal class KeyBind
    {
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        public const int WH_KEYBOARD_LL = 13;
        public static int hHook = 0;
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //抽掉钩子  
        public static extern bool UnhookWindowsHookEx(int idHook);
        [DllImport("user32.dll")]
        //调用下一个钩子  
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);
        static HookProc KeyBoardHookProcedure = HookKey;

        public static CheckBox LeftCheckBox;
        public static CheckBox RightCheckBox;

        public static Label LeftLabel;
        public static Label RightLabel;
        
        static Keys LKeyBind_Code = Keys.LControlKey;
        static Keys RKeyBind_Code = Keys.RControlKey;

        static bool LKeyBind_Shift = false;
        static bool RKeyBind_Shift = false;

        static bool LKeyBind_Ctrl = false;
        static bool RKeyBind_Ctrl = false;

        static bool LKeyBind_Alt = false;
        static bool RKeyBind_Alt = false;

        public static bool SetLKeyBind = false;
        public static bool SetRKeyBind = false;

        public static void Hook_Start()
        {
            // 安装键盘钩子  
            if (hHook == 0)
            {
                //KeyBoardHookProcedure = new HookProc(KeyBoardHookProc);
                hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                          KeyBoardHookProcedure,
                        GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName), 0);

                //如果设置钩子失败.  
                if (hHook == 0)
                {
                    Hook_Clear();
                }
            }
        }

        public static void Hook_Clear()
        {
            UnhookWindowsHookEx(hHook);
        }

        static int HookKey(int nCode, int wParam, IntPtr lParam)
        {
            KeyBoardHookStruct callvalue = Marshal.PtrToStructure<KeyBoardHookStruct>(lParam);
            Keys key = (Keys)callvalue.vkCode;
            
            if (key == Keys.LShiftKey || key == Keys.ShiftKey || key == Keys.LControlKey || key == Keys.ControlKey || key == Keys.Alt || key == Keys.LMenu)
            {
                return CallNextHookEx(hHook, nCode, wParam, lParam);
            }

            bool Shift = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;
            bool Ctrl = (Control.ModifierKeys & Keys.Control) == Keys.Control;
            bool Alt = (Control.ModifierKeys & Keys.Alt) == Keys.Alt;

            if (callvalue.flags == 128)
            {
                if(SetLKeyBind)
                {
                    LKeyBind_Code = key;
                    LKeyBind_Shift = Shift;
                    LKeyBind_Ctrl = Ctrl;
                    LKeyBind_Alt = Alt;
                    LeftLabel.Text = "Bind:";
                    LeftLabel.Text += LKeyBind_Shift ? "S" : "";
                    LeftLabel.Text += LKeyBind_Ctrl ? "C" : "";
                    LeftLabel.Text += LKeyBind_Alt ? "A" : "";
                    if(LKeyBind_Shift || LKeyBind_Ctrl || LKeyBind_Alt)
                    {
                        LeftLabel.Text += "+";
                    }
                    LeftLabel.Text += LKeyBind_Code.ToString();
                    SetLKeyBind = false;
                    return CallNextHookEx(hHook, nCode, wParam, lParam);
                }
                if (SetRKeyBind)
                {
                    RKeyBind_Code = key;
                    RKeyBind_Shift = Shift;
                    RKeyBind_Ctrl = Ctrl;
                    RKeyBind_Alt = Alt;
                    RightLabel.Text = "Bind:";
                    RightLabel.Text += LKeyBind_Shift ? "S" : "";
                    RightLabel.Text += LKeyBind_Ctrl ? "C" : "";
                    RightLabel.Text += LKeyBind_Alt ? "A" : "";
                    if (RKeyBind_Shift || RKeyBind_Ctrl || RKeyBind_Alt)
                    {
                        RightLabel.Text += "+";
                    }
                    RightLabel.Text += RKeyBind_Code.ToString();
                    SetRKeyBind = false;
                    return CallNextHookEx(hHook, nCode, wParam, lParam);
                }

                //MessageBox.Show("按刚下了按键 键值:" + callvalue.vkCode);
                if(LKeyBind_Code != Keys.LControlKey)
                {
                    if(key == LKeyBind_Code)
                    {
                        if (LKeyBind_Shift && !Shift)
                        {
                            return CallNextHookEx(hHook, nCode, wParam, lParam);
                        }
                        if (LKeyBind_Ctrl && !Ctrl)
                        {
                            return CallNextHookEx(hHook, nCode, wParam, lParam);
                        }
                        if (LKeyBind_Alt && !Alt)
                        {
                            return CallNextHookEx(hHook, nCode, wParam, lParam);
                        }
                        LeftCheckBox.Checked = !LeftCheckBox.Checked;
                    }
                }

                if (RKeyBind_Code != Keys.RControlKey)
                {
                    if (key == RKeyBind_Code)
                    {
                        if (RKeyBind_Shift && !Shift)
                        {
                            return CallNextHookEx(hHook, nCode, wParam, lParam);
                        }
                        if (RKeyBind_Ctrl && !Ctrl)
                        {
                            return CallNextHookEx(hHook, nCode, wParam, lParam);
                        }
                        if (RKeyBind_Alt && !Alt)
                        {
                            return CallNextHookEx(hHook, nCode, wParam, lParam);
                        }
                        RightCheckBox.Checked = !RightCheckBox.Checked;
                    }
                }
            }
            
            return CallNextHookEx(hHook,nCode, wParam, lParam);
        }
    }
}
