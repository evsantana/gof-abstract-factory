namespace gof_abstract_factory.Domain.Factory
{
    public sealed class Telegram : Online
    {
        public Telegram() : base("Telegram notification", Enums.NotificationType.Online) 
        {
            Message = "Send by Telegram";
        }
    }
}
