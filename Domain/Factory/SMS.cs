namespace gof_abstract_factory.Domain.Factory
{
    public sealed class SMS : Offline
    {
        public SMS() : base("SMS Notification", Enums.NotificationType.Offline)
        {
            Message = "Message send by SMS";
        }
    }
}
