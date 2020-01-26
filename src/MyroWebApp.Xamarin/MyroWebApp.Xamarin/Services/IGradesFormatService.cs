using MyroWebApp.Xamarin.Entities.Grades;
using MyroWebApp.Xamarin.Entities.FormattedGrades;

namespace MyroWebApp.Xamarin.Services
{
    public interface IGradesFormatService
    {
        FormattedGrades FormatGradesForXamarinLayout(Grades grades);
    }
}
