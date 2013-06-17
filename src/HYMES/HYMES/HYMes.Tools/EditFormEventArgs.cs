using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace HYMes.Tools
{   
    /// <summary>
    /// 
    /// </summary>
    public class EditFormEventArgs:EventArgs
    {  
        /// <summary>
        /// 日志记录集
        /// </summary>
        private DataSet dsLog;
        /// <summary>
        /// 当前编辑界面类型
        /// </summary>
        private Bparmaters.FormMode currentFormMode;
        /// <summary>
        /// 主数据记录表
        /// </summary>
         private DataSet dsMaster;
         
        /// <summary>
        /// 由主界面传过来的datagridviewrow
        /// </summary>
         private DataGridViewRow selectedRow;
        /// <summary>
        /// 
        /// </summary>
         public DataGridViewRow SelectedRow
         {
             get { return selectedRow; }
             set { selectedRow = value; }
         }
        /// <summary>
        /// 
        /// </summary>
        public DataSet DsLog
        {
            get { return dsLog; }
            set { dsLog = value; }
        }
       
        /// <summary>
        /// 
        /// </summary>
        public DataSet DsMaster
        {
            get { return dsMaster; }
            set { dsMaster = value; }
        }


         public Bparmaters.FormMode CurrentFormMode
        {
            get { return currentFormMode; }
            set { currentFormMode = value; }
        }
       
    }
}
