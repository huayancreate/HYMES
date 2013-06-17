using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace HYMes.Tools
{   
    /// <summary>
    /// 对数据集的扩充
    /// </summary>
    public class DataSetExt:DataSet 
    {  
        /// <summary>
        /// 返回执行的记录集
        /// </summary>
        private DataSet dsResult;
        /// <summary>
        /// 返回执行的状态
        /// </summary>
        private Bparmaters.ACKresult ackResult;
        /// <summary>
        /// 执行发生异常的时候，提示一般异常信息及打印SQl
        /// </summary>
        private string errMessage="";

        /// <summary>
        /// 执行发生异常StackTrace
        /// </summary>
        private string errMessageStackTrace="";

        /// <summary>
        /// 返回执行数据操纵时候执行完成后影响的行数
        /// </summary>
        private int  intCnt=0;
       /// <summary>
        /// 返回执行数据操纵时候执行完成后影响的行数
       /// </summary>
        public int IntCnt
        {
            get { return intCnt; }
            set { intCnt = value; }
        }

        /// <summary>
        /// 执行发生异常StackTrace
        /// </summary>
        public string ErrMessageStackTrace
        {
            get { return errMessageStackTrace; }
            set { errMessageStackTrace = value; }
        }
        /// <summary>
        /// 返回执行的记录集
        /// </summary>
        public DataSet DsResult
        {
            get { return dsResult; }
            set { dsResult = value; }
        }
      /// <summary>
        /// 返回执行的状态
      /// </summary>
        public Bparmaters.ACKresult AckResult
        {
            get { return ackResult; }
            set { ackResult = value; }
        }
      
        /// <summary>
        /// 执行发生异常的时候，提示一般异常信息及打印SQl
        /// </summary>
        public string ErrMessage
        {
            get { return errMessage; }
            set { errMessage = value; }
        }
    }
}
