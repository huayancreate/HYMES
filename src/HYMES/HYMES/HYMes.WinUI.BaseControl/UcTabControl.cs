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
    public partial class UcTabControl : System.Windows.Forms.TabControl
    {
        public UcTabControl()
            :base()
        {
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
