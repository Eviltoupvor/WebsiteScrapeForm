using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryDAL.OperationSystemProcess
{
    /// <summary>
    /// C#winform批量给图片加水印代码 http://blog.csdn.net/pukuimin1226/article/details/10242557
    /// </summary>
    public class ThreadOS
    {
        private Thread _thread;
        public Thread CreateThread(Action approach,bool isBackground)
        {
            _thread = new Thread(()=> { approach(); });
            _thread.IsBackground = isBackground;
            _thread.Start();
            return _thread;
        }

        public Thread CreateThread<TFrist>(Action<TFrist> func, TFrist para, bool IsBackground)
        {
            _thread = new Thread(() => { func(para); });
            //判断状态
            //((int)th1.ThreadState &((int)ThreadState.Running | (int)ThreadState.Suspended) ) == 0
            _thread.IsBackground = IsBackground;
            _thread.Start(para);
            return _thread;
        }

        public bool OprateBetweenThread(bool permission)
        {
            return System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = permission;
        }

    }
}
