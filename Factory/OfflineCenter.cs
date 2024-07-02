using gof_abstract_factory.Domain.Enums;
using gof_abstract_factory.Domain.Factory;

namespace gof_abstract_factory.Factory
{
    public sealed class OfflineCenter : NotificationCenter
    {
        public override NotificationBase CreateNotification(NotificationType type)
        {
            var offlineType = (OfflineType)type;

            switch (offlineType)
            {
                case OfflineType.SMS:
                {
                    return new SMS();
                }
                case OfflineType.Phone:
                {
                    return new Phone("Phone notification", type);
                }
                default:
                {
                    throw new ArgumentOutOfRangeException("Not implemented");
                }
            }
        }
    }
}
