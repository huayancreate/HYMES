using System;
using System.Collections.Generic;
using System.Text;
using EAS.Explorer;

namespace HYMes.Res
{
    class ShopContext 
    {
        /// <summary>
        /// µ±Ç°µÇÂ¼ÕËºÅ¡£
        /// </summary>
        public static IAccount Account
        {
            get
            {
                return EAS.Application.Instance.Session.Client as IAccount;
            }
        }
    }
}
