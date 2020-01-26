using MyroWebApp.Xamarin.Entities;

namespace MyroWebApp.Xamarin.Services
{
    public interface IGradesFormatService
    {
        FormattedGrades FormatGradesForXamarinLayout(Grades grades);
    }
}
