using MyroWebApp.Xamarin.Entities.FormattedGrades;
using MyroWebApp.Xamarin.Entities.Grades;

namespace MyroWebApp.Xamarin.Services
{
    public interface IMyroWebService
    {
        /// <summary>
        /// Registers a new user to the MyroWeb api with a key and a user.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="user"></param>
        void RegisterNewUser(string key, User user);

        /// <summary>
        /// Gets a user's grades from the MyroWeb api.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Grades GetUserGrades(string key);

        /// <summary>
        /// Get user's grade with formatted values for easier display.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        FormattedGrades GetUserFormattedGrades(string key);
    }
}
