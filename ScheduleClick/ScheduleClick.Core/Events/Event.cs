using ScheduleClick.Core.Events.Interfaces;

namespace ScheduleClick.Core.Events
{
    internal abstract class Event : IEvent
    {
        internal virtual void Run()
        {
            // log click;
        }
    }
}
