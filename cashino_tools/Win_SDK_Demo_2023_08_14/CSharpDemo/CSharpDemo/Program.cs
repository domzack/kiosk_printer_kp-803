using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CSharpDemo;

namespace CSharpDemo_vs2008
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
