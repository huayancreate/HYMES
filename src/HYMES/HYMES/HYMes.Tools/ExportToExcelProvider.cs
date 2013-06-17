using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Drawing;
namespace HYMes.Tools
{
    /// <summary>
    /// 标题：将 DataSet, DataTable 导出到 Excel
    /// 作者：肖小勇
    /// 日期：2012-07-01
    /// 描述：对之前做的导出 Excel 做调整以支持对 DataSet 及 DataTable 的导出；
    /// DataSet     导出时可以指定需要导出的 DataTable
    /// DataTable   导出时可以指定需要导出的 DataColumn 及自定义导出后的列名
    /// </summary>
    public class ExportToExcelProvider
    {
        private static object missing = Type.Missing;

        #region " ExportToExcel "

        /// <summary>
        /// 将
        /// </summary>
        /// <param name="fDataSet"></param>
        /// <param name="fFileName"></param>
        public static void ExportToExcel(DataSet fDataSet, String fFileName)
        {
            List<DataTableExportOptions> options = new List<DataTableExportOptions>();

            foreach (DataTable dataTable in fDataSet.Tables)
                options.Add(new DataTableExportOptions(dataTable));

            ExportToExcel(options, fFileName);
        }

        public static void ExportToExcel(DataTable fDataTable, String fFileName)
        {
            ExportToExcel(new DataTableExportOptions(fDataTable), fFileName);
        }

        public static void ExportToExcel(DataTableExportOptions fOption, String fFileName)
        {
            ExportToExcel(new List<DataTableExportOptions>(new DataTableExportOptions[] { fOption }), fFileName);
        }

        /// <summary>
        /// 将 DataTable 导出到 Excel
        /// </summary>
        /// <param name="fOptions"></param>
        public static void ExportToExcel(List<DataTableExportOptions> fOptions, String fFileName)
        {
            if (fOptions == null || fOptions.Count == 0) return;
            #region 判定指定的文件路径下是否存在相同的文件名，如果存在就删除之前的文件
            try
            {

                if (File.Exists(fFileName))
                    File.Delete(fFileName);

            }
            catch
            {
                return;
            }
            #endregion
            Excel.Application application = new Excel.Application();
            application.Visible = false;
            application.UserControl = false;

            Excel.Workbook workBook = (Excel.Workbook)(application.Workbooks.Add(missing));

            try
            {
                #region " 根据需要导出的 DataTable 数量，预先增加不足的工作表或多余的工作表 "

                // 添除多余的工作表
                while (application.ActiveWorkbook.Sheets.Count > fOptions.Count)
                    ((Excel.Worksheet)application.ActiveWorkbook.Sheets[1]).Delete();
                // 添加工作表
                while (application.ActiveWorkbook.Sheets.Count < fOptions.Count)
                    application.Worksheets.Add(missing, missing, missing, missing);

                #endregion

                int sheetIndex = 1;
                List<String> sheetNames = new List<string>();
                foreach (DataTableExportOptions option in fOptions)
                {
                    #region " 处理在多个 DataTable 设置为相同的工作表名称的问题 "

                    if (sheetNames.Contains(option.WorkSheetName))
                    {
                        int i = 1;
                        while (true)
                        {
                            string newSheetName = option.WorkSheetName + i.ToString();
                            if (!sheetNames.Contains(newSheetName))
                            {
                                sheetNames.Add(newSheetName);
                                option.WorkSheetName = newSheetName;
                                break;
                            }
                            i++;
                        }
                    }
                    else
                    {
                        sheetNames.Add(option.WorkSheetName);
                    }

                    #endregion

                    ExportToExcel(application, workBook, (Excel.Worksheet)application.ActiveWorkbook.Sheets[sheetIndex], option);
                    sheetIndex++;
                }

                workBook.SaveAs(fFileName, missing, missing, missing, missing, missing
                    , Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing, missing);
            }
            finally
            {
                application.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
                GC.Collect();
            }
        }

        /// <summary>
        /// 将 DataTable 导出到 Excel
        /// </summary>
        /// <param name="fApplication"></param>
        /// <param name="fWorkBook"></param>
        /// <param name="fOption"></param>
        private static void ExportToExcel(Excel.Application fApplication, Excel._Workbook fWorkBook, Excel.Worksheet worksheet, DataTableExportOptions fOption)
        {
            Excel.Range range;

            worksheet.Name = fOption.WorkSheetName;

            if (fOption.DataTable == null) return;

            int rowCount = fOption.DataTable.Rows.Count;
            int colCount = fOption.VisibleColumnOptions.Count;
            int colIndex = 0;
            int rowIndex = 0;

            #region " Set Header Values "

            object[,] colValues = new object[1, colCount];

            foreach (DataColumnExportOptions option in fOption.VisibleColumnOptions)
            {
                if (!option.Visible) continue;
                colValues[0, colIndex] = option.Caption;
                colIndex++;
            }

            range = worksheet.get_Range(GetExcelCellName(1, 1), GetExcelCellName(colCount, 1));
            range.Value2 = colValues;

            #endregion

            #region " Header Style "

            range.Font.Bold = true;
            //range.Font.Name = "Georgia";
            range.Font.Name = "宋体";
            range.Font.Size = 10;
            range.RowHeight = 26;
            range.EntireColumn.AutoFit();
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //range.Locked = true;

            #endregion

            #region " Set Row Values "

            object[,] rowValues = new object[rowCount, colCount];

            rowIndex = 0;

            foreach (DataRow dataRow in fOption.DataTable.Rows)
            {
                colIndex = 0;

                foreach (DataColumnExportOptions option in fOption.VisibleColumnOptions)
                {
                    //rowValues[rowIndex, colIndex] = dataRow[option.ColumnName]; //防止自动将
                    rowValues[rowIndex, colIndex] ="'"+dataRow[option.ColumnName];
                    colIndex++;
                }

                rowIndex++;
            }

            range = worksheet.get_Range(GetExcelCellName(1, 2), GetExcelCellName(colCount, rowCount + 1));
            // worksheet.get_Range(GetExcelCellName(1, 2), GetExcelCellName(colCount, rowCount + 1)).Merge(
            range.Value2 = rowValues;


            #region 测试合并自定的单元格 20120612 CS
            //int tempRowCountStart = 1;
            //int tempRowCountEnd = 1;
            ////for (int i = 2; i <=rowCount+1; i++)
            //Excel.Range tempRange;
            ////  int tempi = 0;
            //string startValue = ""; ;
            //fApplication.DisplayAlerts = false; //取消合并CELL的时候弹出提示框
            //foreach (DataRow dr in fOption.DataTable.Rows)
            //{
            //    //tempi = tempi + 1;

            //    if (dr[0].ToString() == startValue)
            //    {
            //        tempRowCountEnd = tempRowCountEnd + 1;
            //        startValue = dr[0].ToString();
            //    }
            //    else
            //    {
            //        if (tempRowCountEnd - tempRowCountStart > 0)
            //        {
            //            //合并本次付款金额
            //            tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 4], worksheet.Cells[tempRowCountEnd, 4]);
            //            tempRange.Merge(tempRange.MergeCells);
            //            //订单金额
            //            tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 9], worksheet.Cells[tempRowCountEnd, 9]);
            //            tempRange.Merge(tempRange.MergeCells);
            //            //发票总金额
            //            tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 11], worksheet.Cells[tempRowCountEnd, 11]);
            //            tempRange.Merge(tempRange.MergeCells);
            //            //财务最后付款日期
            //            tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 29], worksheet.Cells[tempRowCountEnd, 29]);
            //            tempRange.Merge(tempRange.MergeCells);
            //            //财务付款总额
            //            tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 30], worksheet.Cells[tempRowCountEnd, 30]);
            //            tempRange.Merge(tempRange.MergeCells);
            //        }
            //        tempRowCountStart = tempRowCountEnd + 1;
            //        tempRowCountEnd = tempRowCountStart;
            //        startValue = dr[0].ToString();
            //    }

            //}
            //#region 解决最后全相同的时候，不合并的情况
            //tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 4], worksheet.Cells[tempRowCountEnd, 4]);
            //tempRange.Merge(tempRange.MergeCells);
            ////订单金额
            //tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 9], worksheet.Cells[tempRowCountEnd, 9]);
            //tempRange.Merge(tempRange.MergeCells);
            ////发票总金额
            //tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 11], worksheet.Cells[tempRowCountEnd, 11]);
            //tempRange.Merge(tempRange.MergeCells);
            ////财务最后付款日期
            //tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 29], worksheet.Cells[tempRowCountEnd, 29]);
            //tempRange.Merge(tempRange.MergeCells);
            ////财务付款总额
            //tempRange = worksheet.get_Range(worksheet.Cells[tempRowCountStart, 30], worksheet.Cells[tempRowCountEnd, 30]);
            //tempRange.Merge(tempRange.MergeCells);
            //fApplication.DisplayAlerts = true; //取消警告弹出提示框
            //#endregion
            #endregion
            #region " Row Style "

            range.Font.Name = "宋体";
            range.Font.Size = 9;
            // range.RowHeight = 18;
            range.EntireColumn.AutoFit();
            //range.Borders.ColorIndex = 2;

            #endregion

            #endregion

            #region " Set Borders "

            range = worksheet.get_Range(GetExcelCellName(1, 2), GetExcelCellName(colCount, rowCount + 1));
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            // range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.ColumnWidth = 12;
            range = worksheet.get_Range(GetExcelCellName(1, 1), GetExcelCellName(colCount, rowCount + 1));
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.Color = Color.Black.ToArgb();

            #endregion
        }

        #endregion

        #region " GetCellName "

        private static string GetExcelCellName(int fColIndex, int fRowIndex)
        {
            if (fColIndex <= 0 || fColIndex > 256)
            {
                throw new Exception("Excel 列索引数值超出范围(1-256)!");
            }
            else if (fColIndex <= 26)
            {
                return GetExcelCellName(fColIndex) + fRowIndex.ToString();
            }
            else
            {
                string retLetter = GetExcelCellName(fColIndex / 26);
                retLetter += GetExcelCellName(fColIndex % 26);
                retLetter += fRowIndex.ToString();
                return retLetter;
            }
        }

        private static string GetExcelCellName(int fColIndex)
        {
            int i = 1;

            foreach (string letter in Enum.GetNames(typeof(ExcelColumnLetters)))
            {
                if (i == fColIndex)
                    return letter;
                i++;
            }

            throw new Exception("Excel 列索引数值超出范围(1-256)!");
        }

        #endregion
    }

    #region " ExcelColumnLetters "

    public enum ExcelColumnLetters
    {
        A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8, I = 9, J = 10,
        K = 11, L = 12, M = 13, N = 14, O = 15, P = 16, Q = 17, R = 18, S = 19, T = 20,
        U = 21, V = 22, W = 23, X = 24, Y = 25, Z = 26
    }

    #endregion

    #region " DataColumnExportOptions "

    public class DataColumnExportOptions
    {
        private String fColumnName;
        private String fCaption;
        private Boolean fVisible;

        public String ColumnName
        {
            get { return fColumnName; }
            set { fColumnName = value; }
        }

        public String Caption
        {
            get { return fCaption; }
            set { fCaption = value; }
        }

        public Boolean Visible
        {
            get { return fVisible; }
            set { fVisible = value; }
        }

        public DataColumnExportOptions(String fColumnName)
            : this(fColumnName, fColumnName)
        {

        }

        public DataColumnExportOptions(String fColumnName, String fCaption)
            : this(fColumnName, fCaption, true)
        {

        }

        public DataColumnExportOptions(String fColumnName, String fCaption, Boolean fVisible)
        {
            this.fColumnName = fColumnName;
            this.fCaption = fCaption;
            this.fVisible = fVisible;
        }
    }

    #endregion

    #region " DataTableExportOptions "

    public class DataTableExportOptions
    {
        private DataTable fDataTable;
        private List<DataColumnExportOptions> fColumnOptions;
        private List<DataColumnExportOptions> fVisibleColumnOptions;
        private String fWorkSheetName;


        public DataTable DataTable
        {
            get { return fDataTable; }
            set { fDataTable = value; }
        }

        public List<DataColumnExportOptions> ColumnOptions
        {
            get { return fColumnOptions; }
            set { fColumnOptions = value; }
        }

        public String WorkSheetName
        {
            get { return fWorkSheetName; }
            set { fWorkSheetName = value; }
        }

        public List<DataColumnExportOptions> VisibleColumnOptions
        {
            get { return fVisibleColumnOptions; }
        }

        public DataTableExportOptions(DataTable fDataTable)
            : this(fDataTable, null)
        {

        }

        public DataTableExportOptions(DataTable fDataTable, List<DataColumnExportOptions> fColumnOptions)
            : this(fDataTable, fColumnOptions, null)
        {

        }

        public DataTableExportOptions(DataTable fDataTable, List<DataColumnExportOptions> fColumnOptions, String fWorkSheetName)
        {
            if (fDataTable == null) return;

            this.fDataTable = fDataTable;
            if (fColumnOptions == null)
            {
                this.fColumnOptions = new List<DataColumnExportOptions>();
                foreach (DataColumn dataColumn in fDataTable.Columns)
                    this.fColumnOptions.Add(new DataColumnExportOptions(dataColumn.ColumnName));
            }
            else
            {
                this.fColumnOptions = fColumnOptions;
            }

            if (String.IsNullOrEmpty(fWorkSheetName))
                this.fWorkSheetName = fDataTable.TableName;
            else
                this.fWorkSheetName = fWorkSheetName;

            fVisibleColumnOptions = new List<DataColumnExportOptions>();
            foreach (DataColumnExportOptions option in this.fColumnOptions)
            {
                if (option.Visible)
                    fVisibleColumnOptions.Add(option);
            }
        }
    }

    #endregion
}
