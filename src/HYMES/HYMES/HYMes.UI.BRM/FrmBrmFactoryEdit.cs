using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HYMes.Tools;
using EAS.Services;
using HYMes.Entities;
using EAS.Data.ORM;
using EAS.Explorer;
using HYMes.BLL;
namespace HYMes.WinUI.BRM
{
    public partial class FrmBrmFactoryEdit : HYMes.WinUI.BaseForm.FrmBaseEdit
    {
        private String formType;

        public String FormType
        {
            get { return formType; }
            set { formType = value; }
        }

        public FrmBrmFactoryEdit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.AfterLoadEventHandler += new AfterEditFormLoadEventHandler(FrmBrmFactoryEdit_AfterLoadEventHandler);
            this.SaveOrUpdateEventHandler += new SaveOrUpdateDataEventHandler(FrmBrmFactoryEdit_SaveOrUpdateEventHandler);

        }
        void FrmBrmFactoryEdit_AfterLoadEventHandler(Object sender, EditFormEventArgs e)
        {

            if (e.CurrentFormMode == Bparmaters.FormMode.AddNew)
            {
                this.txtFacID.Focus();
            }
            else if (e.CurrentFormMode == Bparmaters.FormMode.Modify)
            {
              
                fillData();
                this.txtFacID.Enabled = false;
                this.txtFacName.Focus();
            }
        }
        void fillData()
        {
           this.txtFacID.Text=GetSelectedRowCellValueToString("FACTORY_ID");
           this.txtFacName.Text = GetSelectedRowCellValueToString("FACTORY_NAME");
           this.txtFacDesc.Text = GetSelectedRowCellValueToString("FACTORY_DESC");

           if (GetSelectedRowCellValueToString("HOLD_FLG") == "Y")
           {
               this.radioY.Checked = true;
           }
           else
           {
               this.radioY.Checked = false;
           }
           this.dtpHoldDate.Text = GetSelectedRowCellValueToString("HOLD_DATE");
           this.dptChangeDayPoint.Text = GetSelectedRowCellValueToString("DAY_POINT");
           this.comboChangeWeekPoint.SelectedItem = GetSelectedRowCellValueToString("WEEK_POINT");
        }
        void FrmBrmFactoryEdit_SaveOrUpdateEventHandler(Object sender, EditFormEventArgs e)
        {  
            BRM_FACTORY_LOG faclog = new BRM_FACTORY_LOG();
            BRM_FACTORY newfac = new BRM_FACTORY();
            if (e.CurrentFormMode == Bparmaters.FormMode.AddNew)
            {  
                ///需要加入防呆
                newfac.ACTIVE = "Y";
                newfac.FACTORY_KEY = this.GetGuidID;
                newfac.FACTORY_SERIAL_KEY = 1;
                newfac.FACTORY_DESC = this.txtFacDesc.Text.Trim();
                newfac.FACTORY_NAME = this.txtFacName.Text.ToString();
                newfac.FACTORY_ID = this.txtFacID.Text.ToString();
                newfac.DAY_POINT = this.dptChangeDayPoint.Text.ToString();
                newfac.WEEK_POINT = this.comboChangeWeekPoint.Text.ToString();
                newfac.TRX_DATE = DateTime.Today.ToLocalTime().ToString();
                newfac.TRX_LOGINID = LoginInfo.LoginID;
                newfac.HOLD_FLG = this.radioY.Checked == true ? "Y" : "N";
                newfac.HOLD_DATE = this.dtpHoldDate.Value.ToString();


                faclog.ACTIVE = newfac.ACTIVE;
                faclog.DAY_POINT = this.dptChangeDayPoint.Text.ToString();
                faclog.WEEK_POINT = this.comboChangeWeekPoint.Text.ToString();
                faclog.FACTORY_DESC = this.txtFacDesc.Text.Trim();
                faclog.FACTORY_ID = newfac.FACTORY_ID;
                faclog.FACTORY_NAME = this.txtFacName.Text.Trim();
                faclog.FACTORY_SERIAL_KEY = 1;
                faclog.HOLD_DATE = this.dtpHoldDate.Value.ToString();
                faclog.HOLD_FLG = this.radioY.Checked == true ? "Y" : "N";
                faclog.LOCAL_HOST_IP = ClientInfo.ClientInfo.LocalIP;
                faclog.LOCAL_HOST_NAME = ClientInfo.ClientInfo.LocaComputerlName;
                faclog.TRX_DATE = DateTime.Today.ToLocalTime().ToString();
                faclog.TRX_LOGINID = LoginInfo.LoginID;
                faclog.TRX_MODE = Bparmaters.FormMode.AddNew.ToString();
                faclog.FACTORY_KEY = newfac.FACTORY_KEY;

                newfac.Insert();//
                faclog.Insert();//

            }
            else if (e.CurrentFormMode == Bparmaters.FormMode.Modify)
            {
                String fackey = GetSelectedRowCellValueToString("FACTORY_KEY");
                BRM_FACTORY  oldfac = ServiceContainer.GetService<IBRMFactoryService>().FindFacByFacKey(fackey);

                oldfac.TRX_DATE = DateTime.Today.ToLocalTime().ToString();
                oldfac.TRX_LOGINID = LoginInfo.LoginID;
                oldfac.FACTORY_NAME = this.txtFacName.Text.Trim();
                oldfac.FACTORY_DESC = this.txtFacDesc.Text.Trim();
                oldfac.HOLD_FLG = this.radioY.Checked == true ? "Y" : "N";
                oldfac.HOLD_DATE = this.dtpHoldDate.Value.ToString();
                oldfac.DAY_POINT = this.dptChangeDayPoint.Text.ToString();
                oldfac.WEEK_POINT = this.comboChangeWeekPoint.Text.ToString();
                oldfac.FACTORY_SERIAL_KEY = oldfac.FACTORY_SERIAL_KEY + 1;
              
                faclog.ACTIVE = oldfac.ACTIVE;
                faclog.DAY_POINT = this.dptChangeDayPoint.Text.ToString();
                faclog.WEEK_POINT = this.comboChangeWeekPoint.Text.ToString();
                faclog.FACTORY_DESC = this.txtFacDesc.Text.Trim();
                faclog.FACTORY_ID = oldfac.FACTORY_ID;
                faclog.FACTORY_NAME = this.txtFacName.Text.Trim();
                faclog.FACTORY_SERIAL_KEY = Convert.ToInt16(oldfac.FACTORY_SERIAL_KEY) + 1;
                faclog.HOLD_DATE = this.dtpHoldDate.Value.ToString();
                faclog.HOLD_FLG = this.radioY.Checked == true ? "Y" : "N";
                faclog.LOCAL_HOST_IP = ClientInfo.ClientInfo.LocalIP;
                faclog.LOCAL_HOST_NAME = ClientInfo.ClientInfo.LocaComputerlName;
                faclog.TRX_DATE = DateTime.Today.ToLocalTime().ToString();
                faclog.TRX_LOGINID = LoginInfo.LoginID;
                faclog.TRX_MODE = Bparmaters.FormMode.Modify.ToString();
                faclog.FACTORY_KEY = oldfac.FACTORY_KEY;
               
                oldfac.Update();//
                faclog.Insert();//
            }




        }
        private void FrmBrmFactoryEdit_Load(object sender, EventArgs e)
        {
          
        }

        private void FrmBrmFactoryEdit_Activated(object sender, EventArgs e)
        {
            if (this.formType == "edit")
            {
                this.Text = this.Text + "-" + "编辑";
                this.txtFacName.Focus();
            }
            else if (this.formType == "add")
            {
                this.Text = this.Text + "-" + "添加";
                this.txtFacID.Focus();
            }
        }
    }
}
