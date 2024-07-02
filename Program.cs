using gof_abstract_factory.Domain.Enums;
using gof_abstract_factory.Domain.Factory;
using gof_abstract_factory.Factory;


var offlineNotification = NotificationCenter.CreateCenter(NotificationType.Offline);

var SMS = offlineNotification.CreateNotification((NotificationType)OfflineType.SMS);
ExibeDetalhes(SMS);

var onlineNotification = NotificationCenter.CreateCenter(NotificationType.Online);
var telegram = onlineNotification.CreateNotification((NotificationType)OnlineType.Telegram);
ExibeDetalhes(telegram);

static void ExibeDetalhes(NotificationBase notification)
{
    Console.WriteLine($"Type : {notification.Type}");
    Console.WriteLine(notification.Name);
    Console.WriteLine(notification.Message);
    Console.WriteLine($"\n");

}