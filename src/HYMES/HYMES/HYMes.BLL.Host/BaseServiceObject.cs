using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAS.Services;

namespace HYMes.BLL
{  
    /// <summary>
    /// 
    /// </summary>
    public class BaseServiceObject : ServiceObject
    {  
        /// <summary>
        /// 获取IDataAccessor对象实例
        /// </summary>
        public EAS.Data.Access.IDataAccessor DataAccessor
        {
            get 
            {
                return EAS.Context.ContextHelper.GetContext().Container.GetComponentInstance("DataAccessor") as EAS.Data.Access.IDataAccessor;
            }
        }
/// <summary>
/// 获取GUID值
/// </summary>
        public String GetGuidID
        {
            get { return Guid.NewGuid().ToString(); }
        }

    }
}
