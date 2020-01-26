using MyroWebApp.Xamarin.Entities.Grades;

namespace MyroWebApp.Xamarin.Entities.FormattedGrades
{
    public class FormattedTest
    {
        public FormattedTest(Test test)
        {
            DisplayName = $"{test.Name} | {test.Date.ToLongDateString()}";
            Comment = test.Comment;
            DisplayObtainedGrade = $"{test.ObtainedScore}/100";
            DisplayAverageGrade = $"{test.AverageScore}/100";
        }

        public string DisplayName { get; set; }
        public string Comment { get; set; }
        public string DisplayObtainedGrade { get; set; }
        public string DisplayAverageGrade { get; set; }
    }
}
