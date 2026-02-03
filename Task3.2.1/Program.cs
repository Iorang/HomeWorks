using Microsoft.Extensions.DependencyInjection;

namespace Task3._2._1
{
    internal class Program
    {
        static void Main()
        {
            string recipient = string.Empty;
            bool marker = false;

            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<ILogger, FileLogger>();
            services.AddSingleton<INotificationSender, EmailSender>();

            while (!marker)
            {
                Console.WriteLine("Напишите номер необходимого типа рассылки и нажмите Enter: \n   1.Email\n   2.SMS");

                marker = int.TryParse(Console.ReadLine(), out int notificationType) && notificationType > 0 && notificationType <= 2;

                switch (notificationType)
                {
                    case 1:
                        services.AddSingleton<INotificationSender, EmailSender>();
                        Console.WriteLine("Введите Email");
                        recipient = Console.ReadLine();
                        break;
                    case 2:
                        services.AddSingleton<INotificationSender, SmsSender>();
                        Console.WriteLine("Введите телефон");
                        recipient = Console.ReadLine();
                        break;
                }
            }

            services.AddSingleton<NotificationService>();

            ServiceProvider provider = services.BuildServiceProvider();

            var service = provider.GetRequiredService<NotificationService>();
            
            service.SendNotification("Ваш заказ готов", recipient);

            Console.ReadKey();
        }
    }
}
