using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ClassLibraryDAL.WebsiteScrapeProcess
{
    /// <summary>
    /// http://www.jianshu.com/p/66f6b8819fef python+scrapy爬虫时如何自动翻页获取内容
    /// http://www.jb51.net/article/81480.htm 基于C#实现网页爬虫
    /// </summary>
    public class WebsiteCrawlerOS
    {
        private static WebsiteCrawlerOS _websiteCrawler;
        private static readonly object locker = new object();
        public WebClient WebClient { get; set; }
        private WebsiteCrawlerOS()
        {
        }

        public static WebsiteCrawlerOS ExecuteWebsiteCrawler(bool isSingleton)
        {
            if (isSingleton == true)
            {
                lock (locker)
                {
                    if (_websiteCrawler == null)
                    {
                        _websiteCrawler = new WebsiteCrawlerOS();
                    }
                }
            }
            else if (isSingleton == false)
            {
                if (_websiteCrawler == null)
                {
                    _websiteCrawler = new WebsiteCrawlerOS();
                }
            }
            return _websiteCrawler;
        }
        public string UrlEncode(string decodeUri)
        {
            return HttpUtility.UrlEncode(decodeUri);
        }
        public string UrlDecode(string decodeUri)
        {
            return HttpUtility.UrlDecode(decodeUri);
        }
        public void OriginalWebClient(string address,string fileName)
        {
            WebClient = new WebClient();
            WebClient.DownloadFile(address, fileName);
        }
        public void OriginalWebClientAsync(string address, string fileName)
        {
            WebClient = new WebClient();
            WebClient.DownloadFileAsync(new Uri(address), fileName);
        }
    }
}
