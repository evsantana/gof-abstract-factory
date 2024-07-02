using gof_abstract_factory.Domain.Enums;

namespace gof_abstract_factory.Domain.Factory
{
    public abstract class NotificationBase
    {
        public NotificationType Type { get; set; }
        public string Name { get; set; }

        public string Message { get; set; }
        public NotificationBase(string name, NotificationType type)
        {
            Name = name;
            Type = type;
        }
    }
}
