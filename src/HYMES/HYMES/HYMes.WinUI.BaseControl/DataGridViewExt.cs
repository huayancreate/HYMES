using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYMes.WinUI.BaseControl
{
    public partial class DataGridViewExt : DataGridView
    {
        public DataGridViewExt()
            :base()
        {
            InitializeComponent();
            this.AllowUserToAddRows = false;
          this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void DataGridViewExt_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
        /// <summary>
        /// 增加datagridview前面的序列号
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle =
                new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, Convert.ToInt32(e.RowIndex + 1).ToString(), this.RowHeadersDefaultCellStyle.Font, rectangle, this.
            RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            base.OnRowPostPaint(e);
        }
    }
}
