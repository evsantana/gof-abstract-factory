namespace gof_abstract_factory.Domain.Factory
{
    public sealed class Whatsapp : Online
    {
        public Whatsapp() : base("Whatsapp notification", Enums.NotificationType.Online)
        {
            Message = "Message send by Whatsapp";
        }
    }
}
