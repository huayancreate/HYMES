namespace HYMes.WinUI.BaseControl
{
    partial class UcPaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPaging));
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
            ((System.ComponentModel.ISupportInitialize)(this.bdnInfo)).BeginInit();
            this.bdnInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.tstExport});
            this.bdnInfo.Location = new System.Drawing.Point(0, 12);
            this.bdnInfo.MoveFirstItem = null;
            this.bdnInfo.MoveLastItem = null;
            this.bdnInfo.MoveNextItem = null;
            this.bdnInfo.MovePreviousItem = null;
            this.bdnInfo.Name = "bdnInfo";
            this.bdnInfo.PositionItem = null;
            this.bdnInfo.Size = new System.Drawing.Size(855, 25);
            this.bdnInfo.TabIndex = 5;
            this.bdnInfo.RefreshItems += new System.EventHandler(this.bdnInfo_RefreshItems);
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
            // UcPaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bdnInfo);
            this.Name = "UcPaging";
            this.Size = new System.Drawing.Size(855, 37);
            ((System.ComponentModel.ISupportInitialize)(this.bdnInfo)).EndInit();
            this.bdnInfo.ResumeLayout(false);
            this.bdnInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.BindingNavigator bdnInfo;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblShowTotalCount;
        private System.Windows.Forms.ToolStripTextBox txtTotalRowCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstOnePageShowCount;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton tstExport;
    }
}
