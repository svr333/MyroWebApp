using MyroWebApp.Xamarin.Entities.Grades;
using System.Collections.Generic;

namespace MyroWebApp.Xamarin.Entities.FormattedGrades
{
    public class FormattedTerm
    {
        public FormattedTerm(Term term)
        {
            Courses = new List<FormattedCourse>();

            DisplayName = term.Name;
            DisplayObtainedGrade = $"{term.ObtainedScore}/100";
            DisplayAverageGrade = $"{term.AverageScore}/100";

            for (int i = 0; i < term.Courses.Count; i++)
            {
                Courses.Add(new FormattedCourse(term.Courses[i]));
            }
        }

        public string DisplayName { get; set; }
        public string DisplayObtainedGrade { get; set; }
        public string DisplayAverageGrade { get; set; }
        public List<FormattedCourse> Courses { get; set; }
    }
}
