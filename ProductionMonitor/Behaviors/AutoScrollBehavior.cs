using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ProductionMonitor.Behaviors
{
    public class AutoScrollBehavior : Behavior<ScrollViewer>
    {
        private DispatcherTimer _scrollTimer;
        private DispatcherTimer _pauseTimer;   // 定时器用于暂停
        private double _offset = 0;
        private bool _isPaused = false;        // 是否处于暂停状态

        public double ScrollSpeed { get; set; } = 1; // 滚动速度
        public TimeSpan ScrollInterval { get; set; } = TimeSpan.FromMilliseconds(20); // 滚动更新间隔

        public TimeSpan PauseDuration { get; set; } = TimeSpan.FromSeconds(1); // 滚动到尾部后的暂停时间
        protected override void OnAttached()
        {
            base.OnAttached();

            // 初始化滚动定时器
            _scrollTimer = new DispatcherTimer
            {
                Interval = ScrollInterval
            };
            _scrollTimer.Tick += ScrollTimer_Tick;
            _scrollTimer.Start();

            // 初始化暂停定时器
            _pauseTimer = new DispatcherTimer
            {
                Interval = PauseDuration
            };
            _pauseTimer.Tick += PauseTimer_Tick;
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            if (AssociatedObject == null || AssociatedObject.ExtentWidth <= AssociatedObject.ViewportWidth)
                return;
            if (_isPaused)
                return;
            // 自动调整滚动偏移量
            _offset += ScrollSpeed;
            if (_offset >= AssociatedObject.ExtentWidth - AssociatedObject.ViewportWidth)
            {
                // 到达尾部，暂停滚动
                _offset = AssociatedObject.ExtentWidth - AssociatedObject.ViewportWidth; // 确保停留在尾部
                AssociatedObject.ScrollToHorizontalOffset(_offset);

                _isPaused = true;
                _scrollTimer.Stop();
                _pauseTimer.Start(); // 开始暂停定时器
            }
            else
            {
                // 滚动更新
                AssociatedObject.ScrollToHorizontalOffset(_offset);
            }
        }

        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            // 暂停结束，重置状态并开始循环
            _pauseTimer.Stop();
            _isPaused = false;

            _offset = 0; // 重置到起点
            AssociatedObject.ScrollToHorizontalOffset(_offset);

            _scrollTimer.Start(); // 重新开始滚动
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            // 清理定时器
            if (_scrollTimer != null)
            {
                _scrollTimer.Stop();
                _scrollTimer.Tick -= ScrollTimer_Tick;
            }
            if (_pauseTimer != null)
            {
                _pauseTimer.Stop();
                _pauseTimer.Tick -= PauseTimer_Tick;
            }
        }
    }
}
