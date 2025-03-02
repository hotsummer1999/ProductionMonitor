using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Models
{
    public class MachineModel
    {
        /// <summary>
        /// 设备名
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        public string MachineStatus { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        public int PlanNum { get; set; }

        /// <summary>
        /// 已完成数量
        /// </summary>
        public int FinishNum { get; set; }

        /// <summary>
        /// 完成率
        /// </summary>
        public double FinishPercent { get => Math.Round(FinishNum * 100.0 / PlanNum, 2); }

        /// <summary>
        /// 当前工单号
        /// </summary>
        public string CurrentWorkOrder { get; set; }
    }
}