using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2._1
{
    public class NotificationService
    {
        private readonly INotificationSender _sender;
        private readonly ILogger _logger;

        public NotificationService(INotificationSender sender, ILogger logger)
        {
            _sender = sender; // Нарушение: жесткая привязка
            _logger = logger;
        }

        public void SendNotification(string message, string recipient)
        {
            // Логика подготовки уведомления
            string formattedMessage = $"Уведомление: {message}";

            // Отправка email
            _sender.Send(recipient, formattedMessage);

            _logger.Log($"Отправлено уведомление для {recipient}");
        }
    }
}
