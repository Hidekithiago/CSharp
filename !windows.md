## <a href="https://github.com/Hidekithiago/Automacao/blob/master/README.md">Windows</a> <br>
<details>
<details><summary><b>Execute Program</b></summary>
  
####  NuGet
  > 
  
####  import
  > 
  
####  Code  
  > System.Diagnostics.Process.Start("PathToExe.exe");
  
</details>
<details><summary><b>Execute Python</b></summary>
  
####  NuGet
  > 
  
####  import
  > 
  
####  Code  
  > Process p = new Process();
  ><br>ProcessStartInfo start = new ProcessStartInfo();
  ><br>start.UseShellExecute = false;                
  ><br>start.RedirectStandardError = true; //Pega saída de erros
  ><br>start.RedirectStandardOutput = true; //Pega a saída        
  ><br>start.FileName = @"C:\Users\suporte\AppData\Local\Programs\Python\Python38\python.exe";
  ><br>const string quote = "\"";
  ><br>start.Arguments = @"C:\quaestum\robos\leituraPDF.py "+ quote + dir + quote;
  ><br>Console.WriteLine(@"C:\quaestum\robos\leituraPDF.py "+ quote + dir + quote);
  ><br>using ( p = Process.Start(start))
  ><br>{
  ><br>using (StreamReader reader = p.StandardOutput)
  ><br>{
  ><br>string result = reader.ReadToEnd();
  ><br>Console.Write(result);
  ><br>}
  ><br>}
  
</details>
<details><summary><b>Execute Program and Wait answer</b></summary>
  
####  NuGet
  > 
  
####  import
  > 
  
####  Code  
  > Process p = new Process(); 
 ><br>p.StartInfo.UseShellExecute = false;
 ><br>p.StartInfo.RedirectStandardOutput = true;
 ><br>p.StartInfo.Arguments = "/c echo Foo && echo Bar";
 ><br>p.StartInfo.FileName = "YOURBATCHFILE.bat";
 ><br>p.Start(); 
 ><br>string output = p.StandardOutput.ReadToEnd();
 ><br>p.WaitForExit();
  
</details>

<details><summary><b>Taskkill</b></summary>
  
####  NuGet
  > 
  
####  import
  > using System.Diagnostics;
  
####  Code  
  > Process.Start("taskkill", "/F /IM [taskname].exe");
  
</details>

</details>
