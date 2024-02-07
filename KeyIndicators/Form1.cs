using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyIndicators
{
    public partial class AppKeys : Form
    {
        private const int WhKeyboardLl = 13;
        private const int WmKeyup = 0x0101;

        private IntPtr _hookId = IntPtr.Zero;
        private LowLevelKeyboardProc keyboardProc;

        private readonly Image _buttonOffImage;
        private readonly Image _buttonOnImage;
        public AppKeys()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height);
            _buttonOnImage = Properties.Resources.Button_On;
            _buttonOffImage = Properties.Resources.Button_Off;

            CheckLockedKey(Keys.NumLock, NumLockImage);
            CheckLockedKey(Keys.Scroll, ScrollLockImage);
            CheckLockedKey(Keys.CapsLock, CapsLockImage);
            TopMost = true;
            Hide();

            // Set up the global keyboard hook
            keyboardProc = HookCallback;
            _hookId = SetHook(keyboardProc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckLockedKey(Keys key, PictureBox imageBox)
        {
            if (Control.IsKeyLocked(key))
            {
                imageBox.Image = _buttonOnImage;
            }
            else
            {
                imageBox.Image = _buttonOffImage;
            }
        }

        private void ButtonOn(PictureBox imageBox)
        {
            imageBox.Image = _buttonOnImage;
        }

        private void ButtonOff(PictureBox imageBox)
        {
            imageBox.Image = _buttonOffImage;
        }


        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = Properties.Resources.Exit_Off;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = Properties.Resources.Exit_On;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MinButton_MouseEnter(object sender, EventArgs e)
        {
            MinButton.BackgroundImage = Properties.Resources.Minimise_On;
        }

        private void MinButton_MouseLeave(object sender, EventArgs e)
        {
            MinButton.BackgroundImage = Properties.Resources.Minimise_Off;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            TopMost = false;
            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon.Visible = true;
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WhKeyboardLl, proc, GetModuleHandle(curModule?.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WmKeyup))
            {
                int vkCode = Marshal.ReadInt32(lParam);

                bool isNumLockOn = (GetKeyState((int)Keys.NumLock) & 0x0001) != 0;
                bool isCapsLockOn = (GetKeyState((int)Keys.CapsLock) & 0x0001) != 0;
                bool isScrollLockOn = (GetKeyState((int)Keys.Scroll) & 0x0001) != 0;

                if (wParam == (IntPtr)WmKeyup)
                {
                    // Handle the key up event
                    switch ((Keys)vkCode)
                    {
                        case Keys.NumLock:
                            if (isNumLockOn)
                            {
                                ButtonOn(NumLockImage);
                            }
                            else
                            {
                                ButtonOff(NumLockImage);
                            }
                            break;
                        case Keys.CapsLock:
                            if (isCapsLockOn)
                            {
                                ButtonOn(CapsLockImage);
                            }
                            else
                            {
                                ButtonOff(CapsLockImage);
                            }
                            break;
                        case Keys.Scroll:
                            if (isScrollLockOn)
                            {
                                ButtonOn(ScrollLockImage);
                            }
                            else
                            {
                                ButtonOff(ScrollLockImage);
                            }
                            break;
                    }
                }
            }

            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Unhook the keyboard hook when the form is closing
            UnhookWindowsHookEx(_hookId);
            base.OnFormClosing(e);
        }

        private void AppKeys_Activated(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        #region P/Invoke declarations

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetKeyState(int keyCode);


        #endregion

        
    }
}
