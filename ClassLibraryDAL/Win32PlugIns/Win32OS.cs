using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryDAL.Win32PlugIns
{
    /// <summary>
    /// http://bbs.csdn.net/topics/390657209 关于winform移动控件
    /// http://www.cnblogs.com/ac1985482/archive/2012/07/10/2584479.html c# 为你的Form实现动画的效果
    /// http://www.cnblogs.com/wanzhongjun/p/6388371.html 使用C#实现WinForm窗体的动画效果
    /// http://blog.csdn.net/chiyumaomao/article/details/47953045  开博第一篇作品-C#winform版《仿360杀毒》页面切换动画效果(内含源码)
    /// http://blog.csdn.net/Yokeqi/article/details/43487181 C#动画控件(一张图包含所有动作)
    /// http://blog.csdn.net/lianchangshuai/article/details/6440289 WinForm实现窗体上控件的自由拖动
    /// http://www.cnblogs.com/encoding/p/5603080.html [DForm]我也来做自定义Winform之另类标题栏重绘
    /// </summary>
    //public class Win32OS
    //{
    //    private static Win32OS _win32OS;
    //    private static readonly object locker = new object();

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public const int WM_SYSCOMMAND = 0x0112;
    //    public const int SC_MOVE = 0Xf010;
    //    public const int HTCAPTION = 0x0002;

    //    public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
    //    public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
    //    public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
    //    public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
    //    public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
    //    public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。
    //    public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
    //    public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
    //    public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。

    //    public Win32OS()
    //    {
    //    }

    //    [DllImport("user32")]
    //    private static extern bool ReleaseCapture();

    //    [DllImport("user32")]
    //    private static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
    //    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    //    public static extern bool AnimateWindow(IntPtr hwnd, int dwTime,int dwFlags);

    //    public static Win32OS ExecuteWin32OS(bool isSingleton)
    //    {
    //        if (isSingleton == true)
    //        {
    //            lock (locker)
    //            {
    //                if (_win32OS == null)
    //                {
    //                    _win32OS = new Win32OS();
    //                }
    //            }
    //        }
    //        else if (isSingleton == false)
    //        {
    //            if (_win32OS == null)
    //            {
    //                _win32OS = new Win32OS();
    //            }
    //        }
    //        return _win32OS;
    //    }

    //    /// <summary>
    //    /// 拥有拖拽Winform UI控件能力
    //    /// http://www.jb51.net/article/53996.htm
    //    /// </summary>
    //    /// <param name="control">控件的名称</param>
    //    public Control MoveControl(this Control parentControl, string findCtrlName)//这个函数有问题，传参数进来后，出现没有引用的问题
    //    {
    //        ReleaseCapture();
    //        Control _findedControl = null;
    //        if (!string.IsNullOrEmpty(findCtrlName) && parentControl != null)
    //        {
    //            foreach (Control ctrl in parentControl.Controls)
    //            {
    //                if (ctrl.Name.Equals(findCtrlName))
    //                {
    //                    _findedControl = ctrl;
    //                    break;
    //                }
    //            }
    //        }
    //        SendMessage(parentControl.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
    //        return _findedControl;
    //    }

    //    public void AnimateWindow(Control control)
    //    {
    //        AnimateWindow(control.Handle, 2000, AW_SLIDE | AW_HIDE | AW_BLEND);
    //    }

    //}
}
