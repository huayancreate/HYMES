using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace HYMes.Tools
{  
    /// <summary>
    /// 参数使用
    /// </summary>
   public  class Bparmaters
    {  
       /// <summary>
       /// 返回执行的结果
       /// </summary>
        public  enum ACKresult
        {   
            /// <summary>
            /// 成功
            /// </summary>
            OK, 
            /// <summary>
            /// 失败
            /// </summary>
            NG
        }
        public enum FormMode
        {
            AddNew,
            Modify,
            Hide,
            Recovery,
            Refresh,
            Export,
            Copy,
            delete
        }
    }
}
