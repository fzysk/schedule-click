namespace ScheduleClick.Core.Events.Interfaces
{
    interface IClickEvent : IEvent
    {
        IDelayEvent Click(int x, int y);
    }
}
