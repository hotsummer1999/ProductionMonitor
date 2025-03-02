using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Models
{   
    /// <summary>
    /// 报警模型
    /// </summary>
    public class AlarmModel
    {
        /// <summary>
        /// 编号  
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 报警信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>

        public DateTime StartTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 持续时间(秒)
        /// </summary>
        public int Duration { get; set; }
    }
}
