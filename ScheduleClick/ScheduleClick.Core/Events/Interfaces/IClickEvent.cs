namespace ScheduleClick.Core.Events.Interfaces
{
    interface IClickEvent : IEvent
    {
        IDelayEvent Click(IClickArgs clickArgs);
    }
}
