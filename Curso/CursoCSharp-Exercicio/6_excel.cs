using System;
using IronXL;
class _6_excel{
    
    public static void createSheet(string diretorio)
    {
        WorkBook workbook = WorkBook.Create(ExcelFileFormat.XLSX);
        var sheet = workbook.CreateWorkSheet("Curso");
        sheet["A1"].Value = "1"; sheet["B1"].Value = "Celular"; sheet["C1"].Value = "1100.10";
        sheet["A2"].Value = "2"; sheet["B2"].Value = "Notebook"; sheet["C2"].Value = "1500.50";
        sheet["A3"].Value = "3"; sheet["B3"].Value = "Tv"; sheet["C3"].Value = "5100.10";
        sheet["A4"].Value = "4"; sheet["B4"].Value = "Mesa"; sheet["C4"].Value = "100.99";
        sheet["A5"].Value = "5"; sheet["B5"].Value = "Cadeira"; sheet["C5"].Value = "50.50";


        workbook.SaveAs(diretorio);
    }
}