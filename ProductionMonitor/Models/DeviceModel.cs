using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Models
{
    /// <summary>
    /// 设备数据模型
    /// </summary>
    public class DeviceModel
    {
        /// <summary>
        /// 项目名
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 项目值
        /// </summary>
        public double ItemValue { get; set; }
    }
}
