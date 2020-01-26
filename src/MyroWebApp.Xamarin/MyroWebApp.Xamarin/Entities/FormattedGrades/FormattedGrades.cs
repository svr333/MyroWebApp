using System.Collections.Generic;

namespace MyroWebApp.Xamarin.Entities.FormattedGrades
{
    public class FormattedGrades
    {
        public FormattedGrades(Grades.Grades grades)
        {
            Terms = new List<FormattedTerm>();

            for (int i = 0; i < grades.Terms.Count; i++)
            {
                Terms.Add(new FormattedTerm(grades.Terms[i]));
            }
        }

        public List<FormattedTerm> Terms { get; set; }
    }
}
