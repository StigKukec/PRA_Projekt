using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Course
    {
        private const char Del = ':';
        private static readonly string notificationsPath = FilePaths.GetFilePath("/Utilities/Resources/Courses.txt");
        public Course(string title, int ects)
        {
            Title = title;
            Ects = ects;
        }

        public string Title { get; set; }
        public int Ects { get; set; }

        public static List<Course> GetSubjects()
        {
            List<Course> notification = new List<Course>();
            string[] lines = File.ReadAllLines(notificationsPath);
            foreach (string line in lines)
            {
                string[] details = line.Split(Del);
                notification.Add(new Course(details[0], int.Parse(details[1])));
            }

            return notification;
        }

        public static void StoreSubjects(List<Course> subjects)
        {
            using (StreamWriter sw = new StreamWriter(notificationsPath))
            {
                foreach (Course subject in subjects)
                {
                    string save = $"{subject.Title}:{subject.Ects}";
                    sw.WriteLine(save);
                }
            }
        }

        public static void StoreSubject(Course subject)
        {
            string print = $"{subject.Title}{Del}{subject.Ects}";
            using (StreamWriter sw = new StreamWriter(notificationsPath, true))
            {
                sw.WriteLine(print);
            }
        }
        public override string ToString() => $"{Title} - {Ects}";

    }
}
