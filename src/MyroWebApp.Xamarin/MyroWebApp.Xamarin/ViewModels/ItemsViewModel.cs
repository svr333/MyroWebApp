using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using MyroWebApp.Xamarin.Entities.FormattedGrades;

namespace MyroWebApp.Xamarin.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<FormattedTerm> Terms { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Grades";
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            Terms.First().Courses.First().
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy) { return; }
            IsBusy = true;

            var grades = MyroWeb.GetUserFormattedGrades(ProfileStorage.Current.Key);

            Terms = new ObservableCollection<FormattedTerm>(grades.Terms);

            IsBusy = false;

            await Task.CompletedTask;
        }
    }
}
