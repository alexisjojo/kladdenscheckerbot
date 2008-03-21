using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Försök_till_egen_Bot
{
    class Client
    {
        private Process Process;
        private IntPtr Hwnd;

        public static IntPtr THwnd;

        public Client(Process p)
        {
            Process = p;
            Hwnd = Memory.OpenProcess(Memory.PROCESS_ALL_ACCESS, 0, (uint)Process.Id);
        }
        ~Client()
        {
            Memory.CloseHandle(Hwnd);
        }
        public static int ReadInt(long Address)
        {
            return Memory.ReadInt(THwnd, Address);
        }
        public static Process TibiaHwnd()
        {
            Process[] Processes = Process.GetProcessesByName("Tibia");
            THwnd = Processes[0].Handle;
            return Processes[0];
        }
    }
}
