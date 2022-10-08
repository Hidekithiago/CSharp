## <a href="https://github.com/Hidekithiago/Automacao/blob/master/README.md">Mouse/Keyboard</a> <br>
<details>
<details><summary><b>Move mouse and Click</b></summary>
  
####  NuGet
  > 
  
####  import
  >//This is a replacement for Cursor.Position in WinForms
><br>        [System.Runtime.InteropServices.DllImport("user32.dll")]
><br>        static extern bool SetCursorPos(int x, int y);
><br>
><br>        [System.Runtime.InteropServices.DllImport("user32.dll")]
><br>        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
><br>
><br>        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
><br>        public const int MOUSEEVENTF_LEFTUP = 0x04; 
  
####  Code  
  > public static void LeftMouseClick(int xpos, int ypos)
  ><br>      {
  ><br>            SetCursorPos(xpos, ypos);
  ><br>            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
  ><br>            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
  ><br>        }
  
</details>

<details><summary><b>SendKeys</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System.Windows.Forms;
  
####  Code  
  > SendKeys.SendWait("");
  
</details>

</details>
