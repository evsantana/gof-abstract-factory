using gof_abstract_factory.Domain.Enums;

namespace gof_abstract_factory.Domain.Factory
{
    public sealed class Phone : Offline
    {
        public Phone(string name, NotificationType type) : base(name, type)
        {
            Message = "Message send by Phone";
        }
    }
}
