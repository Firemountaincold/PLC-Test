using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.IO;

namespace PLC_Test
{
    class UseExcel
    {
        public static DataTable ReadDataFromExcel(string path, string sheetname)
        {
            DataTable table = new DataTable();
            try
            {
                FileStream sm = new FileStream(path, FileMode.Open, FileAccess.Read);
                XSSFWorkbook workbook = new XSSFWorkbook(sm);
                ISheet sheet = workbook.GetSheet(sheetname);
                if (sheet == null) return null;

                // 处理标题列
                IRow row0 = sheet.GetRow(0);
                for (int i = row0.FirstCellNum; i < row0.LastCellNum; ++i)
                {
                    ICell cell = row0.GetCell(i);
                    if (cell != null)
                    {
                        string cellValue = cell.StringCellValue;
                        if (cellValue != null)
                        {
                            DataColumn column = new DataColumn(cellValue);
                            table.Columns.Add(column);
                        }
                    }
                }
                // 处理行数据
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; ++i)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null) continue; //没有数据的行默认是null　　　　　　　
                    DataRow dataRow = table.NewRow();
                    for (int j = row.FirstCellNum; j < row.LastCellNum; ++j)
                    {
                        if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                            dataRow[j] = row.GetCell(j).ToString();
                    }
                    table.Rows.Add(dataRow);
                }
            }

            catch (Exception ex)
            {
            }
            return table;
        }
    }
}
