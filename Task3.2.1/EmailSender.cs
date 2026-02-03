using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2._1
{
    public class EmailSender : INotificationSender
    {
        public void Send(string to, string message)
        {
            // Симуляция отправки email
            Console.WriteLine($"Email для {to}: {message}");
        }
    }
}
