namespace HYMes.WinUI.BaseControl
{
    partial class UcBRM
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBRM));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bdnInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblsumPageCount = new System.Windows.Forms.ToolStripLabel();
            this.MoveFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.txtCurrPageCnt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.MoveLastPage = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblShowTotalCount = new System.Windows.Forms.ToolStripLabel();
            this.txtTotalRowCount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstOnePageShowCount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnInfo)).BeginInit();
            this.bdnInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bdnInfo);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 498);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 0;
            // 
            // bdnInfo
            // 
            this.bdnInfo.AddNewItem = null;
            this.bdnInfo.CountItem = this.lblsumPageCount;
            this.bdnInfo.CountItemFormat = "{0}";
            this.bdnInfo.DeleteItem = null;
            this.bdnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirstPage,
            this.btnLastPage,
            this.bindingNavigatorSeparator,
            this.txtCurrPageCnt,
            this.toolStripLabel2,
            this.lblsumPageCount,
            this.bindingNavigatorSeparator1,
            this.btnNextPage,
            this.MoveLastPage,
            this.bindingNavigatorSeparator2,
            this.lblShowTotalCount,
            this.txtTotalRowCount,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.tstOnePageShowCount,
            this.toolStripSeparator4,
            this.tstExport,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnAdd,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator5,
            this.btnModify});
            this.bdnInfo.Location = new System.Drawing.Point(0, 30);
            this.bdnInfo.MoveFirstItem = null;
            this.bdnInfo.MoveLastItem = null;
            this.bdnInfo.MoveNextItem = null;
            this.bdnInfo.MovePreviousItem = null;
            this.bdnInfo.Name = "bdnInfo";
            this.bdnInfo.PositionItem = null;
            this.bdnInfo.Size = new System.Drawing.Size(1026, 25);
            this.bdnInfo.TabIndex = 32;
            this.bdnInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bdnInfo_ItemClicked);
            // 
            // lblsumPageCount
            // 
            this.lblsumPageCount.Name = "lblsumPageCount";
            this.lblsumPageCount.Size = new System.Drawing.Size(23, 22);
            this.lblsumPageCount.Text = "{0}";
            this.lblsumPageCount.ToolTipText = "总项数";
            // 
            // MoveFirstPage
            // 
            this.MoveFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirstPage.Image")));
            this.MoveFirstPage.Name = "MoveFirstPage";
            this.MoveFirstPage.RightToLeftAutoMirrorImage = true;
            this.MoveFirstPage.Size = new System.Drawing.Size(23, 22);
            this.MoveFirstPage.Text = "移至首页";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.RightToLeftAutoMirrorImage = true;
            this.btnLastPage.Size = new System.Drawing.Size(64, 22);
            this.btnLastPage.Text = "上一页";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCurrPageCnt
            // 
            this.txtCurrPageCnt.AccessibleName = "位置";
            this.txtCurrPageCnt.AutoSize = false;
            this.txtCurrPageCnt.BackColor = System.Drawing.Color.White;
            this.txtCurrPageCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrPageCnt.Name = "txtCurrPageCnt";
            this.txtCurrPageCnt.Size = new System.Drawing.Size(50, 23);
            this.txtCurrPageCnt.Text = "0";
            this.txtCurrPageCnt.ToolTipText = "当前位置";
            this.txtCurrPageCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrPageCnt_KeyPress);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel2.Text = "/";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.RightToLeftAutoMirrorImage = true;
            this.btnNextPage.Size = new System.Drawing.Size(64, 22);
            this.btnNextPage.Text = "下一页";
            // 
            // MoveLastPage
            // 
            this.MoveLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLastPage.Image = ((System.Drawing.Image)(resources.GetObject("MoveLastPage.Image")));
            this.MoveLastPage.Name = "MoveLastPage";
            this.MoveLastPage.RightToLeftAutoMirrorImage = true;
            this.MoveLastPage.Size = new System.Drawing.Size(23, 22);
            this.MoveLastPage.Text = "移至末页";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblShowTotalCount
            // 
            this.lblShowTotalCount.Name = "lblShowTotalCount";
            this.lblShowTotalCount.Size = new System.Drawing.Size(59, 22);
            this.lblShowTotalCount.Text = "总记录数:";
            // 
            // txtTotalRowCount
            // 
            this.txtTotalRowCount.BackColor = System.Drawing.Color.White;
            this.txtTotalRowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalRowCount.Enabled = false;
            this.txtTotalRowCount.Name = "txtTotalRowCount";
            this.txtTotalRowCount.Size = new System.Drawing.Size(50, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel1.Text = "每页显示的记录数：";
            // 
            // tstOnePageShowCount
            // 
            this.tstOnePageShowCount.BackColor = System.Drawing.Color.White;
            this.tstOnePageShowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstOnePageShowCount.Name = "tstOnePageShowCount";
            this.tstOnePageShowCount.Size = new System.Drawing.Size(40, 25);
            this.tstOnePageShowCount.ToolTipText = "输入每页显示的记录数后按回车!";
            this.tstOnePageShowCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstOnePageShowCount_KeyPress);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tstExport
            // 
            this.tstExport.Image = ((System.Drawing.Image)(resources.GetObject("tstExport.Image")));
            this.tstExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExport.Name = "tstExport";
            this.tstExport.Size = new System.Drawing.Size(76, 22);
            this.tstExport.Text = "资料汇出";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(52, 22);
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ledClock);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 33);
            this.panel2.TabIndex = 31;
            // 
            // ledClock
            // 
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2013, 6, 15, 21, 47, 31, 0);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(817, 7);
            this.ledClock.Name = "ledClock";
            this.ledClock.Size = new System.Drawing.Size(144, 23);
            this.ledClock.TabIndex = 39;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(753, 14);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 12);
            this.label38.TabIndex = 37;
            this.label38.Text = "当前日期：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SkyBlue;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(5, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "厂别信息";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcBRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcBRM";
            this.Size = new System.Drawing.Size(1026, 498);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdnInfo)).EndInit();
            this.bdnInfo.ResumeLayout(false);
            this.bdnInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label11;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.ToolStripLabel lblsumPageCount;
        private System.Windows.Forms.ToolStripButton MoveFirstPage;
        private System.Windows.Forms.ToolStripButton btnLastPage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox txtCurrPageCnt;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton MoveLastPage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel lblShowTotalCount;
        private System.Windows.Forms.ToolStripTextBox txtTotalRowCount;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstOnePageShowCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tstExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnModify;
        protected internal System.Windows.Forms.BindingNavigator bdnInfo;
    }
}
