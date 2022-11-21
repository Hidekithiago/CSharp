using System;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;
using Winium.Cruciatus;
using Winium.Cruciatus.Core;
using Winium.Cruciatus.Extensions;

namespace exemploWinium
{
    internal class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;


        static void Main(string[] args)
        {

            (int x, int y) = GetPosition();
            MouseClick(x, y);
        }

        public void Calculadora()
        {
            var calc = new Winium.Cruciatus.Application("C:/windows/system32/calc.exe");
            calc.Start();

            var winFinder = By.Name("Calculadora").AndType(ControlType.Window);
            var win = Winium.Cruciatus.CruciatusFactory.Root.FindElement(winFinder);

            win.FindElementByUid("num6Button").Click();
            win.FindElementByUid("plusButton").Click();
            win.FindElementByUid("num4Button").Click();
            win.FindElementByUid("equalButton").Click();
        }

        public void MoveMouseClick()
        {

        }

        public static (int, int) GetPosition()
        {
            Thread.Sleep(5000);
            return (Cursor.Position.X, Cursor.Position.Y);
        }

        public static void MouseClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

    }
}
