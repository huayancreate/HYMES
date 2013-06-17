using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace HYMes.Tools
{
    /// <summary>
    /// 常用正则表达式
    /// </summary>
    public class RegexExp
    {
        /// <summary>
        /// 确认输入的邮件地址是否是合法的
        /// </summary>
        /// <param name="mailAddress">待匹配的、输入的邮件地址</param>
        /// <returns>Boolean True为合法的、false为非法的邮件的地址</returns>
        public static Boolean IsMailAddress(string mailAddress)
        {
            string patten = @"[a-zA-Z0-9]+@[a-zA-Z]+\.(com|cn|net)$";
            Regex reg = new Regex(patten);
            Match match = reg.Match(mailAddress);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  确认输入的电话号码是否是合法的
        /// </summary>
        /// <param name="telephoneNumber">输入的电话号码</param>
        /// <returns>Boolean True为合法的、false为非法的电话号码</returns>
        public static Boolean IsTelephoneNumber(string telephoneNumber)
        {
            string patten = @"[0-9]\.{0,1}[0-9]$";  //有问题
            Regex reg = new Regex(patten);
            Match match = reg.Match(telephoneNumber);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  确认输入的是否是合法数值(数字)
        /// </summary>
        /// <param name="Number">输入的数值字符串</param>
        /// <returns>Boolean True为合法的、false为非法的数值</returns>
        public static Boolean IsNumber(string Number)
        {
            string patten = @"^[0-9]{1,}$";
           // string patten = @"\d";
            Regex reg = new Regex(patten);
            Match match = reg.Match(Number);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 确认输入的字符串是否为货币型
        /// </summary>
        /// <param name="Curr">输入的货币字符串</param>
        /// <returns></returns>
        public static Boolean IsCurr(string Curr)
        {
            string patten = @"[0-9]\.{0,1}[0-9]$";
            Regex reg = new Regex(patten);
            Match match = reg.Match(Curr);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
