using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Net;

namespace PLC_Test
{
    class Function
    {
        public static List<string> GetLocalIp()
        {
            List<string> AddressIP = new List<string>();
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP.Add(_IPAddress.ToString());
                }
            }
            return AddressIP;
        }
        public static bool IPCheck(string IP)
        {
            //检查IP格式
            return Regex.IsMatch(IP, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        public static bool PortCheck(string Port)
        {
            //检查端口格式
            return Regex.IsMatch(Port, @"^[0-9]*$");
        }

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

            catch (Exception)
            {
            }
            return table;
        }

        public static void SaveDataTableinExcel(DataTable dt, string filePath)
        {
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate,
                    FileAccess.Write, FileShare.ReadWrite))
                {
                    var workBook = new XSSFWorkbook();
                    var sheet = workBook.CreateSheet("测试结果");

                    //设置成功和失败的单元格样式
                    XSSFCellStyle pass = (XSSFCellStyle)workBook.CreateCellStyle();
                    pass.FillPattern = FillPattern.SolidForeground;
                    byte[] rgbg = { 100, 255, 100 };
                    XSSFColor green = new XSSFColor(rgbg);
                    pass.FillForegroundXSSFColor = green;

                    XSSFCellStyle unpass = (XSSFCellStyle)workBook.CreateCellStyle();
                    unpass.FillPattern = FillPattern.SolidForeground;
                    byte[] rgbr = { 255, 100, 100 };
                    XSSFColor red = new XSSFColor(rgbr);
                    unpass.FillForegroundXSSFColor = red;

                    IRow headRow = sheet.CreateRow(0);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ICell cell = headRow.CreateCell(i);
                        cell.SetCellValue(dt.Columns[i] == null ? "" : dt.Columns[i].ToString());
                    }
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            IRow newRow = sheet.CreateRow(i + 1);
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                ICell cell = newRow.CreateCell(j);
                                cell.SetCellValue(dt.Rows[i][j] == null ? "" : dt.Rows[i][j].ToString());
                                if (dt.Rows[i][j].ToString() == "成功")
                                {
                                    cell.CellStyle = pass;
                                }
                                else if (dt.Rows[i][j].ToString() == "失败")
                                {
                                    cell.CellStyle = unpass;
                                }
                            }
                        }
                    }
                    workBook.Write(fileStream);
                    workBook.Clear();
                }
            }
            catch (Exception)
            {
            }
        }

        public static PLCModel GetPLCModel(PLCModel[] pms, TestModel tm)
        {
            //返回相应编号的PLC
            foreach (PLCModel pm in pms)
            {
                if (pm.PLCid == tm.PLCindex)
                {
                    return pm;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public static ObjectModel GetObjectModel(ObjectModel[] oms, TestModel tm)
        {
            //返回响应编号的对象
            foreach (ObjectModel obj in oms)
            {
                if (obj.objectid == tm.objectindex)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
