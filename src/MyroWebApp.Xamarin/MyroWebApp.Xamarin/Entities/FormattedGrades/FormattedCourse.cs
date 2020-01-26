using MyroWebApp.Xamarin.Entities.Grades;
using System.Collections.Generic;

namespace MyroWebApp.Xamarin.Entities.FormattedGrades
{
    public class FormattedCourse
    {
        public FormattedCourse(Course course)
        {
            Tests = new List<FormattedTest>();

            DisplayName = $"{course.Name} | {course.Teacher}";
            DisplayObtainedGrade = $"{course.ObtainedScore}/100";
            DisplayAverageGrade = $"{course.AverageScore}/100";

            for (int i = 0; i < course.Tests.Count; i++)
            {
                Tests.Add(new FormattedTest(course.Tests[i]));
            }
        }

        public string DisplayName { get; set; }
        public string DisplayObtainedGrade { get; set; }
        public string DisplayAverageGrade { get; set; }
        public List<FormattedTest> Tests { get; set; }
    }
}
