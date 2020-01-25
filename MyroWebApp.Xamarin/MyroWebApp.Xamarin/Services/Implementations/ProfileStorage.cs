using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyroWebApp.Xamarin.Entities;

namespace MyroWebApp.Xamarin.Services.Implementations
{
    public class ProfileStorage : IDataStorage<Profile>
    {
        private List<Profile> _profiles = new List<Profile>();

        public ProfileStorage()
        {
            
        }

        public async Task<bool> AddItemAsync(Profile profile)
        {
            _profiles.Add(profile);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Profile profile)
        {
            var oldItem = _profiles.Where(x => x.Key == profile.Key).FirstOrDefault();
            _profiles.Remove(oldItem);
            _profiles.Add(profile);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string key)
        {
            var oldItem = _profiles.Where(x => x.Key == key).FirstOrDefault();
            _profiles.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Profile> GetItemAsync(string key)
        {
            return await Task.FromResult(_profiles.FirstOrDefault(s => s.Key == key));
        }

        public async Task<IEnumerable<Profile>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_profiles);
        }
    }
}
