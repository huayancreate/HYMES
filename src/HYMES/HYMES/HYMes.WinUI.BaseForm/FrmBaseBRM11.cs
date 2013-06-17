using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HYMes.Tools;
using HYMes.WinUI.BaseControl;
namespace HYMes.WinUI.BaseForm
{ 
    /// <summary>
    /// 主窗体的基FORM
    /// </summary>
    public partial class FrmBaseBRM11 :Form
    {  
        /// <summary>
        /// 单击编辑、添加、修改按钮时弹出的子窗体
        /// </summary>
        private FrmBaseEdit frmEdit;
        /// <summary>
        /// 按钮类型
        /// </summary>
        private Bparmaters.FormMode currentFormMode;

        /// <summary>
        /// 
        /// </summary>
        private DataSet  dsMaster;

        /// <summary>
        /// 
        /// </summary>
        public DataSet DsMaster
        {
            get { return dsMaster; }
            set { dsMaster = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Bparmaters.FormMode CurrentFormMode
        {
            get { return currentFormMode; }
            set { currentFormMode = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public FrmBaseEdit FrmEdit
        {
            get { return frmEdit; }
            set { frmEdit = value;
            }
        }
        private DataGridView dgvInstance;
        /// <summary>
        /// 
        /// </summary>
        public DataGridView DgvInstance
        {
            get { return dgvInstance; }
            set { dgvInstance = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public FrmBaseBRM11()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 刷新按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void AfterClickRefreshEventHandler(object sender, EventArgs e);
        /// <summary>
        /// 刷新事件
        /// </summary>
        public event AfterClickRefreshEventHandler RefreshEventHandler;


        private void FrmBaseBRM_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //DataTable dt = ((DataTable)this.dgvInstance.DataSource).Clone() ;
            //dt.Rows.Add(this.DgvInstance.CurrentRow as DataRow);
            this.CurrentFormMode = Bparmaters.FormMode.AddNew;

           // DsMaster.Tables[0].Rows.Add(this.DgvInstance.SelectedRows);
            if (FrmEdit != null)
            {
                FrmEdit.EditFormEventArgs.CurrentFormMode = Bparmaters.FormMode.AddNew;
                //   FrmEdit.EditFormEventArgs.DgvRow = this.DgvInstance.CurrentRow;
                //  //FrmEdit.EditFormEventArgs.DsMaster.Tables.Add();
                ////FrmEdit.EditFormEventArgs.DsMaster = this.DgvInstance.CurrentRow;
                // //  FrmEdit.EditFormEventArgs.DsMaster = DsMaster;
                FrmEdit.ShowDialog();
                btnRefresh_Click(sender, new EventArgs());
                
            }
            else
            {
                MessageBox.Show("没有指定编辑界面" + this.CurrentFormMode);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {  
            
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.CurrentFormMode = Bparmaters.FormMode.Modify;
            if (this.DgvInstance.CurrentRow == null)
            {
                MessageBox.Show("没有资料可供编辑");
            }

            if (FrmEdit != null)
            {
                FrmEdit.EditFormEventArgs.CurrentFormMode = Bparmaters.FormMode.Modify;
                FrmEdit.EditFormEventArgs.SelectedRow = this.DgvInstance.CurrentRow;
                FrmEdit.ShowDialog();
                btnRefresh_Click(sender, new EventArgs());
            }
            else
            {
                MessageBox.Show("没有指定编辑界面" + this.CurrentFormMode);
            }
        }

        //private void btnCopy_Click(object sender, EventArgs e)
        //{
        //    this.CurrentFormMode = Bparmaters.FormMode.Copy;

        //    if (FrmEdit != null)
        //    {
        //        FrmEdit.EditFormEventArgs.CurrentFormMode = Bparmaters.FormMode.Copy;
        //        FrmEdit.EditFormEventArgs.DgvRow = this.DgvInstance.CurrentRow;
        //        FrmEdit.ShowDialog();
        //        btnRefresh_Click(sender, new EventArgs());
        //    }
        //    else
        //    {
        //        MessageBox.Show("没有指定编辑界面" + this.CurrentFormMode);
        //    }
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshEventHandler(sender, new EventArgs());
        }
    }
}
