using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAS.Modularization;
using HYMes.BLL;
using EAS.Services;
using HYMes.Entities;
using EAS.Data.ORM;
using EAS.Explorer;
namespace HYMes.WinUI.BRM
{

    [Module("{95236E4C-0C18-41C9-8D92-66210C38EA25}",  "厂别信息", "厂别信息")]
    public partial class FrmBrmFactory:HYMes.WinUI.BaseControl.UcBRM
    {
        public FrmBrmFactory()
        {
            InitializeComponent();
            ini(); //初始化操作
        }

        private void spl_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FrmBaseFormTest_Load(object sender, EventArgs e)
        {
          // SourceDataGridView = this.dgvFactoryDetail;//需要重新分页的时候，需要将此语句执行
             //HYMes.WinUI.BRM.FrmEdit frmedit = new FrmEdit();
             //this.FrmEdit=frmedit;
             this.RefreshEventHandler+=new AfterClickRefreshEventHandler(FrmBaseFormTest_RefreshEventHandler);  //刷新事件 ,后台在添加、修改、删除操作后都会执行此操作
             this.DeleteEventHandler += new AfterClickDeleteEventHandler(FrmBaseFormTest_DeleteEventHandler);   //删除事件
        }

        private void dgvFactoryDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         void FrmBaseFormTest_RefreshEventHandler(object sender,EventArgs e)
        {
           // MessageBox.Show("刷新事件!");
            ini();
        }

         #region
         /// <summary>
        /// 初始化及刷新事件
        /// </summary>
         void ini()
         {
             DataSet ds = ServiceContainer.GetService<IBRMFactoryService>().GetBRMFactoryDataSet();
             this.dgvFactoryDetail.DataSource = ds.Tables[0];
             SourceDataGridView = this.dgvFactoryDetail; //需要重新分页的时候，需要将此语句执行
             HYMes.WinUI.BRM.FrmBrmFactoryEdit frmedit = new FrmBrmFactoryEdit(); //设定编辑窗体,一般在构造函数或者load事件中加入此说明
             this.FrmEdit = frmedit;
         }
       #endregion
         void FrmBaseFormTest_DeleteEventHandler(object sender,EventArgs e)
        {
            int bl = 0;
            if (this.dgvFactoryDetail.CurrentRow != null)
            {
                DataGridViewRow row = this.dgvFactoryDetail.CurrentRow;
                String key = row.Cells["FACTORY_KEY"].Value.ToString();

                BRM_FACTORY fac = ServiceContainer.GetService<IBRMFactoryService>().FindFacByFacKey(key);

                if (fac == null)
                {
                    MessageBox.Show("该笔资料不能进行删除，不存在或者已经处于活动状态!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确认要删除么?fackey=" + key, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            bl = ServiceContainer.GetService<IBRMFactoryService>().DelByFacKey(key);
                        }
                        catch
                        {
                            bl = 0;
                        }
                        if (bl == 0)
                        {
                            MessageBox.Show("删除失败", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                            BRM_FACTORY_LOG faclog = new BRM_FACTORY_LOG();
                            faclog.ACTIVE = "N";
                            faclog.DAY_POINT = fac.DAY_POINT;
                            faclog.FACTORY_DESC = fac.FACTORY_DESC;
                            faclog.FACTORY_ID = fac.FACTORY_ID;
                            faclog.FACTORY_NAME = fac.FACTORY_NAME;
                            faclog.FACTORY_SERIAL_KEY = Convert.ToInt16(fac.FACTORY_SERIAL_KEY)+1;
                            faclog.HOLD_DATE = fac.HOLD_DATE;
                            faclog.HOLD_FLG = fac.HOLD_FLG;
                            faclog.LOCAL_HOST_IP = ClientInfo.ClientInfo.LocalIP;
                            faclog.LOCAL_HOST_NAME = ClientInfo.ClientInfo.LocaComputerlName;
                            faclog.TRX_DATE = DateTime.Today.ToLocalTime().ToString();
                            faclog.TRX_LOGINID = LoginInfo.LoginID;
                            faclog.HOLD_FLG = fac.HOLD_FLG;
                            faclog.TRX_MODE = "HIDE";
                            faclog.FACTORY_KEY = fac.FACTORY_KEY;
                            faclog.Insert();

                           
                        }
                    }
                }
            }


           //  MessageBox.Show("删除成功");
        }

         private void dgvFactoryDetail_SelectionChanged(object sender, EventArgs e)
         {
             if (this.dgvFactoryDetail.CurrentRow != null)
             {
                 DataGridViewRow row = this.dgvFactoryDetail.CurrentRow;
                 String key = row.Cells["FACTORY_KEY"].Value.ToString();

                 DataSet ds = ServiceContainer.GetService<IBRMFactoryLogService>().GetBRMFactoryLogDataSetByFactoryKey(key);
                 this.dgvFactoryLogDetail.DataSource = ds.Tables[0];
             }
         }
    }
}
