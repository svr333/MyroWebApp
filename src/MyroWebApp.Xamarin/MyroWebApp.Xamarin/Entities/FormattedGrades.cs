using System.Collections.Generic;

namespace MyroWebApp.Xamarin.Entities
{
    public class FormattedGrades
    {
        public List<FormattedTerm> Terms { get; set; }
    }

    public class FormattedTerm
    {
        public string DisplayName { get; set; }
        public List<FormattedCourse> Courses { get; set; }
    }

    public class FormattedCourse
    {
        public List<FormattedTest> Test { get; set; }
    }

    public class FormattedTest
    {
        public string DisplayName { get; set; }
        public string DisplayObtainedGrade { get; set; }
        public string DisplayAverageGrade { get; set; }
    }
}
