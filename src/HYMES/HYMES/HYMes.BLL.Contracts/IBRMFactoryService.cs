using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HYMes.Entities;
using System.Data;
namespace HYMes.BLL
{
     public interface  IBRMFactoryService 
    {
         IList<BRM_FACTORY> GetBRMFactoryList();
         DataSet GetBRMFactoryDataSet();
         int DelByFacKey(String FactoryKey);
         BRM_FACTORY  FindFacByFacKey(String FactoryKey);
         //DataSet GetBRMFactoryDataSet();
         //IList<BRM_FACTORY> GetDataSetBRMFactoryList();
        //IList<BRM_FACTORY> GetBRMFactoryList(string keyWord);
    }
}
