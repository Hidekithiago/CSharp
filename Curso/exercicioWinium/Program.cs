using System;
using System.IO;

using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace exercicioWinium
{
    class Program
    {
        // Adicionando as variaveis do mouse
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, UIntPtr dwExtraInfo);
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        public static string dirPrint = null;

        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            var (x, y) = GetPosition();//Pega as coordenadas do MOUSE

            MoveMouseClick(30, 166);//Move o mouse para a coordenada e clica com o botao esquerdo do mouse
        }

        private static Boolean ComparatorImage(String urlImg1, String urlImg2)
        {
            string img1_ref, img2_ref;
            Bitmap img1 = new Bitmap(urlImg1);
            Bitmap img2 = new Bitmap(urlImg2);
            var flag = true;
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        img1.Dispose();
                        img2.Dispose();
                        break;
                    }
                }
            }
            else { flag = false; }
            img1.Dispose(); img2.Dispose();

            return flag;
        }

        private static void PrintScreen(int xInicio, int yInicio, int xFim, int yFim, int xTam, int yTam)
        {
            try { File.Delete(dirPrint); } catch (Exception e) { }
            Bitmap printscreen = new Bitmap(xTam, yTam);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(xInicio, yInicio, xFim, yFim, printscreen.Size); //Copia a imagem da tela
            printscreen.Save(dirPrint, ImageFormat.Jpeg); //Salva a captura de tela
            printscreen.Dispose();
        }

        public static void MoveMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, new UIntPtr());
        }

        public static void MoveMouse(int xpos, int ypos) { SetCursorPos(xpos, ypos); }

        public static (string, string) GetPosition() { return (Cursor.Position.X.ToString(), Cursor.Position.Y.ToString()); }

    }
}
