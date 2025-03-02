using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductionMonitor.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }
        

        //切换全屏和窗口模式
        WindowState m_WindowState;
        WindowStyle m_WindowStyle;
        bool m_WindowTopMost;
        ResizeMode m_WindowResizeMode;
        Rect m_WindowRect;
        public void ToFullscreen()
        {
            //存储窗体信息
            m_WindowState = this.WindowState;
            m_WindowStyle = this.WindowStyle;
            m_WindowTopMost = this.Topmost;
            m_WindowResizeMode = this.ResizeMode;
            m_WindowRect.X = this.Left;
            m_WindowRect.Y = this.Top;
            m_WindowRect.Width = this.Width;
            m_WindowRect.Height = this.Height;

            //变成无边窗体
            this.WindowState = WindowState.Normal;//假如已经是Maximized，就不能进入全屏，所以这里先调整状态
            this.WindowStyle = WindowStyle.None;
            this.ResizeMode = ResizeMode.NoResize;
            //this.Topmost = true;//最大化后总是在最上面

            // 调整窗口最大化。
            this.Width = SystemParameters.PrimaryScreenWidth;
            this.Height = SystemParameters.PrimaryScreenHeight;
            this.WindowState = WindowState.Maximized;
        }
        public void ExitFullscreen()
        {
            //恢复窗口先前信息，这样就退出了全屏
            this.Topmost = m_WindowTopMost;
            this.WindowStyle = m_WindowStyle;

            this.ResizeMode = ResizeMode.CanResize;//设置为可调整窗体大小
            this.Left = m_WindowRect.Left;
            this.Width = m_WindowRect.Width;
            this.Top = m_WindowRect.Top;
            this.Height = m_WindowRect.Height;
            this.WindowState = m_WindowState;//恢复窗口状态信息
            this.ResizeMode = m_WindowResizeMode;//恢复窗口可调整信息
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        public void MinimizeScreen()
        {
            this.WindowState = WindowState.Minimized;

        }
    }
}