using ScheduleClick.Core.Events.Interfaces;

namespace ScheduleClick.Core.Events
{
    internal abstract class Event : IEvent
    {
        internal abstract void Run();
    }
}
