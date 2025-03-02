using ProductionMonitor.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductionMonitor.Views.Pages
{
    /// <summary>
    /// WorkShopDetailPage.xaml 的交互逻辑
    /// </summary>
    public partial class WorkShopDetailPage : Page
    {
        private IEventAggregator _eventAggregator;

        public WorkShopDetailPage(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            _eventAggregator = eventAggregator;

            // 订阅动画完成事件
            _eventAggregator.GetEvent<StoryBoardEvent>().Subscribe(ActiveStoryBoard);
        }

        private void ActiveStoryBoard((string, string, Action) tuple)
        {
            // 获取目标元素
            var detailElement = (FrameworkElement)this.FindName(tuple.Item1);
            Storyboard storyboard = new Storyboard();
            // 创建动画（透明度动画）
            var opacityAnimation = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(System.TimeSpan.FromSeconds(0.4))
            };
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 0, 0, 0), new Thickness(0, 50, 0, -50), new TimeSpan(0, 0, 0, 0, 400));
            storyboard.Children.Add(opacityAnimation);
            storyboard.Children.Add(thicknessAnimation);
            // 设置动画目标
            Storyboard.SetTarget(opacityAnimation, detailElement);
            Storyboard.SetTarget(thicknessAnimation, detailElement);
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath("Opacity"));
            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));
            storyboard.Completed += (object sender, EventArgs e) =>
            {
                tuple.Item3.Invoke();
                storyboard.Stop();
                
            };
            storyboard.Begin();
        }
    }
}