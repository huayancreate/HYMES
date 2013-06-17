using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Sys.Unit.BaseForm
{
    using System;
    using System.Data;

    public class NewRowSelectedEventArgs : EventArgs
    {
        private bool afterUserFilter = false;
        private DataRow drSelected;
        private bool userClick = false;

        public bool AfterUserFilter
        {
            get
            {
                return this.afterUserFilter;
            }
            set
            {
                this.afterUserFilter = value;
            }
        }

        public DataRow SelectedDataRow
        {
            get
            {
                return this.drSelected;
            }
            set
            {
                this.drSelected = value;
            }
        }

        public bool UserClick
        {
            get
            {
                return this.userClick;
            }
            set
            {
                this.userClick = value;
            }
        }
    }
}
