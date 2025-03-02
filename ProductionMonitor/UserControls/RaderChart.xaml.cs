using ProductionMonitor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// RaderChart.xaml 的交互逻辑
    /// </summary>
    public partial class RaderChart : UserControl
    {
        public RaderChart()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Draw();
        }

        public List<RaderChartDataModel> ItemSource
        {
            get { return (List<RaderChartDataModel>)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(List<RaderChartDataModel>), typeof(RaderChart));

        public void Draw()
        {
            if (ItemSource == null || ItemSource.Count == 0)
            {
                return;
            }
            //清除旧画布内容
            raderCanvas.Children.Clear();
            P1.Points.Clear();
            P2.Points.Clear();
            P3.Points.Clear();
            P4.Points.Clear();
            Data.Points.Clear();

            double size = Math.Min(base.ActualWidth, base.ActualHeight) - 30;
            LayGrid.Width = size;//画布尺寸
            LayGrid.Height = size;
            double radius = size / 2;//雷达图半径
            double stepAngle = 360 / ItemSource.Count;//角度步长

            for (int i = 0; i < ItemSource.Count; i++)
            {
                double X = (radius - 5) * Math.Cos((stepAngle * i - 90) * Math.PI / 180);
                double Y = (radius - 5) * Math.Sin((stepAngle * i - 90) * Math.PI / 180);
                //雷达图图像
                P1.Points.Add(new Point(radius + X, radius + Y));
                P2.Points.Add(new Point(radius + 0.75 * X, radius + 0.75 * Y));
                P3.Points.Add(new Point(radius + 0.5 * X, radius + 0.5 * Y));
                P4.Points.Add(new Point(radius + 0.25 * X, radius + 0.25 * Y));
                //数据图像
                Data.Points.Add(new Point(radius + X * ItemSource[i].ItemValue / 100, radius + Y * ItemSource[i].ItemValue / 100));
                //raderCanvas.InvalidateVisual();重绘Canvas

                //文字设置
                TextBlock txt = new TextBlock();
                txt.Width = 60;
                txt.FontSize = 10;
                txt.TextAlignment = TextAlignment.Center;
                txt.Text = ItemSource[i].ItemName;
                txt.FontWeight = FontWeights.Bold;
                txt.Foreground = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
                txt.SetValue(Canvas.LeftProperty, radius + (radius + 10) * Math.Cos((stepAngle * i - 90) * Math.PI / 180) - 30);
                txt.SetValue(Canvas.TopProperty, radius + (radius + 10) * Math.Sin((stepAngle * i - 90) * Math.PI / 180) - 7);
                raderCanvas.Children.Add(txt);
            }
        }
    }
}