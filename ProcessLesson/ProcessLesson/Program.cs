using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;

namespace ProcessLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var processesToKill = Process.GetProcessesByName("");

            try
            {
                foreach (var process in processesToKill)
                {
                    Console.WriteLine($"{process.Id} - {process.ProcessName} - {process.SessionId}");
                    Thread.Sleep(1000);
                    process.Kill();
                }
            }
            catch(Win32Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
            }
            Console.ReadLine();
        }
    }
}
