using gof_abstract_factory.Domain.Enums;
using gof_abstract_factory.Domain.Factory;

namespace gof_abstract_factory.Factory
{
    public sealed class OnlineCenter : NotificationCenter
    {
        public override NotificationBase CreateNotification(NotificationType type)
        {
            var onlineType = (OnlineType)type;

            switch(onlineType)
            {
                case OnlineType.Whatsapp:
                    {
                        return new Whatsapp();
                    }
                case OnlineType.Telegram:
                    {
                        return new Telegram();
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Not implemented");
                    }
            }
        }
    }
}
