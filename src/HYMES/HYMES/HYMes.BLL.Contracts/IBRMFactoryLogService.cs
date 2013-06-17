using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HYMes.BLL
{
   public interface  IBRMFactoryLogService
    {
       DataSet GetBRMFactoryLogDataSetByFactoryKey(string fac_key);
    }
}
