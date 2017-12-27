using System;
using System.Runtime.InteropServices;

namespace InjectionLibraryDemo
{
    class Program
    {
        [DllImport("InjectedLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int magic();

        static void Main()
        {
            var a = 10;
            if (!(a <= 0))
            {
            }

            Console.WriteLine(magic());
        }
    }
}
