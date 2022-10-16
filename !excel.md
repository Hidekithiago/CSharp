## <a href="https://github.com/Hidekithiago/CSharp/blob/master/README.md">Excel</a> <br>
<details>
<details><summary><b>Read Excel</b></summary>
  
####  NuGet
  > Microsoft.Office.Interop.Excel
  
####  import
  > using Excel = Microsoft.Office.Interop.Excel;
  
####  Code  
  ><br>public static void readExcel(string filePath)
  ><br>        {
  ><br>            try
  ><br>            {
  ><br>         Console.WriteLine("Inicio");
  ><br>         Excel.Application oExcel = new Excel.Application();
  ><br>         string filepath = @"C:\quaestum\a.xlsx";
  ><br>         Excel.Workbook WB = oExcel.Workbooks.Open(filepath);
  ><br>         string ExcelWorkbookname = WB.Name;
  ><br>         
  ><br>         int worksheetcount = WB.Worksheets.Count;
  ><br>         Excel.Worksheet wks = (Excel.Worksheet)WB.Worksheets[4];
  ><br>         
  ><br>         string firstworksheetname = wks.Name;
  ><br>         for (int k = 1; k < 99999; k++)
  ><br>         {                    
  ><br>             String rowText = Convert.ToString(((Excel.Range)wks.Cells[k, 1]).Value);
  ><br>             if (rowText == null) break;                    
  ><br>             rCount++;                    
  ><br>         }                
  ><br>         Console.WriteLine("workSheet:{0} Rows:{1} Colunas:{2}", firstworksheetname, rCount, cCount);
  ><br>         var firstcellvalue = ((Excel.Range)wks.Cells[rCount, 1]).Value;
  ><br>         Console.WriteLine(firstcellvalue);
  ><br>         WB.Close();
  ><br>     }
  ><br>     catch (Exception ex)
  ><br>     {
  ><br>         Console.WriteLine(ex);
  ><br>     }
  ><br> }
  
</details>
</details>
