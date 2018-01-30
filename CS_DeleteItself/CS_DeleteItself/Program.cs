using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
//http://www.cnblogs.com/Interkey/p/DeleteItself.html
namespace CS_DeleteItself
{
    class Program
    {

        private static void DeleteItselfByCMD()
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 1000 > Nul & Del " + System.AppDomain.CurrentDomain.BaseDirectory + "\\" + System.AppDomain.CurrentDomain.FriendlyName);//WINFORM 路徑 Application.ExecutablePath
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.CreateNoWindow = true;
            Process.Start(psi);
            //Application.Exit();//WINFORM 自行結束自己 
        } 
        static void pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory + "\\" + System.AppDomain.CurrentDomain.FriendlyName);
            pause();
            DeleteItselfByCMD();
        }
    }
}
