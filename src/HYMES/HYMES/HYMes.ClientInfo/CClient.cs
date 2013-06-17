using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Data;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HYMes.ClientInfo
{   
    /// <summary>
    /// 获取客户端的基本信息
    /// </summary>
    public class ClientInfo
    {

        private static int width=SystemInformation.WorkingArea.Width; //显示器的宽度(像素)
        private static  int heigh = SystemInformation.WorkingArea.Height;//显示器的高度(像素)
        private List<string> SQL = new List<string>();
        private static ClientInfo cClientInfo;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ClientInfo()
        {
           
        }
        /// <summary>
        /// 获取CClient实例ActiveucClient
        /// </summary>
        public static ClientInfo ActiveucClientInfo
        {
            get
            {
                if (cClientInfo == null)
                {

                    cClientInfo = new ClientInfo();
                    return cClientInfo;
                }
                else
                {
                    return cClientInfo;
                }
            }
        }
        /// <summary>
        /// 显示器的宽度(像素)
        /// </summary>
        public static int Width
        {
            get { return width; }
            set { width = value; }
        }
        /// <summary>
        /// 显示器的高度(像素)
        /// </summary>
        public static int Heigh
        {
            get { return heigh; }
            set { heigh=value; }
        }
      /// <summary>
      /// 登录电脑的账号
      /// </summary>
        public static string HostAccount
        {
            get {
                return SystemInformation.UserName.ToString();
            }
        }
/// <summary>
/// 主机IP地址
/// </summary>
        public static string LocalIP
        {
            get
            {
                IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
                for (int i = 0; i < addressList.Length; i++)
                {
                    if ((addressList[i].AddressFamily.ToString() == "InterNetwork") && !addressList[i].IsIPv6LinkLocal)
                    {
                        return addressList[i].ToString();
                    }
                }
                return "";
            }
        }
        /// <summary>
        /// 本机计算机名称
        /// </summary>
        public static string LocaComputerlName
        {
            get
            {
                return Dns.GetHostName();
            }
        }
      
    }
}
