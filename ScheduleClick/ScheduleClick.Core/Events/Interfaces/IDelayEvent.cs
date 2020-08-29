namespace ScheduleClick.Core.Events.Interfaces
{
    interface IDelayEvent : IEvent
    {
        IEvent WithDelay(long miliseconds);
    }
}
