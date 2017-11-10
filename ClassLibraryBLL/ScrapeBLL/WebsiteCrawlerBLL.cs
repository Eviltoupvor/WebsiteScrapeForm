using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL.TextProcess;
using ClassLibraryDAL.SerialIOProcess;
using ClassLibraryDAL.WebsiteScrapeProcess;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClassLibraryBLL.ScrapeBLL
{
    /// <summary>
    /// http://www.jb51.net/article/67253.htm C# WinForm程序处理后台繁忙导致前台控件假死现象解决方法
    /// </summary>
    public class WebsiteCrawlerBLL
    {
        private static int count = 0;
        private RegexOS RegexOS;
        private IOProcessOS ProcessIO;
        private WebsiteCrawlerOS WebsiteCrawlerOS;
        public WebsiteCrawlerBLL()
        {
            RegexOS = RegexOS.ExecuteRegexExpression(false);
            ProcessIO = IOProcessOS.ExecuteProcessIO(false);
            WebsiteCrawlerOS = WebsiteCrawlerOS.ExecuteWebsiteCrawler(false);
        }

        /// <summary>
        /// 爬取所有淘宝图片的地址
        /// </summary>
        /// <param name="path">存放txt文件路径</param>
        /// <param name="html">抓取的HTML文本</param>
        public string ScrapeWebImagesSrc(string html, string originalPath)
        {
            ProcessIO.ClearContentByFileStream(originalPath);
            var content = RegexOS.MatchText = html;
            foreach (Match item in RegexOS.RegexMatches(FrequentlyUsedPattern.ImageSrc))
            {
                File.AppendAllText(originalPath, item.Groups["imgUrl"].Value + Environment.NewLine);
            }
            Application.DoEvents();
            return "正在加载网页图片地址......";
        }

        public string[] SplitString(string originalPath)
        {
            return ProcessIO.StreamReadToEnd(originalPath, Encoding.UTF8).Split(new string[] { "\r\n" }, StringSplitOptions.None);
        }

        public string AlicdnStoreLogoSrc(string originalPath, string filteredPath)
        {
            ProcessIO.ClearContentByFileStream(filteredPath);
            string[] filteredStr = SplitString(originalPath);
            for (int i = 0; i < filteredStr.Length - 1; i++)
            {
                Console.WriteLine("第 {0} 行: 网络地址{1},网络文件名{2}", i + 1, filteredStr[i], Path.GetFileName(filteredStr[i]));
                if (RegexOS.IsMatch(filteredStr[i], FrequentlyUsedPattern.AlicdnStoreLogo))
                {
                    File.AppendAllText(filteredPath, filteredStr[i] + Environment.NewLine);
                }
            }
            Application.DoEvents();
            ScrapedImages(filteredPath);
            Process.Start(originalPath);
            Process.Start(filteredPath);
            return "图片已下载完成。";
        }

        public string AlicdnBaoUploadedSrc(string originalPath, string filteredPath)
        {
            ProcessIO.ClearContentByFileStream(filteredPath);
            string[] filteredStr = SplitString(originalPath);
            for (int i = 0; i < filteredStr.Length - 1; i++)
            {
                //Console.WriteLine("第 {0} 行: 网络地址:{1}，网络文件名:{2}", i + 1, filteredStr[i], Path.GetFileName(filteredStr[i]));
                if (RegexOS.IsMatch(filteredStr[i], FrequentlyUsedPattern.AlicdnBaoUploaded))
                {
                    File.AppendAllText(filteredPath, filteredStr[i] + Environment.NewLine);
                }
            }
            Application.DoEvents();
            ScrapedImagesWithHttp(filteredPath);
            Process.Start(originalPath);
            Process.Start(filteredPath);
            return "图片已下载完成。";
        }

        public string AlicdnImgextraSrc(string originalPath, string filteredPath)
        {
            ProcessIO.ClearContentByFileStream(filteredPath);
            string[] filteredStr = SplitString(originalPath);
            for (int i = 0; i < filteredStr.Length - 1; i++)
            {
                Console.WriteLine("第 {0} 行: 网络地址{1},网络文件名{2}", i + 1, filteredStr[i], Path.GetFileName(filteredStr[i]));
                if (RegexOS.IsMatch(filteredStr[i], FrequentlyUsedPattern.AlicdnImgextra))
                {
                    File.AppendAllText(filteredPath, filteredStr[i] + Environment.NewLine);
                }
            }
            Application.DoEvents();
            ScrapedImages(filteredPath);
            Process.Start(originalPath);
            Process.Start(filteredPath);
            return "图片已下载完成。";
        }

        /// <summary>
        /// 下载爬取页面上的所有图片地址上的图片信息
        /// </summary>
        /// <param name="path">爬取到的图片地址的txt存放地址</param>
        public string ScrapedImages(string path)
        {
            string[] filteredStr = SplitString(path);
            for (int i = 0; i < filteredStr.Length - 1; i++)
            {
                Console.WriteLine("第 {0} 行: 网络地址{1},网络文件名{2}", i + 1, filteredStr[i], Path.GetFileName(filteredStr[i]));
                WebsiteCrawlerOS.OriginalWebClient(filteredStr[i], @"E:\Picture\" + Path.GetFileName(filteredStr[i]));
            }
            Application.DoEvents();
            return "图片地址正在解析中.....";
        }

        /// <summary>
        /// 下载爬取页面上的所有图片地址上的图片信息
        /// </summary>
        /// <param name="path">爬取到的图片地址的txt存放地址</param>
        public string ScrapedImagesWithHttp(string path)
        {
            string[] filteredStr = SplitString(path);
            for (int i = 0; i < filteredStr.Length - 1; i++)
            {
                Console.WriteLine("第 {0} 行: 网络地址{1},网络文件名{2}", i + 1, filteredStr[i], Path.GetFileName(filteredStr[i]));
                WebsiteCrawlerOS.OriginalWebClient("http:"+filteredStr[i], @"E:\Picture\" + Path.GetFileName(filteredStr[i]));
            }
            Application.DoEvents();
            return "图片地址正在解析中.....";
        }

    }
}
