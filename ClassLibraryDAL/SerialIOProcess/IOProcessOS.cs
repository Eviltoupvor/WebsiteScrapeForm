using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL.SerialIOProcess
{
    /// <summary>
    /// https://zhidao.baidu.com/question/576811746.html C#中如何把Txt文件里的字符,读取到String数组里?
    /// http://www.cnblogs.com/akwwl/p/3240813.html C#读写txt文件的两种方法介绍
    /// http://blog.csdn.net/xjj800211/article/details/7814196 c#winform使用WebBrowser 大全
    /// </summary>
    public class IOProcessOS
    {
        public StreamReader StreamReader { get; set; }
        public FileStream FileStream { get; set; }

        private static IOProcessOS _IOperation;
        private static readonly object locker = new object();
        public static IOProcessOS ExecuteProcessIO(bool isSingleton)
        {
            if (isSingleton == true)
            {
                lock (locker)
                {
                    if (_IOperation == null)
                    {
                        _IOperation = new IOProcessOS();
                    }
                }
            }
            else if (isSingleton == false)
            {
                if (_IOperation == null)
                {
                    _IOperation = new IOProcessOS();
                }
            }
            return _IOperation;
        }

        public void ClearContentByStream(string path)
        {
            StreamReader = new StreamReader(path , false);
            StreamReader.Close();
        }

        /// <summary>
        /// 清理文本内容
        /// https://zhidao.baidu.com/question/195225454.html
        /// </summary>
        /// <param name="path">文件路径</param>
        public void ClearContentByFileStream(string path)
        {
            FileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            FileStream.SetLength(0);
            FileStream.Close();
        }

        public void Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="mode">文件模式</param>
        /// <param name="input">输入的文本</param>
        public void Write(string path,FileMode mode,string input)
        {
            FileStream fs = new FileStream(path, mode);//FileMode.Create
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(input);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }

        public void Write(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write("Hello World!!!!");
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 处理Txt
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string StreamReadToEnd(string path,Encoding encoding)
        {
            StreamReader = new StreamReader(path, encoding);
            return StreamReader.ReadToEnd();
        }

        /// <summary>
        /// 异步处理Txt
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public async Task<string> StreamReadToEndAsync(string path, Encoding encoding)
        {
            StreamReader = new StreamReader(path, encoding);
            return  await StreamReader.ReadToEndAsync();
        }
    }
}
