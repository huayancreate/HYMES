using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HYMes.Tools;
using EAS.Explorer;
namespace HYMes.WinUI.BaseForm
{  
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmBaseEdit : Form
    {

        /// <summary>
        /// 在窗体Load后执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void AfterEditFormLoadEventHandler(object sender, EditFormEventArgs e);
        /// <summary>
        /// 在添加、修改事件发生之前进行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">EditFormEventArgs</param>
        public delegate void SaveOrUpdateDataEventHandler(object sender, EditFormEventArgs e);
        /// <summary>
        /// 在窗体Load后执行的事件
        /// </summary>
        public event AfterEditFormLoadEventHandler AfterLoadEventHandler;
        /// <summary>
        /// 在添加、修改事件发生之前进行
        /// </summary>
        public event SaveOrUpdateDataEventHandler SaveOrUpdateEventHandler;
        private EditFormEventArgs editFormEventArgs=new EditFormEventArgs();
        /// <summary>
        /// 
        /// </summary>
        public EditFormEventArgs EditFormEventArgs
        {
            get { return editFormEventArgs; }
            set { editFormEventArgs = value; }
        }

        Boolean IsRun = false;
        /// <summary>
        /// 
        /// </summary>
        public FrmBaseEdit()
        {
            InitializeComponent();
            //Tools.Public.FindControlShow(this.tabPage1.Controls);
         
        }

        private void FrmBaseEdit_Load(object sender, EventArgs e)
        {
            this.CenterToParent();//居中
          //  Tools.Public.FindControlShow(this.tabPage1.Controls);
            IsRun = false;
            //if (AfterLoadEventHandler!=null)
            //{
            //    AfterLoadEventHandler(sender, EditFormEventArgs);  //在窗体载入后执行后执行
            //}
            
        }
        /// <summary>
        /// 获取datagridview中的row中的值
        /// </summary>
        /// <param name="colName">列名</param>
        /// <returns></returns>
        public  string GetSelectedRowCellValueToString(string colName)
       {   
            //colName='"'+colName+'"';
           if (EditFormEventArgs != null && EditFormEventArgs.SelectedRow != null && colName.Trim().Length != 0)
           {
               return EditFormEventArgs.SelectedRow.Cells["" + colName + ""].Value.ToString();
           }
           else
           {
               return null;
           }
       }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBaseEdit_Activated(object sender, EventArgs e)
        {
             if (IsRun == false)
            {
                IsRun = true;
                if (this.EditFormEventArgs.CurrentFormMode == Bparmaters.FormMode.AddNew)
                {

                    this.tabPage1.Text = "添加";
                    this.btnSave.Text = "保存";

                }
                if (this.EditFormEventArgs.CurrentFormMode == Bparmaters.FormMode.Modify)
                {

                    this.tabPage1.Text = "修改";
                    this.btnSave.Text = "更新";
                }
                if (AfterLoadEventHandler != null)
                {
                    AfterLoadEventHandler(sender, EditFormEventArgs);  //在窗体载入后执行后执行
                }
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AfterLoadEventHandler != null)
            {
                SaveOrUpdateEventHandler(sender, EditFormEventArgs);
            }
            this.Close();
        }
        /// <summary>
        /// 获取GUID值
        /// </summary>
        public String GetGuidID
        {
            get { return Guid.NewGuid().ToString(); }
        }
      //  private  IAccount loginInfo = EAS.Application.Instance.Session.Client as IAccount;
        /// <summary>
        /// 封装用户登录的一些属性
        /// </summary>
        public IAccount LoginInfo
        {
            get { return EAS.Application.Instance.Session.Client as IAccount; }
           // set { loginInfo = value; }
        }
    }
}
