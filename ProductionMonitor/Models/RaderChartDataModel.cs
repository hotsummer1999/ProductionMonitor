using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Models
{
    /// <summary>
    /// 雷达图数据模型
    /// </summary>
    public class RaderChartDataModel
    {
        /// <summary>
        /// 数据项名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 数据值
        /// </summary>
        public double ItemValue { get; set; }
    }
}
