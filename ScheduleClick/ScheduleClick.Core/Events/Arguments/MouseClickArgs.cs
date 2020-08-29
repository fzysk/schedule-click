using ScheduleClick.Core.Events.Enums;
using ScheduleClick.Core.Events.Interfaces;

namespace ScheduleClick.Core.Events.Arguments
{
    internal class MouseClickArgs : IClickArgs
    {
        public int X { get; }
        public int Y { get; }
        public MouseButton Button { get; }

        public MouseClickArgs(MouseButton button, int x, int y)
        {
            X = x;
            Y = y;
            Button = button;
        }
    }
}
