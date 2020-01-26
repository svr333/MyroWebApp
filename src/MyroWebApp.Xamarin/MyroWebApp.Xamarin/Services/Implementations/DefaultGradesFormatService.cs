using MyroWebApp.Xamarin.Entities.FormattedGrades;
using MyroWebApp.Xamarin.Entities.Grades;

namespace MyroWebApp.Xamarin.Services.Implementations
{
    public class DefaultGradesFormatService : IGradesFormatService
    {
        public FormattedGrades FormatGradesForXamarinLayout(Grades grades)
            => new FormattedGrades(grades);
    }
}
