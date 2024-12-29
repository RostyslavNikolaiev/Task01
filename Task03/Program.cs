using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03Nikolaiev
{
    internal static class Program
    {
        static Program() => DesignMode = true;
        public static bool DesignMode { get; set; }
        [STAThread]
        static void Main()
        {
            DesignMode = false;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}