using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
namespace HYMes.Tools
{
    /// <summary>
    /// 文件的FTP上传与FTP下载
    /// </summary>
    public class FTPDownUp
    {

        #region 参数设置
        //private static FTPDownUp activeFTPDownUp;

        ///// <summary>
        ///// 单例模式
        ///// </summary>
        //public static FTPDownUp ActiveFTPDownUp
        //{
        //    get
        //    {
        //        if (activeFTPDownUp == null)
        //        {
        //            activeFTPDownUp = new FTPDownUp();
        //        }
        //        return FTPDownUp.activeFTPDownUp;
        //    }
        //    set { FTPDownUp.activeFTPDownUp = value; }
        //}

        private string serverAddr;
        /// <summary>
        /// FTP服务器地址
        /// </summary>
        public string ServerAddr
        {
            get { return serverAddr; }
            set { serverAddr = value; }
        }

        private int serverPort;
        /// <summary>
        /// FTP服务器端口号
        /// </summary>
        public int ServerPort
        {
            get
            {
                return serverPort;
            }
            set { serverPort = value; }
        }

        private string userID;

        /// <summary>
        /// 登录FTP服务器的账号
        /// </summary>
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string password;

        /// <summary>
        /// 登录FTP服务器的账号密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion


        /// <summary>
        /// 构造函数
        /// </summary>
        public FTPDownUp()
        {

        }
        /// <summary>
        /// FTP构造函数
        /// </summary>
        /// <param name="serverAdd">FTP服务器地址</param>
        /// <param name="serverPort">FTP服务器端口号</param>
        /// <param name="userID">登录FTP服务器的账号</param>
        /// <param name="password">登录FTP服务器的账号密码</param>
        public FTPDownUp(string serverAdd, int serverPort, string userID, string password)
        {
            //this.ServerAddr = serverAdd;
            this.serverPort = serverPort != 0 ? serverPort : 21;
            this.ServerAddr = serverAdd;
            this.UserID = userID;
            this.Password = password;
        }
        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="remoteFilePath">远程FTPServer上的路径</param>
        /// <param name="remoteFileName">远程FTPServer杀过的文件名称</param>
        /// <param name="localFilePath">本地目录，以“\”分隔每一级目录。如果为空，下载到当前目录。如果非空，以“\”结尾</param>
        /// <param name="localFileName">本地文件名，如果为空，则与远程文件同名</param>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool FTPDownload(string remoteFilePath, string remoteFileName, string localFilePath, string localFileName, out string info)
        {
            bool bRet = false;

            //如果本地文件名为空，则与远程文件同名   
            localFileName = localFileName != "" ? localFileName : remoteFileName;

            // System.Uri tt = new Uri("ftp://" + serverAddr + ":" + serverPort + "/" + remoteFilePath + remoteFileName);//add by cs ceshi
            //初始化ftp目标   
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + serverAddr + ":" + serverPort + "/" + remoteFilePath + remoteFileName));

            //命令方法为下载   
            req.Method = WebRequestMethods.Ftp.DownloadFile;

            //二进制方式传输，即传输文件   
            req.UseBinary = true;

            //登录凭证   
            req.Credentials = new NetworkCredential(this.userID, this.password);
            try
            {
                //发送命令请求至FTP服务器，并得到FtpWebResponse返回结果   
                FtpWebResponse resp = (FtpWebResponse)req.GetResponse();

                //读取FtpWebResponse结果的返回数据流到Stream   
                using (Stream downloadStream = resp.GetResponseStream())
                {
                    //接受数据长度   
                    long length = resp.ContentLength;

                    //缓冲区大小为2048   
                    int bufferSize = 2048;

                    //每次读取到的字节数   
                    int readCount;

                    //缓冲区   
                    byte[] buffer = new byte[bufferSize];

                    //定义本地文件流   
                    using (FileStream fileStream = new FileStream(localFilePath + localFileName, FileMode.Create))
                    {
                        //第一次读取最大为bufferSize字节的内容，内容装到buffer中，长度返回至readCount   
                        readCount = downloadStream.Read(buffer, 0, bufferSize);

                        //读取到内容   
                        while (readCount > 0)
                        {
                            //将内容写入文件流生成文件内容   
                            fileStream.Write(buffer, 0, readCount);

                            //继续读取保存返回数据的Stream   
                            readCount = downloadStream.Read(buffer, 0, bufferSize);
                        }
                    }
                }

                //操作结束，给附加信息info赋值。也可以用resp.StatusCode判断一下   
                info = "SUCCESS";
                bRet = true;
            }
            catch (Exception e)
            {
                //异常情况，返回异常信息   
                info = e.Message;
            }
            return bRet;
        }

        /// <summary>   
        /// FTP上传文件   
        /// </summary>   
        /// <param name="remoteFilePath">远程目录，以“/”分隔每一级目录。如果非空，以“/”结尾</param>   
        /// <param name="remoteFileName">远程文件名，如果为空，则与本地文件同名</param>   
        /// <param name="localFilePath">本地目录，以“\”分隔每一级目录。如果为空，下载到当前目录。如果非空，以“\”结尾</param>   
        /// <param name="localFileName">本地文件名</param>   
        /// <param name="info"></param>   
        /// <returns></returns>   
        public bool FTPUpload(string remoteFilePath, string remoteFileName, FileInfo fileInfo, out string info)
        // public bool Upload(string remoteFilePath, string remoteFileName, string localFilePath, string localFileName, out string info)
        {
            //ChkAndSetDir(remoteFilePath);
            bool bRet = false;
            try
            {
                bRet = true;
                //加载本地文件   
                //  FileInfo fileInfo = new FileInfo(localFilePath + localFileName); //mark by cs 20120912
                // FileInfo fileInfo = new FileInfo(localFilePathFileName);

                //如果远程文件名为空，则与本地文件同名   
                // remoteFileName = remoteFileName != "" ? remoteFileName : localFileName;  //mark by cs 20120912
                remoteFileName = remoteFileName != "" ? remoteFileName : fileInfo.Name;
                string str = "ftp://" + serverAddr + ":" + serverPort + "/" + remoteFilePath;
                ChkAndSetDir(str);


                FtpWebRequest ftpReq = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + serverAddr + ":" + serverPort + "/" + remoteFilePath + remoteFileName));//初始化ftp目标   
                // FtpWebRequest ftpReq = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + serverAddr + ":" + serverPort + "/"));//初始化ftp目标   
                ftpReq.Method = WebRequestMethods.Ftp.UploadFile;//上传方式   
                ftpReq.UseBinary = true;//二进制方式上传，即上传文件   
                ftpReq.Credentials = new NetworkCredential(this.userID, this.password);//登录凭证   
                ftpReq.ContentLength = fileInfo.Length;
                ftpReq.UsePassive = true;
                int bufferSize = 2048 * 10;
                int length;
                byte[] buffer = new byte[bufferSize];

                //将文件流存入FileStream中   
                using (FileStream fs = fileInfo.OpenRead())
                {
                    //上传流指向Stream   
                    using (Stream stream = ftpReq.GetRequestStream())
                    {
                        //读取文件流中最大长度为bufferSize字节内容至buffer，读取长度返回至length   
                        length = fs.Read(buffer, 0, bufferSize);

                        //如果读取到了内容   
                        while (length != 0)
                        {
                            //buffer写入上传流   
                            stream.Write(buffer, 0, length);

                            //继续读取   
                            length = fs.Read(buffer, 0, bufferSize);
                        }
                        info = "SUCCESS";
                    }
                }
            }
            catch (Exception e)
            {
                info = e.Message;
                bRet = false;
            }
            return bRet;
        }

        /// <summary>
        /// 如果目录不存在，将创建新目录
        /// </summary>
        /// <param name="objPath"></param>
        void ChkAndSetDir(string objPath)
        {

            if (!DirExist(objPath))
            {
                FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(objPath);
                req.Method = WebRequestMethods.Ftp.MakeDirectory;
                req.Credentials = new NetworkCredential(this.userID, this.password);//登录凭证   
                // Directory.CreateDirectory(objPath);
                FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                res.Close();
            }
        }
        /// <summary>
        /// 判定该目录是否存在
        /// </summary>
        /// <param name="objPath"></param>
        /// <returns></returns>
        Boolean DirExist(string objPath)
        {
            Boolean bl = false;
            try
            {
                FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(objPath);
                req.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                req.Credentials = new NetworkCredential(this.userID, this.password);//登录凭证   
                // Directory.CreateDirectory(objPath);
                FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());

                string line = reader.ReadLine();

                while (line != null)
                {
                    bl = true;
                    line = reader.ReadLine();
                }
                reader.Close();
                res.Close();
            }
            catch (Exception ex)
            {
                bl = false;
            }
            finally
            {

            }
            return bl;
        }





        /// <summary>
        /// FTP文件下载
        /// </summary>
        /// <param name="remoteFilePathAndFileName">远程需要下载的文件路径及名称</param>
        /// <param name="localFilePathAndName">本地需要下载的文件路径及名称</param>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool FTPDownload(string remoteFilePathAndFileName, string localFilePathAndName, out string info)
        {
            bool bRet = false;

            //如果本地文件名为空，则与远程文件同名   
            //  localFileName = localFileName != "" ? localFileName : remoteFileName;

            // System.Uri tt = new Uri("ftp://" + serverAddr + ":" + serverPort + "/" + remoteFilePath + remoteFileName);//add by cs ceshi
            //初始化ftp目标   
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + serverAddr + ":" + serverPort + "/" + remoteFilePathAndFileName));

            //命令方法为下载   
            req.Method = WebRequestMethods.Ftp.DownloadFile;

            //二进制方式传输，即传输文件   
            req.UseBinary = true;

            //登录凭证   
            req.Credentials = new NetworkCredential(this.userID, this.password);
            try
            {
                //发送命令请求至FTP服务器，并得到FtpWebResponse返回结果   
                FtpWebResponse resp = (FtpWebResponse)req.GetResponse();

                //读取FtpWebResponse结果的返回数据流到Stream   
                using (Stream downloadStream = resp.GetResponseStream())
                {
                    //接受数据长度   
                    long length = resp.ContentLength;

                    //缓冲区大小为2048   
                    int bufferSize = 2048;

                    //每次读取到的字节数   
                    int readCount;

                    //缓冲区   
                    byte[] buffer = new byte[bufferSize];

                    //定义本地文件流   
                    using (FileStream fileStream = new FileStream(localFilePathAndName, FileMode.Create))
                    {
                        //第一次读取最大为bufferSize字节的内容，内容装到buffer中，长度返回至readCount   
                        readCount = downloadStream.Read(buffer, 0, bufferSize);

                        //读取到内容   
                        while (readCount > 0)
                        {
                            //将内容写入文件流生成文件内容   
                            fileStream.Write(buffer, 0, readCount);

                            //继续读取保存返回数据的Stream   
                            readCount = downloadStream.Read(buffer, 0, bufferSize);
                        }
                    }
                }

                //操作结束，给附加信息info赋值。也可以用resp.StatusCode判断一下   
                info = "SUCCESS";
                bRet = true;
            }
            catch (Exception e)
            {
                //异常情况，返回异常信息   
                info = e.Message;
            }
            return bRet;
        }

    }
}
