## <a href="https://github.com/Hidekithiago/CSharp/blob/master/README.md">REGEX</a> <br>
<details>
<details><summary><b>REPLACE</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System;
  
####  Code
  >String s = "aaa"; <br>
  >Console.WriteLine("The initial string: '{0}'", s);<br>
  >s = s.Replace("a", "b").Replace("b", "c").Replace("c", "d");<br>
  >Console.WriteLine("The final string: '{0}'", s);<br>
  
</details>

<details><summary><b>MATCH</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System; <br>
  using System.Text.RegularExpressions;
  
####  Code
  >string pattern = @"\ba\w*\b";<br>
      string input = "An extraordinary day dawns with each new day.";<br>
      Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);<br>
      if (m.Success)<br>
         Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);<br>
  
</details>
</details>
