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
    [ServiceObject("工厂信息服务")]
    [ServiceBind(typeof(IBRMFactoryService))]
    public class BRMFactoryService :BaseServiceObject,IBRMFactoryService
    {
        
        #region 查询服务
        public IList<BRM_FACTORY> GetBRMFactoryList()
        {
            DataEntityQuery<BRM_FACTORY> query = DataEntityQuery<BRM_FACTORY>.Create();
            var p = (
                 from item in query
                 where item.ACTIVE == "Y"
                 orderby item.FACTORY_KEY ascending
                 select item
                );
            return p.ToList();
        }

        //public IList<object> GetBRMFactoryDataSet()
        /// <summary>
        /// 查询工厂信息
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetBRMFactoryDataSet()
        {
            DataSet ds = null;
            string SQLText = "SELECT fac.FACTORY_KEY,fac.FACTORY_ID,fac.FACTORY_NAME,fac.FACTORY_DESC,fac.DAY_POINT,fac.WEEK_POINT,";
            SQLText = SQLText + " fac.HOLD_FLG,fac.HOLD_DATE,fac.TRX_DATE,acc.NAME trx_name,fac.ACTIVE ";

  SQLText=SQLText+" FROM BRM_FACTORY fac left join EAS_ACCOUNTS acc";

  SQLText = SQLText + " on fac.TRX_LOGINID=acc.LOGINID where  fac.ACTIVE ='Y' ";

            //IList<object> objList = this.DataAccessor.QueryList(SQLText);
 ds = this.DataAccessor.QueryDataSet(SQLText);

           return ds;
        }

        #endregion
        public int DelByFacKey(String FactoryKey)
        {
            IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
            int  bl = 1;
            StringBuilder stb = new StringBuilder();
            try
            {
                stb.AppendFormat("UPDATE  BRM_FACTORY  SET ACTIVE='N',TRX_DATE='{0}',TRX_LOGINID='{1}',FACTORY_SERIAL_KEY=FACTORY_SERIAL_KEY+1 WHERE FACTORY_KEY='{2}'", DateTime.Today.ToLocalTime(), LoginInfo.LoginID, FactoryKey);
                this.DataAccessor.Execute(stb.ToString());
            }
            catch
            {
                bl = 0;
            }

            return bl;
        }

        public BRM_FACTORY FindFacByFacKey(String FactoryKey)
        {
            BRM_FACTORY fac = null;
            //StringBuilder stb = new StringBuilder();
            //stb.AppendFormat("SELECT * FROM BRM_FACTORY WHERE FACTORY_KEY='{0}'", FactoryKey);
            //DataSet ds = this.DataAccessor.QueryDataSet(stb.ToString());

            // fac = (BRM_FACTORY)list.First();
           // return fac;

            DataEntityQuery<BRM_FACTORY> query = DataEntityQuery<BRM_FACTORY>.Create();
            var p = (
                 from item in query
                 where item.FACTORY_KEY == FactoryKey && item.ACTIVE=="Y"
                 orderby item.FACTORY_KEY ascending
                 select item
                );
            fac = p.ToList().First();
            return fac;
        }
    }
}
