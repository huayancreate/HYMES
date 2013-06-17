using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
namespace HYMes.Tools
{  
    /// <summary>
    /// 
    /// </summary>
    public class Public
    {
        #region 使控件组件中的子控件清空并将enable属性设为Enable
        /// <summary>
        /// 使控件组件中的子控件清空并将enable属性设为Enable
        /// </summary>
        /// <param name="ctc"></param>
        public static void FindControlShow(Control.ControlCollection ctc)  //刷新时候，使相关控件中的值清空
        {
            foreach (Control ct in ctc)
            {
                if (ct.HasChildren)
                {
                    FindControlShow(ct.Controls);
                }
                switch (ct.GetType().Name)
                {
                    case "TextBox":
                        ((System.Windows.Forms.TextBox)ct).Text = "";
                        ((System.Windows.Forms.TextBox)ct).Enabled = true;
                        break;
                    case "ListBox":
                        ((System.Windows.Forms.ListBox)ct).Text = "";
                        ((System.Windows.Forms.ListBox)ct).Enabled = true;
                        break;
                    case "DataGridView":
                        // ((ListBox)ct).Text = "";
                        ((System.Windows.Forms.DataGridView)ct).Enabled = true;
                        break;
                    case "GroupBox":
                        break;
                    case "Button":
                        ((System.Windows.Forms.Button)ct).Enabled = true;
                        break;
                    case "CheckBox":
                        ((System.Windows.Forms.CheckBox)ct).Checked = false;
                        ((System.Windows.Forms.CheckBox)ct).Enabled = true;
                        break;
                    case "ComboBox":
                        ((System.Windows.Forms.ComboBox)ct).Text = "";
                        //((System.Windows.Forms.ComboBox)ct).SelectedIndex = -1;
                        ((System.Windows.Forms.ComboBox)ct).Enabled = true;
                        break;
                    //case "DataGridView":
                    //    ((DataGridView)ct).DataSource = null;
                    //    ((DataGridView)ct).Enabled = false;
                    //    break;
                    case "RadioButton":
                        ((System.Windows.Forms.RadioButton)ct).Checked = false;
                        ((System.Windows.Forms.RadioButton)ct).Enabled = true;
                        break;
                    case "DateTimePicker"://System.Windows.Forms.DateTimePicker
                        // ((System.Windows.Forms.DateTimePicker)ct).Checked = false;
                        ((System.Windows.Forms.DateTimePicker)ct).Enabled = true;
                        break;
                    case "RichTextBox"://System.Windows.Forms.DateTimePicker
                        ((System.Windows.Forms.RichTextBox)ct).Text = "";
                        ((System.Windows.Forms.RichTextBox)ct).Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
