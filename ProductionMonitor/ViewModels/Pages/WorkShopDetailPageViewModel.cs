using ProductionMonitor.Events;
using ProductionMonitor.Models;
using ProductionMonitor.Views.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ProductionMonitor.ViewModels.Pages
{
    public class WorkShopDetailPageViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;

        private IEventAggregator _eventAggregator;

        private List<MachineModel> _machineList = new List<MachineModel>();

        public ICommand OpenDetailCommand { get; private set; }
        public ICommand CloseDetailCommand { get; private set; }

        public ICommand BackCommand { get; private set; }

        private Visibility _detailVisibility = Visibility.Collapsed;

        public List<MachineModel> MachineList
        {
            get => _machineList;
            set => SetProperty<List<MachineModel>>(ref _machineList, value);
        }

        public Visibility DetailVisibility
        {
            get => _detailVisibility;
            set => SetProperty<Visibility>(ref _detailVisibility, value);
        }

        public WorkShopDetailPageViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
            BackCommand = new DelegateCommand(Back);
            OpenDetailCommand = new DelegateCommand(OpenDetail);
            CloseDetailCommand = new DelegateCommand(CloseDetail);

            #region 设备列表初始化

            MachineList.Add(new MachineModel()
            {
                MachineName = "超声波焊接机-1",
                MachineStatus = "作业中",
                FinishNum = 355,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "超声波焊接机-2",
                MachineStatus = "作业中",
                FinishNum = 432,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "超声波焊接机-3",
                MachineStatus = "停机中",
                FinishNum = 1455,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "超声波焊接机-4",
                MachineStatus = "作业中",
                FinishNum = 1900,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "氦检机-1",
                MachineStatus = "作业中",
                FinishNum = 445,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "氦检机-2",
                MachineStatus = "待料中",
                FinishNum = 903,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "氦检机-3",
                MachineStatus = "作业中",
                FinishNum = 1222,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });
            MachineList.Add(new MachineModel()
            {
                MachineName = "氦检机-4",
                MachineStatus = "故障中",
                FinishNum = 999,
                PlanNum = 1900,
                CurrentWorkOrder = "100009859-0213"
            });

            #endregion 设备列表初始化
        }

        private void CloseDetail()
        {
            Debug.WriteLine($"Close");
            _eventAggregator.GetEvent<StoryBoardEvent>().Publish(("Detail", "Leave", () => { this.DetailVisibility = Visibility.Collapsed; }));
        }

        private void OpenDetail()
        {
            Debug.WriteLine($"Open");
            DetailVisibility = Visibility.Visible;
        }

        private void Back()
        {
            Debug.WriteLine($"返回命令触发");
            //var journal = _regionManager.Regions["ContentRegion"].NavigationService.Journal;
            //if (journal.CanGoBack)
            //{
            //    journal.GoBack();
            //}
            _regionManager.Regions["ContentRegion"].RequestNavigate("MonitorPage");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // 页面加载时执行动画

            var page = _regionManager.Regions["ContentRegion"].ActiveViews.FirstOrDefault() as WorkShopDetailPage;
            if (page != null)
            {
                var animation = (Storyboard)page.Resources["PageLoadAnimation"];
                animation.Begin();
            }
        }
    }
}