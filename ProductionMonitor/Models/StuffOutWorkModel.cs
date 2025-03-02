using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Models
{
    /// <summary>
    /// 缺岗数据模型
    /// </summary>
    public class StuffOutWorkModel
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string StuffName { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 缺岗次数
        /// </summary>
        public int OutWorkCount { get; set; }
    }
}