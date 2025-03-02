using ProductionMonitor.ViewModels;
using ProductionMonitor.Views;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace ProductionMonitor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 获取当前程序集
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes()
                                       .Where(t => t.Namespace.Contains("ProductionMonitor.Views") && t.IsClass) // 过滤命名空间和类
                                       .ToList();

            // 输出所有类的名称
            foreach (var type in types)
            {
                Debug.WriteLine($"注册页面{type.Name}"); // 打印类的全名
                containerRegistry.RegisterForNavigation(type, type.Name);
            }

            containerRegistry.RegisterDialog<SettingsWindow>();
        }
    }
}