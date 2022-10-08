## <a href="https://github.com/Hidekithiago/Automacao/blob/master/README.md">FOLDER</a> <br>
<details>
<details><summary><b>GET FILES IN FOLDER</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System; <br>
   using System.IO; <br>
  
####  Code
  >try <br>
        { <br>
            // Only get files that begin with the letter "c". <br>
            string[] dirs = Directory.GetFiles(@"c:\", "c*"); <br>
            Console.WriteLine("The number of files starting with c is {0}.", dirs.Length); <br>
            foreach (string dir in dirs) <br>
            { <br>
                Console.WriteLine(dir); <br>
            } <br>
        } <br>
        catch (Exception e) <br>
        { <br>
            Console.WriteLine("The process failed: {0}", e.ToString()); <br>
        } <br>
  
</details>
<details><summary><b>GET Dir Special Folder</b></summary>
  
####  NuGet
  > 
  
####  import
  >
  
####  Code
  >private static String desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
  
</details>
</details>
