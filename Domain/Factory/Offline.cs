using gof_abstract_factory.Domain.Enums;

namespace gof_abstract_factory.Domain.Factory
{
    public abstract class Offline : NotificationBase
    {
        public Offline(string name, NotificationType type) : base(name, type)
        {

        }
    }
}
