using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
namespace HYMes.Tools
{
    public class ExcelGridImport
    {
        #region 根据路径打开一个Excel文件并将数据填充到DataSet
        /// <summary>
        /// 根据路径打开一个Excel文件并将数据填充到DataSet中
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="dgv"></param>
        public static DataSet  EcxelToDataSet(string filePath)
        {
            //根据路径打开一个Excel文件并将数据填充到DataSet中

           string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + filePath + ";Extended Properties=\"Excel 12.0;HDR=YES\"";


            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + filePath + ";Extended Properties ='Excel 8.0;HDR=NO;IMEX=1'";//HDR=YES 有两个值:YES/NO,表示第一行是否字段名,默认是YES,第一行是字段名
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select  * from   [SHEET1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            return ds;
        }
        #endregion
        #region 将DataGridView中的数据导入到Excel2007
        /// <summary>   
        /// 将DataGridView中的数据导入到Excel中
        /// </summary>   
        /// <param name="datagridview">DataGridView</param>   
        /// <param name="SheetName">Excel sheet title</param>   
        public static void DataGridView2Excel(System.Windows.Forms.DataGridView datagridview, string SheetName)
        {
            //string val;//add by cs 20120531
            int iRows = 0;
            int iCols = 0;
            int iTrueCols = 0;
            string filename = "";
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            if (wb.Worksheets.Count > 0)
            {
                ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.get_Item(1);
            }
            else
            {
                wb.Worksheets.Add(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.get_Item(1);
            }
            // Add by cs  Strat 2010-12-14 
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Execl2007 files(*.xlsx)|*.xlsx";

            saveFileDialog.FilterIndex = 0;

            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.CreatePrompt = true;

            saveFileDialog.Title = "Export Data To Excel!"; //Modify by cs 2010-12-14

            //saveFileDialog.ShowDialog(); // Mark by cs 2010-12-14

            // Add by cs  End 2010-12-14 
            saveFileDialog.CreatePrompt = false;
            // saveFileDialog.OverwritePrompt = false;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filename = saveFileDialog.FileName.ToString();
                    if (ws != null)
                    {
                        if (SheetName.Trim() != "")
                        {
                            ws.Name = SheetName;
                        }
                        iRows = datagridview.Rows.Count;　　　//加上列头行   
                        iTrueCols = datagridview.Columns.Count;　 //包含隐藏的列，一共有多少列   
                        //求列数，省略Visible = false的列   
                        for (int i = 0; i < datagridview.Columns.Count; i++)
                        {
                            if (datagridview.Columns[i].Visible)
                                iCols++;
                        }
                        //string[,] dimArray = new string[iRows + 1, iCols];    // 需要修改string[iRows + 1, iCols]为string[iRows, iCols]   
                        string[,] dimArray = new string[iRows + 1, iCols];
                        for (int j = 0, k = 0; j < iTrueCols; j++)
                        {
                            //省略Visible = false的列   
                            if (datagridview.Columns[j].Visible)
                            {
                                dimArray[0, k] = datagridview.Columns[j].HeaderText;
                                k++;
                            }
                        }
                        // for (int i = 0; i < iRows; i++) 修改前   
                        for (int i = 0; i < iRows; i++) // 修改后   
                        {
                            for (int j = 0, k = 0; j < iTrueCols; j++)
                            {
                                //省略Visible = false的列   
                                if (datagridview.Columns[j].Visible) //mark by cs 20110121 
                                {
                                    if (datagridview.Rows[i].Cells[j].Value == null)
                                    {
                                        dimArray[i + 1, k] = "Null";
                                    }
                                    else
                                    {
                                        dimArray[i + 1, k] = datagridview.Rows[i].Cells[j].Value.ToString();
                                    }
                                    k++;
                                }
                            }
                        }
                        /* 修改前  
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[iRows + 1, iCols]).Value2 = dimArray;  
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[1, iCols]).Font.Bold = true;  
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[iRows + 1, iCols]).Font.Size = 10.0;  
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[iRows + 1, iCols]).RowHeight = 14.25;  
                         * */
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[iRows + 1, iCols]).Value2 = dimArray;
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[1, iCols]).Font.Bold = true;
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[iRows, iCols]).Font.Size = 10.0;
                        ws.get_Range(ws.Cells[1, 1], ws.Cells[iRows, iCols]).RowHeight = 14.25;
                        for (int j = 0, k = 0; j < iTrueCols; j++)
                        {
                            //省略Visible = false的列   
                            if (datagridview.Columns[j].Visible)
                            {
                                ws.get_Range(ws.Cells[1, k + 1], ws.Cells[1, k + 1]).ColumnWidth =
                                    (datagridview.Columns[j].Width / 8.4) > 255 ? 255 : (datagridview.Columns[j].Width / 8.4);
                                //ws.Columns.c = datagridview.Columns[j].Width;   
                                k++;
                            }
                        }
                    }
                    // app.Visible = true;//Modify by cs 20101214
                    //app.Visible = false;
                    //app.Save(filename);//Add by cs 2010-12-14 保存
                    //app.ActiveWorkbook.Name = filename;
                    //app.ActiveWorkbook.Save();
                    wb.Close(true, filename, System.Reflection.Missing.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    wb.Close(false, filename, System.Reflection.Missing.Value);
                }
                finally
                {
                    // wb.Close(true, AFileName, ObjMissing);
                    app.Quit();
                    app = null;
                    GC.Collect();
                }

            }
            //else if  (saveFileDialog.FileName.IndexOf(":") < 0) //被点了"取消"
            else
            {
                wb.Close(false, filename, System.Reflection.Missing.Value);
                app.Quit();
                app = null;
                GC.Collect();
                return;
            }

        }
        #endregion 
    }
}
