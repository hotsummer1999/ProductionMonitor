using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductionMonitor.UserControls
{
    /// <summary>
    /// PercentRing.xaml 的交互逻辑
    /// </summary>
    public partial class PercentRing : UserControl
    {
        public PercentRing()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Draw();
        }

        /// <summary>
        /// 百分比
        /// </summary>
        public double Percent
        {
            get { return (double)GetValue(PercentProperty); }
            set { SetValue(PercentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Percent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PercentProperty =
            DependencyProperty.Register("Percent", typeof(double), typeof(PercentRing));

        /// <summary>
        /// 绘制圆环方法
        /// </summary>
        private void Draw()
        {
            double size = Math.Min(base.ActualWidth, base.ActualHeight) - 30;
            LayGrid.Width = size;//画布尺寸
            LayGrid.Height = size;
            double radius = size / 2;//环形半径

            //计算坐标
            double X = radius + (radius - 4) * Math.Cos((Percent * 3.6 - 90) * Math.PI / 180);
            double Y = radius + (radius - 4) * Math.Sin((Percent * 3.6 - 90) * Math.PI / 180);

            int largeArcFlag = Percent < 50 ? 0 : 1;
            string pathStr = $"M{radius+0.01},4 A{radius - 4},{radius - 4} 0 {largeArcFlag} 1 {X},{Y}";

            ActualRing.Data = Geometry.Parse(pathStr);
        }
    }
}