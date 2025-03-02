using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProductionMonitor.Behaviors
{
    public class HorizontalScrollBehavior:Behavior<ScrollViewer>
    {
        /// <summary>
        /// 鼠标滚轮滚动的步长（默认 20）
        /// </summary>
        public static readonly DependencyProperty ScrollStepProperty =
            DependencyProperty.Register("ScrollStep", typeof(double), typeof(HorizontalScrollBehavior), new PropertyMetadata(20.0));

        public double ScrollStep
        {
            get => (double)GetValue(ScrollStepProperty);
            set => SetValue(ScrollStepProperty, value);
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            if (AssociatedObject != null)
            {
                AssociatedObject.PreviewMouseWheel += OnPreviewMouseWheel;
            }
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            if (AssociatedObject != null)
            {
                AssociatedObject.PreviewMouseWheel -= OnPreviewMouseWheel;
            }
        }

        private void OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (AssociatedObject == null) return;

            // 判断 Ctrl 键是否按下（可选）
            //if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
            //{
            //    return; // 如果按下 Ctrl 键，保持默认行为（比如页面缩放）
            //}

            // 横向滚动，正负值取决于鼠标滚动方向
            double scrollOffset = AssociatedObject.HorizontalOffset - e.Delta / 120.0 * ScrollStep;

            // 限制在有效范围内
            AssociatedObject.ScrollToHorizontalOffset(Math.Max(0, Math.Min(scrollOffset, AssociatedObject.ExtentWidth - AssociatedObject.ViewportWidth)));

            // 标记事件为已处理，防止向上传递
            e.Handled = true;
        }
    }
}
