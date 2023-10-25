using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProgramaInventario1.util
{
    internal class ExcelGenerator
    {

        //EXCEL no se implementa en el proyecto

        /**static void Main(string[] args)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWB = excelApp.Workbooks.Add("");
            Excel._Worksheet excelWS = excelWB.ActiveSheet;
            excelWS.Cells[1, 1] = "productos";
            excelWB.SaveCopyAs(System.IO.Directory.GetCurrentDirectory() + "\\productos.xlsx"); //DIRECTORIO DESTINO Y NOMBRE 
            excelWB.Close();
            excelApp.Quit();
            
        }**/
    }
}
