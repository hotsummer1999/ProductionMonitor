using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Models
{
    /// <summary>
    /// 车间模型
    /// </summary>
    public class WorkShopModel
    {
        /// <summary>
        /// 车间名称
        /// </summary>
        public string WorkShopName { get; set; }
        /// <summary>
        /// 工作中数量
        /// </summary>
        public int WorkingNum { get; set; }
        /// <summary>
        /// 报警数量
        /// </summary>
        public int AlarmNum { get; set; }
        /// <summary>
        /// 待机数量
        /// </summary>
        public int WaitNum { get; set; }
        /// <summary>
        /// 停机数量
        /// </summary>
        public int StopNum { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalNum { get => WorkingNum + AlarmNum + WaitNum + StopNum; }
    }
}
