using ProductionMonitor.Views;
using ProductionMonitor.Views.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProductionMonitor.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;

        private readonly Window _window;

        public ICommand MinimizeCommand { get; private set; }
        public ICommand MaxmizeCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }

        public MainWindowViewModel(Window window, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _window = window;

            regionManager.RegisterViewWithRegion<MonitorPage>("ContentRegion");

            MinimizeCommand = new DelegateCommand(Minimize);
            MaxmizeCommand = new DelegateCommand(ToggleFullscreen);
            CloseCommand = new DelegateCommand(Close);
        }

        private void Close()
        {
            Environment.Exit(0);
        }

        private void ToggleFullscreen()
        {
            
            if (_window.WindowState != WindowState.Maximized)
            {
                _window.WindowState = WindowState.Maximized;
                ToFullscreen();
            }
            else
            {
                _window.WindowState = WindowState.Normal;
                ExitFullscreen();
            }
            //RaisePropertyChanged(nameof(BtnCloseFSContent));//通知UI层BtnCloseFS属性已经改变
        }

        private void Minimize()
        {
            ((MainWindow)Application.Current.MainWindow).MinimizeScreen();
        }

        private void ToFullscreen()
        {
            //() => ((MainWindow)Application.Current.MainWindow).ToFullscreen();
            ((MainWindow)Application.Current.MainWindow).ToFullscreen();
        }

        private void ExitFullscreen()
        {
            //() => ((MainWindow)Application.Current.MainWindow).ExitFullscreen();
            ((MainWindow)Application.Current.MainWindow).ExitFullscreen();
        }
    }
}