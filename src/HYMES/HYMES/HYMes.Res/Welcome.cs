using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using EAS.Windows.UI.Controls;
using EAS.Modularization;
using EAS.Explorer.Entities;
using EAS.Explorer;

namespace HYMes.Res
{
    [Module("704B3F05-0BBC-413A-B554-53733539FCC9", "启始页", "AgileEAS.NET平台WinForm/Wpf容器起始页模块")]
    partial class Welcome : UserControl
    {
        [ModuleStart]
        public void Start()
        {
        }

        IAccount account = null;
        private PictureBox pbDrugStoreIn;
        private PictureBox pbDrugChangePriceAdIn;
        private PictureBox pbDrugBackCustom;
        private PictureBox pbDrugLost;
        private PictureBox pbDrugStoreOut;
        private PictureBox pbDrugBackProviderAdIn;
        private PictureBox pbDrugStoreQuery;
        private PictureBox pbDrugStoreCount;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private System.ComponentModel.IContainer components = null;

        public Welcome()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);

            InitializeComponent();
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        protected override void OnResize(EventArgs e)
        {
            //this.lblGuest.Top = (this.Height - this.lblGuest.Height) / 2;
            //this.lblGuest.Left = (this.Width - this.lblGuest.Width) / 2;
            //this.lblGuest.Left = this.lblGuest.Left / 5 * 4;

            base.OnResize(e);
        }

        #region 设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pbDrugLost = new System.Windows.Forms.PictureBox();
            this.pbDrugStoreQuery = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pbDrugStoreCount = new System.Windows.Forms.PictureBox();
            this.pbDrugBackProviderAdIn = new System.Windows.Forms.PictureBox();
            this.pbDrugStoreOut = new System.Windows.Forms.PictureBox();
            this.pbDrugBackCustom = new System.Windows.Forms.PictureBox();
            this.pbDrugChangePriceAdIn = new System.Windows.Forms.PictureBox();
            this.pbDrugStoreIn = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugBackProviderAdIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugBackCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugChangePriceAdIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrugLost
            // 
            this.pbDrugLost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugLost.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugLost.Image")));
            this.pbDrugLost.Location = new System.Drawing.Point(534, 18);
            this.pbDrugLost.Name = "pbDrugLost";
            this.pbDrugLost.Size = new System.Drawing.Size(130, 130);
            this.pbDrugLost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugLost.TabIndex = 7;
            this.pbDrugLost.TabStop = false;
            this.pbDrugLost.Click += new System.EventHandler(this.pbDrugLost_Click);
            // 
            // pbDrugStoreQuery
            // 
            this.pbDrugStoreQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugStoreQuery.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugStoreQuery.Image")));
            this.pbDrugStoreQuery.Location = new System.Drawing.Point(323, 184);
            this.pbDrugStoreQuery.Name = "pbDrugStoreQuery";
            this.pbDrugStoreQuery.Size = new System.Drawing.Size(130, 130);
            this.pbDrugStoreQuery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugStoreQuery.TabIndex = 10;
            this.pbDrugStoreQuery.TabStop = false;
            this.pbDrugStoreQuery.Click += new System.EventHandler(this.pbDrugStoreQuery_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Enabled = false;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(459, 126);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(90, 85);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 18;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Enabled = false;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(474, 230);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(64, 44);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Enabled = false;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(252, 230);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(64, 44);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Enabled = false;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(365, 323);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(64, 44);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(365, 134);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(64, 44);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pbDrugStoreCount
            // 
            this.pbDrugStoreCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugStoreCount.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugStoreCount.Image")));
            this.pbDrugStoreCount.Location = new System.Drawing.Point(523, 373);
            this.pbDrugStoreCount.Name = "pbDrugStoreCount";
            this.pbDrugStoreCount.Size = new System.Drawing.Size(130, 130);
            this.pbDrugStoreCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugStoreCount.TabIndex = 11;
            this.pbDrugStoreCount.TabStop = false;
            this.pbDrugStoreCount.Click += new System.EventHandler(this.pbDrugStoreCount_Click);
            // 
            // pbDrugBackProviderAdIn
            // 
            this.pbDrugBackProviderAdIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugBackProviderAdIn.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugBackProviderAdIn.Image")));
            this.pbDrugBackProviderAdIn.Location = new System.Drawing.Point(116, 199);
            this.pbDrugBackProviderAdIn.Name = "pbDrugBackProviderAdIn";
            this.pbDrugBackProviderAdIn.Size = new System.Drawing.Size(130, 130);
            this.pbDrugBackProviderAdIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugBackProviderAdIn.TabIndex = 9;
            this.pbDrugBackProviderAdIn.TabStop = false;
            this.pbDrugBackProviderAdIn.Click += new System.EventHandler(this.pbDrugBackProviderAdIn_Click);
            // 
            // pbDrugStoreOut
            // 
            this.pbDrugStoreOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugStoreOut.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugStoreOut.Image")));
            this.pbDrugStoreOut.Location = new System.Drawing.Point(337, 373);
            this.pbDrugStoreOut.Name = "pbDrugStoreOut";
            this.pbDrugStoreOut.Size = new System.Drawing.Size(130, 130);
            this.pbDrugStoreOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugStoreOut.TabIndex = 8;
            this.pbDrugStoreOut.TabStop = false;
            this.pbDrugStoreOut.Click += new System.EventHandler(this.pbDrugStoreOut_Click);
            // 
            // pbDrugBackCustom
            // 
            this.pbDrugBackCustom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugBackCustom.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugBackCustom.Image")));
            this.pbDrugBackCustom.Location = new System.Drawing.Point(555, 184);
            this.pbDrugBackCustom.Name = "pbDrugBackCustom";
            this.pbDrugBackCustom.Size = new System.Drawing.Size(130, 130);
            this.pbDrugBackCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugBackCustom.TabIndex = 6;
            this.pbDrugBackCustom.TabStop = false;
            this.pbDrugBackCustom.Click += new System.EventHandler(this.pbDrugBackCustom_Click);
            // 
            // pbDrugChangePriceAdIn
            // 
            this.pbDrugChangePriceAdIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugChangePriceAdIn.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugChangePriceAdIn.Image")));
            this.pbDrugChangePriceAdIn.Location = new System.Drawing.Point(146, 369);
            this.pbDrugChangePriceAdIn.Name = "pbDrugChangePriceAdIn";
            this.pbDrugChangePriceAdIn.Size = new System.Drawing.Size(130, 130);
            this.pbDrugChangePriceAdIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugChangePriceAdIn.TabIndex = 5;
            this.pbDrugChangePriceAdIn.TabStop = false;
            this.pbDrugChangePriceAdIn.Click += new System.EventHandler(this.pbDrugChangePriceAdIn_Click);
            // 
            // pbDrugStoreIn
            // 
            this.pbDrugStoreIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrugStoreIn.Image = ((System.Drawing.Image)(resources.GetObject("pbDrugStoreIn.Image")));
            this.pbDrugStoreIn.Location = new System.Drawing.Point(331, 0);
            this.pbDrugStoreIn.Name = "pbDrugStoreIn";
            this.pbDrugStoreIn.Size = new System.Drawing.Size(130, 130);
            this.pbDrugStoreIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrugStoreIn.TabIndex = 4;
            this.pbDrugStoreIn.TabStop = false;
            this.pbDrugStoreIn.Click += new System.EventHandler(this.pbDrugIn_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Enabled = false;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(256, 306);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(90, 89);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Enabled = false;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(457, 300);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(90, 94);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 20;
            this.pictureBox15.TabStop = false;
            // 
            // Welcome
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbDrugStoreOut);
            this.Controls.Add(this.pbDrugChangePriceAdIn);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pbDrugLost);
            this.Controls.Add(this.pbDrugStoreQuery);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pbDrugStoreCount);
            this.Controls.Add(this.pbDrugBackProviderAdIn);
            this.Controls.Add(this.pbDrugBackCustom);
            this.Controls.Add(this.pbDrugStoreIn);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox13);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1139, 606);
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugBackProviderAdIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugBackCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugChangePriceAdIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrugStoreIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        internal void InternalSetShell()
        {
            //if (account.OriginalID.Length == 0)
            //{
            //    (EAS.Application.Instance as EAS.Windows.Application).Shell.Text = "卫联医院管理信息系统 帐号名称:[" + account.AccountName + "] 帐号[" + account.LoginID + "]";
            //}
            //else
            //{
            //    (EAS.Application.Instance as EAS.Windows.Application).Shell.Text = "卫联医院管理信息系统 科室：[" + DataConvertHelper.GetDeptName(LoginInfo.Employee.DepartmentID) + "] 帐号名称:[" + account.AccountName + "] 帐号[" + account.LoginID + "]";
            //}
        }        

        internal void InternalLoginDepartSelect()
        {
            if (account.OriginalID.Length == 0)
            {
                return;
            }

            //IMultiDepartEmployeeList employeeList = WLPersonnel.DAL.Interface.DALHelper.DALManager.CreateMultiDepartEmployeeList();
            //employeeList.GetMultiDepartEmployeeList(LoginInfo.Employee.EmployeeID);

            //if (employeeList.Rows.Count > 0)
            //{
            //    employeeList.Rows.Clear();
            //    employeeList.GetMultiDepartEmployeeList2(LoginInfo.Employee.EmployeeID);

            //    FormLoginSelect select = new FormLoginSelect(employeeList);
            //    select.ShowDialog(this.ParentForm);
            //}
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    System.Drawing.Graphics g = e.Graphics;

        //    if (this.backImage != null)
        //    {
        //        g.DrawImage(this.backImage, this.Width - this.backImage.Width, this.Height - this.backImage.Height, this.backImage.Width, this.backImage.Height);
        //    }
        //}

        private void pbDrugIn_Click(object sender, EventArgs e)
        {
           // EAS.Application.Instance.OpenModule(typeof(DrugIn));
        }

        private void pbDrugLost_Click(object sender, EventArgs e)
        {
            // EAS.Application.Instance.OpenModule(typeof(DrugLost));
        }

        private void pbDrugBackProviderAdIn_Click(object sender, EventArgs e)
        {
            // EAS.Application.Instance.OpenModule(typeof(DrugBackProvider));
        }

        private void pbDrugStoreQuery_Click(object sender, EventArgs e)
        {
            // EAS.Application.Instance.OpenModule(typeof(DrugStoreQuery));
        }

        private void pbDrugBackCustom_Click(object sender, EventArgs e)
        {
            // EAS.Application.Instance.OpenModule(typeof(DrugBackCustom));
        }

        private void pbDrugChangePriceAdIn_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.OpenModule(typeof(DrugChangePrice));
        }

        private void pbDrugStoreOut_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.OpenModule(typeof(DrugSale));
        }

        private void pbDrugStoreCount_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.OpenModule(typeof(DrugStoreCount));
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}

