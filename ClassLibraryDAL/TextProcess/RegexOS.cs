using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryDAL.TextProcess
{
    /// <summary>
    /// http://bbs.csdn.net/topics/391078615?page=1 用正则表达式抓取Image的Src
    /// </summary>
    public enum FrequentlyUsedPattern
    {
        IsDigit,
        IsMutiDigit,
        AtLeastMutiDigit,
        IsExtentNumber,
        QQNumber,
        ImageSrc,
        AlicdnStoreLogo,
        AlicdnBaoUploaded,
        AlicdnImgextra
    }
    public class RegexOS
    {
        private Regex Regex { get; set; }
        private static RegexOS _regexOperation;
        private static readonly object locker = new object();

        public string MatchText { get; set; }
        public FrequentlyUsedPattern FrequentlyUsedPattern { get; set; }
        public string RegexPatternList(FrequentlyUsedPattern frequentlyUsedPattern)
        {
            switch (frequentlyUsedPattern)
            {
                case FrequentlyUsedPattern.IsDigit:
                    return @"^[0-9]*$";
                    break;
                case FrequentlyUsedPattern.IsMutiDigit:
                    return @"^\d{n}$";
                    break;
                case FrequentlyUsedPattern.AtLeastMutiDigit:
                    return @"^\d{n,}$";
                    break;
                case FrequentlyUsedPattern.IsExtentNumber:
                    return @"^\d{m,n}$";
                    break;
                case FrequentlyUsedPattern.QQNumber:
                    return @"[1-9][0-9]{4,}";
                    break;
                case FrequentlyUsedPattern.ImageSrc:
                    return @"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>";
                    break;
                case FrequentlyUsedPattern.AlicdnStoreLogo:
                    return @"//logo.taobao.com/shop-logo/";
                    break;
                case FrequentlyUsedPattern.AlicdnBaoUploaded:
                    return @"//img.alicdn.com/bao/uploaded/";
                    break;
                case FrequentlyUsedPattern.AlicdnImgextra:
                    return @"https://img.alicdn.com/imgextra/";
                    break;
                default:
                    throw new ArgumentNullException();
                    break;
            }
        }

        public static RegexOS ExecuteRegexExpression(bool isSingleton)
        {
            if (isSingleton == true)
            {
                lock (locker)
                {
                    if (_regexOperation == null)
                    {
                        _regexOperation = new RegexOS();
                    }
                }
            }
            else if (isSingleton == false)
            {
                if (_regexOperation == null)
                {
                    _regexOperation = new RegexOS();
                }
            }
            return _regexOperation;
        }

        /// <summary>  
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true  
        /// </summary>
        /// <param name="pattern">模式字符串</param>          
        public bool IsMatch(FrequentlyUsedPattern frequentlyUsedPattern)
        {
            return IsMatch(MatchText, RegexPatternList(frequentlyUsedPattern), RegexOptions.IgnoreCase);
        }

        /// <summary>  
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true  
        /// </summary>  
        /// <param name="input">输入字符串</param>  
        /// <param name="pattern">模式字符串</param>          
        public bool IsMatch(string input, FrequentlyUsedPattern frequentlyUsedPattern)
        {
            return IsMatch(input, RegexPatternList(frequentlyUsedPattern), RegexOptions.IgnoreCase);
        }

        /// <summary>  
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true  
        /// </summary>  
        /// <param name="input">输入字符串</param>  
        /// <param name="pattern">模式字符串</param>          
        public bool IsMatch(string input, string pattern)
        {
            return IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }

        /// <summary>  
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true  
        /// </summary>  
        /// <param name="input">输入的字符串</param>  
        /// <param name="pattern">模式字符串</param>  
        /// <param name="options">筛选条件</param>  
        public bool IsMatch(string input, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }

        /// <summary>
        /// 使用正则表达式批量匹配语句
        /// 用法：
        /// var regexOS = RegexOS.ExecuteWebsiteCrawler();
        /// foreach (var item in regexOS.RegexMatches(matchStr,matchPattern,startAt))
        /// {
        /// }
        /// </summary>
        /// <param name="input">要匹配的文本</param>
        /// <param name="matchPattern">被匹配的正则表达式</param>
        /// <returns>
        /// </returns>
        public MatchCollection RegexMatches(FrequentlyUsedPattern frequentlyUsedPattern)
        {
            return RegexMatches(MatchText, RegexPatternList(frequentlyUsedPattern));
        }

        /// <summary>
        /// 使用正则表达式批量匹配语句
        /// 用法：
        /// var regexOS = RegexOS.ExecuteWebsiteCrawler();
        /// foreach (var item in regexOS.RegexMatches(matchStr,matchPattern,startAt))
        /// {
        /// }
        /// </summary>
        /// <param name="input">要匹配的文本</param>
        /// <param name="matchPattern">被匹配的正则表达式</param>
        /// <returns>
        /// </returns>
        public MatchCollection RegexMatches(string input, FrequentlyUsedPattern frequentlyUsedPattern)
        {
            return RegexMatches(input, RegexPatternList(frequentlyUsedPattern));
        }

        /// <summary>
        /// 使用正则表达式批量匹配语句
        /// 用法：
        /// var regexOS = RegexOS.ExecuteWebsiteCrawler();
        /// foreach (var item in regexOS.RegexMatches(matchStr,matchPattern,startAt))
        /// {
        /// }
        /// </summary>
        /// <param name="input">要匹配的文本</param>
        /// <param name="pattern">被匹配的正则表达式</param>
        /// <returns>
        /// </returns>
        public MatchCollection RegexMatches(string input, string pattern)
        {
            return new Regex(pattern).Matches(input);
        }

        /// <summary>
        /// 使用正则表达式批量匹配语句
        /// 用法：
        /// var regexOS = RegexOS.ExecuteWebsiteCrawler();
        /// foreach (var item in regexOS.RegexMatches(matchStr,matchPattern,startAt))
        /// {
        /// }
        /// </summary>
        /// <param name="input">要匹配的文本</param>
        /// <param name="pattern">被匹配的正则表达式</param>
        /// <param name="startAt">被匹配的位置</param>
        /// <returns>
        /// 用法：
        /// var regexOS = RegexOS.ExecuteWebsiteCrawler();
        /// foreach (var item in regexOS.RegexMatches(matchStr,matchPattern,startAt))
        /// {
        /// }
        /// </returns>
        public MatchCollection RegexMatches(string input,string pattern,int startAt)
        {
            return new Regex(pattern).Matches(input, startAt);
        }

        /// <summary>
        /// 在指定的输入字符串内，使用指定的替换字符串替换与某个指定正则表达式模式匹配的所有的字符串
        /// </summary>
        /// <param name="replacement">在指定的输入字符串内，使用指定的替换字符串替换与某个指定正则表达式模式匹配的所有的字符串</param>
        /// <param name="FrequentlyUsedPattern">使用FrequentlyUsedPatten常用正则表达式枚举</param>
        /// <returns></returns>
        public string RegexReplace(string replacement, FrequentlyUsedPattern frequentlyUsedPattern)
        {
            return RegexReplace(MatchText, replacement, RegexPatternList(frequentlyUsedPattern));
        }

        /// <summary>
        /// 在指定的输入字符串内，使用指定的替换字符串替换与某个指定正则表达式模式匹配的所有的字符串
        /// </summary>
        /// <param name="replacement">在指定的输入字符串内，使用指定的替换字符串替换与某个指定正则表达式模式匹配的所有的字符串</param>
        /// <param name="pattern">要输入正则表达式</param>
        /// <returns></returns>
        public string RegexReplace(string replacement,string pattern)
        {
            return RegexReplace(MatchText, replacement, pattern);
        }

        /// <summary>
        /// 使用正则表达式替换文字内容
        /// </summary>
        /// <param name="input">要搜索匹配的字符串</param>
        /// <param name="replacement">在指定的输入字符串内，使用指定的替换字符串替换与某个指定正则表达式模式匹配的所有的字符串</param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public string RegexReplace(string input,string replacement,string pattern)
        {
            return new Regex(pattern).Replace(input , replacement);
        }
    }
}
