using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardOfLegends
{

    class HookKeys
    {
        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern Point GetCursorPos();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        // ... { GLOBAL HOOK }
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13; 
        const int WM_KEYDOWN = 0x100; 
        const int WM_KEYUP = 0x101; 

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static bool HookDisabled;

        public static Point CursorBeforMove;

        static void SaveBefore()
        {
            CursorBeforMove = new Point(Cursor.Position.X, Cursor.Position.Y);
        }

        public static void RightMouseClick(int xpos, int ypos)
        {
            int xBefore = Cursor.Position.X;
            int yBefore = Cursor.Position.Y;



            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
            System.Threading.Thread.Sleep(5);
            SetCursorPos(CursorBeforMove.X, CursorBeforMove.Y);
            

        }

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
                     

            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
            System.Threading.Thread.Sleep(5);
            SetCursorPos(CursorBeforMove.X, CursorBeforMove.Y);
        }

  

        static bool IsLeftPressed = false;
        static bool IsRightPressed = false;
        static bool IsUpPressed = false;
        static bool IsDownPressed = false;

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            int marge = 200;
            bool Up = wParam == (IntPtr)WM_KEYUP;
            bool Down = wParam == (IntPtr)WM_KEYDOWN;
            if (code >= 0  && (Up || Down) && !HookDisabled)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                int xx = 0;
                int yy = 0;


                if (Down && !(IsLeftPressed || IsRightPressed || IsUpPressed || IsDownPressed))
                {
                    SaveBefore();
                }

                if (vkCode.ToString() == "37" || IsLeftPressed) //gauche                    
                {
                    IsLeftPressed = Down;
                    if (Down) xx -= marge;
                }
                if (vkCode.ToString() == "38" || IsUpPressed) //haut
                {
                    IsUpPressed = Down;
                    if (Down) yy -= marge;
                }
                if (vkCode.ToString() == "39" || IsRightPressed) //droite
                {
                    IsRightPressed = Down;
                    if (Down) xx += marge;
                }
                if (vkCode.ToString() == "40" || IsDownPressed) //bas
                {
                    IsDownPressed = Down;
                    if (Down) yy += marge;
                }

                
                    

                if (xx != 0 || yy != 0)
                {
                    
                    RightMouseClick(Screen.PrimaryScreen.Bounds.Width / 2 - 100  + xx, Screen.PrimaryScreen.Bounds.Height / 2 - 20 + yy);
                    //LeftMouseClick(Screen.PrimaryScreen.Bounds.Width / 2 - 100 + xx, Screen.PrimaryScreen.Bounds.Height / 2 - 20 + yy);
                    
                    return (IntPtr)1;
                }
                
            }            
            return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        public HookKeys()
        {
            SetHook();
        }

        ~HookKeys()
        {
        }

    }
}
