using System;
using System.Windows.Forms;

namespace Bai4._9_Quanlylichhenphongkham
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}