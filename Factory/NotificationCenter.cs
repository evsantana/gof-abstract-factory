using gof_abstract_factory.Domain.Enums;
using gof_abstract_factory.Domain.Factory;

namespace gof_abstract_factory.Factory
{
    public abstract class NotificationCenter
    {
        public abstract NotificationBase CreateNotification(NotificationType type);

        public static NotificationCenter CreateCenter(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Offline:
                    {
                        return new OfflineCenter();
                    }
                case NotificationType.Online:
                    {
                        return new OnlineCenter();
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
