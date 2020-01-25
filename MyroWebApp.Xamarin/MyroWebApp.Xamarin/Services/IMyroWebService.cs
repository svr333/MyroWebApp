using MyroWebApp.Xamarin.Entities;

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
    }
}
