using IronXL;
using System;
using System.Linq;

namespace Curso_cSharp
{
    class Excel
    {
        public void readSheet(string diretorio)
        {
            WorkBook workbook = WorkBook.Load(diretorio);
            WorkSheet sheet = workbook.WorkSheets.First();
            //Select cells easily in Excel notation and return the calculated value
            int cellValue = sheet["A2"].IntValue;
            // Read from Ranges of cells elegantly.
            foreach (var cell in sheet["A2:A10"])
            {
                Console.WriteLine("Cell {0} has value '{1}'", cell.AddressString, cell.Text);
            }
            ///Advanced Operations
            //Calculate aggregate values such as Min, Max and Sum
            decimal sum = sheet["A2:A10"].Sum();
            //Linq compatible
            decimal max = sheet["A2:A10"].Max(c => c.DecimalValue);
        }

        public static void createSheet(string diretorio)
        {
            WorkBook workbook = WorkBook.Create(ExcelFileFormat.XLSX);
            var sheet = workbook.CreateWorkSheet(diretorio);
            sheet["A1"].Value = "Example";
            //set value to multiple cells
            sheet["A2:A4"].Value = 5;
            sheet["A5"].Style.SetBackgroundColor("#f0f0f0");
            //set style to multiple cells
            sheet["A5:A6"].Style.Font.Bold = true;
            //set formula
            sheet["A6"].Value = "=SUM(A2:A4)";
            if (sheet["A6"].IntValue == sheet["A2:A4"].IntValue)
            {
                Console.WriteLine("Basic test passed");
            }
            workbook.SaveAs(@"C:\Users\hidek\OneDrive\Área de Trabalho\GitHub\CSharp\Curso\Cursoexample_workbook.xlsx");
        }
        /*
        static void Main(string[] args)
        {
            createSheet(@"test");
        }
        */
    }
}