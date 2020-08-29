using ScheduleClick.Core.Events.Arguments;
using ScheduleClick.Core.Events.Interfaces;
using System;

namespace ScheduleClick.Core.Events
{
    class ClickEvent : Event, IClickEvent, IDelayEvent
    {
        private MouseClickArgs _args;
        private long _delay;

        IDelayEvent IClickEvent.Click(IClickArgs args)
        {
            if (!(args is MouseClickArgs))
            {
                throw new ArgumentException($"{nameof(args)} must be of {typeof(MouseClickArgs)} type");
            }

            _args = (MouseClickArgs)args;

            return this;
        }

        IEvent IDelayEvent.WithDelay(long miliseconds)
        {
            _delay = miliseconds;

            return this;
        }

        internal override void Run()
        {
            base.Run();
            throw new NotImplementedException();
        }
    }
}
