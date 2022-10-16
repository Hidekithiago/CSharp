## <a href="https://github.com/Hidekithiago/CSharp/blob/master/README.md">FILES</a> <br>
<details>
<details><summary><b>DELETE FILE</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System; <br>
   using System.IO; <br>
  
####  Code
  >try <br>
        { <br>
            File.Delete(diretorio);<br>
        } <br>
        catch (Exception e) <br>
        { <br>
            Console.WriteLine("The process failed: {0}", e.ToString()); <br>
        } <br>
  
</details>
<details><summary><b>GetFiles in folder</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  ><br>using System.IO;
  
####  Code
  >private static void getFilesinFolder(String urlPasta, String tipo)
  ><br>      {
  ><br>            try
  ><br>            {                
  ><br>                string[] dirs = Directory.GetFiles(urlPasta, tipo);
  ><br>                Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
  ><br>                foreach (string dir in dirs)
  ><br>                {
  ><br>                    Console.WriteLine(dir);
  ><br>                }
  ><br>            }
  ><br>            catch (Exception e)
  ><br>            {
  ><br>                Console.WriteLine("The process failed: {0}", e.ToString());
  ><br>            }
  ><br>        }
</details>
<details><summary><b>Change folder a file</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  ><br>using System.IO;
  
####  Code
  >private static void ChangeFolder()
  ><br>      {
  ><br>            string sourceFile = @"C:\Users\Public\public\test.txt";
  ><br>            string destinationFile = @"C:\Users\Public\private\test.txt";
  ><br>
  ><br>            // To move a file or folder to a new location:
  ><br>            System.IO.File.Move(sourceFile, destinationFile);
  ><br>
  ><br>            // To move an entire directory. To programmatically modify or combine
  ><br>            // path strings, use the System.IO.Path class.
  ><br>            System.IO.Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");
  ><br>        }
</details>
<details><summary><b>Read file</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  ><br>using System.IO;
  ><br>using System.Text;
  
####  Code
  >public static void readFile(String filePath)
  ><br>      {
  ><br>            string readText = File.ReadAllText(filePath, Encoding.Default);
  ><br>            Console.WriteLine(readText);
  ><br>        }
</details>
<details><summary><b>GET FILE NAME</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  ><br>using System.IO;
  
####  Code
  >private static void GetFileName(){
  ><br>      String filePath = @"C:\quaestum\a.xlsx";
  ><br>          FileInfo fileInfo = new FileInfo(filePath);
  ><br>          System.IO.File.Move(filePath, @"C:\quaestum\robo\" + fileInfo.Name);
  ><br>          Environment.Exit(0);
  ><br>}
</details>
<details><summary><b>Write File</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  ><br>using System.IO;
  
####  Code
  >using (StreamWriter writer = new StreamWriter("C:\\dados\\macoratti.txt", true))
	><br>{
  ><br>	    writer.WriteLine("Macoratti .net");
	><br>}
</details>
<details><summary><b>Write File Exists</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  ><br>using System.IO;
  
####  Code
  > using (StreamWriter writer = new StreamWriter(@"C:\dados\macoratti.txt", true))
	><br>{
	><br>    writer.WriteLine("Quase tudo para Visual Basic");
	><br>}
</details>
<details><summary><b>Unzip File</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System.IO.Compression;
  
####  Code
  > string startPath = @".\start";
  ><br>      string zipPath = @".\result.zip";
  ><br>      string extractPath = @".\extract";
  ><br>     ZipFile.CreateFromDirectory(startPath, zipPath);
  ><br>     ZipFile.ExtractToDirectory(zipPath, extractPath);
</details>

</details>
