using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProductionMonitor.Converters
{
    public class MachineStatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? val = value?.ToString();
            switch (val)
            {
                case "作业中":
                    return "LightGreen";

                case "故障中":
                    return "IndianRed";

                case "停机中":
                    return "Orange";

                case "待料中":
                    return "Orange";
            }
            return "LightGray";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}