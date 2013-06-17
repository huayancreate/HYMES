using System;
using EAS.Explorer;

namespace HYMes.Res
{
	public class Resources:EAS.Explorer.IResource  
	{
        /// <summary>
        /// 主界面图标。
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Icon GetMainIcon()
        {
            return Properties.Resources.Drugbasket;
           
        }

        /// <summary>
        /// Tab页图标
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Image GetModuleIcon()
        {
            return Properties.Resources.Module.ToBitmap();
        }

        /// <summary>
        /// 桌面背景。
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Image GetDesktopImage()
        {
            return null;
        }

        /// <summary>
        /// 应用程序名称。
        /// </summary>
        /// <returns></returns>
        public string GetApplicationName()
        {
            return "制造执行系统";
        }

        /// <summary>
        /// 应用程序标题。
        /// </summary>
        /// <returns></returns>
        public string GetApplicationTitle()
        {
            return "HY Manufacturing Execution System";
        }

        public object GetMainShell()
        {
            return null;
        }

        /// <summary>
        /// 关于窗口。
        /// </summary>
        /// <returns></returns>
        public object GetAboutForm()
        {
            return new AboutForm();
        }

        /// <summary>
        /// Bottom通知。
        /// </summary>
        /// <returns></returns>
        public object GetBottomControl()
        {
            return new BottomControl();
        }

        /// <summary>
        /// Top条幅。
        /// </summary>
        /// <returns></returns>
        public object GetBannerControl()
        {
            return new Banner();
           // return null;
        }

        /// <summary>
        /// 导航工具条。
        /// </summary>
        /// <returns></returns>
        public object GetNavigationControl()
        {
            return new NavigationControl();
        }

        /// <summary>
        /// 登录窗口。
        /// </summary>
        /// <returns></returns>
        public ILoginForm GetLoginForm()
        {  

            
            return new LoginForm();

           // return new Login();
        }

        /// <summary>
        /// 起始页。
        /// </summary>
        /// <returns></returns>
        public object GetStartModule()
        {
            return new Welcome();
        }

        /// <summary>
        /// 显示菜单。
        /// </summary>
        public bool DisplayMainMenu
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 显示导航工具条。
        /// </summary>
        public bool DisplayNavigationTool
        {
            get
            {
                return false;
            }
        }
    }
}