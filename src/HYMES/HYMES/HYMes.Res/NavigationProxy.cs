using System;
using System.Collections.Generic;
using System.Text;
using EAS.Explorer.Entities;
using EAS.Services;
using EAS.Explorer;
using System.Linq;

namespace HYMes.Res
{
    class NavigationProxy
    {
        /// <summary>
        /// 导航信息。
        /// </summary>
        public IList<INavigateGroup> GroupList
        {
            get;
            set;
        }

        /// <summary>
        /// 模块信息。
        /// </summary>
        public IList<INavigateModule> ModuleList
        {
            get;
            set;
        }

        /// <summary>
        /// 查一级分组。
        /// </summary>
        /// <returns></returns>
        public IList<INavigateGroup> GetGroupList()
        {
            Dictionary<string, int> gms = new Dictionary<string, int>();
            foreach (INavigateGroup var in this.GroupList)
                gms.Add(var.ID, 0);

            foreach (INavigateGroup var in this.ModuleList)
            {
                gms[var.ID] += 1;
            }

            IList<INavigateGroup> List = new List<INavigateGroup>();
            foreach (NavigateGroup var in this.GroupList)
            {
                if (gms[var.ID] > 0)
                    List.Add(var);
            }

            return List;
        }

        /// <summary>
        /// 查下载分组。
        /// </summary>
        /// <param name="parentID"></param>
        /// <returns></returns>
        public IList<INavigateGroup> GetGroupList(string parentID)
        {
            //return this.GroupList.Where(p => p.ParentID == parentID).ToList();
            return this.GroupList.Where(p => p.ParentID == parentID).Distinct().ToList();
        }

        /// <summary>
        /// 查询导航模块。
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public IList<INavigateModule> GeModuleList(string groupID)
        {
            return this.ModuleList.Where(p => p.GroupID == groupID).ToList();
        }
    }
}
