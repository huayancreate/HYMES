using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HYMes.Entities;
using EAS.Services;
using EAS.Data.Linq;
using System.Data;
using EAS.Data.ORM;
using EAS.Explorer;
using EAS;
namespace HYMes.BLL
{
    [ServiceObject("工厂信息LOG服务")]
    [ServiceBind(typeof(IBRMFactoryLogService))]
    public  class BRMFactoryLogService : BaseServiceObject, IBRMFactoryLogService
    {
        public DataSet GetBRMFactoryLogDataSetByFactoryKey(string fac_key)
        {
            DataSet ds = null;
            string SQLText = "SELECT FACTORY_ID,FACTORY_NAME,FACTORY_DESC,HOLD_FLG,HOLD_DATE,DAY_POINT";
            SQLText = SQLText + "  ,WEEK_POINT,ACTIVE,TRX_MODE,TRX_DATE,LOCAL_HOST_IP,LOCAL_HOST_NAME,TRX_LOGINID from BRM_FACTORY_LOG where FACTORY_KEY='" + fac_key + "' order by FACTORY_SERIAL_KEY asc";
            //IList<object> objList = this.DataAccessor.QueryList(SQLText);
            ds = this.DataAccessor.QueryDataSet(SQLText);

            return ds;
        }

    }
}
