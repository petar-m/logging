using System.Collections.Generic;
using System.Linq;
using NLog;
using NLog.Targets;

namespace M.Utilities.Logging
{
    [Target("CustomMemoryLogger")]
    public class NlogMemoryTarget : TargetWithLayout
    {
        private readonly LimitedQueue<string> logs;

        public NlogMemoryTarget()
        {
            logs = new LimitedQueue<string>(1000);
        }

        public IEnumerable<string> Logs
        {
            get { return logs.ToArray(); }
        }

        protected override void Write(LogEventInfo logEvent)
        {
            string @event = Layout.Render(logEvent);
            logs.Enqueue(@event);
        }
    }
}
