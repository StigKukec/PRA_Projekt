using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Notification
    {
        private const char Del = '¤';
        private const string dateFormat = "MM.dd.yyyy HH:mm:ss";
        private static readonly string notificationsPath = FilePaths.GetFilePath("/Utilities/Resources/Notifications.txt");

        public Notification(string title, string message, string course)
        {
            Title = title;
            Message = message;
            Course = course;
            Date = DateTime.Now;
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public string Course { get; set; }
        public DateTime Date { get; set; }

        public static List<Notification> GetNotifications()
        {
            List<Notification> notification = new List<Notification>();
            string[] lines = File.ReadAllLines(notificationsPath);
            foreach (string line in lines)
            {
                string[] details = line.Split(Del);

                if (DateTime.TryParseExact(details[3], dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    notification.Add(new Notification(details[0], details[1], details[2])
                    {
                        Date = parsedDate
                    });
                }
            }
            return notification;
        }
        public void StoreNotification(Notification notification)
        {
            string save = $"{notification.Title}{Del}{notification.Message}{Del}{notification.Course}{Del}{Date.ToString(dateFormat)}";
            using (StreamWriter sw = new StreamWriter(notificationsPath, true))
            {
                sw.WriteLine(save);
            }
        }
        public static void DeleteNotification(Notification notification_copy)
        {
            List<Notification> notifications = GetNotifications();
            List<Notification> notifications_copy = new List<Notification>(notifications);

            for (int i = notifications_copy.Count - 1; i >= 0; i--)
            {
                Notification notification = notifications_copy[i];
                if (notification_copy.Title == notification.Title && notification_copy.Message == notification.Message && notification_copy.Course == notification.Course)
                {
                    notifications_copy.RemoveAt(i);
                }
            }

            File.WriteAllText(notificationsPath, string.Empty);
            foreach (Notification notification in notifications_copy)
            {
                string save = $"{notification.Title}{Del}{notification.Message}{Del}{notification.Course}{Del}{notification.Date.ToString(dateFormat)}";
                using (StreamWriter sw = new StreamWriter(notificationsPath, true))
                {
                    sw.WriteLine(save);
                }
            }
        }
    }
}
