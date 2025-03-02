using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionMonitor.Events
{
    public class StoryBoardEvent : PubSubEvent<(string, string, Action)>
    {
    }
}