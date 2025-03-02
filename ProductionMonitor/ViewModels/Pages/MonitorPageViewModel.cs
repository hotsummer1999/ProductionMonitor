using ProductionMonitor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ProductionMonitor.ViewModels.Pages
{
    public class MonitorPageViewModel : BindableBase
    {
        private List<EnvironmentModel> _environmentModelList = new List<EnvironmentModel>();

        private List<AlarmModel> _alarmList = new List<AlarmModel>();

        private List<DeviceModel> _deviceModelList = new List<DeviceModel>();

        private List<RaderChartDataModel> _raderChartDataList = new List<RaderChartDataModel>();

        private List<StuffOutWorkModel> _stuffOutWorkList = new List<StuffOutWorkModel>();
        private List<WorkShopModel> _workShopList = new List<WorkShopModel>();

        private IRegionManager _regionManager { get; set; }
        private IDialogService _dialogService { get; set; }

        public ICommand ShowDetail { get; set; }
        public ICommand ShowSettingsCommand { get; set; }

        public List<EnvironmentModel> EnvironemntModelList
        {
            get
            {
                return _environmentModelList;
            }
            set
            {
                var temp = _environmentModelList;
                SetProperty<List<EnvironmentModel>>(ref temp, value);
                _environmentModelList = temp;
            }
        }

        public List<AlarmModel> AlarmList
        {
            get => _alarmList;
            set => SetProperty<List<AlarmModel>>(ref _alarmList, value);
        }

        public List<DeviceModel> DeviceList
        {
            get => _deviceModelList;
            set => SetProperty<List<DeviceModel>>(ref _deviceModelList, value);
        }

        public List<RaderChartDataModel> RaderChartDataList
        {
            get => _raderChartDataList;
            set => SetProperty<List<RaderChartDataModel>>(ref _raderChartDataList, value);
        }

        public List<StuffOutWorkModel> StuffOutWorkList
        {
            get => _stuffOutWorkList;
            set => SetProperty<List<StuffOutWorkModel>>(ref _stuffOutWorkList, value);
        }

        public List<WorkShopModel> WorkShopList
        {
            get => _workShopList;
            set => SetProperty<List<WorkShopModel>>(ref _workShopList, value);
        }

        public MonitorPageViewModel(IDialogService dialogService, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            ShowDetail = new DelegateCommand(ShowWorkShopDeatil);
            ShowSettingsCommand = new DelegateCommand(ShowSettings);
            Debug.WriteLine($"初始化Data");
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "温度(℃)",
                ItemValue = 80
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "湿度(%)",
                ItemValue = 44
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "光照(Lux)",
                ItemValue = 123
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "压力(Pa)",
                ItemValue = 400.3f
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "氮气(L/min)",
                ItemValue = 25
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "功率(W)",
                ItemValue = 2500
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "频率(Hz)",
                ItemValue = 2500
            });
            EnvironemntModelList.Add(new EnvironmentModel()
            {
                ItemName = "噪音(db)",
                ItemValue = 80
            });

            AlarmList.Add(new AlarmModel()
            {
                Id = "1",
                Message = "上料气缸发生报警",
                StartTime = DateTime.Now,
                Duration = 20
            });
            AlarmList.Add(new AlarmModel()
            {
                Id = "2",
                Message = "上料气缸2发生报警",
                StartTime = DateTime.Now,
                Duration = 20
            });
            AlarmList.Add(new AlarmModel()
            {
                Id = "3",
                Message = "上料气缸3发生报警",
                StartTime = DateTime.Now,
                Duration = 20
            });
            AlarmList.Add(new AlarmModel()
            {
                Id = "4",
                Message = "上料气缸4发生报警",
                StartTime = DateTime.Now,
                Duration = 20
            });
            AlarmList.Add(new AlarmModel()
            {
                Id = "5",
                Message = "上料气缸5发生报警",
                StartTime = DateTime.Now,
                Duration = 20
            });

            DeviceList.Add(new DeviceModel()
            {
                ItemName = "电能(Kwh)",
                ItemValue = 60.08
            });
            DeviceList.Add(new DeviceModel()
            {
                ItemName = "电压(V)",
                ItemValue = 383
            });
            DeviceList.Add(new DeviceModel()
            {
                ItemName = "电流(A)",
                ItemValue = 5
            });
            DeviceList.Add(new DeviceModel()
            {
                ItemName = "压差(kpa)",
                ItemValue = 13
            });
            DeviceList.Add(new DeviceModel()
            {
                ItemName = "温度(℃)",
                ItemValue = 44
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "电量",
                ItemValue = 13
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "水量",
                ItemValue = 45
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "氮气",
                ItemValue = 33
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "AA",
                ItemValue = 23
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "BB",
                ItemValue = 77
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "CC",
                ItemValue = 33
            });
            RaderChartDataList.Add(new RaderChartDataModel()
            {
                ItemName = "DD",
                ItemValue = 55
            });

            StuffOutWorkList.Add(new StuffOutWorkModel()
            {
                StuffName = "张三",
                Position = "技术员",
                OutWorkCount = 12
            });
            StuffOutWorkList.Add(new StuffOutWorkModel()
            {
                StuffName = "李四",
                Position = "ME",
                OutWorkCount = 32
            });
            StuffOutWorkList.Add(new StuffOutWorkModel()
            {
                StuffName = "王五",
                Position = "QC",
                OutWorkCount = 44
            });

            WorkShopList.Add(new WorkShopModel()
            {
                WorkShopName = "贴片车间",
                WorkingNum = 13,
                AlarmNum = 2,
                WaitNum = 3,
                StopNum = 4
            });

            WorkShopList.Add(new WorkShopModel()
            {
                WorkShopName = "组装车间",
                WorkingNum = 13,
                AlarmNum = 2,
                WaitNum = 3,
                StopNum = 4
            });
            WorkShopList.Add(new WorkShopModel()
            {
                WorkShopName = "搅拌车间",
                WorkingNum = 13,
                AlarmNum = 2,
                WaitNum = 3,
                StopNum = 4
            });
            WorkShopList.Add(new WorkShopModel()
            {
                WorkShopName = "打包车间",
                WorkingNum = 13,
                AlarmNum = 2,
                WaitNum = 3,
                StopNum = 4
            });
        }

        private void ShowSettings()
        {
            var parameters = new DialogParameters
            {
                { "Owner", Application.Current.MainWindow }
            };

            _dialogService.ShowDialog("SettingsWindow", parameters, r =>
            {
                if (r.Result == ButtonResult.OK)
                {
                    // Handle OK result
                }
            });
        }

        private void ShowWorkShopDeatil()
        {
            _regionManager.Regions["ContentRegion"].RequestNavigate("WorkShopDetailPage");
            ////动画效果
            ////位移+时间
            //ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 50, 0, -50), new Thickness(0, 0, 0, 0), new TimeSpan(0, 0, 0, 0,4000));
            ////透明度变化
            //DoubleAnimation doubleAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 4000));

            ////应用效果
            //Storyboard.SetTargetName(thicknessAnimation, "ContentRegion");
            //Storyboard.SetTargetName(doubleAnimation, "ContentRegion");
            //Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));
            //Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity"));

            //Storyboard storyboard = new Storyboard();
            //storyboard.Children.Add(thicknessAnimation);
            //storyboard.Children.Add(doubleAnimation);
            //storyboard.Begin();
        }
    }
}