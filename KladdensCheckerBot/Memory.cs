using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Försök_till_egen_Bot
{
    class Memory
    {
        #region API's and Const's
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hObject);

        public const uint PROCESS_ALL_ACCESS = 0x1F0FFF;
        public const uint PROCESS_VM_READ = 0x0010;
        public const uint PROCESS_VM_WRITE = 0x0020;
        public const uint PROCESS_VM_OPERATION = 0x0008;
        #endregion

        public static byte[] ReadBytes(IntPtr handle, long address, uint bytesToRead)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[bytesToRead];

            ReadProcessMemory(handle, new IntPtr(address), buffer, bytesToRead, out ptrBytesRead);

            return buffer;
        }

        public static int ReadInt(IntPtr handle, long address)
        {
            return BitConverter.ToInt32(ReadBytes(handle, address, 4), 0);
        }
    }
}