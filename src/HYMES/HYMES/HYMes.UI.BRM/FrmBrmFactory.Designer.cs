namespace HYMes.WinUI.BRM
{
    partial class FrmBrmFactory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvFactoryDetail = new HYMes.WinUI.Base.ControlUIExt.DataGridViewExt();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFactoryLogDetail = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTORY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTORY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTORY_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOLD_FLG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAY_POINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEEK_POINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOLD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTORY_KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRX_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trx_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactoryDetail)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactoryLogDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 439);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "清单明细";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvFactoryDetail);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1012, 407);
            this.panel5.TabIndex = 1;
            // 
            // dgvFactoryDetail
            // 
            this.dgvFactoryDetail.AllowUserToAddRows = false;
            this.dgvFactoryDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactoryDetail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFactoryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactoryDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FACTORY_ID,
            this.FACTORY_NAME,
            this.FACTORY_DESC,
            this.HOLD_FLG,
            this.DAY_POINT,
            this.WEEK_POINT,
            this.ACTIVE,
            this.HOLD_DATE,
            this.FACTORY_KEY,
            this.TRX_DATE,
            this.trx_name});
            this.dgvFactoryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactoryDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvFactoryDetail.Name = "dgvFactoryDetail";
            this.dgvFactoryDetail.ReadOnly = true;
            this.dgvFactoryDetail.RowTemplate.Height = 23;
            this.dgvFactoryDetail.Size = new System.Drawing.Size(1012, 407);
            this.dgvFactoryDetail.TabIndex = 7;
            this.dgvFactoryDetail.SelectionChanged += new System.EventHandler(this.dgvFactoryDetail_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvFactoryLogDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "履历";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFactoryLogDetail
            // 
            this.dgvFactoryLogDetail.AllowUserToAddRows = false;
            this.dgvFactoryLogDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactoryLogDetail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFactoryLogDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactoryLogDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column8,
            this.Column11,
            this.Column12,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.dgvFactoryLogDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactoryLogDetail.Location = new System.Drawing.Point(3, 3);
            this.dgvFactoryLogDetail.Name = "dgvFactoryLogDetail";
            this.dgvFactoryLogDetail.ReadOnly = true;
            this.dgvFactoryLogDetail.RowTemplate.Height = 23;
            this.dgvFactoryLogDetail.Size = new System.Drawing.Size(1012, 407);
            this.dgvFactoryLogDetail.TabIndex = 6;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TRX_MODE";
            this.Column10.HeaderText = "交易模式";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FACTORY_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "厂别代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FACTORY_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "厂别名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FACTORY_DESC";
            this.dataGridViewTextBoxColumn3.HeaderText = "厂别说明";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HOLD_FLG";
            this.dataGridViewTextBoxColumn4.HeaderText = "是否HOLD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DAY_POINT";
            this.dataGridViewTextBoxColumn5.HeaderText = "换日时点";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WEEK_POINT";
            this.dataGridViewTextBoxColumn6.HeaderText = "换周日别";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ACTIVE";
            this.Column8.HeaderText = "活动标示";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "LOCAL_HOST_IP";
            this.Column11.HeaderText = "IP地址";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "LOCAL_HOST_NAME";
            this.Column12.HeaderText = "电脑名称";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TRX_DATE";
            this.dataGridViewTextBoxColumn7.HeaderText = "最后修改日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TRX_LOGINID";
            this.dataGridViewTextBoxColumn9.HeaderText = "最后修改人";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // FACTORY_ID
            // 
            this.FACTORY_ID.DataPropertyName = "FACTORY_ID";
            this.FACTORY_ID.HeaderText = "厂别代码";
            this.FACTORY_ID.Name = "FACTORY_ID";
            this.FACTORY_ID.ReadOnly = true;
            // 
            // FACTORY_NAME
            // 
            this.FACTORY_NAME.DataPropertyName = "FACTORY_NAME";
            this.FACTORY_NAME.HeaderText = "厂别名称";
            this.FACTORY_NAME.Name = "FACTORY_NAME";
            this.FACTORY_NAME.ReadOnly = true;
            // 
            // FACTORY_DESC
            // 
            this.FACTORY_DESC.DataPropertyName = "FACTORY_DESC";
            this.FACTORY_DESC.HeaderText = "厂别说明";
            this.FACTORY_DESC.Name = "FACTORY_DESC";
            this.FACTORY_DESC.ReadOnly = true;
            // 
            // HOLD_FLG
            // 
            this.HOLD_FLG.DataPropertyName = "HOLD_FLG";
            this.HOLD_FLG.HeaderText = "是否HOLD";
            this.HOLD_FLG.Name = "HOLD_FLG";
            this.HOLD_FLG.ReadOnly = true;
            // 
            // DAY_POINT
            // 
            this.DAY_POINT.DataPropertyName = "DAY_POINT";
            this.DAY_POINT.HeaderText = "换日时点";
            this.DAY_POINT.Name = "DAY_POINT";
            this.DAY_POINT.ReadOnly = true;
            // 
            // WEEK_POINT
            // 
            this.WEEK_POINT.DataPropertyName = "WEEK_POINT";
            this.WEEK_POINT.HeaderText = "换周日别";
            this.WEEK_POINT.Name = "WEEK_POINT";
            this.WEEK_POINT.ReadOnly = true;
            // 
            // ACTIVE
            // 
            this.ACTIVE.DataPropertyName = "ACTIVE";
            this.ACTIVE.HeaderText = "是否活动";
            this.ACTIVE.Name = "ACTIVE";
            this.ACTIVE.ReadOnly = true;
            // 
            // HOLD_DATE
            // 
            this.HOLD_DATE.DataPropertyName = "HOLD_DATE";
            this.HOLD_DATE.HeaderText = "HOLD日期";
            this.HOLD_DATE.Name = "HOLD_DATE";
            this.HOLD_DATE.ReadOnly = true;
            // 
            // FACTORY_KEY
            // 
            this.FACTORY_KEY.DataPropertyName = "FACTORY_KEY";
            this.FACTORY_KEY.HeaderText = "FACTORY_KEY";
            this.FACTORY_KEY.Name = "FACTORY_KEY";
            this.FACTORY_KEY.ReadOnly = true;
            this.FACTORY_KEY.Visible = false;
            // 
            // TRX_DATE
            // 
            this.TRX_DATE.DataPropertyName = "TRX_DATE";
            this.TRX_DATE.HeaderText = "最后修改日期";
            this.TRX_DATE.Name = "TRX_DATE";
            this.TRX_DATE.ReadOnly = true;
            // 
            // trx_name
            // 
            this.trx_name.DataPropertyName = "trx_name";
            this.trx_name.HeaderText = "最后修改人";
            this.trx_name.Name = "trx_name";
            this.trx_name.ReadOnly = true;
            // 
            // FrmBrmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "FrmBrmFactory";
            this.Load += new System.EventHandler(this.FrmBaseFormTest_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactoryDetail)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactoryLogDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private Base.ControlUIExt.DataGridViewExt dgvFactoryDetail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFactoryLogDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTORY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTORY_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOLD_FLG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAY_POINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEEK_POINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOLD_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTORY_KEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRX_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn trx_name;



    }
}
