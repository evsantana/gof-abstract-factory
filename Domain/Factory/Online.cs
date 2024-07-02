using gof_abstract_factory.Domain.Enums;

namespace gof_abstract_factory.Domain.Factory
{
    public abstract class Online : NotificationBase
    {
        public Online(string name, NotificationType type) : base(name, type)
        {

        }
    }
}
